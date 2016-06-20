using LibreriaCeibaB21290.LibreriaCeibaB21290.Common.Domain;
using System;
using System.Collections.Generic;
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

    }
}
