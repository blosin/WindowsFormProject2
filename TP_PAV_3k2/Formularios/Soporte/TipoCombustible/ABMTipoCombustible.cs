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
    public partial class ABMTipoCombustible : Form
    {
        RepositorioTipoCombustible _repositorioTipoCombustible;
        FormularioPrincipal _formularioPrincipal;

        public ABMTipoCombustible()
        {
            InitializeComponent();
            _repositorioTipoCombustible = new RepositorioTipoCombustible();
        }

        public ABMTipoCombustible(FormularioPrincipal _formPrincipal)
        {
            InitializeComponent();
            _repositorioTipoCombustible = new RepositorioTipoCombustible();
            _formularioPrincipal = _formPrincipal;
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            var ventana = new AltaTipoCombustible();
            ventana.ShowDialog();
            ActualizarTiposCombustible();
        }

        private void ActualizarTiposCombustible()
        {
            dgvTipoCombustible.Rows.Clear();
            var TiposCombustible = _repositorioTipoCombustible.ObtenerTiposCombustible().Rows;
            ActualizarGrilla(TiposCombustible);
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

                dgvTipoCombustible.Rows.Add(fila);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarTiposCombustible();
        }

        private void ABMTipoCombustible_Load(object sender, EventArgs e)
        {
            ActualizarTiposCombustible();
        }

        private void ABMTipoCombustible_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_formularioPrincipal.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            var seleccionadas = dgvTipoCombustible.SelectedRows;
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

                if (_repositorioTipoCombustible.Eliminar(id.ToString()))
                {
                    MessageBox.Show("Se elimino exitosamente");
                    ActualizarTiposCombustible();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var seieccionadas = dgvTipoCombustible.SelectedRows;
            if (seieccionadas.Count == 0 || seieccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seieccionadas)
            {
                var id = fila.Cells[0].Value;

                var ventana = new ModificarTipoCombustible(id.ToString());
                ventana.ShowDialog();
                ActualizarTiposCombustible();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
