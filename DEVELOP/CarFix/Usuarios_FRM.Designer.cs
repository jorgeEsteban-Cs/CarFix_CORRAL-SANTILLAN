
namespace CarFix
{
    partial class Usuarios_FRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios_FRM));
            this.panel_title_users = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.CarFixTitleBar = new System.Windows.Forms.Label();
            this.pictureBox_CarFixIcon_title = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panel_sideBar_users = new System.Windows.Forms.Panel();
            this.menu_users_btn = new System.Windows.Forms.Button();
            this.panel_user_info = new System.Windows.Forms.Panel();
            this.label_apellido_user = new System.Windows.Forms.Label();
            this.label_name_user = new System.Windows.Forms.Label();
            this.pictureBox_user_icon = new System.Windows.Forms.PictureBox();
            this.panel_search_title_sarched_users = new System.Windows.Forms.Panel();
            this.dataGridView_user_selected = new System.Windows.Forms.DataGridView();
            this.panel_search_users = new System.Windows.Forms.Panel();
            this.button_search_user = new System.Windows.Forms.Button();
            this.textBox_search_users = new System.Windows.Forms.TextBox();
            this.label_title_users = new System.Windows.Forms.Label();
            this.panel_grid_buttons_users = new System.Windows.Forms.Panel();
            this.button_eliminar_user = new System.Windows.Forms.Button();
            this.button_modificar_user = new System.Windows.Forms.Button();
            this.button_nuevo_user = new System.Windows.Forms.Button();
            this.dataGridView_users_searched = new System.Windows.Forms.DataGridView();
            this.panel_title_users.SuspendLayout();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarFixIcon_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panel_sideBar_users.SuspendLayout();
            this.panel_user_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user_icon)).BeginInit();
            this.panel_search_title_sarched_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user_selected)).BeginInit();
            this.panel_search_users.SuspendLayout();
            this.panel_grid_buttons_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users_searched)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_title_users
            // 
            this.panel_title_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(163)))), ((int)(((byte)(158)))));
            this.panel_title_users.Controls.Add(this.titleBar);
            this.panel_title_users.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title_users.Location = new System.Drawing.Point(0, 0);
            this.panel_title_users.Name = "panel_title_users";
            this.panel_title_users.Size = new System.Drawing.Size(1386, 60);
            this.panel_title_users.TabIndex = 0;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(163)))), ((int)(((byte)(158)))));
            this.titleBar.Controls.Add(this.CarFixTitleBar);
            this.titleBar.Controls.Add(this.pictureBox_CarFixIcon_title);
            this.titleBar.Controls.Add(this.pictureBoxExit);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1386, 60);
            this.titleBar.TabIndex = 1;
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
            this.pictureBoxExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxExit_MouseMove);
            // 
            // panel_sideBar_users
            // 
            this.panel_sideBar_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.panel_sideBar_users.Controls.Add(this.menu_users_btn);
            this.panel_sideBar_users.Controls.Add(this.panel_user_info);
            this.panel_sideBar_users.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sideBar_users.Location = new System.Drawing.Point(0, 60);
            this.panel_sideBar_users.Name = "panel_sideBar_users";
            this.panel_sideBar_users.Size = new System.Drawing.Size(200, 728);
            this.panel_sideBar_users.TabIndex = 1;
            // 
            // menu_users_btn
            // 
            this.menu_users_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.menu_users_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_users_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.menu_users_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_users_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_users_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_users_btn.ImageKey = "(ninguno)";
            this.menu_users_btn.Location = new System.Drawing.Point(0, 250);
            this.menu_users_btn.Name = "menu_users_btn";
            this.menu_users_btn.Size = new System.Drawing.Size(200, 46);
            this.menu_users_btn.TabIndex = 1;
            this.menu_users_btn.Text = "Menu";
            this.menu_users_btn.UseVisualStyleBackColor = false;
            this.menu_users_btn.Click += new System.EventHandler(this.menu_users_btn_Click);
            // 
            // panel_user_info
            // 
            this.panel_user_info.Controls.Add(this.label_apellido_user);
            this.panel_user_info.Controls.Add(this.label_name_user);
            this.panel_user_info.Controls.Add(this.pictureBox_user_icon);
            this.panel_user_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_user_info.Location = new System.Drawing.Point(0, 0);
            this.panel_user_info.Name = "panel_user_info";
            this.panel_user_info.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panel_user_info.Size = new System.Drawing.Size(200, 250);
            this.panel_user_info.TabIndex = 0;
            // 
            // label_apellido_user
            // 
            this.label_apellido_user.AutoSize = true;
            this.label_apellido_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_apellido_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_apellido_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(207)))), ((int)(((byte)(228)))));
            this.label_apellido_user.Location = new System.Drawing.Point(0, 186);
            this.label_apellido_user.Name = "label_apellido_user";
            this.label_apellido_user.Padding = new System.Windows.Forms.Padding(15);
            this.label_apellido_user.Size = new System.Drawing.Size(106, 54);
            this.label_apellido_user.TabIndex = 2;
            this.label_apellido_user.Text = "apellido";
            // 
            // label_name_user
            // 
            this.label_name_user.AutoSize = true;
            this.label_name_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_name_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(207)))), ((int)(((byte)(228)))));
            this.label_name_user.Location = new System.Drawing.Point(0, 132);
            this.label_name_user.Name = "label_name_user";
            this.label_name_user.Padding = new System.Windows.Forms.Padding(15);
            this.label_name_user.Size = new System.Drawing.Size(88, 54);
            this.label_name_user.TabIndex = 1;
            this.label_name_user.Text = "name";
            // 
            // pictureBox_user_icon
            // 
            this.pictureBox_user_icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_user_icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_user_icon.Image")));
            this.pictureBox_user_icon.Location = new System.Drawing.Point(0, 15);
            this.pictureBox_user_icon.Name = "pictureBox_user_icon";
            this.pictureBox_user_icon.Size = new System.Drawing.Size(200, 117);
            this.pictureBox_user_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_user_icon.TabIndex = 0;
            this.pictureBox_user_icon.TabStop = false;
            // 
            // panel_search_title_sarched_users
            // 
            this.panel_search_title_sarched_users.Controls.Add(this.dataGridView_user_selected);
            this.panel_search_title_sarched_users.Controls.Add(this.panel_search_users);
            this.panel_search_title_sarched_users.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_search_title_sarched_users.Location = new System.Drawing.Point(200, 60);
            this.panel_search_title_sarched_users.Name = "panel_search_title_sarched_users";
            this.panel_search_title_sarched_users.Size = new System.Drawing.Size(1186, 255);
            this.panel_search_title_sarched_users.TabIndex = 2;
            // 
            // dataGridView_user_selected
            // 
            this.dataGridView_user_selected.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.dataGridView_user_selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user_selected.GridColor = System.Drawing.Color.Black;
            this.dataGridView_user_selected.Location = new System.Drawing.Point(573, 15);
            this.dataGridView_user_selected.Name = "dataGridView_user_selected";
            this.dataGridView_user_selected.Size = new System.Drawing.Size(587, 225);
            this.dataGridView_user_selected.TabIndex = 5;
            // 
            // panel_search_users
            // 
            this.panel_search_users.Controls.Add(this.button_search_user);
            this.panel_search_users.Controls.Add(this.textBox_search_users);
            this.panel_search_users.Controls.Add(this.label_title_users);
            this.panel_search_users.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_search_users.Location = new System.Drawing.Point(0, 0);
            this.panel_search_users.Name = "panel_search_users";
            this.panel_search_users.Size = new System.Drawing.Size(542, 255);
            this.panel_search_users.TabIndex = 4;
            // 
            // button_search_user
            // 
            this.button_search_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(53)))));
            this.button_search_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search_user.Location = new System.Drawing.Point(334, 157);
            this.button_search_user.Name = "button_search_user";
            this.button_search_user.Size = new System.Drawing.Size(75, 30);
            this.button_search_user.TabIndex = 4;
            this.button_search_user.Text = "Buscar";
            this.button_search_user.UseVisualStyleBackColor = false;
            // 
            // textBox_search_users
            // 
            this.textBox_search_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.textBox_search_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search_users.Location = new System.Drawing.Point(54, 157);
            this.textBox_search_users.Name = "textBox_search_users";
            this.textBox_search_users.Size = new System.Drawing.Size(259, 26);
            this.textBox_search_users.TabIndex = 3;
            // 
            // label_title_users
            // 
            this.label_title_users.AutoSize = true;
            this.label_title_users.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_title_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(207)))), ((int)(((byte)(228)))));
            this.label_title_users.Location = new System.Drawing.Point(0, 0);
            this.label_title_users.Name = "label_title_users";
            this.label_title_users.Padding = new System.Windows.Forms.Padding(60, 40, 15, 15);
            this.label_title_users.Size = new System.Drawing.Size(253, 101);
            this.label_title_users.TabIndex = 2;
            this.label_title_users.Text = "Usuarios\r\n";
            // 
            // panel_grid_buttons_users
            // 
            this.panel_grid_buttons_users.Controls.Add(this.button_eliminar_user);
            this.panel_grid_buttons_users.Controls.Add(this.button_modificar_user);
            this.panel_grid_buttons_users.Controls.Add(this.button_nuevo_user);
            this.panel_grid_buttons_users.Controls.Add(this.dataGridView_users_searched);
            this.panel_grid_buttons_users.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_grid_buttons_users.Location = new System.Drawing.Point(200, 315);
            this.panel_grid_buttons_users.Name = "panel_grid_buttons_users";
            this.panel_grid_buttons_users.Size = new System.Drawing.Size(1186, 478);
            this.panel_grid_buttons_users.TabIndex = 3;
            // 
            // button_eliminar_user
            // 
            this.button_eliminar_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(53)))));
            this.button_eliminar_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eliminar_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar_user.Location = new System.Drawing.Point(573, 383);
            this.button_eliminar_user.Name = "button_eliminar_user";
            this.button_eliminar_user.Size = new System.Drawing.Size(150, 60);
            this.button_eliminar_user.TabIndex = 8;
            this.button_eliminar_user.Text = "Eliminar";
            this.button_eliminar_user.UseVisualStyleBackColor = false;
            // 
            // button_modificar_user
            // 
            this.button_modificar_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(53)))));
            this.button_modificar_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modificar_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar_user.Location = new System.Drawing.Point(334, 383);
            this.button_modificar_user.Name = "button_modificar_user";
            this.button_modificar_user.Size = new System.Drawing.Size(150, 60);
            this.button_modificar_user.TabIndex = 7;
            this.button_modificar_user.Text = "Modificar";
            this.button_modificar_user.UseVisualStyleBackColor = false;
            // 
            // button_nuevo_user
            // 
            this.button_nuevo_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(53)))));
            this.button_nuevo_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nuevo_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nuevo_user.Location = new System.Drawing.Point(87, 383);
            this.button_nuevo_user.Name = "button_nuevo_user";
            this.button_nuevo_user.Size = new System.Drawing.Size(150, 60);
            this.button_nuevo_user.TabIndex = 5;
            this.button_nuevo_user.Text = "Nuevo";
            this.button_nuevo_user.UseVisualStyleBackColor = false;
            // 
            // dataGridView_users_searched
            // 
            this.dataGridView_users_searched.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.dataGridView_users_searched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users_searched.GridColor = System.Drawing.Color.Black;
            this.dataGridView_users_searched.Location = new System.Drawing.Point(54, 32);
            this.dataGridView_users_searched.Name = "dataGridView_users_searched";
            this.dataGridView_users_searched.Size = new System.Drawing.Size(1086, 333);
            this.dataGridView_users_searched.TabIndex = 6;
            // 
            // Usuarios_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel_grid_buttons_users);
            this.Controls.Add(this.panel_search_title_sarched_users);
            this.Controls.Add(this.panel_sideBar_users);
            this.Controls.Add(this.panel_title_users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios_FRM";
            this.Text = "Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_title_users.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarFixIcon_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panel_sideBar_users.ResumeLayout(false);
            this.panel_user_info.ResumeLayout(false);
            this.panel_user_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user_icon)).EndInit();
            this.panel_search_title_sarched_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user_selected)).EndInit();
            this.panel_search_users.ResumeLayout(false);
            this.panel_search_users.PerformLayout();
            this.panel_grid_buttons_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users_searched)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title_users;
        private System.Windows.Forms.Panel panel_sideBar_users;
        private System.Windows.Forms.Panel panel_user_info;
        private System.Windows.Forms.Label label_apellido_user;
        private System.Windows.Forms.Label label_name_user;
        private System.Windows.Forms.PictureBox pictureBox_user_icon;
        private System.Windows.Forms.Panel panel_search_title_sarched_users;
        private System.Windows.Forms.Label label_title_users;
        private System.Windows.Forms.Panel panel_grid_buttons_users;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Label CarFixTitleBar;
        private System.Windows.Forms.PictureBox pictureBox_CarFixIcon_title;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Button menu_users_btn;
        private System.Windows.Forms.Panel panel_search_users;
        private System.Windows.Forms.TextBox textBox_search_users;
        private System.Windows.Forms.DataGridView dataGridView_user_selected;
        private System.Windows.Forms.DataGridView dataGridView_users_searched;
        private System.Windows.Forms.Button button_search_user;
        private System.Windows.Forms.Button button_eliminar_user;
        private System.Windows.Forms.Button button_modificar_user;
        private System.Windows.Forms.Button button_nuevo_user;
    }
}