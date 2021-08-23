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

namespace TP_PAV_3k2.Informes.IDetalleTicket
{
    public partial class TicketReporteform : Form
    {
        int numeroSticket;
        string precioUnidad;
        string SubTotal;
        public TicketReporteform(string numTicket, string precioUNIDAD, string subtotal)
        {
            InitializeComponent();
            numeroSticket = int.Parse(numTicket);
            this.precioUnidad = precioUNIDAD;
            SubTotal = subtotal;
        }

        private void TicketReporteform_Load(object sender, EventArgs e)
        {
            this.rvTicket.RefreshReport();
            // TODO: esta línea de código carga datos en la tabla 'DatosDetalleTicket.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DatosDetalleTicket.DataTable1, numeroSticket);
            // TODO: esta línea de código carga datos en la tabla 'DatosDetalleTicket.DataTable2' Puede moverla o quitarla según sea necesario.
            this.DataTable2TableAdapter.Fill(this.DatosDetalleTicket.DataTable2, numeroSticket);

            /*         
            var adapter = new DatosDetalleTicketTableAdapters.DataTable1TableAdapter();
            var d = new DatosDetalleTicket.DataTable1DataTable();
            adapter.Fill(d,8);
            var ds = new ReportDataSource("DatosDetalles", (DataTable)d);
            rvTicket.LocalReport.DataSources.Clear();

            rvTicket.LocalReport.DataSources.Add(ds);*/
            ReportParameter a = new ReportParameter("Precio", precioUnidad);
            ReportParameter b = new ReportParameter("Subtotal", SubTotal);
            rvTicket.LocalReport.SetParameters(a);
            rvTicket.LocalReport.SetParameters(b);
            this.rvTicket.RefreshReport();
        }
    }
}
