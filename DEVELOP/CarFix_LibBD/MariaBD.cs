using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;


namespace CarFix_LibBD
{
    public class MariaBD : BD
    {

        MySqlConnection conMysql;
        MySqlCommand comMyslq;
        MySqlDataReader reader;
        public string conectionString;

        //METODOS



        //METODO para autentificar al usuario
        public override bool login(string email, string password)
        {
            
            
            //definir una var de resultado
            bool res = false;
            //bloque trycatch
            try
            {
                //abrir con
               
                this.conexion();
                //crear query
                string query = $"SELECT * from users WHERE email='{email}' AND password='{password}'";
                //conectar el query con los datos sentencia SELECT
                comMyslq = new MySqlCommand(query, conMysql);
                //Ejecutar sentencia
                reader = comMyslq.ExecuteReader();
                //Validar
                if (reader.HasRows)
                {
                    //cambiar var resultado 
                    res = true;
                }

            }
            //excepciones
            catch (MySqlException myex)
            {
                BD.BD_ERROR = "Error al buscar usuario en la BD" + myex.Message;

            }
            catch (Exception ex)
            {
                BD.BD_ERROR = "Error al buscar usuario en la BD" + ex.Message;

            }
            finally 
            {
                this.desconexion();
            }

            //var retorno de resultado
            return res;
        }

  




        //Metodo de Abrir Conexion a BD
        public override bool conexion()
        {
            bool res = false;
            try
            {
                //instanciar conexion
                this.conMysql = new MySqlConnection(this.conectionString);
                if (conMysql.State == ConnectionState.Closed)
                {
                    conMysql.Open();
                }
                else if (conMysql.State == ConnectionState.Broken)
                {
                    conMysql.Close(); conMysql.Open();
                }
                //se establecio la conexion
                res = true;
            }
            catch (MySqlException myex)
            {
                BD.BD_ERROR = "ERROR de MYSQL_EXCEPTION al conectarse a la base de datos" + myex.Message;

            }
            catch (Exception ex) 
            {
                BD.BD_ERROR = "ERROR al conectarse a la base de datos " + ex.Message;
            }
            return res;
            
        }

        //Metodo de desconexion a base de datos
        public override bool desconexion()
        {
            bool res = false;
            try
            {
                //instanciar conexion
                this.conMysql = new MySqlConnection();
                if (conMysql.State != ConnectionState.Closed)
                {
                    conMysql.Close();
                }
                
                //se establecio la conexion
                res = true;
            }
            catch (MySqlException myex)
            {
                BD.BD_ERROR = "ERROR de MYSQL_EXCEPTION al cerrar la base de datos" + myex.Message;

            }
            catch (Exception ex)
            {
                BD.BD_ERROR = "ERROR al cerrarse la base de datos " + ex.Message;
            }
            return res;
        }


        /// <summary>
        /// metodo insert a usuario
        /// </summary>
        /// <param name="name"></param>
        /// <param name="last_name"></param>
        /// <param name="email"></param>
        /// <param name="cell_phone"></param>
        /// <param name="curp"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public override bool insertUsers(string name, string last_name, string email, string cell_phone, string curp, string password)
        {
            //var de verificación
            bool res = false;
            //TryCatch
            try
            {
                //abrir conexion
                this.conexion();
                //crearQUery
                string query = $"INSERT INTO users VALUES(name='{name}', last_name='{last_name}', email='{email}', cell_phone='{cell_phone}', curp='{curp}', password='{password}')";
                //Conectar Query a Sentencia INSERT
                comMyslq = new MySqlCommand(query, conMysql);
                //Ejecutar Query
                comMyslq.ExecuteNonQuery();
                //cambiar valor de retorno pará confirmación de insercción correcta
                res = true;
            }
            catch (MySqlException myex)
            {
                BD.BD_ERROR = "Error de mysql al insertar en MariaBd" + myex.Message;
            }
            catch (Exception ex) 
            {
                BD.BD_ERROR = "Error general al insertar" + ex.Message;
            }
            //Excepciones

            //retornar valor de verificación
            return res;
        }

        public override bool InsertService(string service_name, Enum service_type, DateTime fecha, double cost, string car, string license_plate, string serial_number, int id_user)
        {
            bool res = false;

            //try
            try 
            {
                
                //abrir conexion
                this.conexion();
                //Crear Query
                string query = $"INSERT INTO sdmaves " +
                    $"VALUES(service_name='{service_name}', service_type={service_type}, cost={cost}, car='{car}', license_plate='{license_plate}', serial_number='{serial_number}', id_user={id_user})";
                //Conectar Query Con Sentencia INSERT
                comMyslq = new MySqlCommand(query, conMysql);
                //Ejecutar Query
                comMyslq.ExecuteNonQuery();
                //cambiar valor de retorno
                //catch
            }

            catch (MySqlException myex) 
            {
            
            }
            return res;
        }

        public override bool updateUsers(string name, string last_name, string email, string curp, string password)
        {
            throw new NotImplementedException();
        }

        public override bool UpdateServices(string service_name, Enum service_type, double cost, string car, string license_plate, string serial_number)
        {
            throw new NotImplementedException();
        }

        public override List<List<string>> read(string table, string search)
        {
            throw new NotImplementedException();
        }

        public override List<List<string>> Read(string id)
        {
            throw new NotImplementedException();
        }

        public override bool delete(string table, string id)
        {
            throw new NotImplementedException();
        }


        //CONSTRUCTOR
        public MariaBD(string database, string user, string password, string server, string port)
        {
            //iniciando atributos
            this.dataBase = database;
            this.server = server;
            this.port = port;
            this.user_dataBase = user;
            this.password_dataBase = password;
            //conexion string
            conectionString = $"Server={this.server};Port={this.port}; Database={this.dataBase};Uid={this.user_dataBase};Pwd={this.password_dataBase};";


        }
    }
}
