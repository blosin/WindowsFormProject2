namespace TP_PAV_3k2.Informes.StockFaltantes
{
    partial class formularioStocks
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
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosStockFaltantes = new TP_PAV_3k2.Informes.StockFaltantes.DatosStockFaltantes();
            this.rvStocks = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductoTableAdapter = new TP_PAV_3k2.Informes.StockFaltantes.DatosStockFaltantesTableAdapters.ProductoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosStockFaltantes)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataMember = "Producto";
            this.ProductoBindingSource.DataSource = this.DatosStockFaltantes;
            // 
            // DatosStockFaltantes
            // 
            this.DatosStockFaltantes.DataSetName = "DatosStockFaltantes";
            this.DatosStockFaltantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvStocks
            // 
            this.rvStocks.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "datosstock";
            reportDataSource1.Value = this.ProductoBindingSource;
            this.rvStocks.LocalReport.DataSources.Add(reportDataSource1);
            this.rvStocks.LocalReport.ReportEmbeddedResource = "TP_PAV_3k2.Informes.StockFaltantes.InformeStockFaltantes.rdlc";
            this.rvStocks.Location = new System.Drawing.Point(0, 0);
            this.rvStocks.Name = "rvStocks";
            this.rvStocks.ServerReport.BearerToken = null;
            this.rvStocks.Size = new System.Drawing.Size(644, 300);
            this.rvStocks.TabIndex = 0;
            // 
            // ProductoTableAdapter
            // 
            this.ProductoTableAdapter.ClearBeforeFill = true;
            // 
            // formularioStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 300);
            this.Controls.Add(this.rvStocks);
            this.Name = "formularioStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos con stock faltante";
            this.Load += new System.EventHandler(this.formularioStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosStockFaltantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvStocks;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private DatosStockFaltantes DatosStockFaltantes;
        private DatosStockFaltantesTableAdapters.ProductoTableAdapter ProductoTableAdapter;
    }
}