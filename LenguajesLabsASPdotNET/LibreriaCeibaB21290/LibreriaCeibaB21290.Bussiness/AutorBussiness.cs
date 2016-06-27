using LibreriaCeibaB21290.LibreriaCeibaB21290.Common.Domain;
using LibreriaCeibaB21290.LibreriaCeibaB21290.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCeibaB21290.LibreriaCeibaB21290.Bussiness
{
    public class AutorBusiness
    {
        AutorData autorData;

        public AutorBusiness(string connectionString)
        {
            this.autorData = new AutorData(connectionString);
        }

        public LinkedList<Autor> GetAutores(int id)
        {
            return this.autorData.GetAutoresPorLibro(id);
        }
    }
}

}
