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

namespace TP_PAV_3k2.Informes.MesMasVenta
{
    public partial class MesMasVentaForm : Form
    {
        public MesMasVentaForm()
        {
            InitializeComponent();
        }

        private void MesMasVentaForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosMasVenta.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DatosMasVenta.DataTable1);

            this.rvMesMasVenta.RefreshReport();            
            var adapter = new DatosMasVentaTableAdapters.DataTable1TableAdapter();
            var d = new DatosMasVenta.DataTable1DataTable();
            adapter.Fill(d);
            var ds = new ReportDataSource("datosMesVenta", (DataTable)d);
            rvMesMasVenta.LocalReport.DataSources.Clear();

            rvMesMasVenta.LocalReport.DataSources.Add(ds);
            this.rvMesMasVenta.RefreshReport();
        }
    }
}
