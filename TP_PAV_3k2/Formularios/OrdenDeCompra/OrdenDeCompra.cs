using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3k2.Formularios.DetalleOrdenCompra;
using TP_PAV_3k2.Repositorios;

namespace TP_PAV_3k2.Formularios.OrdenDeCompra
{
    public partial class OrdenDeCompra : Form
    {
        RepositorioProductos repositorioProductos;
        RepositorioOrdenDeCompra repositorio;
        public OrdenDeCompra()
        {
            InitializeComponent();
            repositorioProductos = new RepositorioProductos();
            repositorio = new RepositorioOrdenDeCompra();
        }

        private void OrdenDeCompra_Load(object sender, EventArgs e)
        {            
            ActualizarOrdenes();
        }

        public void ActualizarOrdenes()
        {
            grdOrdenes.Rows.Clear();
            var ordenes = repositorio.ObtenerOrdenes().Rows;
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

                };

                grdOrdenes.Rows.Add(fila);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaOrdenCompra form = new AltaOrdenCompra(this);
            form.ShowDialog();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            var seleccion = grdOrdenes.SelectedRows;
            if (seleccion.Count == 0 || seleccion.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccion)
            {
                var numOrden = fila.Cells[0].Value;
                var montoTotal= fila.Cells[4].Value;

                var ventana = new DetalleCompra(numOrden.ToString(), decimal.Parse(montoTotal.ToString()));
                ventana.ShowDialog();
                
            }
        }
        /*public decimal montoFinal()
        {
            var seleccion = grdOrdenes.SelectedRows;
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
        }*/
    }
}
