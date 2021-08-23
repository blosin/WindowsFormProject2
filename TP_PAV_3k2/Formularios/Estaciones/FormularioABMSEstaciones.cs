using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3k2.Formularios.Estaciones;
using TP_PAV_3k2.Repositorios;

namespace TP_PAV_3k2
{
    public partial class FormularioABMSucursal : Form
    {
        RepositorioEstacion repositorio;
        FormularioPrincipal formulario;
        public FormularioABMSucursal()
        {
            InitializeComponent();
            repositorio = new RepositorioEstacion();
        }
        public FormularioABMSucursal(FormularioPrincipal formularioTemporal)
        {
            InitializeComponent();
            repositorio = new RepositorioEstacion();
            formulario = formularioTemporal;
        }

        private void AbmSucursales_Load(object sender, EventArgs e)
        {
            ActualizarSucursales();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            formulario.ActualizarSucursales();
        }

        private void BntAgregar_Click(object sender, EventArgs e)
        {

            FormularioAgregarEstacion form = new FormularioAgregarEstacion(this);
            form.ShowDialog();
                       
        }
        public void ActualizarSucursales()
        {
            grdEstaciones.Rows.Clear();
            var sucursales = repositorio.ObtenerSucursales().Rows;
            ActualizarGrilla(sucursales);
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

                grdEstaciones.Rows.Add(fila);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            var seleccion = grdEstaciones.SelectedRows;
            if (seleccion.Count == 0 || seleccion.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccion)
            {
                var nombre = fila.Cells["razonSocial"].Value;
                var id = fila.Cells["Cuit"].Value;
                var confirmacion = MessageBox.Show($"Esta seguro que desea elimiar a {nombre}? ",
                    "Confirme operacion",
                    MessageBoxButtons.YesNo);
                if (confirmacion.Equals(DialogResult.No))
                    return;

                if (repositorio.Eliminar(id.ToString()))
                {
                    MessageBox.Show("Se elimino exitosamente");
                    ActualizarSucursales();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var seleccion = grdEstaciones.SelectedRows;
            if (seleccion.Count == 0 || seleccion.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccion)
            {
                var id = fila.Cells[0].Value;

                var ventana = new ModificarEstaciones(id.ToString());
                ventana.ShowDialog();
                ActualizarSucursales();
            }
        }

        private void grdEstaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
