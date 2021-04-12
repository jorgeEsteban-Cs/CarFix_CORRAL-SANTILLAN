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
    public partial class Login_FRM : Form
    {
        public Login_FRM()
        {
            InitializeComponent();
            login_panel.Location = new Point(this.Width/ 2 - (login_panel.Width/2), (this.Height/2)  - (login_panel.Height/2));
            pictureBox_CarFixIcon_Login.Location = new Point(login_panel.Width / 2 - pictureBox_CarFixIcon_Login.Width/2, login_panel.Height/4 - pictureBox_CarFixIcon_Login.Height/4);


        }

        private void Login_FRM_Load(object sender, EventArgs e)
        {
            

        }



        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //HOVER ON CLOSE BTN
        private void pictureBoxExit_MouseMove_1(object sender, MouseEventArgs e)
        {
            pictureBoxExit.BackColor = Color.FromArgb(231, 91, 91);
        }

        //HOVER ON CLOSE BTN
        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxExit.BackColor = Color.FromArgb(32, 163, 158);
        }



        //BTN ON CLICK EVENT
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            bool res = false;
            Login login_user = new Login();
            res = login_user.login(textBox_Login_Usuario.Text.ToString(), textBox_Login_password.Text.ToString());

            if (res)
            {

                Form menuEnter = new Usuarios_FRM();//Cambiando De ventana
                menuEnter.Activate();
                menuEnter.Show();
                MessageBox.Show("Bienvenido");
                
            }
            else 
            {
               MessageBox.Show($"No se Encontro Usuario");
            }
            
            
            

        }

        //HOVER ON ENTER BTN
        /*private void {,´p{(object sender, MouseEventArgs e)
        {
            btn_entrar.BackColor = Color.FromArgb(239, 91, 91);

        }
        //HOVER ON ENTER BTN
        private void btn_entrar_MouseLeave(object sender, EventArgs e)
        {
            btn_entrar.BackColor = Color.FromArgb(32, 163, 158);
        }*/
    }
}
