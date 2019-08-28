using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClLogin
    {
        public static int IniciarSesion(String user, String pass)
        {
            EntidadDataContext context = new EntidadDataContext();
            int userID = 0;
            var query = context.usuarios.Where(p => p.usuario == user && p.clave == pass).Select(p => p);

            var query1 = from p in context.usuarios
                        where p.usuario == user && p.clave == pass
                        select p;

            if (query.Count() > 0)
            {
                userID = query.First().idRol;
            }

            return userID;
        }
    }
}
