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
    public partial class AltaUrgencia : Form
    {
        RepositorioUrgencia _repositorio;

        public AltaUrgencia()
        {
            InitializeComponent();
            _repositorio = new RepositorioUrgencia();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Urgencia = new Urgencia();
            Urgencia.Nombre = txtNombre.Text;
            
            
            if (!Urgencia.NombreValido())
            {
                MessageBox.Show("Nombre inválido");
                return;
            }
            DataTable tablatemporal = _repositorio.SoyUrgenciaExistente(Urgencia.Nombre);
            if (tablatemporal.Rows.Count == 0)
            {
                if (_repositorio.Guardar(Urgencia))
                {
                    MessageBox.Show("Se registro con éxito");
                    this.Dispose();
                }
            }
            else
                MessageBox.Show($"ya existe un tipo de urgencia con ese nombre");
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
