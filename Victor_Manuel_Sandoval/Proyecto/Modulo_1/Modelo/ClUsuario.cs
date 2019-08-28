using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClUsuario
    {

        public static clientes BuscarID(int userID)
        {
            EntidadDataContext context = new EntidadDataContext();
            clientes cliente = null;

            var query = context.clientes.Where(p => p.idCliente == userID).Select(p => p);

            if (query.Count() > 0)
            {

                cliente = query.First();
            }
            return cliente;
        }

        public static object ListaClientes()
        {
            EntidadDataContext context = new EntidadDataContext();

            var query = from u in context.clientes
                        select new
                        {
                            Cedula = u.documento,
                            Nombre = u.nombre,
                            Correo = u.correo,
                            Dirección = u.direccion,
                            Telefono = u.telefono
                        };

            return query;
        }

        public static int AgregarUsuario(string documento, string correo, string nombres,
            string direccion, string telefono)
        {
            int resultado = 0;

            EntidadDataContext entity = new EntidadDataContext();
            clientes clientes = Buscar_Documento(documento);

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

        public static clientes Buscar_Documento(string documento)
        {
            EntidadDataContext context = new EntidadDataContext();
            clientes cliente = null;

            var query = context.clientes.Where(p => p.documento == documento).Select(p => p);

            if (query.Count() > 0)
            {
                 cliente = query.First();
            } 
            return cliente;
        }
    }
}
