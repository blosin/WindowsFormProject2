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
    public partial class ModificarEstados : Form
    {
        RepositorioEstados repositorio;
        Estadoss estado;

        public ModificarEstados(string idEstado)
        {
            InitializeComponent();
            repositorio = new RepositorioEstados();
            estado = repositorio.ObtenerEstado(idEstado);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var datosEstado = new Estadoss();
            datosEstado.Id = estado.Id;
            datosEstado.Nombre = txtNombre.Text;

            if (!estado.NombreValido())
            {
                MessageBox.Show("Nombre inválido");
                return;
            }
            if (repositorio.Actualizar(datosEstado))
            {
                MessageBox.Show("Se actualizó con éxito");
                this.Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ModificarEstados_Load(object sender, EventArgs e)
        {
            lblName.Text = estado.Nombre;
        }
    }
}
