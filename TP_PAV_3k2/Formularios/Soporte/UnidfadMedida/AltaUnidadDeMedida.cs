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
    public partial class AltaUnidadDeMedida : Form
    {
        RepositorioUnidadDeMedida _repositorio;

        public AltaUnidadDeMedida()
        {
            InitializeComponent();
            _repositorio = new RepositorioUnidadDeMedida();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var UnidadMedida = new UnidadDeMedida();
            UnidadMedida.Nombre = txtNombre.Text;


            if (!UnidadMedida.NombreValido())
            {
                MessageBox.Show("Nombre inválido");
                return;
            }
            DataTable tablatemporal = _repositorio.SoyUnidadMedidaExistente(UnidadMedida.Nombre);
            if (tablatemporal.Rows.Count == 0)
            {
                if (_repositorio.Guardar(UnidadMedida))
                {
                    MessageBox.Show("Se registro con éxito");
                    this.Dispose();
                }
            }
            else
                MessageBox.Show($"ya existe una unidad de medida con ese nombre");
                
        }
    }
}
