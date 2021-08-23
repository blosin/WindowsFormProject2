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

namespace TP_PAV_3k2.Formularios.Soporte.TipoDocumentos
{
    public partial class fmTipoDocumento : Form
    {
        RepositorioTiposDoc repositorioTiposDoc;
        FormularioPrincipal formularioPrincipal;

        public fmTipoDocumento()
        {
            InitializeComponent();
            repositorioTiposDoc = new RepositorioTiposDoc();
        }
        public fmTipoDocumento(FormularioPrincipal _formPrincipal)
        {
            InitializeComponent();
            repositorioTiposDoc = new RepositorioTiposDoc();
            formularioPrincipal = _formPrincipal;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            var ventana = new AltaTipoDocumento();
            ventana.ShowDialog();
            ActualizarTiposDocumento();
        }
        private void ActualizarTiposDocumento()
        {
            dgvTiposDocumento.Rows.Clear();
            var tiposDoc = repositorioTiposDoc.ObtenerTiposDocumento().Rows;
            ActualizarGrilla(tiposDoc);
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

                dgvTiposDocumento.Rows.Add(fila);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var seieccionadas = dgvTiposDocumento.SelectedRows;
            if (seieccionadas.Count == 0 || seieccionadas.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seieccionadas)
            {
                var id = fila.Cells[0].Value;

                var ventana = new ModificarTipoDocumento(id.ToString());
                ventana.ShowDialog();
                ActualizarTiposDocumento();
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            var seleccionadas = dgvTiposDocumento.SelectedRows;
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

                if (repositorioTiposDoc.Eliminar(id.ToString()))
                {
                    MessageBox.Show("Se elimino exitosamente");
                    ActualizarTiposDocumento();
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void fmTipoDocumento_Load(object sender, EventArgs e)
        {
            ActualizarTiposDocumento();
        }

        private void fmTipoDocumento_FormClosing(object sender, FormClosingEventArgs e)
        {
            //formularioPrincipal.Show();
        }
    }
}
