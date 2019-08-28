using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista.Admin
{
    public partial class VerPers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lista();
        }

        protected void admin_pers(object sender, EventArgs e)
        {
            Response.Redirect("AdminPers.aspx");
        }

        protected void admin_perso(object sender, EventArgs e)
        {
            Response.Redirect("MenuAdmin.aspx");
        }

        protected void Lista()
        {
            gvPersonas.DataSource = ClUsuario.ListaClientes();
            gvPersonas.DataBind();
        }
    }
}