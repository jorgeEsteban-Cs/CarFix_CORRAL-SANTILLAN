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

        //desconexion
        public abstract bool desconexion();

        //----Login metodo abstracto
        public abstract bool  login(string email, string password);

        //----insert metodo abstracto
        public abstract bool insert();

        //---update metodo abstracto 
        public abstract bool update();

        //---delete metodo abstracto
        public abstract bool delete();


        //---read metodo abstracto
        public abstract List<List<string>>read();
        //--read metodo abstracto sobrecarga para busqueda con id_client FK id.usuario
        public abstract List<List<string>> read(string id);



       
        
    }
}
