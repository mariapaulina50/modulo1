using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar1_Click(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;
            string correo = txtEmail.Text;
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            int Registro = ClCliente.AgregarCliente(documento, correo, nombre, direccion, telefono);

            if (Registro == 1)
            {
                Response.Write("<script>alert('Cliente ya existe')</script>");
            }
            else if (Registro == 2)
            {
                Response.Write("<script>alert('Ocurrió un error al registrarse')</script>");
            }
            else if (Registro == 3)
            {
                Response.Write("<script>alert('Cliente registrado con éxito')</script>");
                Response.Redirect("RegistroUsuario.aspx");
            }

            Limpiar();
        }

        public void Limpiar()
        {
            txtDocumento.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }
    }
}