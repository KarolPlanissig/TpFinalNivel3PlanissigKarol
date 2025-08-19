using Clases;
using ClasesNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Discovery;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paginas
{
    public partial class AgregarArticulo : System.Web.UI.Page
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
                List<Marcas> marcas = negocio.listarMarcas();
                ddlMarca.DataSource = marcas;
                ddlMarca.DataTextField = "Descripcion";
                ddlMarca.DataValueField = "Id";
                ddlMarca.DataBind();

                List<Categorias> categorias = new List<Categorias>();
                ddlCategoria.DataSource = negocio.listarCategoria();
                ddlCategoria.DataTextField = "Descripcion";
                ddlCategoria.DataValueField = "Id";
                ddlCategoria.DataBind();
            }

        }

        protected void btnConfimar_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (!Page.IsValid)
            {
                return;
            }

            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            nuevo.Nombre = txtNombre.Text;
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Codigo = txtCodigo.Text;
            nuevo.ImagenUrl = txtImagen.Text;
            nuevo.Categoria = new Categorias();
            nuevo.Categoria.Id = int.Parse(ddlCategoria.SelectedValue);
            nuevo.Marcas = new Marcas();
            nuevo.Marcas.Id = int.Parse(ddlMarca.SelectedValue);
            nuevo.Precio = decimal.Parse(txtPrecio.Text);

            negocio.agregarArticulo(nuevo);

            Response.Redirect("Inicio.aspx", true);

        }
    }
}