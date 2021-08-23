namespace TP_PAV_3k2
{
    partial class FormularioABMEmpleado
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
            this.bntAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grdEmpleados = new System.Windows.Forms.DataGridView();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajoSuperior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // bntAgregar
            // 
            this.bntAgregar.Location = new System.Drawing.Point(972, 12);
            this.bntAgregar.Name = "bntAgregar";
            this.bntAgregar.Size = new System.Drawing.Size(75, 27);
            this.bntAgregar.TabIndex = 20;
            this.bntAgregar.Text = "Agregar";
            this.bntAgregar.UseVisualStyleBackColor = true;
            this.bntAgregar.Click += new System.EventHandler(this.BntAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1018, 418);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 27);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // grdEmpleados
            // 
            this.grdEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajo,
            this.nombre,
            this.apellido,
            this.tipoDoc,
            this.nroDocumento,
            this.fechaNacimiento,
            this.fechaAlta,
            this.legajoSuperior,
            this.estacion});
            this.grdEmpleados.Location = new System.Drawing.Point(12, 12);
            this.grdEmpleados.Name = "grdEmpleados";
            this.grdEmpleados.ReadOnly = true;
            this.grdEmpleados.Size = new System.Drawing.Size(954, 337);
            this.grdEmpleados.TabIndex = 36;
            // 
            // legajo
            // 
            this.legajo.HeaderText = "Legajo";
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // tipoDoc
            // 
            this.tipoDoc.HeaderText = "Tipo Documento";
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.ReadOnly = true;
            // 
            // nroDocumento
            // 
            this.nroDocumento.HeaderText = "Numero de Documento";
            this.nroDocumento.Name = "nroDocumento";
            this.nroDocumento.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // fechaAlta
            // 
            this.fechaAlta.HeaderText = "Fecha de Alta";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            // 
            // legajoSuperior
            // 
            this.legajoSuperior.HeaderText = "Legajo de Superior";
            this.legajoSuperior.Name = "legajoSuperior";
            this.legajoSuperior.ReadOnly = true;
            // 
            // estacion
            // 
            this.estacion.HeaderText = "Estacion";
            this.estacion.Name = "estacion";
            this.estacion.ReadOnly = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 388);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 57);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(972, 45);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 38;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormularioABMEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 457);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grdEmpleados);
            this.Controls.Add(this.bntAgregar);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormularioABMEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "abmEmpleados";
            this.Load += new System.EventHandler(this.AbmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView grdEmpleados;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoSuperior;
        private System.Windows.Forms.DataGridViewTextBoxColumn estacion;
    }
}