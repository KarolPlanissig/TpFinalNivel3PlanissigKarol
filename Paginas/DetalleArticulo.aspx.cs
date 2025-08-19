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
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        protected Articulo articulo;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["IdArticulo"] is null)
            {
                Response.Redirect("Inicio.aspx", false);
            }

            string id = (string)Session["IdArticulo"];

            ArticuloNegocio negocio = new ArticuloNegocio();

            articulo = negocio.devolverArticulo(id);

            if (Session["Usuario"] != null)
            {
                Usuario usuario = (Usuario)Session["Usuario"];

               List<Articulo> lista =  negocio.listarFavoritos(usuario.Id.ToString());

                foreach (Articulo item in lista)
                {
                    if (item.Id.ToString() == id)
                    {
                        btnFavorito.Visible = false;
                    }
                }

            }
            
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        { 
            if (Session["Usuario"] != null)
            {
                Usuario usuario = (Usuario)Session["Usuario"];
                UsuarioNegocio negocio = new UsuarioNegocio();

                if (negocio.esAdmin(usuario))
                {
                    Session.Remove("ArticuloFavorito");
                    Response.Redirect("PaginaAdmin.aspx", true);
                }

            }
            Session.Remove("ArticuloFavorito"); 
            Response.Redirect("Inicio.aspx", false);
        }



        protected void btnFavorito_Click(object sender, EventArgs e)
        {
            string idArticulo = (string)Session["IdArticulo"];
            int idUsuario = ((Usuario)Session["Usuario"]).Id;

            UsuarioNegocio negocio = new UsuarioNegocio();

            negocio.agregarFavorito(idArticulo, idUsuario);
            btnFavorito.Visible = false; 
            

        }

        protected void btnRegresarUsuarioArticulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("Favoritos.aspx", false); 
        }

        protected void btnUsuarioNull_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx", false); 
        }

        protected void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            string id = (string)Session["IdArticulo"];

            Session.Add("IdArticulo", id); 
              
            Response.Redirect("ModificarArticulo.aspx", true); 
        }
    }
}