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
    public partial class AltaTipoCombustible : Form
    {
        RepositorioTipoCombustible _repositorio;

        public AltaTipoCombustible()
        {
            InitializeComponent();
            _repositorio = new RepositorioTipoCombustible();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var TipoCombustible = new TipoCombustible();
            TipoCombustible.Nombre = txtNombre.Text;


            if (!TipoCombustible.NombreValido())
            {
                MessageBox.Show("Nombre inválido");
                return;
            }
            DataTable tablatemporal = _repositorio.SoyTipoCombustibleExistente(TipoCombustible.Nombre);
            if (tablatemporal.Rows.Count == 0)
            {
                if (_repositorio.Guardar(TipoCombustible))
                {
                    MessageBox.Show("Se registro con éxito");
                    this.Dispose();
                }
            }
            else
                MessageBox.Show($"ya existe un tipo de combustible con ese nombre");
            
        }
    }
}
