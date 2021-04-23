
namespace CarFix_UI
{
    partial class Pagar_Sdmave_FRM
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
            this.button_confirmar_pagar = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.textBox_Cantidad_Pagar = new System.Windows.Forms.TextBox();
            this.label_pagar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_confirmar_pagar
            // 
            this.button_confirmar_pagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(73)))));
            this.button_confirmar_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirmar_pagar.Location = new System.Drawing.Point(33, 165);
            this.button_confirmar_pagar.Name = "button_confirmar_pagar";
            this.button_confirmar_pagar.Size = new System.Drawing.Size(75, 23);
            this.button_confirmar_pagar.TabIndex = 0;
            this.button_confirmar_pagar.Text = "Confirmar";
            this.button_confirmar_pagar.UseVisualStyleBackColor = false;
            this.button_confirmar_pagar.Click += new System.EventHandler(this.button_confirmar_pagar_Click);
            // 
            // button_salir
            // 
            this.button_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(73)))));
            this.button_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salir.Location = new System.Drawing.Point(170, 165);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 1;
            this.button_salir.Text = "Cancelar";
            this.button_salir.UseVisualStyleBackColor = false;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // textBox_Cantidad_Pagar
            // 
            this.textBox_Cantidad_Pagar.Location = new System.Drawing.Point(68, 108);
            this.textBox_Cantidad_Pagar.Name = "textBox_Cantidad_Pagar";
            this.textBox_Cantidad_Pagar.Size = new System.Drawing.Size(155, 20);
            this.textBox_Cantidad_Pagar.TabIndex = 2;
            // 
            // label_pagar
            // 
            this.label_pagar.AutoSize = true;
            this.label_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pagar.Location = new System.Drawing.Point(29, 75);
            this.label_pagar.Name = "label_pagar";
            this.label_pagar.Size = new System.Drawing.Size(216, 20);
            this.label_pagar.TabIndex = 3;
            this.label_pagar.Text = "Introduce la cantidad a pagar";
            // 
            // Pagar_Sdmave_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.label_pagar);
            this.Controls.Add(this.textBox_Cantidad_Pagar);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.button_confirmar_pagar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pagar_Sdmave_FRM";
            this.Text = "Pagar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_confirmar_pagar;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.TextBox textBox_Cantidad_Pagar;
        private System.Windows.Forms.Label label_pagar;
    }
}