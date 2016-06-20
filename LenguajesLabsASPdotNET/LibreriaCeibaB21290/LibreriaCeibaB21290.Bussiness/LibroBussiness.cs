using LibreriaCeibaB21290.LibreriaCeibaB21290.Common.Domain;
using LibreriaCeibaB21290.LibreriaCeibaB21290.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCeibaB21290.LibreriaCeibaB21290.Bussiness
{
    public class LibroBusiness
    {
        private String conetionString;
        private LibroData libroData;

        public LibroBusiness(String conetionString)
        {
            this.conetionString = conetionString;
            libroData = new LibroData(conetionString);
        }

        public LinkedList<Libro> GetLibrosPorPublicador(int idPublicador)
        {
            return libroData.GetLibrosPorPublicador(idPublicador);
        }


    }
}
