namespace TP_PAV_3k2.Formularios.OrdenDeCompra
{
    partial class AltaOrdenCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblFechaHoy = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioDeVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCuits = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 419);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "TOTAL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(93, 419);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(91, 20);
            this.TxtTotal.TabIndex = 21;
            // 
            // LblFechaHoy
            // 
            this.LblFechaHoy.AutoSize = true;
            this.LblFechaHoy.Location = new System.Drawing.Point(90, 9);
            this.LblFechaHoy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFechaHoy.Name = "LblFechaHoy";
            this.LblFechaHoy.Size = new System.Drawing.Size(0, 13);
            this.LblFechaHoy.TabIndex = 20;
            this.LblFechaHoy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(45, 9);
            this.lblX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(37, 13);
            this.lblX.TabIndex = 19;
            this.lblX.Text = "Fecha";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(45, 35);
            this.LblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(57, 13);
            this.LblCliente.TabIndex = 16;
            this.LblCliente.Text = "Empleado:";
            this.LblCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdProductos
            // 
            this.grdProductos.AllowUserToAddRows = false;
            this.grdProductos.AllowUserToDeleteRows = false;
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.descripcion,
            this.stock,
            this.precioCompra,
            this.PrecioDeVenta,
            this.fecha,
            this.unidadDeMedida,
            this.Cantidad,
            this.Subtotal});
            this.grdProductos.Location = new System.Drawing.Point(11, 61);
            this.grdProductos.Margin = new System.Windows.Forms.Padding(2);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.RowTemplate.Height = 24;
            this.grdProductos.Size = new System.Drawing.Size(845, 327);
            this.grdProductos.TabIndex = 14;
            this.grdProductos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductos_CellEndEdit);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio de compra";
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.ReadOnly = true;
            this.precioCompra.Visible = false;
            // 
            // PrecioDeVenta
            // 
            this.PrecioDeVenta.HeaderText = "Precio de venta";
            this.PrecioDeVenta.Name = "PrecioDeVenta";
            this.PrecioDeVenta.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "fecha de ultima actualizacion";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // unidadDeMedida
            // 
            this.unidadDeMedida.HeaderText = "unidad de medida";
            this.unidadDeMedida.Name = "unidadDeMedida";
            this.unidadDeMedida.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(603, 419);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(684, 419);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(107, 35);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleados.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cuit:";
            // 
            // cmbCuits
            // 
            this.cmbCuits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuits.FormattingEnabled = true;
            this.cmbCuits.Location = new System.Drawing.Point(304, 35);
            this.cmbCuits.Name = "cmbCuits";
            this.cmbCuits.Size = new System.Drawing.Size(121, 21);
            this.cmbCuits.TabIndex = 27;
            // 
            // AltaOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.cmbCuits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.LblFechaHoy);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.grdProductos);
            this.Name = "AltaOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta orden de compra";
            this.Load += new System.EventHandler(this.AltaOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label LblFechaHoy;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCuits;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioDeVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}