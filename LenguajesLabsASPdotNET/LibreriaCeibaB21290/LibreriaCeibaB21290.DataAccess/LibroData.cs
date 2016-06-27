using LibreriaCeibaB21290.LibreriaCeibaB21290.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCeibaB21290.LibreriaCeibaB21290.DataAccess
{
    public class LibroData
    {
        private String conetionString;
        public LibroData(String conetionString)
        {
            this.conetionString = conetionString;
        }

        public LinkedList<Libro> GetLibrosPorPublicador(int idPublicador)
        {
            //----- 1-----//
            SqlConnection conexion = new SqlConnection(conetionString);
            //----- 2-----//
            SqlCommand cmdLibros = new SqlCommand("select l.cod_libro, l.titulo_libro, l.ano_publicacion, l.isbn,l.id_publicador, l.precio " +
                                                  "from Libro l " +
                                                  "where l.id_publicador = " + idPublicador + " " +
                                                  "order by l.titulo_libro  ", conexion);
            //----- 3-----//
            conexion.Open();
            SqlDataReader drLibros = cmdLibros.ExecuteReader();
            LinkedList<Libro> libros = new LinkedList<Libro>();
            while (drLibros.Read())
            {
                //*****************************----------Libro----------***********************//
                Libro libro = new Libro();
                libro.CodLibro = Int32.Parse(drLibros["cod_libro"].ToString());
                libro.TituloLibro = drLibros["titulo_libro"].ToString();
                libro.AnoPublicacion = Int32.Parse(drLibros["ano_publicacion"].ToString());
                libro.Isbn = drLibros["isbn"].ToString();
                libro.Publicador.IdPublicador = Int32.Parse(drLibros["id_publicador"].ToString());
                libro.Precio = float.Parse(drLibros["precio"].ToString());

                //*****************************------Publicador-------*************************//
                PublicadorData publicadorData = new PublicadorData(conetionString);
                libro.Publicador = publicadorData.GetPublicadorPorLibro(libro.CodLibro);
                //*****************************------Autores---------*************************//
                AutorData autorData = new AutorData(conetionString);
                libro.Autores = autorData.GetAutoresPorLibro(libro.CodLibro);

                libros.AddLast(libro);

            }//fin while

            conexion.Close();
            return libros;
        }

        public Libro InsertarLibro(Libro libro)
        {
            String slqProcedureInsertarLibro = "InsertarLibro";
            SqlConnection conexion = new SqlConnection(conetionString);
            SqlCommand cmdInsertarLibro = new SqlCommand(slqProcedureInsertarLibro, conexion);
            cmdInsertarLibro.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar el parametro de salida 
            SqlParameter parCodLibro = new SqlParameter("@cod_libro", SqlDbType.Int);
            parCodLibro.Direction = System.Data.ParameterDirection.Output;
            cmdInsertarLibro.Parameters.Add(parCodLibro);
            //Agregar los demas parametros restantes
            cmdInsertarLibro.Parameters.Add(new SqlParameter("@titulo_libro", libro.TituloLibro));
            cmdInsertarLibro.Parameters.Add(new SqlParameter("@anio_publicacion", libro.AnoPublicacion));
            cmdInsertarLibro.Parameters.Add(new SqlParameter("@isbn", libro.Isbn));
            cmdInsertarLibro.Parameters.Add(new SqlParameter("@precio", libro.Precio));
            cmdInsertarLibro.Parameters.Add(new SqlParameter("@id_publicador", libro.Publicador.IdPublicador));
            conexion.Open();
            SqlTransaction transaction = conexion.BeginTransaction();

            try
            {
                //Para que los objetos tipo SqlCommand funcionen debe estar abierta una conexion

                cmdInsertarLibro.Transaction = transaction;
                cmdInsertarLibro.ExecuteNonQuery();
                libro.CodLibro = Int32.Parse(cmdInsertarLibro.Parameters["@cod_libro"].Value.ToString());
                foreach (Autor autor in libro.ListaAutores)
                {
                    SqlCommand cmdInsertarLibroAutor = new SqlCommand("InsertarLibroAutor", conexion);
                    cmdInsertarLibroAutor.Transaction = transaction;
                    cmdInsertarLibroAutor.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdInsertarLibroAutor.Parameters.Add(new SqlParameter("@id_autor", autor.IdAutor));
                    cmdInsertarLibroAutor.Parameters.Add(new SqlParameter("@cod_libro", libro.CodLibro));
                    cmdInsertarLibroAutor.ExecuteNonQuery();

                }
                transaction.Commit();

            }
            catch (SqlException exc)
            {
                transaction.Rollback();
                throw exc;
            }
            finally
            {
                conexion.Close();
            }

            return libro;

        }

    }
}
