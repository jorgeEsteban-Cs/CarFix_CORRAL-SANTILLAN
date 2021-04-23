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


namespace CarFix_UI
{
    public partial class Servicio_Mantenimiento_FRM : Form
    {
        public static int idGlobal;
        public Servicio_Mantenimiento_FRM()
        {
            InitializeComponent();
            
        }

        private void dataGridView_SDMV_selected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void label_apellido_Click(object sender, EventArgs e)
        {

        }

        private void button_usuarios_FRM_Click(object sender, EventArgs e)
        {
            CarFix.Usuarios_FRM usuarios_FRM = new CarFix.Usuarios_FRM();
            usuarios_FRM.Show();
            this.Dispose();
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_insertar_SDMV_Click(object sender, EventArgs e)
        {
            Insert_sdmave_FRM inserServicioFRM = new Insert_sdmave_FRM();
            inserServicioFRM.Show();
        }

        private void button_busqueda_sdmave_Click(object sender, EventArgs e)
        {
            //creo una lista de lista de objetos
            List<List<object>> listUsers = new List<List<object>>();
            //creo un objeto user de sobrecarga !!accion desesperada para no crear con los parametros
            Sdmave sdmave = new Sdmave();
            //asigno la lista a lo que me devolvera el metodo search
            listUsers = sdmave.read(textBox_busqueda_Sdmave.Text);
            //arriva se inicializa este datagrid y columnas
            //se asigna n es el indice de la Row a una nueva row
            int n = dataGridView_SDMV_searched.Rows.Add();

            //bucles para sacar los datos de lista de lista de objetos
            //primero saco la lista y sus listas
            foreach (List<object> list in listUsers)
            {
                int i = 0;//*variable para indice para usarse para sacar los valores de las listas*/
                foreach (object valor in list)
                {
                    //saco el valor que se encuentra en la lista de la listas
                    //y lo asigno a la row n a su celda i que es el indice en su valor asigno el valor del objeto
                    dataGridView_SDMV_searched.Rows[n].Cells[i].Value = valor;
                    //acumulador para sacar el indice
                    i++;
                }
            }
        }

        private void dataGridView_SDMV_searched_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {

                //selecciono la row y la primera celda y asigno el valor de la celda a una var
                idGlobal = Convert.ToInt32(dataGridView_SDMV_searched.Rows[n].Cells[0].Value);
            }
        }

        private void button_update_SDMV_Click(object sender, EventArgs e)
        {
            Modificar_Sdmave_FRM edit = new Modificar_Sdmave_FRM();
            edit.Show();
        }

        private void button_delete_SDMV_Click(object sender, EventArgs e)
        {
            //validar si quiere borrarlo realmente
            string mensaje = "Estas a punto de BORRAR este Servicio\n¿Deseas Continuar?";
            DialogResult dialog = MessageBox.Show("Borrar", mensaje, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                //crear variable de validacion
                bool res = false;
                //crear un objeto usuario
                Sdmave delete_user = new Sdmave();
                //obteniendo el id del dataGridView y llamando al metodo delete
                res = delete_user.delete(idGlobal);
                if (res)
                    MessageBox.Show("Servicio Eliminado Correctamente");
                else
                    MessageBox.Show(User.ERROR);
            }
        }

        private void button_pagar_SDMV_Click(object sender, EventArgs e)
        {
            Pagar_Sdmave_FRM pagar_frm = new Pagar_Sdmave_FRM();
            pagar_frm.Show();
        }
    }
}
