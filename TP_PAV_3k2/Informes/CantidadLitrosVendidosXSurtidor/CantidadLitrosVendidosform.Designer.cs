namespace TP_PAV_3k2.Informes.CantidadLitrosVendidosXSurtidor
{
    partial class CantidadLitrosVendidosform
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
            this.rvVentasXSurtidor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rvVentasXSurtidor
            // 
            this.rvVentasXSurtidor.LocalReport.ReportEmbeddedResource = "TP_PAV_3k2.Informes.CantidadLitrosVendidosXSurtidor.InfomeVentaPorSurtidor.rdlc";
            this.rvVentasXSurtidor.Location = new System.Drawing.Point(-2, 45);
            this.rvVentasXSurtidor.Name = "rvVentasXSurtidor";
            this.rvVentasXSurtidor.ServerReport.BearerToken = null;
            this.rvVentasXSurtidor.Size = new System.Drawing.Size(800, 398);
            this.rvVentasXSurtidor.TabIndex = 0;
            this.rvVentasXSurtidor.Load += new System.EventHandler(this.rvVentasXSurtidor_Load);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(79, 13);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 1;
            this.dtpDesde.Value = new System.DateTime(2014, 11, 15, 1, 31, 0, 0);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(352, 12);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(586, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CantidadLitrosVendidosform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.rvVentasXSurtidor);
            this.Name = "CantidadLitrosVendidosform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas por surtidor";
            this.Load += new System.EventHandler(this.CantidadLitrosVendidosform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvVentasXSurtidor;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
    }
}