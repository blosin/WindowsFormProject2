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
    public partial class ModificarTipoCombustible : Form
    {
        RepositorioTipoCombustible repositorio;
        TipoCombustible _tipoCombustible;

        public ModificarTipoCombustible(string TipoCombustibleId)
        {
            InitializeComponent();
            repositorio = new RepositorioTipoCombustible();
            _tipoCombustible = repositorio.ObtenerTipoCombustible(TipoCombustibleId);
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void ModificarTipoCombustible_Load(object sender, EventArgs e)
        {
            lblName.Text = _tipoCombustible.Nombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var datosTipoCombustible = new TipoCombustible();
            datosTipoCombustible.Id = _tipoCombustible.Id;
            datosTipoCombustible.Nombre = txtNombre.Text;

            if (!_tipoCombustible.NombreValido())
            {
                MessageBox.Show("Nombre inválido");
                return;
            }
            if (repositorio.Actualizar(datosTipoCombustible))
            {
                MessageBox.Show("Se actualizó con éxito");
                this.Dispose();
            }
        }
    }
}
