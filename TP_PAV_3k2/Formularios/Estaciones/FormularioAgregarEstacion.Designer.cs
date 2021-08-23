namespace TP_PAV_3k2
{
    partial class FormularioAgregarEstacion
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
            this.bntAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtNumeroCalle = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaHabilitación = new System.Windows.Forms.DateTimePicker();
            this.lblcuit = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntAceptar
            // 
            this.bntAceptar.Location = new System.Drawing.Point(12, 160);
            this.bntAceptar.Name = "bntAceptar";
            this.bntAceptar.Size = new System.Drawing.Size(140, 67);
            this.bntAceptar.TabIndex = 5;
            this.bntAceptar.Text = "Aceptar";
            this.bntAceptar.UseVisualStyleBackColor = true;
            this.bntAceptar.Click += new System.EventHandler(this.BntAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(242, 160);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 67);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(182, 36);
            this.txtRazonSocial.MaxLength = 20;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(200, 20);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // txtNumeroCalle
            // 
            this.txtNumeroCalle.Location = new System.Drawing.Point(182, 88);
            this.txtNumeroCalle.MaxLength = 10;
            this.txtNumeroCalle.Name = "txtNumeroCalle";
            this.txtNumeroCalle.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroCalle.TabIndex = 3;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(182, 62);
            this.txtCalle.MaxLength = 20;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(200, 20);
            this.txtCalle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Razon Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Calle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Número";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha Habilitacion";
            // 
            // fechaHabilitación
            // 
            this.fechaHabilitación.Location = new System.Drawing.Point(182, 119);
            this.fechaHabilitación.MaxDate = new System.DateTime(2100, 1, 25, 23, 59, 59, 0);
            this.fechaHabilitación.Name = "fechaHabilitación";
            this.fechaHabilitación.Size = new System.Drawing.Size(200, 20);
            this.fechaHabilitación.TabIndex = 4;
            this.fechaHabilitación.Value = new System.DateTime(2019, 9, 23, 1, 2, 50, 0);
            // 
            // lblcuit
            // 
            this.lblcuit.AutoSize = true;
            this.lblcuit.Location = new System.Drawing.Point(12, 17);
            this.lblcuit.Name = "lblcuit";
            this.lblcuit.Size = new System.Drawing.Size(32, 13);
            this.lblcuit.TabIndex = 14;
            this.lblcuit.Text = "CUIT";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(182, 10);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(200, 20);
            this.txtCuit.TabIndex = 0;
            // 
            // FormularioAgregarEstacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 232);
            this.ControlBox = false;
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblcuit);
            this.Controls.Add(this.fechaHabilitación);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNumeroCalle);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.bntAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormularioAgregarEstacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Estación";
            this.Load += new System.EventHandler(this.FormularioAgregarEstacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtNumeroCalle;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fechaHabilitación;
        private System.Windows.Forms.Label lblcuit;
        private System.Windows.Forms.TextBox txtCuit;
    }
}