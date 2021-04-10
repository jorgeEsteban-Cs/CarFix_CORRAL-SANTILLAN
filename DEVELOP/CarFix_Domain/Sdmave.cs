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
        public string serviceName;
        public ServiceType service;
        public DateTime startDate;
        public DateTime endDate;
        public double cost;
        public string licensePlate;
        public string serialNumber;

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
        public bool insert(string serviceName, ServiceType service, DateTime startDate, DateTime endDate, double cost, string licensePlate, string serialNumber) 
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
        public bool update(string serviceName, ServiceType service, DateTime startDate, DateTime endDate, double cost, string licensePlate, string serialNumber) 
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
        public Sdmave(string serviceName, ServiceType service, DateTime startDate, DateTime endDate, double cost, string licensePlate, string serialNumber)
        {
            this.serviceName = serviceName;
            this.service = service;
            this.startDate = startDate;
            this.endDate = endDate;
            this.cost = cost;
            this.licensePlate = licensePlate;
            this.serialNumber = serialNumber;
        }
    }
}
