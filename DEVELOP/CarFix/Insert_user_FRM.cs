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
            
            User userAdd = new User(textBox_user_Name.Text, textBox_user_lastName.Text, textBox_email.Text, textBox_celular.Text, textBox_curp.Text, textBox_password.Text);

            bool res = false;
            
                
            res = userAdd.insert();
            if(res)
                MessageBox.Show("Agregado Correctamente");
            else
            {
                MessageBox.Show(User.ERROR);
            }
        }

        private void button_cancelar_agregar_user_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
