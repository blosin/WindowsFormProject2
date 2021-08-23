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

namespace TP_PAV_3k2.Formularios.Soporte.TipoDocumentos
{
    public partial class AltaTipoDocumento : Form
    {
        RepositorioTiposDoc _repositorio;

        public AltaTipoDocumento()
        {
            InitializeComponent();
            _repositorio = new RepositorioTiposDoc();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var tipoDocumento = new TipoDocumento();
            tipoDocumento.Nombre = txtNombre.Text;


            if (!tipoDocumento.NombreValido())
            {
                MessageBox.Show("Nombre inválido");
                return;
            }
            DataTable tablatemporal = _repositorio.SoyTipoDocExistente(tipoDocumento.Nombre);
            if (tablatemporal.Rows.Count == 0)
            {
                if (_repositorio.Guardar(tipoDocumento))
                {
                    MessageBox.Show("Se registro con éxito");
                    this.Dispose();
                }
            }
            else
                MessageBox.Show($"ya existe un tipo de documento con ese nombre");
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
