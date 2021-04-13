using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFix_LibBD;


namespace CarFix_Domain
{
    public class User
    {
        //atributos
        private string _name;
        private string _lastName;
        private string _email;
        private string _cellPhone;
        private string _curp;
        private string _password;

        //LISTA DE CAMPOS para insertar y Modificar
        public List<object> fieldList = new List<object>()
        {
            "name",
            "last_name",
            "email",
            "cell_phone",
            "curp",
            "password"
        };

        //lista de CAMPOS PARA BUSQUEDA
        public List<object> fieldListRead = new List<object>()
        {
            "name",
            "last_name",
            "email",
            "cell_phone",
            "curp"
        };

        public User(string name, string lastName, string email, string cellPhone, string curp, string password)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            CellPhone = cellPhone;
            Curp = curp;
            Password = password;
        }



        //Campos Encapsualdos
        public string Name { get => _name; set => _name = "'" + value + "'"; }
        public string LastName { get => _lastName; set => _lastName = "'" + value + "'"; }
        public string Email { get => _email; set => _email = "'" + value + "'"; }
        public string CellPhone { get => _cellPhone; set => _cellPhone = "'" + value + "'"; }
        public string Curp { get => _curp; set => _curp = "'" + value + "'"; }
        public string Password { get => _password; set => _password = "'" + value + "'"; }

        

        //METHODS.........................

        /// <summary>
        /// /Metodo insert para la creacion y captura de un nuevo usuario
        /// insert method, this will be used to create a new user in the system.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="cellPhone"></param>
        /// <param name="curp"></param>
        /// <param name="password"></param>
        /// <returns>
        /// / Retorna un boleano para verificar si el methodo se cumplio correctamente
        /// / it returns a boolean type to verify if the new user was correctly inseted.
        /// </returns>
        public bool insert()
        { 
            bool res = false;
            List<object> data = new List<object>()
            {
                Name,
                LastName,
                Email,
                CellPhone,
                Curp,
                Password
            };
            BD mysql = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");
            mysql.insert("users", this.fieldList, data);
            
            return res;
        }





        /// <summary>
        /// 
        /// Este metodo edita la información de un usuario previamente registrado.
        /// This method edits the information of a user that was previously registered.
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="cellPhone"></param>
        /// <param name="curp"></param>
        /// <param name="password"></param>
        /// <returns>
        ///  Retorna un booleano para verificar si fue correcta la modificacón.
        ///  
        /// 
        /// </returns>
        public bool update(int id) 
        {
            bool res = false;
            List<object> data = new List<object>()
            {
                Name,
                LastName,
                Email,
                CellPhone,
                Curp,
                Password
            };
            BD mysql = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");
            mysql.update("users", this.fieldList, data, id);

            

            return res;
        }


        /// <summary>
        /// Delete es usado para borrar un registro 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool delete(int id) 
        {
            bool res = false;

            BD mysql = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");
            mysql.delete("users",id);
            return res;
        
        }


        public List<List<User>> read(string search) 
        {
            List<List<User>> users = new List<List<User>>();

            BD mysql = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");
            mysql.read(fieldListRead, "users", search);

            return users;
        
        }
        
    }
}
