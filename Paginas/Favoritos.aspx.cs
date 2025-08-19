using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClasesNegocio; 

namespace Paginas
{
    public partial class Favoritos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            if (Session["Usuario"] == null)
            {
                Response.Redirect("Inicio.aspx", true);
            }
            
            if (!IsPostBack)
            {
                
                string idUsuario = ((Usuario)Session["Usuario"]).Id.ToString(); 
                repFavoritos.DataSource =negocio.listarFavoritos(idUsuario);
                repFavoritos.DataBind();
                if(repFavoritos.Items.Count == 0)
                {
                    lblBienvenida.Text = "No tienes favoritos aún";
                    repFavoritos.Visible = false;
                }

            }


        }

        protected void VerDetalle_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;

            Session.Add("IdArticulo", valor);
            Session.Add("ArticuloFavorito", valor); 
            Response.Redirect("DetalleArticulo.aspx", false);
        }
    }
}