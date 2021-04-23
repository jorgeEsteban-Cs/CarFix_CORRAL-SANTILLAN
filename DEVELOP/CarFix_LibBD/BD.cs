using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFix_LibBD
{
    public abstract class BD
    {

        public static string BD_ERROR;
        protected string server { get; set; } //En esta variable se guardara el SERVIDOR
        protected string port { get; set; } //Aqui se guarda el PUERTO de la Base de Datos
        protected string dataBase { get; set; } //Aqui se guarda el NOMBRE de la base de datos
        protected string user_dataBase { get; set; } //Aqui se guarda el USUARIO de la base de datos
        protected string password_dataBase { get; set; } // aqui se guarda la CONTRASEÑA de la base de datos




        //Metodos

        //--Conexion

        public abstract bool conexion();
        //ReadInner
        public abstract bool readInner(int user_id);

        //desconexion
        public abstract bool desconexion();

        //----Login metodo abstracto
        public abstract bool  login(string email, string password);

        //----insert metodo abstracto sobrecargado, un metodo para update Usuarios y otro para Servicios_de_mantenimiento
        public abstract bool insert(string table, List<object> fieldList, List<object> data);

        //---delete metodo abstracto
        public abstract bool delete(string table, int id);

        //----UPDATE
        public abstract bool update(string table, List<object> fieldList, List<object> data, int id);


        //---read metodo abstracto
        public abstract List<List<object>>read(List<object> fieldList, string table, string search);
        //--read metodo abstracto para busqueda con inner join con id_client FK id.usuario

        //metodo para pagar

        public abstract double pagar(int id_servicio);




       
        
    }
}
