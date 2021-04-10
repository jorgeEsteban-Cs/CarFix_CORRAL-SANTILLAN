using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFix_LibBD;

namespace CarFix_Domain
{
    public class Login
    {

        public bool login(string email, string password)
        {

            bool res = false;

            //iniciando el servidor
            MariaBD lginBD = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");

            //MEtodo login para la autentificacion de usuario
            res = lginBD.login(email, password);

            return res;

        }
    }
}
