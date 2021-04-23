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
        public static string ERROR;

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
            "id",
            "name",
            "last_name",
            "email",
            "cell_phone",
            "curp"


        };

        public User(string name, string lastName, string email, string cellPhone, string curp, string password)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Email = email;
            this.CellPhone = cellPhone;
            this.Curp = curp;
            this.Password = password;
        }


        
        //Campos Encapsualdos
        public string Name { get => _name; set => _name =  value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Email { get => _email; set => _email = value; }
        public string CellPhone { get => _cellPhone; set => _cellPhone =  value; }
        public string Curp { get => _curp; set => _curp = value; }
        public string Password { get => _password; set => _password =  value; }



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
            //variable de validación del metodo
            bool res = false;
            bool isnull = false;

            //intanciación de una lista que guarda los datos para insertar
            List<object> data = new List<object>()
            {
                Name,
                LastName,
                Email,
                CellPhone,
                Curp,
                Password
            };


            //Validando si un dato es null si lo es no ejecuta este metodo y guarda un mensaje de error
            foreach (object dato in data)
            {

                if (string.IsNullOrWhiteSpace((string)dato))
                {
                    isnull = true;
                    break;
                }
                else 
                {
                    isnull = false;
                }
            }

            //si vienen los datos llenos correctamente procede a mandar a mariaDB
            if (isnull == false)
            {
                //poniendo comillas a datos que ocupan comillas
                for (int i = 0; i<data.Count;i++) 
                {
                    data[i] = "'" + data[i] + "'";
                
                }

                //instanciación de clase mariaBd para obtener conexion string y sus metodos de clase
                BD mysql = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");


                //metodo insert de maraBD
                res = mysql.insert("users", this.fieldList, data);
                //validar res
                if (res == false)
                {
                    User.ERROR = BD.BD_ERROR;
                }

            }
            else 
            {
                User.ERROR = "Faltaron campos por llenar";
            }

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
            bool isnull = false;
            List<object> data = new List<object>()
            {
                Name,
                LastName,
                Email,
                CellPhone,
                Curp,
                Password
            };
            foreach (object dato in data)
            {

                if (string.IsNullOrWhiteSpace((string)dato))
                {
                    isnull = true;
                }
                else 
                {
                    isnull = false;
                }
            }
            if (isnull == false)
            {
                //poniendo comillas a datos que ocupan comillas
                for (int i = 0; i < data.Count; i++)
                {
                    data[i] = "'" + data[i] + "'";

                }

                BD mysql = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");
                res = mysql.update("users", this.fieldList, data, id);
                if (res == false)
                {
                    User.ERROR = BD.BD_ERROR;
                }

            }
            else 
            {
                User.ERROR = "Faltaron campos por llenar";
            }
            
            

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
            res = mysql.delete("users",id);
            if (res == false) 
            {
                User.ERROR = BD.BD_ERROR;
            }
            return res;
        
        }


        public List<List<object>> read(string search) 
        {
            List<List<object>> users = new List<List<object>>();
            if (string.IsNullOrWhiteSpace((string)search))
            {
                User.ERROR = "Favor de llenar el campo de busqueda";
            }
            else 
            {
                

                BD mysql = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");
                users = mysql.read(fieldListRead, "users", search);
                foreach (List<object> lista in users) 
                {
                    if (lista == null)
                        User.ERROR = "No se encontro resultados";
                }

                User.ERROR = BD.BD_ERROR;
            }

            
            return users;
        
        }
        public User() 
        {
        
        }
    }
}
