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
            User userAdd = new User(textBox_user_Name.Text.ToString(), textBox_user_lastName.Text.ToString(), textBox_email.Text.ToString(), textBox_celular.Text.ToString(), textBox_curp.Text.ToString(), textBox_password.Text.ToString());

            try 
            {
                
                userAdd.insert(textBox_user_Name.Text.ToString(), textBox_user_lastName.Text.ToString(), textBox_email.Text.ToString(), textBox_celular.Text.ToString(), textBox_curp.Text.ToString(), textBox_password.Text.ToString());
                MessageBox.Show("Agregado Correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }

        private void button_cancelar_agregar_user_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
