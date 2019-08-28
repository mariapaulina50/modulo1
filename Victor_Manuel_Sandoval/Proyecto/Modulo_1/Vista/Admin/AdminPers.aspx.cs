using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista.Admin
{
    public partial class AdminPers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void admin_perso(object sender, EventArgs e)
        {
            Response.Redirect("MenuAdmin.aspx");
        }

        protected void lista_clientes(object sender, EventArgs e)
        {
            Response.Redirect("VerPers.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;
            string correo = txtEmail.Text;
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            int Registro = ClUsuario.AgregarUsuario(documento, correo, nombre, direccion, telefono);

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
            txtDocumento.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }
    }
}