using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3k2.Clases;
using TP_PAV_3k2.Repositorios;


namespace TP_PAV_3k2.Formularios.Soporte.Estados
{
    public partial class AltaEstado : Form
    {
        RepositorioEstados _repositorio;

        public AltaEstado()
        {
            InitializeComponent();
            _repositorio = new RepositorioEstados();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var estado = new Estadoss();
            estado.Nombre = txtNombre.Text;


            if (!estado.NombreValido())
            {
                MessageBox.Show("Nombre inválido");
                return;
            }

            DataTable tablatemporal = _repositorio.SoyEstadoExistente(estado.Nombre);
            if (tablatemporal.Rows.Count == 0)
            {
                if (_repositorio.Guardar(estado))
                {
                    MessageBox.Show("Se registro con éxito");
                    this.Dispose();
                }
            }
            else
                MessageBox.Show($"ya existe un estado con ese nombre");

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
