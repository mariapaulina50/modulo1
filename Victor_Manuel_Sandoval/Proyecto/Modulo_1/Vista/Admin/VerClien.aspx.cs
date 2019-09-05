using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista.Admin
{
    public partial class VerClien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lista();
            OcultarDiv();
        }

        private void OcultarDiv()
        {
            Modificar.Visible = false;
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
            gvClientes.DataSource = ClCliente.ListaClientes();
            gvClientes.DataBind();
        }

        protected void gvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow fila = gvClientes.SelectedRow;
            hddocumentoCliente.Value = fila.Cells[1].Text;
            AsignarCampos();

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(hdclienteID.Value);
            string documento = txtDocumento.Text;
            string correo = txtEmail.Text;
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
           

            int Registro = CLAdmin.ModificarClienteAdmin(idCliente, documento, correo, nombre, direccion, telefono);

            if (Registro == 3)
            {
                Response.Write("<script>alert('Cliente modificado')</script>");
            }
            else
            {
                Response.Write("<script>alert('Ocurrió un error al modificarse')</script>");
            }

            Limpiar();
            OcultarDiv();

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            OcultarDiv();

        }

        public void Limpiar()
        {
            txtDocumento.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private void AsignarCampos()
        {
            string documento = hddocumentoCliente.Value;
            clientes clientes = CLAdmin.Buscar_DocumentoClienteAdmin(documento);
            hdclienteID.Value = clientes.idCliente.ToString();
            txtDocumento.Text = clientes.documento;
            txtNombre.Text = clientes.nombre;
            txtEmail.Text = clientes.correo;
            txtTelefono.Text = clientes.telefono;
            txtDireccion.Text = clientes.direccion;

            Modificar.Visible = true;

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(hdclienteID.Value);
            bool resultado = CLAdmin.EliminarClientesAdmin(idCliente);


            if (resultado == false)
            {
                Response.Write("<script>alert('Ocurrió un error al eliminar el cliente')</script>");
            }
            else
            {
                Response.Write("<script>alert('Cliente eliminado con exito')</script>");
                Lista();
            }

            
        }
        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            GridViewRow fila = gvClientes.SelectedRow;
        }
    }
}