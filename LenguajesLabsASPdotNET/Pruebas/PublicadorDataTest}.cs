using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaCeibaB21290.LibreriaCeibaB21290.DataAccess;
using LibreriaCeibaB21290.LibreriaCeibaB21290.Common.Domain;

namespace Pruebas
{

    [TestClass]
    public class PublicadorDataTest_
    {
        PublicadorData publicadorData;
        public PublicadorDataTest_()
        {
            this.publicadorData = new PublicadorData("Data Source=163.178.107.130;Initial Catalog=LibreriaCeibaB21290;Integrated Security=True;User ID=sqlserver;Password=saucr.12");
        }

        [TestMethod]
        public void TestMethod1()
        {
            LinkedList<Publicador> lista = publicadorData.GetPublicadores();

            foreach (Publicador publicadorActual in lista)
            {
                Console.Write("Nombre del publicador" + publicadorActual.NombrePublicador);
            }
        }
    }
}
