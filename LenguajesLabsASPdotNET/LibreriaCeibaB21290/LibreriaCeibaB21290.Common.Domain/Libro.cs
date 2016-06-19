using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCeibaB21290.LibreriaCeibaB21290.Common.Domain
{
    public class Libro
    {
        private int codLibro;
        private String tituloLibro;
        private int anoPublicacion;
        private float precio;
        private String isbn;
        private LinkedList<Autor> autores;
        private Publicador publicador;

        public Libro(int codLibro, String tituloLibro)
        {
            this.codLibro = codLibro;
            this.tituloLibro = tituloLibro;
            publicador = new Publicador();
        }

        public Libro()
        {
            publicador = new Publicador();
            autores = new LinkedList<Autor>();
        }
        public int CodLibro
        {
            get
            {
                return codLibro;
            }

            set
            {
                codLibro = value;
            }
        }

        public string TituloLibro
        {
            get
            {
                return tituloLibro;
            }

            set
            {
                tituloLibro = value;
            }
        }

        public int AnoPublicacion
        {
            get
            {
                return anoPublicacion;
            }

            set
            {
                anoPublicacion = value;
            }
        }

        public float Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public LinkedList<Autor> Autores
        {
            get
            {
                return autores;
            }

            set
            {
                autores = value;
            }
        }

        public Publicador Publicador
        {
            get
            {
                return publicador;
            }

            set
            {
                publicador = value;
            }
        }

        public string Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }




    }
}
