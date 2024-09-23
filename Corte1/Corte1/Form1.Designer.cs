
namespace Corte1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMayorEdad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarEdad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(177, 97);
            this.tbNombres.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(196, 30);
            this.tbNombres.TabIndex = 1;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(177, 183);
            this.tbApellidos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(196, 30);
            this.tbApellidos.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(150, 258);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(396, 30);
            this.dtpFecha.TabIndex = 3;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(158, 345);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(238, 33);
            this.cmbCiudad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 5;
            // 
            // lblMayorEdad
            // 
            this.lblMayorEdad.AutoSize = true;
            this.lblMayorEdad.Location = new System.Drawing.Point(426, 484);
            this.lblMayorEdad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMayorEdad.Name = "lblMayorEdad";
            this.lblMayorEdad.Size = new System.Drawing.Size(17, 25);
            this.lblMayorEdad.TabIndex = 6;
            this.lblMayorEdad.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ciudad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(660, 58);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(242, 73);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarEdad
            // 
            this.btnMostrarEdad.Location = new System.Drawing.Point(675, 258);
            this.btnMostrarEdad.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMostrarEdad.Name = "btnMostrarEdad";
            this.btnMostrarEdad.Size = new System.Drawing.Size(224, 86);
            this.btnMostrarEdad.TabIndex = 11;
            this.btnMostrarEdad.Text = "Mostrar Edad";
            this.btnMostrarEdad.UseVisualStyleBackColor = true;
            this.btnMostrarEdad.Click += new System.EventHandler(this.mostrarEdad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 866);
            this.Controls.Add(this.btnMostrarEdad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMayorEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Registro de Edades - DAAM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMayorEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostrarEdad;
    }
}

