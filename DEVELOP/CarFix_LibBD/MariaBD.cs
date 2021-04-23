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
                this.conMysql = new MySqlConnection(this.conectionString);
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
                conMysql.Close();
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
            catch (IOException ioex) 
            {
                BD.BD_ERROR = "ERROR IO EX" + ioex.Message;
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
            finally 
            {
                conMysql.Close();
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
        public override bool insert(string table, List<object> fieldList, List<object> data)
        {
            //var de verificación
            bool res = false;
            //TryCatch
            try
            {

                //abrir conexion
                this.conMysql = new MySqlConnection(this.conectionString);
                this.conexion();
                //creando el query de las listas
                string campos = "";
                string valores = "";
                foreach (object campo in fieldList)
                {
                    campos += campo + ", ";
                }
                foreach (object valor in data)
                {
                    valores += valor + ", ";
                }
                campos = campos.Remove(campos.Length - 2);
                valores = valores.Remove(valores.Length - 2);


                //crearQUery
                string query = $"INSERT INTO {table} ({campos}) VALUES ({valores})";
                //Conectar Query a Sentencia INSERT
                comMyslq = new MySqlCommand(query, conMysql);
                //Ejecutar Query
                int rows = comMyslq.ExecuteNonQuery();
                //cambiar valor de retorno pará confirmación de insercción correcta
                if (rows == 1)
                {
                    res = true;
                }
                {
                    BD.BD_ERROR = "ERROR EN INSERTAR MARIA DB";
                }

            }
            catch (MySqlException myex)
            {
                res = false;
                BD.BD_ERROR = "Error de mysql al insertar en MariaBd" + myex.Message;
            }
            catch (IOException ioex) 
            {
                BD.BD_ERROR = "Error io " + ioex.Message;
            }
            catch (Exception ex)
            {
                res = false;
                BD.BD_ERROR = "Error general al insertar" + ex.Message;
            }
            finally
            {
                conMysql.Close();
            }
            //Excepciones

            //retornar valor de verificación
            return res;
        }

        public override bool delete(string table, int id)
        {
            //var de verificación
            bool res = false;
            //TryCatch
            try
            {
                //abrir conexion
                this.conMysql = new MySqlConnection(this.conectionString);
                this.conexion();
                //creando el query de las listas



                //crearQUery
                string query = $"DELETE FROM {table} WHERE id={id}";
                //Conectar Query a Sentencia INSERT
                comMyslq = new MySqlCommand(query, conMysql);
                //Ejecutar Query
                int rows = comMyslq.ExecuteNonQuery();
                //cambiar valor de retorno pará confirmación de insercción correcta
                if (rows == 1)
                {
                    res = true;
                }
                {
                    BD.BD_ERROR = "ERROR Borrar MARIA DB";
                }

            }
            catch (MySqlException myex)
            {
                res = false;
                BD.BD_ERROR = "Error de mysql al borrar en MariaBd" + myex.Message;
            }
            catch (IOException ioex) 
            {
                BD.BD_ERROR = "Error de borrar io " + ioex.Message;
            }
            catch (Exception ex)
            {
                res = false;
                BD.BD_ERROR = "Error general al borrar" + ex.Message;
            }
            finally
            {
                conMysql.Close();
            }
            //Excepciones

            //retornar valor de verificación
            return res;
        }

        //read
        public override List<List<object>> read(List<object> fieldList,string table, string search)
        {

            //CREACION de lista de lista de objetos
            List<List<object>> lista = new List<List<object>>();

            /*
              CAMBIAR-la query que solo busque por id y nombre o solo id o nombre
             */


            //TRY
            try
            {
                //conectarse
                conMysql = new MySqlConnection(this.conectionString);
                this.conexion();
                //creacion de string a los campos a consultar
                string query = $"SELECT * FROM {table} WHERE id={search}";
                
                //Ejecutando query
                comMyslq = new MySqlCommand(query, conMysql);
                reader = comMyslq.ExecuteReader();
                //validando si tiene resultados




                if (reader.HasRows)
                {
                    List<object> row = new List<object>();
                    //meter los datos obtenidos en una lista
                    while (reader.Read())
                    {

                        for (int i = 0; i < fieldList.Count; i++)
                        {
                            row.Add(reader.GetValue(i));
                            
                        }
                        lista.Add(row);

                    }

                    return lista;
                }
                else 
                {
                    BD.BD_ERROR = "No se encontro ningun resultado";
                }


                
                
            }
            catch (MySqlException myex)
            {
                BD.BD_ERROR = "Error de Entradas a Mysql" + myex.Message;
            }
            catch (IOException ioex)
            {
                BD.BD_ERROR = "Error de IO  Mysql" + ioex.Message;
            }
            catch (Exception ex) 
            {
                BD.BD_ERROR = "Error General" + ex.Message;
            }
            finally 
            {
                conMysql.Close();
            }
            return lista;
        }


        //update 
        public override bool update(string table, List<object> fieldList, List<object> data, int id)
        {
            //var de verificación
            bool res = false;
            //TryCatch
            try
            {
                //abrir conexion
                this.conMysql = new MySqlConnection(this.conectionString);
                this.conexion();
                //creando el query de las listas
                string updateSentencia = "";

                for (int i = 0; i < fieldList.Count; i++)
                {
                    updateSentencia += $"{fieldList[i]}={data[i]}, ";
                }
                updateSentencia = updateSentencia.Remove(updateSentencia.Length - 2);
                

                //crearQUery
                string query = $"UPDATE {table} SET {updateSentencia} WHERE id={id}";
                //Conectar Query a Sentencia INSERT
                comMyslq = new MySqlCommand(query, conMysql);
                //Ejecutar Query
                int rows = comMyslq.ExecuteNonQuery();
                //cambiar valor de retorno pará confirmación de insercción correcta
                if (rows == 1)
                {
                    res = true;
                }
                {
                    BD.BD_ERROR = "ERROR EN INSERTAR MARIA DB";
                }

            }
            catch (MySqlException myex)
            {
                res = false;
                BD.BD_ERROR = "Error de mysql al insertar en MariaBd" + myex.Message;
            }
            catch (Exception ex)
            {
                res = false;
                BD.BD_ERROR = "Error general al insertar" + ex.Message;
            }
            finally
            {
                conMysql.Close();
            }
            //Excepciones

            //retornar valor de verificación
            return res;
        }

        //metodo para saber si el usuario existe
        public override bool readInner(int user_id)
        {
            //definir una var de resultado
            bool res = false;
            //bloque trycatch
            try
            {
                //abrir con
                this.conMysql = new MySqlConnection(this.conectionString);
                this.conexion();
                //crear query
                string query = $"SELECT * from users WHERE id={user_id}";
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
                else 
                {
                    BD.BD_ERROR = "Usuario No encontrado";
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
                conMysql.Close();
            }
            return res;
        }

        public override double pagar(int id_servicio)
        {
            //definir una var de resultado
            double costo=0;
            //bloque trycatch
            try
            {
                //abrir con
                this.conMysql = new MySqlConnection(this.conectionString);
                this.conexion();
                //crear query
                string query = $"SELECT cost FROM sdmaves WHERE id={id_servicio}";
                //conectar el query con los datos sentencia SELECT
                comMyslq = new MySqlCommand(query, conMysql);
                //Ejecutar sentencia
                reader = comMyslq.ExecuteReader();
                //Validar
                if (reader.HasRows)
                {
                    //cambiar var resultado 
                    while (reader.Read()) 
                    {
                        costo = reader.GetDouble(0);
                    }
                   
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
                conMysql.Close();
            }

            return costo;

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
