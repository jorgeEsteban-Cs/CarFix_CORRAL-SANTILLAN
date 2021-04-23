using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFix_LibBD;

namespace CarFix_Domain
{
    public class Sdmave
    {

        //ATRIBUTOS
        private string _serviceName;
        private ServiceType _service;
        private string _startDate;
        private string _endDate;
        private double _cost;
        private string _car;
        private string _licensePlate;
        private string _serialNumber;
        private int _idUser;
        public static string ERROR_SDMAVE;
        //campos encapsulados
        public string ServiceName { get => _serviceName; set => _serviceName = value; }
        public ServiceType ServiceType { get => _service; set => _service = value; }
        public string StartDate { get => _startDate; set => _startDate = value; }
        public string EndDate { get => _endDate; set => _endDate = value; }
        public double Cost { get => _cost; set => _cost = value; }
        public string LicensePlate { get => _licensePlate; set => _licensePlate = value; }
        public string SerialNumber { get => _serialNumber; set => _serialNumber = value; }
        public int IdUser { get => _idUser; set => _idUser = value; }
        public string Car { get => _car; set => _car = value; }

        //¨* lista de Campos para insertar o modificar
        List<object> fieldList = new List<object>() 
        {
            "service_name",
            "service_type",
            "start_date",
            "end_date",
            "cost",
            "car",
            "license_plate",
            "serial_number",
            "id_user"
        };
        List<object> fieldListRead = new List<object>()
        {
            "id",
            "service_name",
            "service_type",
            "start_date",
            "end_date",
            "cost",
            "car",
            "license_plate",
            "serial_number",
            "id_user"
        };
        //lista de campos para buscar

        //METODOS

        /// <summary>
        /// Metodo para insertar un nuevo servicio
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="service"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="cost"></param>
        /// <param name="licensePlate"></param>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        public bool insert() 
        {
            //variables para validar
            bool isnull = false;
            bool res = false;
            //crear una lista para mandar los datos
            List<object> data = new List<object>()
            {
                
                this.ServiceName,
                this.ServiceType,
                this.StartDate,
                this.EndDate,
                this.Cost,
                this.Car,
                this.LicensePlate,
                this.SerialNumber,
                this.IdUser

            };
            //validar si viene el dato nulo o vacio
            foreach(object dato in data) 
            {
                if (data == null)
                {
                    isnull = true;
                    break;
                }
                else 
                {
                    isnull = false;
                }
                
            }
            //si los datos vienen correctamente procede a mandar a mariaDb
            if (isnull==false) 
            {
                //poner commillas a datos que nececiten para insertar

                data[0] = "'"+  data[0] + "'";
                data[1] = "'" + data[1] + "'";
                data[2] = "'" + data[2] + "'";
                data[3] = "'" + data[3] + "'";
                data[5] = "'" + data[5] + "'";
                data[6] = "'" + data[6] + "'";
                data[7] = "'" + data[7] + "'";
                //convirtiendo los dates a string
                
                
                //verificando si el usuario existe
                bool user = false;
                user = this.readInner(IdUser);
                if (user) 
                {
                    //si encontro al usuario
                    //instanciando conexion a bd
                    BD mysql = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");
                    res = mysql.insert("sdmaves", this.fieldList, data);
                    if (res == false) 
                    {
                        Sdmave.ERROR_SDMAVE = BD.BD_ERROR;
                    }
                }
               
                


            }

            return res;
        }



        /// <summary>
        /// Metodo para Modificar o editar un servicio previamente registrado.
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="service"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="cost"></param>
        /// <param name="licensePlate"></param>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        public bool update(int id) 
        {
            //variables para validar
            bool isnull = false;
            bool res = false;
            //crear una lista para mandar los datos
            List<object> data = new List<object>()
            {

                this.ServiceName,
                this.ServiceType,
                this.StartDate,
                this.EndDate,
                this.Cost,
                this.Car,
                this.LicensePlate,
                this.SerialNumber,
                this.IdUser

            };
            //validar si viene el dato nulo o vacio
            foreach (object dato in data)
            {
                if (data == null)
                {
                    isnull = true;
                    break;
                }
                else
                {
                    isnull = false;
                }

            }
            //si los datos vienen correctamente procede a mandar a mariaDb
            if (isnull == false)
            {
                //poner commillas a datos que nececiten para 
                data[0] = "'" + data[0] + "'";
                data[1] = "'" + data[1] + "'";
                data[2] = "'" + data[2] + "'";
                data[3] = "'" + data[3] + "'";
                data[5] = "'" + data[5] + "'";
                data[6] = "'" + data[6] + "'";
                data[7] = "'" + data[7] + "'";
                
                //verificando si el usuario existe
                bool user = false;
                user = this.readInner(IdUser);
                if (user)
                {
                    //si encontro al usuario
                    //instanciando conexion a bd
                    BD mysql = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");
                    res = mysql.update("sdmaves", fieldList, data, id);
                    if (res == false)
                    {
                        Sdmave.ERROR_SDMAVE = BD.BD_ERROR;
                    }
                }
            }

            return res;
        }

        /// <summary>
        /// Metodo para borrar un registro de servicio.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool delete(int id) 
        {
            bool res = false;
            BD mysql = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");
            res = mysql.delete("sdmaves", id);
            if (res == false)
            {
                User.ERROR = BD.BD_ERROR;
            }


            return res;
        }


        /// <summary>
        /// Metodo para buscar un servicio y mostrarlos mediante un data grid y la busqueda en base de datos por el operador LIKE
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public List<List<object>> read(string search)
        {
            List<List<object>> sdmaves = new List<List<object>>();
            if (string.IsNullOrWhiteSpace((string)search))
            {
                User.ERROR = "Favor de llenar el campo de busqueda";
            }
            else
            {


                BD mysql = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");
                sdmaves = mysql.read(fieldListRead,"sdmaves",search);
                foreach (List<object> lista in sdmaves)
                {
                    if (lista == null)
                        User.ERROR = "No se encontro resultados";
                }

                User.ERROR = BD.BD_ERROR;
            }


            return sdmaves;

        }

        //metodo para verificar si el usuario existe
        public bool readInner(int user_id) 
        {
            bool user=false;
            //instanciando conexion string a bd
            BD mysql = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");
            //ejecutando metodo de mariaBD
            user = mysql.readInner(user_id);
            if (user==false) 
            {
                Sdmave.ERROR_SDMAVE = BD.BD_ERROR;
            }

            return user;
        }

        //metodo para  pagar. verifica el costo
        public bool pagar(double costo, int id_servicio) 
        {
            bool res = false;
            //objeto de clase maria bd instanciado
            BD mysql = new MariaBD("car_fix_bd", "root", "1234", "127.0.0.1", "3306");
            //ejecutando metodo pagar de libd
            double costo_de_servicio = mysql.pagar(id_servicio);
            if (costo >= costo_de_servicio)
            {
                res = true;
            }
            else 
            {
                Sdmave.ERROR_SDMAVE = "No es suficiente dinero";
            }


            return res;
         
        }
        



        //CONSTRUCTOR
        public Sdmave(string serviceName, int IndiceServicio, double cost,string car ,string licensePlate, string serialNumber, int id_user)
        {
            
            this.ServiceName = serviceName;
            this.Cost = cost;
            this.Car = car;
            this.LicensePlate = licensePlate;
            this.StartDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            this.EndDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            this.SerialNumber = serialNumber;
            this.IdUser = id_user;

            //sacando el tipo de servicio
            switch (IndiceServicio)
            {
                case 0:
                    this.ServiceType = ServiceType.GENERAL;
                    break;

                case 1:
                    this.ServiceType = ServiceType.CAMBIO_DE_ACEITE;
                    break;
                case 2:
                    this.ServiceType = ServiceType.BALANCEO;
                    break;
                case 3:
                    this.ServiceType = ServiceType.ALINEACIÓN;
                    break;
                case 4:
                    this.ServiceType = ServiceType.CUERPO_DE_ACELERACION;
                    break;
                case 5:
                    this.ServiceType = ServiceType.SUSPENSION;
                    break;

                    /*
                     * 0 GENERAL
                       1 CAMBIO DE ACEITE
                       2 BALANCEO
                       3 ALINEACIÓN,
                       4 CUERPO DE ACELERACIÓN
                       5 SUSPENSIÓN
                     */
            }

           
        }

        public Sdmave() 
        {
            //para usar los metodos 
        }
    }
}
