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

namespace TP_PAV_3k2.Informes.ProductosVendidos
{
    public partial class formProductosVendidos : Form
    {
        public formProductosVendidos()
        {
            InitializeComponent();
        }

        private void formProductosVendidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosProductosVendidos.Producto' Puede moverla o quitarla según sea necesario.
            this.ProductoTableAdapter.Fill(this.DatosProductosVendidos.Producto);

            this.rvProductosVendidos.RefreshReport();            
            var adapter = new DatosProductosVendidosTableAdapters.ProductoTableAdapter();
            var d = new DatosProductosVendidos.ProductoDataTable();
            adapter.Fill(d);
            var ds = new ReportDataSource("DatosProductosVendidos", (DataTable)d);
            rvProductosVendidos.LocalReport.DataSources.Clear();

            rvProductosVendidos.LocalReport.DataSources.Add(ds);
            this.rvProductosVendidos.RefreshReport();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
