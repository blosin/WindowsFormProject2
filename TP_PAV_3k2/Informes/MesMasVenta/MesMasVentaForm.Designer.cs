namespace TP_PAV_3k2.Informes.MesMasVenta
{
    partial class MesMasVentaForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosMasVenta = new TP_PAV_3k2.Informes.MesMasVenta.DatosMasVenta();
            this.rvMesMasVenta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1TableAdapter = new TP_PAV_3k2.Informes.MesMasVenta.DatosMasVentaTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosMasVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DatosMasVenta;
            // 
            // DatosMasVenta
            // 
            this.DatosMasVenta.DataSetName = "DatosMasVenta";
            this.DatosMasVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvMesMasVenta
            // 
            this.rvMesMasVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "datosMesVenta";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rvMesMasVenta.LocalReport.DataSources.Add(reportDataSource1);
            this.rvMesMasVenta.LocalReport.ReportEmbeddedResource = "TP_PAV_3k2.Informes.MesMasVenta.InformeMesMasVenta.rdlc";
            this.rvMesMasVenta.Location = new System.Drawing.Point(0, 0);
            this.rvMesMasVenta.Name = "rvMesMasVenta";
            this.rvMesMasVenta.ServerReport.BearerToken = null;
            this.rvMesMasVenta.Size = new System.Drawing.Size(800, 450);
            this.rvMesMasVenta.TabIndex = 0;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // MesMasVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvMesMasVenta);
            this.Name = "MesMasVentaForm";
            this.Text = "Mes con mas venta";
            this.Load += new System.EventHandler(this.MesMasVentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosMasVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvMesMasVenta;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DatosMasVenta DatosMasVenta;
        private DatosMasVentaTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}