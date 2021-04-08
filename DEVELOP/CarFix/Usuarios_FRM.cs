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
    public partial class Usuarios_FRM : Form
    {
        public Usuarios_FRM()
        {
            InitializeComponent();
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_users_btn_Click(object sender, EventArgs e)
        {

        }

        //Hover_EXIT USERS
        private void pictureBoxExit_MouseMove(object sender, MouseEventArgs e)
        {
            this.pictureBoxExit.BackColor = Color.FromArgb(239,91,91);

        }

        //Hover_EXIT USERS
        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxExit.BackColor = Color.FromArgb(32, 163, 158);
        }
    }
}
