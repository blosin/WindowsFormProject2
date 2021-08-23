namespace TP_PAV_3k2
{
    partial class FormularioABMSucursal
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grdEstaciones = new System.Windows.Forms.DataGridView();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHabilitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(634, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 27);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BntAgregar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 26;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // grdEstaciones
            // 
            this.grdEstaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuit,
            this.RazonSocial,
            this.Calle,
            this.Numero,
            this.FechaHabilitacion});
            this.grdEstaciones.Location = new System.Drawing.Point(12, 12);
            this.grdEstaciones.Name = "grdEstaciones";
            this.grdEstaciones.ReadOnly = true;
            this.grdEstaciones.Size = new System.Drawing.Size(616, 337);
            this.grdEstaciones.TabIndex = 28;
            this.grdEstaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEstaciones_CellContentClick);
            // 
            // Cuit
            // 
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            this.Cuit.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // Calle
            // 
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // FechaHabilitacion
            // 
            this.FechaHabilitacion.HeaderText = "Fecha Habilitacion";
            this.FechaHabilitacion.Name = "FechaHabilitacion";
            this.FechaHabilitacion.ReadOnly = true;
            this.FechaHabilitacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(634, 45);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 29;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 355);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 57);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FormularioABMSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 457);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.grdEstaciones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.button1);
            this.Name = "FormularioABMSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "abmSucursales";
            this.Load += new System.EventHandler(this.AbmSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEstaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdEstaciones;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHabilitacion;
    }
}