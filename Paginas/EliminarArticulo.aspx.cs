using ClasesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paginas
{
    public partial class EliminarArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null && Session["IdEliminar"] == null)
            {
                Response.Redirect("Inicio.aspx", false); 
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {

                string id = (string)Session["IdEliminar"];
                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.eliminarArticulo(id);
                Session.Remove("IdEliminar");
                Response.Redirect("PaginaAdmin.aspx", false);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaAdmin.aspx", true);
        }
    }
}