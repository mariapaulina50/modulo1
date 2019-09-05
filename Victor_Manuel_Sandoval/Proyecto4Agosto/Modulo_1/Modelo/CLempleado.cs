using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class CLempleado
    {
        public static object ListaEmpleados()
        {
            EntidadDataContext context = new EntidadDataContext();

            var query = from u in context.empleados
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
    }
}
