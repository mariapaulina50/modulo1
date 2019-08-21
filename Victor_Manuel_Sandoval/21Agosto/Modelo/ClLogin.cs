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
            var query = context.usuarios.Where(p => p.usuario == user && p.clave == pass).Select(p => p);
            int IDRol = 0;
            if(query.Count() > 0)
            {
                IDRol = query.First().idRol;
            }
            return IDRol;
        }

    }
}
