using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCeibaB21290.LibreriaCeibaB21290.Common.Domain
{
    public class Autor
    {
        private int idAutor;
        private String nombreAutor;
        private String primerApellido;
        private String segundoApellido;

        public Autor(){}

        public int IdAutor
        {
            get
            {
                return idAutor;
            }

            set
            {
                idAutor = value;
            }
        }

        public string NombreAutor
        {
            get
            {
                return nombreAutor;
            }

            set
            {
                nombreAutor = value;
            }
        }

        public string PrimerApellido
        {
            get
            {
                return primerApellido;
            }

            set
            {
                primerApellido = value;
            }
        }

        public string SegundoApellido
        {
            get
            {
                return segundoApellido;
            }

            set
            {
                segundoApellido = value;
            }
        }
    }
}
