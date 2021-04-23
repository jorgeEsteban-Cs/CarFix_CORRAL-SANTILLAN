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
    public partial class Modificar_Sdmave_FRM : Form
    {
        public int id = Servicio_Mantenimiento_FRM.idGlobal;
        public Modificar_Sdmave_FRM()
        {
            InitializeComponent();
        }

        private void button_agregar_sdmave_Click(object sender, EventArgs e)
        {
            bool res = false;
            //crear un user
            Sdmave sdmave = new Sdmave(textBox_nombre_sdmave.Text, comboBox_Servicios.SelectedIndex, double.Parse(textBox_costo.Text), textBox_carro.Text, textBox_placa.Text, textBox_numero_serie.Text, int.Parse(textBox_id_Usuario.Text));
            //validar combo box vacio o en titulo
            if (comboBox_Servicios.SelectedIndex == -1 || comboBox_Servicios == null)
                MessageBox.Show("Ingrese tipo de servicio");
            //llamar update y asignarlo a una var para validar
            res = sdmave.update(this.id);
            if (res)
                MessageBox.Show("Usuario Modificado Correctamente");
            else
                MessageBox.Show(Sdmave.ERROR_SDMAVE);
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
