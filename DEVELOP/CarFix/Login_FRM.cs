using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        private void pictureBoxExit_MouseMove_1(object sender, MouseEventArgs e)
        {
            pictureBoxExit.BackColor = Color.FromArgb(231, 91, 91);
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxExit.BackColor = Color.FromArgb(32, 163, 158);
        }

    
    }
}
