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

        public override bool delete()
        {
            throw new NotImplementedException();
        }

        public override bool insert()
        {
            throw new NotImplementedException();
        }


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

        public override List<List<string>> read()
        {
            throw new NotImplementedException();
        }

        public override List<List<string>> read(string id)
        {
            throw new NotImplementedException();
        }

        public override bool update()
        {
            throw new NotImplementedException();
        }

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
                BD.BD_ERROR = "ERROR de MYSQL_EXCEPTION " + myex.Message;

            }
            catch (Exception ex)
            {
                BD.BD_ERROR = "ERROR al cerrarse la base de datos " + ex.Message;
            }
            return res;
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
