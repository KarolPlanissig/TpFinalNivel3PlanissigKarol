using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;
using ClasesNegocio;

namespace Paginas
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                
                ArticuloNegocio negocio = new ArticuloNegocio();
                Session.Add("ListaArticulos", negocio.listarArticulos());
                repRepetidorr.DataSource = Session["ListaArticulos"];
                repRepetidorr.DataBind(); 
            }
            
        }


        protected void btnVerDetalle_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument;

            Session.Add("IdArticulo", valor);
            Response.Redirect("DetalleArticulo.aspx", false);

        }

        protected void Filtro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> lista = (List<Articulo>)Session["ListaArticulos"];
            List<Articulo> listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()));
            repRepetidorr.DataSource= listaFiltrada;
            repRepetidorr.DataBind(); 

        }
    }
}