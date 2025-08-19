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
    public partial class CrearCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Page.Validate();

            if (!Page.IsValid)
            {
                return;
            }

            try
            {

                if(txtRepetir.Text == txtPassword.Text)
                { 

                    Usuario nuevo = new Usuario();
                    UsuarioNegocio negocio = new UsuarioNegocio();

                    nuevo.Nombre = txtNombre.Text;
                    nuevo.Apellido = txtApellido.Text;
                    nuevo.Email = txtCorreo.Text;
                    nuevo.Contraseña = txtPassword.Text;

                    negocio.insertarUsuario(nuevo);

                    Session.Add("Usuario", nuevo);
                    Response.Redirect("Inicio.aspx", false);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}