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

namespace TP_PAV_3k2.Formularios.Producto
{
    public partial class ABMProductos : Form
    {
        FormularioPrincipal formulario;
        RepositorioProductos repositorio;
        


        public ABMProductos()
        {
            InitializeComponent();
            repositorio = new RepositorioProductos();
            formulario = new FormularioPrincipal();

        }
        public ABMProductos(FormularioPrincipal formularioTemporal)
        {
            InitializeComponent();
            repositorio = new RepositorioProductos();
            formulario = formularioTemporal;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            var seleccion = grdProductos.SelectedRows;
            if (seleccion.Count == 0 || seleccion.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccion)
            {
                var id = fila.Cells["id"].Value;
                var nombre = fila.Cells["Nombre"].Value;

                var confirmacion = MessageBox.Show($"¿Esta seguro que desea elimiar el producto {nombre}? ",
                       "Confirme operacion",
                       MessageBoxButtons.YesNo);
                if (confirmacion.Equals(DialogResult.No))
                    return;

                if (repositorio.Eliminar(id.ToString()))
                {
                    MessageBox.Show("Se elimino exitosamente");
                    ActualizarProductos();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bntAgregar_Click(object sender, EventArgs e)
        {
            AltaProductos form = new AltaProductos(this);
            form.ShowDialog();
        }

        public void ActualizarProductos()
        {
            grdProductos.Rows.Clear();
            var prodctos = repositorio.ObtenerProductos().Rows;
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
                    registro.ItemArray[7].ToString(),
                    

                };

                grdProductos.Rows.Add(fila);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
        }

        private void btnStock_Click(object sender, EventArgs e)
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

                var ventana = new ActualizarStock(id.ToString());
                ventana.ShowDialog();
                ActualizarProductos();
            }
        }

        private void ABMProductos_Load(object sender, EventArgs e)
        {
            ActualizarProductos();
        }
    }
}
