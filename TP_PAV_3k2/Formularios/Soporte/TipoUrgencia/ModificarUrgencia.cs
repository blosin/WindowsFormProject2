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
    public partial class ModificarUrgencia : Form
    {
        RepositorioUrgencia _urgenciasRepositorio;
        Urgencia urgencia;

        public ModificarUrgencia(string urgenciaId)
        {
            InitializeComponent();
            _urgenciasRepositorio = new RepositorioUrgencia();
            urgencia = _urgenciasRepositorio.ObtenerUrgencia(urgenciaId);
        }

        private void ModificarUrgencia_Load(object sender, EventArgs e)
        {
            lblName.Text = urgencia.Nombre;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var datosUrgencia = new Urgencia();
            datosUrgencia.Id = urgencia.Id;
            datosUrgencia.Nombre = txtNombre.Text;
            
            if (!datosUrgencia.NombreValido())
            {
                MessageBox.Show("Nombre inválido");
                return;
            }
            if (_urgenciasRepositorio.Actualizar(datosUrgencia))
            {
                MessageBox.Show("Se actualizó con éxito");
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
