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
    public partial class ModificarUnidadMedida : Form
    {
        RepositorioUnidadDeMedida repositorio;
        UnidadDeMedida _unidadMedida;

        public ModificarUnidadMedida(string UnidadMedidaId)
        {
            InitializeComponent();
            repositorio = new RepositorioUnidadDeMedida();
            _unidadMedida = repositorio.OtenerUnidadMedida(UnidadMedidaId);
        }

        private void ModificarUnidadMedida_Load(object sender, EventArgs e)
        {
            lblName.Text = _unidadMedida.Nombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var datosUnidadMedida = new UnidadDeMedida();
            datosUnidadMedida.Id = _unidadMedida.Id;
            datosUnidadMedida.Nombre = txtNombre.Text;

            if (!datosUnidadMedida.NombreValido())
            {
                MessageBox.Show("Nombre inválido");
                return;
            }
            if (repositorio.Actualizar(datosUnidadMedida))
            {
                MessageBox.Show("Se actualizó con éxito");
                this.Dispose();
            }
        }
    }
}
