using Clases;
using ClasesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paginas
{
    public partial class PaginaAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (!IsPostBack)
            {
                if (Session["Usuario"] != null)
                {
                    Usuario usuario = (Usuario)Session["Usuario"];
                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                
                    if (!(usuarioNegocio.esAdmin(usuario)))
                    {
                        Response.Redirect("Inicio.aspx", true); 
                    }
                }
                else
                {
                    Response.Redirect("Inicio.aspx", true); 
                }
                ArticuloNegocio negocio = new ArticuloNegocio();

                repRepetidorAdmin.DataSource = negocio.listarArticulos();
                repRepetidorAdmin.DataBind();
            }
        }


        protected void btnVerDetalle_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;
            Session.Add("IdArticulo", valor);
            Session.Add("ArticuloFavorito", valor); 
            Response.Redirect("DetalleArticulo.aspx", true);
        }

        protected void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio(); 
            string valor = ((Button)sender).CommandArgument;
            Session.Add("IdEliminar", valor);
            Response.Redirect("EliminarArticulo.aspx", false);

            
        }

        protected void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;
            Session.Add("IdArticulo", valor);
            Response.Redirect("ModificarArticulo.aspx", false); 
        }

        protected void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarArticulo.aspx", false);
        }
    }
}