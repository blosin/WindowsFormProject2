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
    public partial class ModificarTipoDocumento : Form
    {
        RepositorioTiposDoc repositorio;
        TipoDocumento tipoDocumento;

        public ModificarTipoDocumento(string idTipoDocumento)
        {
            InitializeComponent();
            repositorio = new RepositorioTiposDoc();
            tipoDocumento = repositorio.ObtenerTipoDocumento(idTipoDocumento);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var datosTipoDoc = new TipoDocumento();
            datosTipoDoc.Id = tipoDocumento.Id;
            datosTipoDoc.Nombre = txtNombre.Text;

            if (!tipoDocumento.NombreValido())
            {
                MessageBox.Show("Nombre inválido");
                return;
            }
            if (repositorio.Actualizar(datosTipoDoc))
            {
                MessageBox.Show("Se actualizó con éxito");
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ModificarTipoDocumento_Load(object sender, EventArgs e)
        {
            lblName.Text = tipoDocumento.Nombre;
        }
    }
}
