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
        public string name { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string cellPhone { get; set; }
        public string curp { get; set; }
        public string password { get; set; }










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
        public bool insert(string name, string last_name, string email, string cell_phone ,string curp, string password) 
        {
            bool res = false;
            try 
            {
                MariaBD maria = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");
                maria.insertUsers(name, last_name, email, cell_phone, curp, password);
                res = true;
            } catch(Exception ex) 
            {
                BD.BD_ERROR = "Error al insertar en user Class "+ ex.Message;

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
        public bool update(string name, string lastName, string email, string cellPhone, string curp, string password) 
        {
            bool res = false;


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


            return res;
        
        }


        /// <summary>
        /// /Este metodo recibe un string y lo busca en la base de datos con el operador LIKE
        /// 
        /// </summary>
        /// <param name="search"></param>
        /// <returns>
        /// Retorna una Lista de Listas de User
        /// </returns>
       // public List<List<User>> read(string search) 
        //{
            
        
            
        //}
        
        




        //constructor
        public User(string name, string lastName, string email, string cellPhone, string curp, string password)
        {
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.cellPhone = cellPhone;
            this.curp = curp;
            this.password = password;
        }
    }
}
