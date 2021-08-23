namespace TP_PAV_3k2
{
    partial class FormularioPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarEstadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMSurtidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarTiposDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTipoCombustibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUnidadDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUrgenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosFaltantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesConMasVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.litrosVendidosPorSurtidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grdEmpleados = new System.Windows.Forms.DataGridView();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajoSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdEstaciones = new System.Windows.Forms.DataGridView();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHabilitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.ordenDeCompraToolStripMenuItem,
            this.ticketToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEmpleadoToolStripMenuItem,
            this.agregarSucursalToolStripMenuItem,
            this.administrarEstadosToolStripMenuItem,
            this.administrarProductosToolStripMenuItem,
            this.aBMSurtidorToolStripMenuItem,
            this.administrarTiposDocumentoToolStripMenuItem,
            this.agregarTipoCombustibleToolStripMenuItem,
            this.agregarUnidadDeMedidaToolStripMenuItem,
            this.agregarUrgenciaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            this.agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            this.agregarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.agregarEmpleadoToolStripMenuItem.Text = "Administrar empleados";
            this.agregarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.agregarEmpleadoToolStripMenuItem_Click);
            // 
            // agregarSucursalToolStripMenuItem
            // 
            this.agregarSucursalToolStripMenuItem.Name = "agregarSucursalToolStripMenuItem";
            this.agregarSucursalToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.agregarSucursalToolStripMenuItem.Text = "Administrar estaciones";
            this.agregarSucursalToolStripMenuItem.Click += new System.EventHandler(this.agregarSucursalToolStripMenuItem_Click);
            // 
            // administrarEstadosToolStripMenuItem
            // 
            this.administrarEstadosToolStripMenuItem.Name = "administrarEstadosToolStripMenuItem";
            this.administrarEstadosToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.administrarEstadosToolStripMenuItem.Text = "Administrar estados";
            this.administrarEstadosToolStripMenuItem.Click += new System.EventHandler(this.administrarEstadosToolStripMenuItem_Click);
            // 
            // administrarProductosToolStripMenuItem
            // 
            this.administrarProductosToolStripMenuItem.Name = "administrarProductosToolStripMenuItem";
            this.administrarProductosToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.administrarProductosToolStripMenuItem.Text = "Administrar Productos";
            this.administrarProductosToolStripMenuItem.Click += new System.EventHandler(this.administrarProductosToolStripMenuItem_Click);
            // 
            // aBMSurtidorToolStripMenuItem
            // 
            this.aBMSurtidorToolStripMenuItem.Name = "aBMSurtidorToolStripMenuItem";
            this.aBMSurtidorToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.aBMSurtidorToolStripMenuItem.Text = "Administrar surtidores";
            this.aBMSurtidorToolStripMenuItem.Click += new System.EventHandler(this.aBMSurtidorToolStripMenuItem_Click);
            // 
            // administrarTiposDocumentoToolStripMenuItem
            // 
            this.administrarTiposDocumentoToolStripMenuItem.Name = "administrarTiposDocumentoToolStripMenuItem";
            this.administrarTiposDocumentoToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.administrarTiposDocumentoToolStripMenuItem.Text = "Administrar tipos documento";
            this.administrarTiposDocumentoToolStripMenuItem.Click += new System.EventHandler(this.administrarTiposDocumentoToolStripMenuItem_Click);
            // 
            // agregarTipoCombustibleToolStripMenuItem
            // 
            this.agregarTipoCombustibleToolStripMenuItem.Name = "agregarTipoCombustibleToolStripMenuItem";
            this.agregarTipoCombustibleToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.agregarTipoCombustibleToolStripMenuItem.Text = "Administrar tipos de  combustible";
            this.agregarTipoCombustibleToolStripMenuItem.Click += new System.EventHandler(this.agregarTipoCombustibleToolStripMenuItem_Click);
            // 
            // agregarUnidadDeMedidaToolStripMenuItem
            // 
            this.agregarUnidadDeMedidaToolStripMenuItem.Name = "agregarUnidadDeMedidaToolStripMenuItem";
            this.agregarUnidadDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.agregarUnidadDeMedidaToolStripMenuItem.Text = "Administrar unidades de medida";
            this.agregarUnidadDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.agregarUnidadDeMedidaToolStripMenuItem_Click);
            // 
            // agregarUrgenciaToolStripMenuItem
            // 
            this.agregarUrgenciaToolStripMenuItem.Name = "agregarUrgenciaToolStripMenuItem";
            this.agregarUrgenciaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.agregarUrgenciaToolStripMenuItem.Text = "Administrar urgencias";
            this.agregarUrgenciaToolStripMenuItem.Click += new System.EventHandler(this.agregarUrgenciaToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProductosFaltantesToolStripMenuItem,
            this.verProductosVendidosToolStripMenuItem,
            this.mesConMasVentasToolStripMenuItem,
            this.litrosVendidosPorSurtidorToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // verProductosFaltantesToolStripMenuItem
            // 
            this.verProductosFaltantesToolStripMenuItem.Name = "verProductosFaltantesToolStripMenuItem";
            this.verProductosFaltantesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.verProductosFaltantesToolStripMenuItem.Text = "Ver productos faltantes";
            this.verProductosFaltantesToolStripMenuItem.Click += new System.EventHandler(this.verProductosFaltantesToolStripMenuItem_Click);
            // 
            // verProductosVendidosToolStripMenuItem
            // 
            this.verProductosVendidosToolStripMenuItem.Name = "verProductosVendidosToolStripMenuItem";
            this.verProductosVendidosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.verProductosVendidosToolStripMenuItem.Text = "Ver productos vendidos";
            this.verProductosVendidosToolStripMenuItem.Click += new System.EventHandler(this.verProductosVendidosToolStripMenuItem_Click);
            // 
            // mesConMasVentasToolStripMenuItem
            // 
            this.mesConMasVentasToolStripMenuItem.Name = "mesConMasVentasToolStripMenuItem";
            this.mesConMasVentasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.mesConMasVentasToolStripMenuItem.Text = "Mes con mas ventas";
            this.mesConMasVentasToolStripMenuItem.Click += new System.EventHandler(this.mesConMasVentasToolStripMenuItem_Click);
            // 
            // litrosVendidosPorSurtidorToolStripMenuItem
            // 
            this.litrosVendidosPorSurtidorToolStripMenuItem.Name = "litrosVendidosPorSurtidorToolStripMenuItem";
            this.litrosVendidosPorSurtidorToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.litrosVendidosPorSurtidorToolStripMenuItem.Text = "Ventas por surtidor";
            this.litrosVendidosPorSurtidorToolStripMenuItem.Click += new System.EventHandler(this.litrosVendidosPorSurtidorToolStripMenuItem_Click);
            // 
            // ordenDeCompraToolStripMenuItem
            // 
            this.ordenDeCompraToolStripMenuItem.Name = "ordenDeCompraToolStripMenuItem";
            this.ordenDeCompraToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.ordenDeCompraToolStripMenuItem.Text = "Orden de Compra";
            this.ordenDeCompraToolStripMenuItem.Click += new System.EventHandler(this.ordenDeCompraToolStripMenuItem_Click);
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ticketToolStripMenuItem.Text = "Ticket";
            this.ticketToolStripMenuItem.Click += new System.EventHandler(this.ticketToolStripMenuItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(656, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grdEmpleados
            // 
            this.grdEmpleados.AllowUserToAddRows = false;
            this.grdEmpleados.AllowUserToDeleteRows = false;
            this.grdEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.legajo,
            this.nombre,
            this.apellido,
            this.tipoDoc,
            this.nroDoc,
            this.fechaNac,
            this.fechaAlta,
            this.legajoSup});
            this.grdEmpleados.Location = new System.Drawing.Point(40, 241);
            this.grdEmpleados.Name = "grdEmpleados";
            this.grdEmpleados.ReadOnly = true;
            this.grdEmpleados.Size = new System.Drawing.Size(868, 142);
            this.grdEmpleados.TabIndex = 4;
            this.grdEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdEmpleados_CellContentClick);
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
            this.tipoDoc.HeaderText = "Tipo de documento";
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.ReadOnly = true;
            // 
            // nroDoc
            // 
            this.nroDoc.HeaderText = "Numero de documento";
            this.nroDoc.Name = "nroDoc";
            this.nroDoc.ReadOnly = true;
            // 
            // fechaNac
            // 
            this.fechaNac.HeaderText = "Fecha de nacimiento";
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.ReadOnly = true;
            // 
            // fechaAlta
            // 
            this.fechaAlta.HeaderText = "Fecha de alta";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            // 
            // legajoSup
            // 
            this.legajoSup.HeaderText = "Legajo de superior";
            this.legajoSup.Name = "legajoSup";
            this.legajoSup.ReadOnly = true;
            // 
            // grdEstaciones
            // 
            this.grdEstaciones.AllowUserToAddRows = false;
            this.grdEstaciones.AllowUserToDeleteRows = false;
            this.grdEstaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuit,
            this.razonSocial,
            this.calle,
            this.numero,
            this.fechaHabilitacion});
            this.grdEstaciones.Location = new System.Drawing.Point(39, 81);
            this.grdEstaciones.MultiSelect = false;
            this.grdEstaciones.Name = "grdEstaciones";
            this.grdEstaciones.ReadOnly = true;
            this.grdEstaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEstaciones.Size = new System.Drawing.Size(869, 141);
            this.grdEstaciones.TabIndex = 5;
            this.grdEstaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEstaciones_CellClick_1);
            // 
            // cuit
            // 
            this.cuit.HeaderText = "Cuit";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // fechaHabilitacion
            // 
            this.fechaHabilitacion.HeaderText = "Fecha De Habilitacion";
            this.fechaHabilitacion.Name = "fechaHabilitacion";
            this.fechaHabilitacion.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estaciones Registradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Empleados Registrados";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdEstaciones);
            this.Controls.Add(this.grdEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarSucursalToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView grdEmpleados;
        private System.Windows.Forms.DataGridView grdEstaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem agregarTipoCombustibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUnidadDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUrgenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMSurtidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarTiposDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarEstadosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoSup;
        private System.Windows.Forms.ToolStripMenuItem administrarProductosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHabilitacion;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProductosFaltantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProductosVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesConMasVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem litrosVendidosPorSurtidorToolStripMenuItem;
    }
}