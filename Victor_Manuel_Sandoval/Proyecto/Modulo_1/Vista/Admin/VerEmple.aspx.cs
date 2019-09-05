using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Vista.Admin
{
    public partial class VerEmple : System.Web.UI.Page
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
            gvEmpleados.DataSource = CLempleado.ListaEmpleados();
            gvEmpleados.DataBind();
        }

        protected void gvEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow fila = gvEmpleados.SelectedRow;
            hdDocumentoEmpleado.Value = fila.Cells[1].Text;
            AsignarCampos();
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            int idEmpleado = int.Parse(hdEmpleadoID.Value);
            string documento = txtDocumento.Text;
            string correo = txtEmail.Text;
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;


            int Registro = CLAdmin.ModificarEmpleadoAdmin(idEmpleado, documento, correo, nombre, direccion, telefono);

            if (Registro == 3)
            {
                Response.Write("<script>alert('Empleado modificado')</script>");
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
            string documento = hdDocumentoEmpleado.Value;
            empleados empleados = CLAdmin.Buscar_DocumentoEmpleadoAdmin(documento);
            hdEmpleadoID.Value = empleados.idEmpleado.ToString();
            txtDocumento.Text = empleados.documento;
            txtNombre.Text = empleados.nombre;
            txtEmail.Text = empleados.correo;
            txtTelefono.Text = empleados.telefono;
            txtDireccion.Text = empleados.direccion;

            Modificar.Visible = true;

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int idEmpleado = int.Parse(hdEmpleadoID.Value);
            bool resultado = CLAdmin.EliminarEmpleadosAdmin(idEmpleado);


            if (resultado == false)
            {
                Response.Write("<script>alert('Ocurrió un error al eliminar el empleado')</script>");
            }
            else
            {
                Response.Write("<script>alert('Empleado eliminado con exito')</script>");
                Lista();
            }
        }
    }
    }
