using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCeibaB21290.LibreriaCeibaB21290.Common.Domain
{
    public class Publicador
    {
        private int idPublicador;
        private String nombrePublicador;
        private String urlSitioWeb;

        public Publicador(){}

        public int IdPublicador
        {
            get
            {
                return idPublicador;
            }

            set
            {
                idPublicador = value;
            }
        }

        public string NombrePublicador
        {
            get
            {
                return nombrePublicador;
            }

            set
            {
                nombrePublicador = value;
            }
        }

        public string UrlSitioWeb
        {
            get
            {
                return urlSitioWeb;
            }

            set
            {
                urlSitioWeb = value;
            }
        }

    }
}

