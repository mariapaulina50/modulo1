using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class CLAdmin
    {
        public static int AgregarEmpleadoAdmin(string documento, string correo, string nombres,
           string direccion, string telefono)
        {
            int resultado = 0;

            EntidadDataContext entity = new EntidadDataContext();
            empleados empleados = Buscar_DocumentoEmpleadoAdmin(documento);

            if (empleados == null)
            {
                empleados = new empleados();
                empleados.documento = documento;
                empleados.correo = correo;
                empleados.nombre = nombres;
                empleados.direccion = direccion;
                empleados.telefono = telefono;

                try
                {
                    entity.empleados.InsertOnSubmit(empleados);
                    entity.SubmitChanges();

                    resultado = 3;
                    //Exitoooo
                }
                catch (Exception)
                {
                    resultado = 2;
                    //Error al guardar
                }
            }
            else
            {
                resultado = 1;
                //Ya existe en la base de datos
            }

            return resultado;
        }
        public static empleados Buscar_DocumentoEmpleadoAdmin(string documento)
        {
            EntidadDataContext context = new EntidadDataContext();
            empleados empleados = null;

            var query = context.empleados.Where(p => p.documento == documento).Select(p => p);

            if (query.Count() > 0)
            {
                empleados = query.First();
            }
            return empleados;
        }
        //Modificar Empleado
        public static int ModificarEmpleadoAdmin(int Documento, string documento, string correo, string nombres,
           string direccion, string telefono)
        {
            int resultado = 0;

            EntidadDataContext entity = new EntidadDataContext();

            empleados empleados = entity.empleados.Where(p => p.idEmpleado == Documento).Select(p => p).First();
            empleados.documento = documento;
            empleados.correo = correo;
            empleados.nombre = nombres;
            empleados.direccion = direccion;
            empleados.telefono = telefono;

            try
            {
                entity.SubmitChanges();

                resultado = 3;
                //Exitoooo
            }
            catch (Exception)
            {
                resultado = 2;
                //Error al modificar
            }

            return resultado;
            
            //Eliminar Empleado
        }
        public static bool EliminarEmpleadosAdmin(int idEmpleado)
        {
            EntidadDataContext entity = new EntidadDataContext();
            bool resultado = true;

            empleados empleados = entity.empleados.Where(p => p.idEmpleado == idEmpleado).Select(p => p).First();

            try
            {
                entity.empleados.DeleteOnSubmit(empleados);
                entity.SubmitChanges();
            }
            catch (Exception)
            {
                resultado = false;
            }

            return resultado;
        }

        public static int AgregarClienteAdmin(string documento, string correo, string nombres,
            string direccion, string telefono)
        {
            int resultado = 0;

            EntidadDataContext entity = new EntidadDataContext();
            clientes clientes = Buscar_DocumentoClienteAdmin(documento);

            if (clientes == null)
            {
                clientes = new clientes();
                clientes.documento = documento;
                clientes.correo = correo;
                clientes.nombre = nombres;
                clientes.direccion = direccion;
                clientes.telefono = telefono;

                try
                {
                    entity.clientes.InsertOnSubmit(clientes);
                    entity.SubmitChanges();

                    resultado = 3;
                    //Exitoooo
                }
                catch (Exception)
                {
                    resultado = 2;
                    //Error al guardar
                }
            }
            else
            {
                resultado = 1;
                //Ya existe en la base de datos
            }

            return resultado;
        }
        public static clientes Buscar_DocumentoClienteAdmin(string documento)
        {
            EntidadDataContext context = new EntidadDataContext();
            clientes clientes = null;

            var query = context.clientes.Where(p => p.documento == documento).Select(p => p);

            if (query.Count() > 0)
            {
                clientes = query.First();
            }
            return clientes;
        }
        
        //Modificar Cliente 
        public static int ModificarClienteAdmin(int idCliente, string documento, string correo, string nombres,
            string direccion, string telefono)
        {
            int resultado = 0;

            EntidadDataContext entity = new EntidadDataContext();

            clientes clientes = entity.clientes.Where(p => p.idCliente == idCliente).Select(p => p).First();
            clientes.documento = documento;
            clientes.correo = correo;
            clientes.nombre = nombres;
            clientes.direccion = direccion;
            clientes.telefono = telefono;

            try
            {
                entity.SubmitChanges();

                resultado = 3;
                //Exitoooo
            }
            catch (Exception)
            {
                resultado = 2;
                //Error al modificar
            }

            return resultado;
        }
        public static bool EliminarClientesAdmin(int idCliente)
        {
            EntidadDataContext entity = new EntidadDataContext();
            bool resultado = true;

            clientes clientes = entity.clientes.Where(p => p.idCliente == idCliente).Select(p => p).First();

            try
            {
                entity.clientes.DeleteOnSubmit(clientes);
                entity.SubmitChanges();
            }
            catch (Exception)
            {
                resultado = false;
            }

            return resultado;
        }


    }
}
