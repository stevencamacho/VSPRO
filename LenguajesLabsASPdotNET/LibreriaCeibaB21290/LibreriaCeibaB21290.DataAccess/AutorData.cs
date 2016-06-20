using LibreriaCeibaB21290.LibreriaCeibaB21290.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCeibaB21290.LibreriaCeibaB21290.DataAccess
{
    class AutorData
    {
        private String conetionString;

        public AutorData(String conetionString)
        {
            this.conetionString = conetionString;
        }

        public LinkedList<Autor> GetAutoresPorLibro(int idLibro)
        {
            //----- 1-----//
            SqlConnection conexion = new SqlConnection(conetionString);
            //----- 2-----//
            SqlCommand cmdAutores = new SqlCommand("select a.id_autor,a.nombre_autor,a.primer_apellido,a.segundo_apellido " +
                                                    "from Autor a, Libro_Autor la " +
                                                    "where la.id_autor = a.id_autor and la.cod_libro = " + idLibro + " " +
                                                    "order by nombre_autor ", conexion);
            //----- 3-----//
            conexion.Open();
            SqlDataReader drLibros = cmdAutores.ExecuteReader();
            LinkedList<Autor> autores = new LinkedList<Autor>();
            while (drLibros.Read())
            {
                Autor autor = new Autor();
                autor.IdAutor = Int32.Parse(drLibros["id_autor"].ToString());
                autor.NombreAutor = drLibros["nombre_autor"].ToString();
                autor.PrimerApellido = drLibros["primer_apellido"].ToString();
                autor.SegundoApellido = drLibros["segundo_apellido"].ToString();


                autores.AddLast(autor);

            }//fin while

            conexion.Close();
            return autores;
        }



    }
}
