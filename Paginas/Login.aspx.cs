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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrEmpty(txtEmail.Text)) && !(string.IsNullOrEmpty(txtContraseña.Text)))
            {
                Usuario usuario = new Usuario();
                UsuarioNegocio negocio = new UsuarioNegocio(); 
                usuario.Email = txtEmail.Text;
                usuario.Contraseña = txtContraseña.Text;

                if (negocio.validarUsuario(usuario))
                {
                    Session.Add("Usuario", usuario);
                    if (negocio.esAdmin(usuario))
                    {
                        Response.Redirect("PaginaAdmin.aspx", true);
                    }
                    else
                    {
                        Response.Redirect("Inicio.aspx", false); 
                    }
                }

            }
            else
            {
                Response.Redirect("ErrorLogin.aspx", false); 
            }
        }
    }
}