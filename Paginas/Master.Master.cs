using Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClasesNegocio; 

namespace Paginas
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["Usuario"] != null)
                {
                    Usuario usuario = new Usuario();
                    UsuarioNegocio negocio = new UsuarioNegocio();
                    usuario.Nombre = ((Usuario)Session["Usuario"]).Nombre;
                    usuario.Id = ((Usuario)Session["Usuario"]).Id;
                    usuario.Admin = ((Usuario)Session["Usuario"]).Admin;
                    lblUsuarioBienvenida.Text = "!Bienvenido, " + usuario.Nombre + "!";
                    
                    if (negocio.esAdmin(usuario)){ 
                        btnAdmin.Visible = true;
                        btnFavoritos.Visible = false; 
                    }
                    
                }
            }

            if (Page is CrearCuenta)
            {
                btnCrearCuenta.Visible = false;
                btnInicio.Visible = true;
            }

            if (Page is Inicio)
            {
                btnInicio.Visible = false;
            } 
            if (Page is Login)
            {
                btnLogin.Visible = false; 
            }
            if(Page is Favoritos)
            {
                btnFavoritos.Visible = false; 
                
            }
            if(Page is PaginaAdmin)
            {
                btnCrearCuenta.Visible = false;
                btnLogin.Visible = false; 
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx", false); 
        }

        protected void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearCuenta.aspx", false); 
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx", false); 
        }

        protected void btnFavoritos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Favoritos.aspx", false); 
        }

        protected void btnInicioFavorito_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx", true);
        }


        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaAdmin.aspx", false); 
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Remove("Usuario");
            Response.Redirect("Inicio.aspx", true); 
        }
    }
}