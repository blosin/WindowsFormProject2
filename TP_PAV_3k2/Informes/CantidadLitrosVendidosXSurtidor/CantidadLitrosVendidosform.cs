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

namespace TP_PAV_3k2.Informes.CantidadLitrosVendidosXSurtidor
{
    public partial class CantidadLitrosVendidosform : Form
    {
        public CantidadLitrosVendidosform()
        {
            InitializeComponent();
        }

        private void CantidadLitrosVendidosform_Load(object sender, EventArgs e)
        {

            //this.rvVentasXSurtidor.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde=dtpDesde.Value.Date; //fechaNacimiento.ToString("yyyy-MM-dd");
            DateTime fechaHasta=dtpHasta.Value.Date;
            this.rvVentasXSurtidor.RefreshReport();
            var adapter = new DatosVentaXSurtidorTableAdapters.DataTable1TableAdapter();
            var d = new DatosVentaXSurtidor.DataTable1DataTable();
            adapter.Fill(d, fechaDesde.ToString("yyyy-MM-dd"), fechaHasta.ToString("yyyy-MM-dd"));
            var ds = new ReportDataSource("DatosSurtidores", (DataTable)d);
            rvVentasXSurtidor.LocalReport.DataSources.Clear();

            rvVentasXSurtidor.LocalReport.DataSources.Add(ds);
            this.rvVentasXSurtidor.RefreshReport();
        }

        private void rvVentasXSurtidor_Load(object sender, EventArgs e)
        {

        }
    }
}
