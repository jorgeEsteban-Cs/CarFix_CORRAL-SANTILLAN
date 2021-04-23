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
using CarFix_UI;

namespace CarFix_UI
{
    public partial class Pagar_Sdmave_FRM : Form
    {
        public int id = Servicio_Mantenimiento_FRM.idGlobal;
        public Pagar_Sdmave_FRM()
        {
            InitializeComponent();
        }

        private void button_confirmar_pagar_Click(object sender, EventArgs e)
        {
            //variable de resultado
            bool res = false;
            //crear objeto de sdmave
            Sdmave pagar_servicio = new Sdmave();
            res = pagar_servicio.pagar(double.Parse(textBox_Cantidad_Pagar.Text), id);
            if (res)
            {
                MessageBox.Show("Has pagado satisfactoriamente");
            }
            else
            {
                MessageBox.Show("El pago no concuerda te hace falta");
            }

        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
