using LibreriaCeibaB21290.LibreriaCeibaB21290.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCeibaB21290.LibreriaCeibaB21290.DataAccess
{
    public class PublicadorData
    {
        private string cadenaConexion;
        public PublicadorData(string conexion) {
            this.cadenaConexion = conexion;
        }

        
        public LinkedList<Publicador> GetPublicadores()
        {
            //************----- 1:Creación variable de tipo SqlConnection-----***********//
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            //************----- 2:Creación variable de tipo SqlCommand-----***********//
            //************----Recibe por parametro la consulta requerida a la base de datos----***************//
            SqlCommand cmdPublicador = new SqlCommand("select id_publicador,nombre_publicador,url_sitio_web "+
                                                   "from Publicador "+
                                                   "order by nombre_publicador ", conexion);

            //************----- 3: Abre la conexión con el servidor**************-----//
            conexion.Open();
            
            //************-----4: Se utiliza SqlDataReader para almacenar y lograr acceder a la consulta realizada.----***// 
            SqlDataReader drpublicador = cmdPublicador.ExecuteReader();

            //************-----5: Se crea una lista enlazada y posterior mediante un ciclo se almacenan las diferentes tuplas obtenidas----*****//
            LinkedList<Publicador> publicadores = new LinkedList<Publicador>();
            while (drpublicador.Read())
            {
                Publicador publicador = new Publicador();
                publicador.IdPublicador = Int32.Parse(drpublicador["id_publicador"].ToString());
                publicador.NombrePublicador = drpublicador["nombre_publicador"].ToString();
                publicadores.AddLast(publicador);

            }//fin while

            //************-----6: Se cierra la conexión -----**********//
            conexion.Close();
            return publicadores;
        }

        public Publicador GetPublicadorPorLibro(int libro) //Extención funcionabilidad
        {
            //************----- 1:Creación variable de tipo SqlConnection-----***********//
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            //************----- 2:Creación variable de tipo SqlCommand-----***********//
            //************----Recibe por parametro la consulta requerida a la base de datos----***************//
            SqlCommand cmdPublicador = new SqlCommand("select p.id_publicador,p.nombre_publicador,p.url_sitio_web " +
                                                       " from Publicador p , Libro l " +
                                                       " where l.cod_libro = " + libro+" and p.id_publicador = l.id_publicador " +
                                                       " order by nombre_publicador  ", conexion);

            //************----- 3: Abre la conexión con el servidor**************-----//
            conexion.Open();

            //************-----4: Se utiliza SqlDataReader para almacenar y lograr acceder a la consulta realizada.----***// 
            SqlDataReader drpublicador = cmdPublicador.ExecuteReader();

            //************-----5: Se crea una lista enlazada y posterior mediante un ciclo se almacenan las diferentes tuplas obtenidas----*****//
            LinkedList<Publicador> publicadores = new LinkedList<Publicador>();
            Publicador publicador = new Publicador();
            while (drpublicador.Read())
            {
               
                publicador.IdPublicador = Int32.Parse(drpublicador["id_publicador"].ToString());
                publicador.NombrePublicador = drpublicador["nombre_publicador"].ToString();
              

            }//fin while

            //************-----6: Se cierra la conexión -----**********//
            conexion.Close();
            return publicador;
        }
    }


}
