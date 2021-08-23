using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3k2.Formularios.detalleTicket;
using TP_PAV_3k2.Repositorios;

namespace TP_PAV_3k2.Formularios.Tickets
{
    public partial class Ticket : Form
    {
        RepositorioTickets repositorio;
        public Ticket()
        {
            InitializeComponent();
            repositorio = new RepositorioTickets();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaTicket form = new AltaTicket(this);
            form.ShowDialog();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            ActualizarTickets();
        }
        public void ActualizarTickets()
        {
            grdTicket.Rows.Clear();
            var ordenes = repositorio.ObtenerTickets().Rows;
            ActualizarGrilla(ordenes);
        }

        private void ActualizarGrilla(DataRowCollection registros)
        {
            foreach (DataRow registro in registros)
            {
                if (registro.HasErrors)
                    continue; // no corto el ciclo
                var fila = new string[] {
                    registro.ItemArray[0].ToString(),
                    registro.ItemArray[1].ToString(),
                    registro.ItemArray[2].ToString(),
                    registro.ItemArray[3].ToString(),
                    registro.ItemArray[4].ToString(),
                    registro.ItemArray[5].ToString(),
                    registro.ItemArray[6].ToString(),
                    registro.ItemArray[7].ToString(),

                };

                grdTicket.Rows.Add(fila);
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            var seleccion = grdTicket.SelectedRows;
            if (seleccion.Count == 0 || seleccion.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccion)
            {
                var numTicket = fila.Cells[0].Value;
                var montoTotal = fila.Cells[7].Value;

                var ventana = new DetalleTicket(numTicket.ToString(), decimal.Parse(montoTotal.ToString()));
                ventana.ShowDialog();

            }
        }
    }
}
