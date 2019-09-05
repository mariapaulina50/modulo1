using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClCliente
    {
        //Busca que el ID exista
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
        //Muestra los clientes
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
        //Muestra los usuarios
        public static object ListaUsuarios()
        {
            EntidadDataContext context = new EntidadDataContext();

            var query = from u in context.usuarios
                        select new
                        {
                            correo = u.correo,
                            clave = u.clave
                        };

            return query;
        }

        //Acá cualquier persona puede registrarse como cliente 
        public static int AgregarCliente(string documento, string correo, string nombre,
            string direccion, string telefono)
        {
            int resultado = 0;

            EntidadDataContext entity = new EntidadDataContext();
            clientes clientes = Buscar_DocumentoClientes(documento);

            if (clientes == null)
            {
                clientes = new clientes();
                clientes.documento = documento;
                clientes.correo = correo;
                clientes.nombre = nombre;
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

        public static clientes Buscar_DocumentoClientes(string documento)
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
        public static int AgregarUsuario(string correo, string clave)
        {
            int resultado = 0;

            EntidadDataContext entity = new EntidadDataContext();
            usuarios usuario = Buscar_CorreoUsuarios(correo);

            if (usuario == null)
            {
                usuario = new usuarios();
                usuario.correo = correo;
                usuario.clave = clave;
                usuario.idRol = 2;

                try
                {
                    entity.usuarios.InsertOnSubmit(usuario);
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

        public static usuarios Buscar_CorreoUsuarios(string correo)
        {
            EntidadDataContext context = new EntidadDataContext();
            usuarios usuario = null;

            var query = context.usuarios.Where(p => p.correo == correo).Select(p => p);

            if (query.Count() > 0)
            {
                usuario = query.First();
            }
            return usuario;
        }
       
    }
}
