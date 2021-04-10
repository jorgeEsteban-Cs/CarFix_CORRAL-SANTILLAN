
namespace CarFix
{
    partial class Login_FRM
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_FRM));
            this.titleBar = new System.Windows.Forms.Panel();
            this.CarFixTitleBar = new System.Windows.Forms.Label();
            this.pictureBox_CarFixIcon_title = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.title_Bar = new System.Windows.Forms.FlowLayoutPanel();
            this.login_panel = new System.Windows.Forms.Panel();
            this.panel_Login_Components = new System.Windows.Forms.Panel();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.textBox_Login_password = new System.Windows.Forms.TextBox();
            this.textBox_Login_Usuario = new System.Windows.Forms.TextBox();
            this.label_Login_password = new System.Windows.Forms.Label();
            this.label_Login_User = new System.Windows.Forms.Label();
            this.pictureBox_CarFixIcon_Login = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarFixIcon_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.login_panel.SuspendLayout();
            this.panel_Login_Components.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarFixIcon_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(163)))), ((int)(((byte)(158)))));
            this.titleBar.Controls.Add(this.CarFixTitleBar);
            this.titleBar.Controls.Add(this.pictureBox_CarFixIcon_title);
            this.titleBar.Controls.Add(this.pictureBoxExit);
            this.titleBar.Controls.Add(this.title_Bar);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1386, 60);
            this.titleBar.TabIndex = 0;
            // 
            // CarFixTitleBar
            // 
            this.CarFixTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CarFixTitleBar.AutoSize = true;
            this.CarFixTitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarFixTitleBar.Location = new System.Drawing.Point(60, 7);
            this.CarFixTitleBar.Name = "CarFixTitleBar";
            this.CarFixTitleBar.Size = new System.Drawing.Size(156, 52);
            this.CarFixTitleBar.TabIndex = 3;
            this.CarFixTitleBar.Text = "CarFix";
            // 
            // pictureBox_CarFixIcon_title
            // 
            this.pictureBox_CarFixIcon_title.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_CarFixIcon_title.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CarFixIcon_title.Image")));
            this.pictureBox_CarFixIcon_title.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_CarFixIcon_title.Name = "pictureBox_CarFixIcon_title";
            this.pictureBox_CarFixIcon_title.Size = new System.Drawing.Size(64, 60);
            this.pictureBox_CarFixIcon_title.TabIndex = 2;
            this.pictureBox_CarFixIcon_title.TabStop = false;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(1291, 0);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(95, 60);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 1;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            this.pictureBoxExit.MouseLeave += new System.EventHandler(this.pictureBoxExit_MouseLeave);
            this.pictureBoxExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxExit_MouseMove_1);
            // 
            // title_Bar
            // 
            this.title_Bar.AutoSize = true;
            this.title_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_Bar.Location = new System.Drawing.Point(0, 0);
            this.title_Bar.Name = "title_Bar";
            this.title_Bar.Size = new System.Drawing.Size(1386, 0);
            this.title_Bar.TabIndex = 0;
            // 
            // login_panel
            // 
            this.login_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(163)))), ((int)(((byte)(158)))));
            this.login_panel.Controls.Add(this.panel_Login_Components);
            this.login_panel.Controls.Add(this.pictureBox_CarFixIcon_Login);
            this.login_panel.Location = new System.Drawing.Point(388, 116);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(398, 480);
            this.login_panel.TabIndex = 1;
            // 
            // panel_Login_Components
            // 
            this.panel_Login_Components.Controls.Add(this.btn_entrar);
            this.panel_Login_Components.Controls.Add(this.textBox_Login_password);
            this.panel_Login_Components.Controls.Add(this.textBox_Login_Usuario);
            this.panel_Login_Components.Controls.Add(this.label_Login_password);
            this.panel_Login_Components.Controls.Add(this.label_Login_User);
            this.panel_Login_Components.Location = new System.Drawing.Point(75, 188);
            this.panel_Login_Components.Name = "panel_Login_Components";
            this.panel_Login_Components.Size = new System.Drawing.Size(241, 250);
            this.panel_Login_Components.TabIndex = 3;
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(163)))), ((int)(((byte)(158)))));
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(78, 198);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(82, 32);
            this.btn_entrar.TabIndex = 5;
            this.btn_entrar.Text = "entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            
            // 
            // textBox_Login_password
            // 
            this.textBox_Login_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(207)))), ((int)(((byte)(228)))));
            this.textBox_Login_password.Location = new System.Drawing.Point(57, 160);
            this.textBox_Login_password.Name = "textBox_Login_password";
            this.textBox_Login_password.Size = new System.Drawing.Size(130, 20);
            this.textBox_Login_password.TabIndex = 4;
            // 
            // textBox_Login_Usuario
            // 
            this.textBox_Login_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(207)))), ((int)(((byte)(228)))));
            this.textBox_Login_Usuario.Location = new System.Drawing.Point(58, 66);
            this.textBox_Login_Usuario.Name = "textBox_Login_Usuario";
            this.textBox_Login_Usuario.Size = new System.Drawing.Size(130, 20);
            this.textBox_Login_Usuario.TabIndex = 3;
            // 
            // label_Login_password
            // 
            this.label_Login_password.AutoSize = true;
            this.label_Login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login_password.Location = new System.Drawing.Point(53, 107);
            this.label_Login_password.Name = "label_Login_password";
            this.label_Login_password.Size = new System.Drawing.Size(124, 25);
            this.label_Login_password.TabIndex = 2;
            this.label_Login_password.Text = "Contraseña";
            this.label_Login_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Login_User
            // 
            this.label_Login_User.AutoSize = true;
            this.label_Login_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login_User.Location = new System.Drawing.Point(53, 22);
            this.label_Login_User.Name = "label_Login_User";
            this.label_Login_User.Size = new System.Drawing.Size(86, 25);
            this.label_Login_User.TabIndex = 1;
            this.label_Login_User.Text = "Usuario";
            this.label_Login_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_CarFixIcon_Login
            // 
            this.pictureBox_CarFixIcon_Login.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_CarFixIcon_Login.Image")));
            this.pictureBox_CarFixIcon_Login.Location = new System.Drawing.Point(133, 54);
            this.pictureBox_CarFixIcon_Login.Name = "pictureBox_CarFixIcon_Login";
            this.pictureBox_CarFixIcon_Login.Size = new System.Drawing.Size(128, 128);
            this.pictureBox_CarFixIcon_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_CarFixIcon_Login.TabIndex = 0;
            this.pictureBox_CarFixIcon_Login.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // Login_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_FRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarFix";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_FRM_Load);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarFixIcon_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.login_panel.ResumeLayout(false);
            this.panel_Login_Components.ResumeLayout(false);
            this.panel_Login_Components.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarFixIcon_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.FlowLayoutPanel title_Bar;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.PictureBox pictureBox_CarFixIcon_title;
        private System.Windows.Forms.Label CarFixTitleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_CarFixIcon_Login;
        private System.Windows.Forms.Panel panel_Login_Components;
        private System.Windows.Forms.Label label_Login_password;
        private System.Windows.Forms.Label label_Login_User;
        private System.Windows.Forms.TextBox textBox_Login_password;
        private System.Windows.Forms.TextBox textBox_Login_Usuario;
        private System.Windows.Forms.Button btn_entrar;
    }
}

