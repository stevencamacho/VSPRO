using LibreriaCeibaB21290.LibreriaCeibaB21290.Common.Domain;
using LibreriaCeibaB21290.LibreriaCeibaB21290.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCeibaB21290.LibreriaCeibaB21290.Bussiness
{
    public class PublicadorBusiness
    {
        private PublicadorData publicadorData;
        private String conetionString;

        public PublicadorBusiness(String conetionString)
        {
            this.conetionString = conetionString;
            publicadorData = new PublicadorData(this.conetionString);
        }

        public LinkedList<Publicador> GetPublicadores()
        {
            return publicadorData.GetPublicadores();
        }

    }
}
