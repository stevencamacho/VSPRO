using LibreriaCeibaB21290.LibreriaCeibaB21290.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibreriaCeibaWebAppB21290
{
    public partial class MostrarLibro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
               
                if (Session["Libro"] != null)
                {
                    Libro libro = (Libro)Session["Libro"];

                    lbTitulo.Text = libro.TituloLibro;
                    lbPublicador.Text = libro.Publicador.NombrePublicador;
                    lbIsbn.Text = libro.Isbn;
                    lbAnio.Text = libro.AnoPublicacion.ToString();
                    lbCodigo.Text = libro.CodLibro.ToString();
                    lbPrecio.Text = libro.Precio.ToString();
                    gvAutores.DataSource = libro.Autores;
                    gvAutores.DataBind();

                }



            }



        }
    }
}