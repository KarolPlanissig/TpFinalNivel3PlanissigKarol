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
    public partial class ModificarArticulo : System.Web.UI.Page
    {
        protected Articulo articulo;
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

                if (Session["IdArticulo"] != null)
                {
                    string id = (string)Session["IdArticulo"];
                    ArticuloNegocio negocio = new ArticuloNegocio();

                    articulo = negocio.devolverArticulo(id);

                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.ImagenUrl; 
                    txtCodigo.Text = articulo.Codigo;
                    txtPrecio.Text = articulo.Precio.ToString();

                    List<Marcas> marcas = negocio.listarMarcas();
                    ddlMarca.DataSource = marcas;
                    ddlMarca.DataTextField = "Descripcion";
                    ddlMarca.DataValueField = "Id";
                    ddlMarca.DataBind();
                    ddlMarca.SelectedValue = articulo.Marcas.Id.ToString();

                    List<Categorias> categorias = new List<Categorias>();
                    ddlCategoria.DataSource = negocio.listarCategoria();
                    ddlCategoria.DataTextField = "Descripcion";
                    ddlCategoria.DataValueField = "Id";
                    ddlCategoria.DataBind();
                    ddlCategoria.SelectedValue = articulo.Categoria.Id.ToString();

                    //negocio.modificarArticulo(articulo);
                }
                else
                {
                    Response.Redirect("Inicio.aspx", true); 
                }
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaginaAdmin.aspx", true); 
        }

        protected void btnConfimar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            int id = Convert.ToInt32(Session["IdArticulo"]); 

            try
            {
                articulo.Nombre = txtNombre.Text; 
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Codigo = txtCodigo.Text;
                articulo.ImagenUrl = txtImagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Id = id;

                negocio.modificarArticulo(articulo);
                Response.Redirect("PaginaAdmin.aspx", true); 

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}