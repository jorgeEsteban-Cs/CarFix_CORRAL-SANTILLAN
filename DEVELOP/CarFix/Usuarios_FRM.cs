using CarFix_UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarFix_Domain;

namespace CarFix
{
    public partial class Usuarios_FRM : Form
    {
        static public int idGlobal;
        public Usuarios_FRM()
        {

            
            InitializeComponent();
            
            //DataTable dataTable = new DataTable();
            //dataTable.Columns.Add("Id");
            //dataTable.Columns.Add("Nombre");
            //dataTable.Columns.Add("Apellido");
            //dataTable.Columns.Add("Email");
            //dataTable.Columns.Add("Curp");
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        

        private void button_nuevo_user_Click(object sender, EventArgs e)
        {
            //abre formulario para el insert
            Insert_user_FRM n = new Insert_user_FRM();
            n.TopLevel = true;
            n.Show();
        }

        private void button_modificar_user_Click(object sender, EventArgs e)
        {
            //abriendo FRM formulario edit modificar
            Modificar_user_FRM edit = new Modificar_user_FRM();
            edit.TopLevel = true;
            edit.Show();

        }

        private void button_search_user_Click(object sender, EventArgs e)
        {
            
            //creo una lista de lista de objetos
            List<List<object>> listUsers = new List<List<object>>();
            //creo un objeto user de sobrecarga !!accion desesperada para no crear con los parametros
            User userSearch = new User();
            //asigno la lista a lo que me devolvera el metodo search
            listUsers = userSearch.read(textBox_search_users.Text);
            //arriva se inicializa este datagrid y columnas
            //se asigna n es el indice de la Row a una nueva row
            int n= dataGridView_users_searched.Rows.Add();

            //bucles para sacar los datos de lista de lista de objetos
            //primero saco la lista y sus listas
            foreach (List<object> list in listUsers) 
            {
                int i = 0;//*variable para indice para usarse para sacar los valores de las listas*/
                foreach (object valor in list) 
                {
                    //saco el valor que se encuentra en la lista de la listas
                    //y lo asigno a la row n a su celda i que es el indice en su valor asigno el valor del objeto
                    dataGridView_users_searched.Rows[n].Cells[i].Value = valor;
                    //acumulador para sacar el indice
                    i++;
                }
            }
            
            
            
            
        }

        private void dataGridView_users_searched_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //sacar el indice del row seleccionado
            //el row de los headers corresponde al indice -1

            //validar para no escoger el header
            int n = e.RowIndex;
            if (n != -1)
            {
                
                //selecciono la row y la primera celda y asigno el valor de la celda a una var
                 idGlobal = Convert.ToInt32(dataGridView_users_searched.Rows[n].Cells[0].Value);
            }
            
        }

        private void button_eliminar_user_Click(object sender, EventArgs e)
        {
            //validar si quiere borrarlo realmente
            string mensaje = "Estas a punto de BORRAR este Usuario\n¿Deseas Continuar?";
            DialogResult dialog = MessageBox.Show("Borrar", mensaje, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes) 
            {
                //crear variable de validacion
                bool res = false;
                //crear un objeto usuario
                User delete_user = new User();
                //obteniendo el id del dataGridView y llamando al metodo delete
                res = delete_user.delete(idGlobal);
                if (res)
                    MessageBox.Show("Usuario Eliminado Correctamente");
                else
                    MessageBox.Show(User.ERROR);
            }

            
        }

        private void button_servicios_FRM_Click(object sender, EventArgs e)
        {
            //**** COMO PODER ABRIR DESDE UN PANEL
            //abriendo frm servicios en un panel
            //Servicio_Mantenimiento_FRM FrmSericios = new Servicio_Mantenimiento_FRM();
            //FrmSericios.TopLevel = false;
            //FrmSericios.Dock = DockStyle.Fill;
            //this.panel_servicios_contenedor.Controls.Add(FrmSericios);
            //this.panel_servicios_contenedor.Tag = FrmSericios;
            //FrmSericios.Show();
            //inhabilitando paneles de usuarios que contienen componentes
            //this.panel_grid_buttons_users.Enabled = false;
            //this.panel_title_users.Enabled = false;

            //abriendo servicios_FRM
            Servicio_Mantenimiento_FRM servicioFRM = new Servicio_Mantenimiento_FRM();
            servicioFRM.TopLevel = true;
            servicioFRM.Show();
            //ocultando este form
            this.Hide();
        }

        private void dataGridView_users_searched_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
