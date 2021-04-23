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
    public partial class Modificar_user_FRM : Form
    {
        public int id = CarFix.Usuarios_FRM.idGlobal;
        public Modificar_user_FRM()
        {
            InitializeComponent();
        }

        private void button_modificar_user_Click(object sender, EventArgs e)
        {
            bool res = false;
            //crear un user
            User edit_user = new User(textBox_user_Name.Text, textBox_user_lastName.Text, textBox_email.Text, textBox_celular.Text, textBox_curp.Text, textBox_password.Text);
            //llamar update y asignarlo a una var para validar
            res = edit_user.update(this.id);
            if (res)
                MessageBox.Show("Usuario Modificado Correctamente");
            else
                MessageBox.Show(User.ERROR);
        }

        private void button_cancelar_modificar_user_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
