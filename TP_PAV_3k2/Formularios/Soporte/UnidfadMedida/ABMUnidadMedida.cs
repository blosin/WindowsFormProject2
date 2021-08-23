using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3k2
{
    public partial class ABMUnidadMedida : Form
    {
        RepositorioUnidadDeMedida _repositorioUnidadMedida;
        FormularioPrincipal _formularioPrincipal;
        public ABMUnidadMedida()
        {
            InitializeComponent();
            _repositorioUnidadMedida = new RepositorioUnidadDeMedida();
        }

        public ABMUnidadMedida(FormularioPrincipal _formPrincipal)
        {
            InitializeComponent();
            _repositorioUnidadMedida = new RepositorioUnidadDeMedida();
            _formularioPrincipal = _formPrincipal;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            var ventana = new AltaUnidadDeMedida();
            ventana.ShowDialog();
            ActualizarUnidadMedidas();
        }
        private void ActualizarUnidadMedidas()
        {
            dgvUnidadMedida.Rows.Clear();
            var unidadMedidas = _repositorioUnidadMedida.ObtenerUnidadesMedida().Rows;
            ActualizarGrilla(unidadMedidas);
        }

        private void ActualizarGrilla(DataRowCollection registros)
        {
            foreach (DataRow registro in registros)
            {
                if (registro.HasErrors)
                    continue; // no corto el ciclo
                var fila = new string[] {
                    registro.ItemArray[0].ToString(), // Codigo
                    registro.ItemArray[1].ToString(), // Nombre
                    
                };

                dgvUnidadMedida.Rows.Add(fila);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarUnidadMedidas();
        }

        private void ABMUnidadMedida_Load(object sender, EventArgs e)
        {
            ActualizarUnidadMedidas();
        }

        private void ABMUnidadMedida_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_formularioPrincipal.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            var seleccionadas = dgvUnidadMedida.SelectedRows;
            if (seleccionadas.Count == 0 || seleccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccionadas)
            {
                var nombre = fila.Cells[1].Value;
                var id = fila.Cells[0].Value;
                var confirmacion = MessageBox.Show($"Esta seguro que desea elimiar a {nombre}? ",
                    "Confirme operacion",
                    MessageBoxButtons.YesNo);
                if (confirmacion.Equals(DialogResult.No))
                    return;

                if (_repositorioUnidadMedida.Eliminar(id.ToString()))
                {
                    MessageBox.Show("Se elimino exitosamente");
                    ActualizarUnidadMedidas();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var seieccionadas = dgvUnidadMedida.SelectedRows;
            if (seieccionadas.Count == 0 || seieccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seieccionadas)
            {
                var id = fila.Cells[0].Value;

                var ventana = new ModificarUnidadMedida(id.ToString());
                ventana.ShowDialog();
                ActualizarUnidadMedidas();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
