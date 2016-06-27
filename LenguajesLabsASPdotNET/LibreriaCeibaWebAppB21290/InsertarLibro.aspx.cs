using LibreriaCeibaB21290.LibreriaCeibaB21290.Bussiness;
using LibreriaCeibaB21290.LibreriaCeibaB21290.Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaCeibaWebAppB21290
{
    public partial class InsertarLibro : System.Web.UI.Page
    {
        string connectionString;
        AutorBusiness autorBusiness;
        PublicadorBusiness publicadorBusiness;
        LibroBusiness libroBusiness;
        LinkedList<Autor> listaAutores;
        LinkedList<Publicador> listaPublicadores;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //connectionString = "Data Source=163.178.107.130;Initial Catalog=LibreriaCeibaB20031;Persist Security Info=True;User ID=sqlserver;Password=saucr.12";
                connectionString = WebConfigurationManager.ConnectionStrings["LibreriaCeibaDB"].ConnectionString;
                this.autorBusiness = new AutorBusiness(connectionString);
                this.publicadorBusiness = new PublicadorBusiness(connectionString);
                this.listaAutores = autorBusiness.GetAutores(1);
                this.listaPublicadores = publicadorBusiness.GetPublicadores();

               
                
            }
        }

        protected void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            List<ListItem> itemsARemover = new List<ListItem>();
            //cargamos el listbox de Seleccionados
            foreach (ListItem autor in lbAutoresDisponibles.Items)
            {
                if (autor.Selected)
                {
                    lbAutoresSeleccionados.Items.Add(autor);
                    itemsARemover.Add(autor);
                }
            }

            //Borramos los elementos seleccionados del listbox de Disponibles
            foreach (ListItem autor in itemsARemover)
            {
                lbAutoresDisponibles.Items.Remove(autor);
            }
        }

        protected void btnQuitarAutor_Click(object sender, EventArgs e)
        {
            List<ListItem> itemsARemover = new List<ListItem>();
            //cargamos el listbox de Seleccionados
            foreach (ListItem autor in lbAutoresSeleccionados.Items)
            {
                if (autor.Selected)
                {
                    lbAutoresDisponibles.Items.Add(autor);
                    itemsARemover.Add(autor);
                }
            }

            //Borramos los elementos seleccionados del listbox de Disponibles
            foreach (ListItem autor in itemsARemover)
            {
                lbAutoresSeleccionados.Items.Remove(autor);
            }
        }

       
    }
}