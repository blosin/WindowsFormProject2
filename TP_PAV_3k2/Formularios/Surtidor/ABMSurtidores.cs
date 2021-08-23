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

namespace TP_PAV_3k2.Formularios.Surtidor
{
    public partial class ABMSurtidores : Form
    {
        FormularioPrincipal formulario;
        RepositorioSurtidor repositorio;
        public ABMSurtidores()
        {
            InitializeComponent();
            repositorio = new RepositorioSurtidor();
            formulario = new FormularioPrincipal();
        }

        public ABMSurtidores(FormularioPrincipal formularioTemporal)
        {
            InitializeComponent();
            repositorio = new RepositorioSurtidor();
            formulario = formularioTemporal;
        }

        private void ABMSurtidores_Load(object sender, EventArgs e)
        {
            ActualizarSurtidores();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var seleccion = grdSurtidores.SelectedRows;
            if (seleccion.Count == 0 || seleccion.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccion)
            {
                var numero = fila.Cells[0].Value;

               var ventana = new ModificarSurtidor(numero.ToString());
                ventana.ShowDialog();
                ActualizarSurtidores();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaSurtidor form = new AltaSurtidor(this);
            form.ShowDialog();
        }

        public void ActualizarSurtidores()
        {
            grdSurtidores.Rows.Clear();
            var surtidores = repositorio.ObtenerSurtidores().Rows;
            ActualizarGrilla(surtidores);
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
                };

                grdSurtidores.Rows.Add(fila);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            var seleccion = grdSurtidores.SelectedRows;
            if (seleccion.Count == 0 || seleccion.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccion)
            {
                var numero = fila.Cells["id"].Value;
                var estado = fila.Cells["idestado"].Value;

                var confirmacion = MessageBox.Show($"¿Esta seguro que desea elimiar a el surtidor {numero} con estado {estado}? ",
                       "Confirme operacion",
                       MessageBoxButtons.YesNo);
                if (confirmacion.Equals(DialogResult.No))
                    return;

                if (repositorio.Eliminar(numero.ToString()))
                {
                    MessageBox.Show("Se elimino exitosamente");
                    ActualizarSurtidores();
                }
            }

                
        }
    }
}
