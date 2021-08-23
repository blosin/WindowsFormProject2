namespace TP_PAV_3k2.Informes.IDetalleTicket
{
    partial class TicketReporteform
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvTicket = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosDetalleTicket = new TP_PAV_3k2.Informes.IDetalleTicket.DatosDetalleTicket();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new TP_PAV_3k2.Informes.IDetalleTicket.DatosDetalleTicketTableAdapters.DataTable1TableAdapter();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable2TableAdapter = new TP_PAV_3k2.Informes.IDetalleTicket.DatosDetalleTicketTableAdapters.DataTable2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDetalleTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvTicket
            // 
            this.rvTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "datosTicket";
            reportDataSource3.Value = this.DataTable1BindingSource;
            reportDataSource4.Name = "DatosDetalles";
            reportDataSource4.Value = this.DataTable2BindingSource;
            this.rvTicket.LocalReport.DataSources.Add(reportDataSource3);
            this.rvTicket.LocalReport.DataSources.Add(reportDataSource4);
            this.rvTicket.LocalReport.ReportEmbeddedResource = "TP_PAV_3k2.Informes.IDetalleTicket.Informeticket.rdlc";
            this.rvTicket.Location = new System.Drawing.Point(0, 0);
            this.rvTicket.Name = "rvTicket";
            this.rvTicket.ServerReport.BearerToken = null;
            this.rvTicket.Size = new System.Drawing.Size(800, 450);
            this.rvTicket.TabIndex = 0;
            // 
            // DatosDetalleTicket
            // 
            this.DatosDetalleTicket.DataSetName = "DatosDetalleTicket";
            this.DatosDetalleTicket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DatosDetalleTicket;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.DatosDetalleTicket;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // TicketReporteform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvTicket);
            this.Name = "TicketReporteform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.TicketReporteform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDetalleTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvTicket;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DatosDetalleTicket DatosDetalleTicket;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private DatosDetalleTicketTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private DatosDetalleTicketTableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
    }
}