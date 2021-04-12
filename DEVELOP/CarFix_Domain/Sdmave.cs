using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFix_Domain
{
    class Sdmave
    {

        //ATRIBUTOS
        public string serviceName { get; set; }
        public ServiceType service { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public double cost { get; set; }
        public string licensePlate { get; set; }
        public string serialNumber { get; set; }

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
        public bool insert(string service_name, ServiceType service_type, double cost, string car, string license_plate, string serial_number) 
        {
            
            bool res = false;

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
        public bool update(string service_name, ServiceType service_type, double cost, string car, string license_plate, string serial_number) 
        {
            bool res = false;

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


            return res;
        }


        /// <summary>
        /// Metodo para buscar un servicio y mostrarlos mediante un data grid y la busqueda en base de datos por el operador LIKE
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        /*public List<List<Sdmave>> read(string search) 
        {
        
        }
        /// <summary>
        /// Metodo de Busqueda de un servicio mediante un INNER JOIN entre las tablas de users y sdmaves ON id_user = users.id
        /// </summary>
        /// <param name="id_user"></param>
        /// <returns></returns>
        public List<List<Sdmave>> read(int id_user)
        {

        }*/





        //CONSTRUCTOR
        public Sdmave(string serviceName, ServiceType service, double cost, string licensePlate, string serialNumber)
        {
            this.serviceName = serviceName;
            this.service = service;
            this.startDate = DateTime.Now;
            this.cost = cost;
            this.licensePlate = licensePlate;
            this.serialNumber = serialNumber;
        }
    }
}
