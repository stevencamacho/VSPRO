using LibreriaCeibaB21290.LibreriaCeibaB21290.Bussiness;
using LibreriaCeibaB21290.LibreriaCeibaB21290.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaCeibaWebAppB21290
{
    public partial class LibrosPorPublicador : System.Web.UI.Page
    {

        private static LinkedList<Libro> libros;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                PublicadorBusiness publicadorBusiness = new PublicadorBusiness(WebConfigurationManager.ConnectionStrings["LibreriaCeiba"].ConnectionString);
                LinkedList<Publicador> publicadores = publicadorBusiness.GetPublicadores();
                libros = new LinkedList<Libro>();
                //llenamos el drop down list
                foreach (Publicador pub in publicadores)
                {
                    lbPublicadores.Items.Add(new ListItem(pub.NombrePublicador, pub.IdPublicador.ToString()));
                }


                ddlPublicadores.DataSource = publicadores;
                ddlPublicadores.DataTextField = "nombrePublicador";
                ddlPublicadores.DataValueField = "idPublicador";
                ddlPublicadores.DataBind();


            }//fin if
        }// fin metodo page_load

        protected void ddlPublicadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarGvLibros(Int32.Parse(ddlPublicadores.SelectedValue));
        }

        protected void lbPublicadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarGvLibros(Int32.Parse(lbPublicadores.SelectedValue));
        }

        public void cargarGvLibros(int indice)
        {
            LibroBusiness libroBusiness = new LibroBusiness(WebConfigurationManager.ConnectionStrings["LibreriaCeiba"].ConnectionString);
            libros = libroBusiness.GetLibrosPorPublicador(indice);
            gvLibros.DataSource = libros;
            gvLibros.DataBind();
        }

        protected void gvLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            String gvIndice = gvLibros.Rows[gvLibros.SelectedRow.RowIndex].Cells[1].Text;

            foreach (Libro libro in libros)
            {
                if (libro.CodLibro == Int32.Parse(gvIndice))
                {
                    Session["Libro"] = libro;
                }
            }

            Response.Redirect("~/MostrarLibro.aspx");
        }

        
    }
}