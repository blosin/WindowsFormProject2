using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3k2.Repositorios;

namespace TP_PAV_3k2.Formularios.DetalleOrdenCompra
{
    public partial class DetalleCompra : Form
    {
        RepositorioDetalleOrden repostorio;
        RepositorioUnidadDeMedida repositorioUnidadDeMedida;
        decimal MontoTotal;
        string numeroOrden;
        public DetalleCompra(string numOrden, decimal montoTotal)
        {
            InitializeComponent();
            repostorio = new RepositorioDetalleOrden();
            numeroOrden = numOrden;
            repositorioUnidadDeMedida = new RepositorioUnidadDeMedida();
            MontoTotal = montoTotal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void ActualizarDetalle()
        {
            grvDetalle.Rows.Clear();
            var detalles = repostorio.ObtenerDetalles(numeroOrden).Rows;
            ActualizarGrilla(detalles);
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
                    repositorioUnidadDeMedida.ObtenerNombreUnidadMedida(registro.ItemArray[3].ToString()),
                    registro.ItemArray[4].ToString(),
                    registro.ItemArray[5].ToString(),

                };

                grvDetalle.Rows.Add(fila);
            }
        }
        private void DetalleCompra_Load(object sender, EventArgs e)
        {
            ActualizarDetalle();
            lblTotal.Text = MontoTotal.ToString();
            //ActualizarTotal();

        }
        /*private void ActualizarTotal()
        {
            var seleccion = grdProductos.SelectedRows;
            if (seleccion.Count == 0 || seleccion.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccion)
            {
                var id = fila.Cells[0].Value;

                var ventana = new ModificarProducto(id.ToString());
                ventana.ShowDialog();
                ActualizarProductos();
            }
            var filas = grvDetalle.Rows;

            decimal total = 0;
            foreach (DataGridViewRow fila in filas)
            {
                if (fila.Cells["cantidad"].Value == null)
                    continue;
                total += decimal.Parse(fila.Cells["cantidad"].Value.ToString())* decimal.Parse(fila.Cells["precio"].Value.ToString());
            }
            if (total != 0)
                lblTotal.Text = total.ToString();
            else
                lblTotal.Text = null;
        }*/
    }
}
