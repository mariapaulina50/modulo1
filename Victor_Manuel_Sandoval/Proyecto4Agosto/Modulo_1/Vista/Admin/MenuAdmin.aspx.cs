using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class MenuAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lista_clientes(object sender, EventArgs e)
        {
            Response.Redirect("VerUsu.aspx");
        }

        protected void admin_clientes(object sender, EventArgs e)
        {
            Response.Redirect("AgregarEmple.aspx");
        }
    }
}