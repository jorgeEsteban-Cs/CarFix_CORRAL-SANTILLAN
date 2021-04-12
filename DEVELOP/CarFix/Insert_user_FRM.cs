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
    public partial class Insert_user_FRM : Form
    {
        public Insert_user_FRM()
        {
            InitializeComponent();
        }

        private void button_agregar_user_Click(object sender, EventArgs e)
        {
            bool res = false;
            User userAdd = new User(textBox_user_Name.ToString(), textBox_user_lastName.ToString(), textBox_email.ToString(), textBox_celular.ToString(), textBox_curp.ToString(), textBox_password.ToString());
            res = userAdd.insert(textBox_user_Name.ToString(), textBox_user_lastName.ToString(), textBox_email.ToString(), textBox_celular.ToString(), textBox_curp.ToString(), textBox_password.ToString());
            if (res) { MessageBox.Show("Agregado Correctamente"); } else { MessageBox.Show("Error"); }
        }

        private void button_cancelar_agregar_user_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
