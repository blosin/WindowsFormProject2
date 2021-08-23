using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3k2.Informes.StockFaltantes
{
    public partial class formularioStocks : Form
    {
        public formularioStocks()
        {
            InitializeComponent();
        }

        private void formularioStocks_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosStockFaltantes.Producto' Puede moverla o quitarla según sea necesario.
            //this.ProductoTableAdapter.Fill(this.DatosStockFaltantes.Producto);

            this.rvStocks.RefreshReport();            
            var adapter = new DatosStockFaltantesTableAdapters.ProductoTableAdapter();
            var d = new DatosStockFaltantes.ProductoDataTable();
            adapter.Fill(d);
            var ds = new ReportDataSource("datosstock", (DataTable)d);
            rvStocks.LocalReport.DataSources.Clear();

            rvStocks.LocalReport.DataSources.Add(ds);
            this.rvStocks.RefreshReport();
        }
    }
}
