
namespace CarFix_UI
{
    partial class Insert_sdmave_FRM
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
            this.panel_title_bar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_nombre_sdmave = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.button_agregar_sdmave = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.label_servicio = new System.Windows.Forms.Label();
            this.label_costo = new System.Windows.Forms.Label();
            this.textBox_costo = new System.Windows.Forms.TextBox();
            this.label_numero_serial = new System.Windows.Forms.Label();
            this.textBox_numero_serie = new System.Windows.Forms.TextBox();
            this.label_placa = new System.Windows.Forms.Label();
            this.textBox_placa = new System.Windows.Forms.TextBox();
            this.comboBox_Servicios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_carro = new System.Windows.Forms.TextBox();
            this.label_Id_Usiuario = new System.Windows.Forms.Label();
            this.textBox_id_Usuario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_title_bar
            // 
            this.panel_title_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(163)))), ((int)(((byte)(158)))));
            this.panel_title_bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title_bar.Location = new System.Drawing.Point(0, 0);
            this.panel_title_bar.Name = "panel_title_bar";
            this.panel_title_bar.Size = new System.Drawing.Size(410, 100);
            this.panel_title_bar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Id_Usiuario);
            this.panel1.Controls.Add(this.textBox_id_Usuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_carro);
            this.panel1.Controls.Add(this.comboBox_Servicios);
            this.panel1.Controls.Add(this.label_placa);
            this.panel1.Controls.Add(this.textBox_placa);
            this.panel1.Controls.Add(this.label_numero_serial);
            this.panel1.Controls.Add(this.textBox_numero_serie);
            this.panel1.Controls.Add(this.label_costo);
            this.panel1.Controls.Add(this.textBox_costo);
            this.panel1.Controls.Add(this.label_servicio);
            this.panel1.Controls.Add(this.button_cancelar);
            this.panel1.Controls.Add(this.button_agregar_sdmave);
            this.panel1.Controls.Add(this.label_nombre);
            this.panel1.Controls.Add(this.textBox_nombre_sdmave);
            this.panel1.Location = new System.Drawing.Point(49, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 401);
            this.panel1.TabIndex = 1;
            // 
            // textBox_nombre_sdmave
            // 
            this.textBox_nombre_sdmave.Location = new System.Drawing.Point(133, 21);
            this.textBox_nombre_sdmave.Name = "textBox_nombre_sdmave";
            this.textBox_nombre_sdmave.Size = new System.Drawing.Size(121, 20);
            this.textBox_nombre_sdmave.TabIndex = 0;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(47, 28);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 1;
            this.label_nombre.Text = "Nombre";
            // 
            // button_agregar_sdmave
            // 
            this.button_agregar_sdmave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_agregar_sdmave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(73)))));
            this.button_agregar_sdmave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_agregar_sdmave.Location = new System.Drawing.Point(50, 358);
            this.button_agregar_sdmave.Name = "button_agregar_sdmave";
            this.button_agregar_sdmave.Size = new System.Drawing.Size(75, 23);
            this.button_agregar_sdmave.TabIndex = 2;
            this.button_agregar_sdmave.Text = "Agregar";
            this.button_agregar_sdmave.UseVisualStyleBackColor = false;
            this.button_agregar_sdmave.Click += new System.EventHandler(this.button_agregar_sdmave_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(73)))));
            this.button_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancelar.Location = new System.Drawing.Point(178, 358);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 3;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // label_servicio
            // 
            this.label_servicio.AutoSize = true;
            this.label_servicio.Location = new System.Drawing.Point(7, 54);
            this.label_servicio.Name = "label_servicio";
            this.label_servicio.Size = new System.Drawing.Size(84, 13);
            this.label_servicio.TabIndex = 5;
            this.label_servicio.Text = "Tipo de Servicio";
            // 
            // label_costo
            // 
            this.label_costo.AutoSize = true;
            this.label_costo.Location = new System.Drawing.Point(47, 90);
            this.label_costo.Name = "label_costo";
            this.label_costo.Size = new System.Drawing.Size(34, 13);
            this.label_costo.TabIndex = 7;
            this.label_costo.Text = "Costo";
            // 
            // textBox_costo
            // 
            this.textBox_costo.Location = new System.Drawing.Point(133, 87);
            this.textBox_costo.Name = "textBox_costo";
            this.textBox_costo.Size = new System.Drawing.Size(121, 20);
            this.textBox_costo.TabIndex = 6;
            // 
            // label_numero_serial
            // 
            this.label_numero_serial.AutoSize = true;
            this.label_numero_serial.Location = new System.Drawing.Point(26, 168);
            this.label_numero_serial.Name = "label_numero_serial";
            this.label_numero_serial.Size = new System.Drawing.Size(86, 13);
            this.label_numero_serial.TabIndex = 9;
            this.label_numero_serial.Text = "Numero de Serie";
            this.label_numero_serial.Click += new System.EventHandler(this.label_numero_serial_Click);
            // 
            // textBox_numero_serie
            // 
            this.textBox_numero_serie.Location = new System.Drawing.Point(133, 168);
            this.textBox_numero_serie.Name = "textBox_numero_serie";
            this.textBox_numero_serie.Size = new System.Drawing.Size(121, 20);
            this.textBox_numero_serie.TabIndex = 8;
            this.textBox_numero_serie.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label_placa
            // 
            this.label_placa.AutoSize = true;
            this.label_placa.Location = new System.Drawing.Point(47, 207);
            this.label_placa.Name = "label_placa";
            this.label_placa.Size = new System.Drawing.Size(34, 13);
            this.label_placa.TabIndex = 11;
            this.label_placa.Text = "Placa";
            // 
            // textBox_placa
            // 
            this.textBox_placa.Location = new System.Drawing.Point(133, 204);
            this.textBox_placa.Name = "textBox_placa";
            this.textBox_placa.Size = new System.Drawing.Size(121, 20);
            this.textBox_placa.TabIndex = 10;
            // 
            // comboBox_Servicios
            // 
            this.comboBox_Servicios.FormattingEnabled = true;
            this.comboBox_Servicios.Items.AddRange(new object[] {
            "GENERAL",
            "CAMBIO DE ACEITE",
            "BALANCEO",
            "ALINEACIÓN,",
            "CUERPO DE ACELERACIÓN",
            "SUSPENSIÓN"});
            this.comboBox_Servicios.Location = new System.Drawing.Point(133, 51);
            this.comboBox_Servicios.Name = "comboBox_Servicios";
            this.comboBox_Servicios.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Servicios.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Carro";
            // 
            // textBox_carro
            // 
            this.textBox_carro.Location = new System.Drawing.Point(133, 124);
            this.textBox_carro.Name = "textBox_carro";
            this.textBox_carro.Size = new System.Drawing.Size(121, 20);
            this.textBox_carro.TabIndex = 13;
            // 
            // label_Id_Usiuario
            // 
            this.label_Id_Usiuario.AutoSize = true;
            this.label_Id_Usiuario.Location = new System.Drawing.Point(46, 243);
            this.label_Id_Usiuario.Name = "label_Id_Usiuario";
            this.label_Id_Usiuario.Size = new System.Drawing.Size(53, 13);
            this.label_Id_Usiuario.TabIndex = 16;
            this.label_Id_Usiuario.Text = "Id usuario";
            // 
            // textBox_id_Usuario
            // 
            this.textBox_id_Usuario.Location = new System.Drawing.Point(132, 240);
            this.textBox_id_Usuario.Name = "textBox_id_Usuario";
            this.textBox_id_Usuario.Size = new System.Drawing.Size(121, 20);
            this.textBox_id_Usuario.TabIndex = 15;
            // 
            // Insert_sdmave_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_title_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Insert_sdmave_FRM";
            this.Text = "Nuevo Servicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title_bar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_agregar_sdmave;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox textBox_nombre_sdmave;
        private System.Windows.Forms.Label label_placa;
        private System.Windows.Forms.TextBox textBox_placa;
        private System.Windows.Forms.Label label_numero_serial;
        private System.Windows.Forms.TextBox textBox_numero_serie;
        private System.Windows.Forms.Label label_costo;
        private System.Windows.Forms.TextBox textBox_costo;
        private System.Windows.Forms.Label label_servicio;
        private System.Windows.Forms.ComboBox comboBox_Servicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_carro;
        private System.Windows.Forms.Label label_Id_Usiuario;
        private System.Windows.Forms.TextBox textBox_id_Usuario;
    }
}