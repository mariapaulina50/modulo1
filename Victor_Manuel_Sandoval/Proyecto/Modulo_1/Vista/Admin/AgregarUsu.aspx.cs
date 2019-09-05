using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista.Admin
{
    public partial class AgregarUsu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string clave = txtClave.Text;

            int Registro = ClCliente.AgregarUsuario(correo, clave);

            if (Registro == 1)
            {
                Response.Write("<script>alert('Usuario ya existe')</script>");
            }
            else if (Registro == 2)
            {
                Response.Write("<script>alert('Ocurrió un error al registrarse')</script>");
            }
            else if (Registro == 3)
            {
                Response.Write("<script>alert('Usuario registrado con éxito')</script>");
            }

            Limpiar();
        }
        public void Limpiar()
        {
            txtCorreo.Text = string.Empty;
            txtClave.Text = string.Empty;
        }
    }
}