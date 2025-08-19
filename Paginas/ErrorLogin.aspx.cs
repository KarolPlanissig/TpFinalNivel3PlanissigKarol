using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paginas
{
    public partial class ErrorLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReintentar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx", false); 
        }
    }
}