using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista.Admin
{
    public partial class VerUsu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lista();
        }

        protected void admin_pers(object sender, EventArgs e)
        {
            
        }

        protected void admin_perso(object sender, EventArgs e)
        {
            Response.Redirect("MenuAdmin.aspx");
        }

        protected void Lista()
        {
            gvUsuarios.DataSource = ClCliente.ListaUsuarios();
            gvUsuarios.DataBind();
        }

        protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}