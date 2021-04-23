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
    public partial class Insert_sdmave_FRM : Form
    {
        public Insert_sdmave_FRM()
        {
            InitializeComponent();
        }

        private void label_numero_serial_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        //idear algo para el tipo de servicio y el combo box

        private void button_agregar_sdmave_Click(object sender, EventArgs e)
        {

            Sdmave sdmave = new Sdmave(textBox_nombre_sdmave.Text, comboBox_Servicios.SelectedIndex, double.Parse(textBox_costo.Text), textBox_carro.Text, textBox_placa.Text, textBox_numero_serie.Text, int.Parse(textBox_id_Usuario.Text));
            //validar combo box vacio o en titulo
            if (comboBox_Servicios.SelectedIndex == -1 || comboBox_Servicios == null)
                MessageBox.Show("Ingrese tipo de servicio");
            //variable de validación y ejecuto el metodo insert
            bool res = sdmave.insert();
            if (res)
                MessageBox.Show("Agregado Correctamente");
            else MessageBox.Show(Sdmave.ERROR_SDMAVE);
        }
        
        
    }
}
