using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3k2.Clases;
using TP_PAV_3k2.Informes.IDetalleTicket;
using TP_PAV_3k2.Repositorios;


namespace TP_PAV_3k2.Formularios.Tickets
{
    public partial class AltaTicket : Form
    {
        RepositorioSurtidor repositorioSurtidor;
        RepositorioEstacion repositorioEstacion;
        RepositorioProductos repositorioProductos;
        RepositorioTickets repositorio;
        Ticket ticket;
        public AltaTicket(Ticket ticket)
        {
            InitializeComponent();
            repositorioSurtidor = new RepositorioSurtidor();
            repositorioEstacion = new RepositorioEstacion();
            repositorioProductos = new RepositorioProductos();
            repositorio = new RepositorioTickets();
            this.ticket = ticket;
        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }

        private void AltaTicket_Load(object sender, EventArgs e)
        {
            //cambiar combo de surtidores segun cuit seleccionado.
            TxtTotal.Text = "0";
            LblFechaHoy.Text = DateTime.Today.ToString("dd/MM/yyyy");
            
            //DataTable Surtidores;
            DataTable cuit;
            //Surtidores = repositorioSurtidor.ObtenerSurtidoresCombo();
            //cmbSurtidores.DataSource = Surtidores;
            //cmbSurtidores.ValueMember = "numeroSurtidor";
            //cmbSurtidores.DisplayMember = "nombre";
            cuit = repositorioEstacion.ObtenerComboSucursales();
            cmbCuit.DataSource = cuit;
            cmbCuit.ValueMember = "cuit";
            cmbCuit.DisplayMember = "sucursales";

            cmbCuit.SelectedIndex = -1;
            //cmbSurtidores.SelectedIndex = -1;

            ActualizarProductos();
        }
        public void ActualizarProductos()
        {
            grdProductos.Rows.Clear();
            var prodctos = repositorioProductos.ObtenerProductosSinMedida().Rows;
            ActualizarGrilla(prodctos);
        }

        private void ActualizarGrilla(DataRowCollection registros)
        {
            foreach (DataRow registro in registros)
            {
                if (registro.HasErrors)
                    continue; // no corto el ciclo
                var fila = new string[] {
                    registro.ItemArray[0].ToString(),
                    registro.ItemArray[6].ToString(),
                    registro.ItemArray[1].ToString(),
                    registro.ItemArray[2].ToString(),
                    registro.ItemArray[3].ToString(),
                    registro.ItemArray[4].ToString(),
                    registro.ItemArray[5].ToString(),
                    
                };

                grdProductos.Rows.Add(fila);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ActualizarTotal()
        {
            var filas = grdProductos.Rows;

            decimal total = 0;
            foreach (DataGridViewRow fila in filas)
            {
                if (fila.Cells["Subtotal"].Value == null)
                    continue;
                total += decimal.Parse(fila.Cells["Subtotal"].Value.ToString());
            }
            if (total != 0)
                TxtTotal.Text = (total+(int.Parse(txtCantidad.Text)*decimal.Parse(txtPrecioUnidad.Text))).ToString();
            else
                TxtTotal.Text = (int.Parse(txtCantidad.Text) * decimal.Parse(txtPrecioUnidad.Text)).ToString();
        }

        private void grdProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(txtCantidad.Text=="")
            {
                MessageBox.Show("primero debe ingresar cantidad");
                
                var selec = grdProductos.Rows[e.RowIndex];
                
                
                    selec.Cells["Cantidad"].Value = null;
                    selec.Cells["Subtotal"].Value = null;                    
                    return;
               
            }
            if(txtPrecioUnidad.Text=="")
            {
                MessageBox.Show("debe elegir un surtidor");
                var selec = grdProductos.Rows[e.RowIndex];


                selec.Cells["Cantidad"].Value = null;
                selec.Cells["Subtotal"].Value = null;
                return;
            }
            var fila = grdProductos.Rows[e.RowIndex];
            int cantidad = 0;
            if (!int.TryParse(fila.Cells["Cantidad"].Value?.ToString(), out cantidad))
            {
                fila.Cells["Cantidad"].Value = null;
                fila.Cells["Subtotal"].Value = null;
                ActualizarTotal();
                return;
            }
            else
            {
                if(cantidad<0)
                {
                    MessageBox.Show("ingrese cantidad valida");
                    fila.Cells["Cantidad"].Value = null;
                    fila.Cells["Subtotal"].Value = null;
                    ActualizarTotal();
                    return;                    
                }
            }
            var precioUnitario = decimal.Parse(fila.Cells["PrecioDeVenta"].Value.ToString());
            var subtotal = cantidad * precioUnitario;
            fila.Cells["Subtotal"].Value = subtotal;
            ActualizarTotal();
            return;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int numticket=0;
            if (cmbCuit.Text == "")
            {
                MessageBox.Show("ingrese cuit valido");
                return;
            }

            if (cmbSurtidores.Text == "")
            {
                MessageBox.Show("ingrese surtidor valido");
                return;
            }

            if(txtCantidad.Text=="")
            {
                MessageBox.Show("Ingrese cantidad");
                return;
            }

            if((int.Parse(lblStock.Text)-int.Parse(txtCantidad.Text))<0)
            {
                MessageBox.Show("Falta de stock");
                return;
            }
            if(txtObservacion.Text.Length>200)
            {
                MessageBox.Show("maximo 200 caracteres para observacion");
                return;
            }

            try
            {
                var ticket = new Tickett();
                ticket.fecha = DateTime.Today;
                ticket.cuit = cmbCuit.SelectedValue.ToString();
                ticket.numeroSurtidor = repositorioSurtidor.ObtenerSurtidor(cmbSurtidores.SelectedValue.ToString());
                ticket.cantidad = int.Parse(txtCantidad.Text);
                ticket.unidadMedida = txtUnidadMedida.Text;
                ticket.observacion = txtObservacion.Text;
                ticket.MontoFinal= string.IsNullOrEmpty(TxtTotal.Text) ? 0 : decimal.Parse(TxtTotal.Text);
                ticket.detalleTicket = PreparaDetallesTickets();

                ticket.Validar();
                numticket=repositorio.Guardar(ticket);
                MessageBox.Show("La operación se realizó con exito");
                
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error inesperado: " + ex);
            }
            finally
            {
                ticket.ActualizarTickets();
                if(numticket==0)
                {
                    MessageBox.Show("error");
                }
                else
                {
                    TicketReporteform formulario = new TicketReporteform(numticket.ToString(), txtPrecioUnidad.Text.ToString(), (decimal.Parse(txtPrecioUnidad.Text) * int.Parse(txtCantidad.Text)).ToString());
                    formulario.Show();
                    this.Dispose();


                }
            }//HARD

        }
        public List<DetalleTickett> PreparaDetallesTickets()
        {
            var detalles = new List<DetalleTickett>();

            var filas = grdProductos.Rows;

            foreach (DataGridViewRow fila in filas)
            {
                if (fila.Cells["Subtotal"].Value == null)
                    continue;
                var detalle = new DetalleTickett()
                {

                    cantidad = int.Parse(fila.Cells["cantidad"].Value.ToString()),
                    precio = decimal.Parse(fila.Cells["PrecioDeVenta"].Value.ToString()),
                    producto = new Productoo() { Id = int.Parse(fila.Cells["id"].Value.ToString()) }
                };
                detalles.Add(detalle);
            }
            return detalles;
        }

        private void cmbSurtidores_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

        private void cmbSurtidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbSurtidores_SelectedValueChanged(object sender, EventArgs e)
        {
            //txtUnidadMedida.Text = repositorioSurtidor.ObtenerUnidadMedia(cmbSurtidores.SelectedValue.ToString());
        }

        private void cmbSurtidores_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            txtUnidadMedida.Text = repositorioSurtidor.ObtenerUnidadMedia(cmbSurtidores.SelectedValue.ToString());
            txtPrecioUnidad.Text=repositorioProductos.ObtenerPrecio(cmbSurtidores.SelectedValue.ToString());
            lblStock.Text = repositorioProductos.ObtenerStock(cmbSurtidores.SelectedValue.ToString());
            int defaul;
            if (int.TryParse(txtCantidad.Text, out defaul))
            {
                txtCantidad.Text = defaul.ToString();
                if (txtPrecioUnidad.Text != "")
                {
                    ActualizarTotal();
                }
            }
            else
            {
                txtCantidad.Text = "";
                txtCantidad.Focus();
                return;
            }
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            int defaul;
            if (int.TryParse(txtCantidad.Text, out defaul))
            {
                txtCantidad.Text=defaul.ToString();
                if (txtPrecioUnidad.Text != "")
                {
                    ActualizarTotal();
                }
            }
            else
            {
                txtCantidad.Text = "";
                txtCantidad.Focus();
                return;
            }

        }

        private void cmbCuit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbSurtidores.Enabled = true;

            //cambiar combo de surtidores segun cuit seleccionado.   

            DataTable Surtidores;          
            Surtidores = repositorioSurtidor.ObtenerSurtidoresPorCuit(cmbCuit.SelectedValue.ToString());
            cmbSurtidores.DataSource = Surtidores;
            cmbSurtidores.ValueMember = "numeroSurtidor";
            cmbSurtidores.DisplayMember = "nombre";
            cmbSurtidores.SelectedIndex = -1;
        }
    }
}
