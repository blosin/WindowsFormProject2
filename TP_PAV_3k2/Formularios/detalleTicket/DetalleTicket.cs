using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3k2.Formularios.Tickets;
using TP_PAV_3k2.Repositorios;

namespace TP_PAV_3k2.Formularios.detalleTicket
{
    public partial class DetalleTicket : Form
    {
        decimal monto;
        RepositorioTickets repositorioTickets;        
        RepositorioDetalleTicket repositorioDetalleTicket;
        RepositorioUnidadDeMedida repositorioUnidadDeMedida;
        RepositorioTipoCombustible repositorioTipoCombustible;
        string numeroTicket;

        public DetalleTicket(string numTicket, decimal monto)
        {
            InitializeComponent();
            this.monto = monto;
            repositorioTickets = new RepositorioTickets();
            repositorioDetalleTicket = new RepositorioDetalleTicket();
            repositorioUnidadDeMedida = new RepositorioUnidadDeMedida();
            repositorioTipoCombustible = new RepositorioTipoCombustible();
            numeroTicket = numTicket;
        }

        private void DetalleTicket_Load(object sender, EventArgs e)
        {
            ActualizarDetalle();            
            lblTotal.Text = monto.ToString();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void ActualizarDetalle()
        {
            grvDetalle.Rows.Clear();
            var detalles = repositorioDetalleTicket.ObtenerDetalles(numeroTicket).Rows;
            var detalles2 = repositorioTickets.ObtenerTicket(numeroTicket).Rows;
            ActualizarGrilla(detalles);
            ActualizarTipoCombustibleGrilla(detalles2);
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

                };

                grvDetalle.Rows.Add(fila);
            }
        }
        private void ActualizarTipoCombustibleGrilla(DataRowCollection registros)
        {
            foreach (DataRow registro in registros)
            {
                if (registro.HasErrors)
                    continue; // no corto el ciclo               

                              
                lblCantidad.Text = registro.ItemArray[4].ToString();
                lblUnidadMedida.Text = repositorioUnidadDeMedida.ObtenerNombreUnidadMedida(registro.ItemArray[5].ToString());
                decimal montoadicional=0;
                var fila = grvDetalle.Rows;
                foreach(DataGridViewRow file in fila)
                {                    
                    montoadicional += decimal.Parse(file.Cells["Subtotal"].Value.ToString());
                }

                lblSubtotal.Text=(monto-montoadicional).ToString();
                //var nombrecombustible = repositorioTipoCombustible.ObtenerNombreTipoCombustible(registro.ItemArray[3].ToString());
                
                lblTipoCombustible.Text =repositorioTipoCombustible.ObtenerNombreTipoCombustible(registro.ItemArray[3].ToString());
                

            }
        }
    }
}
