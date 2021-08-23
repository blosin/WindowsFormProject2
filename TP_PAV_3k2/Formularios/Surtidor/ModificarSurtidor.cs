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

namespace TP_PAV_3k2.Formularios.Surtidor
{
    public partial class ModificarSurtidor : Form
    {
        RepositorioSurtidor repositorio;
        Surtidorr surtidor;
        RepositorioEstados repositoriosEstados;
        RepositorioTipoCombustible repositorioTiposCombustible;
        RepositorioEstacion repositorioEstacion;


        public ModificarSurtidor(string numeroSurtidor)
        {
            InitializeComponent();
            repositorio = new RepositorioSurtidor();
            surtidor = repositorio.ObtenerSurtidor(numeroSurtidor);
            repositoriosEstados = new RepositorioEstados();
            repositorioTiposCombustible = new RepositorioTipoCombustible();
            repositorioEstacion = new RepositorioEstacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ModificarSurtidor_Load(object sender, EventArgs e)
        {            
            DataTable estados;
            DataTable tiposCombustible;
            DataTable estaciones;
            estados = repositoriosEstados.ObtenerEstados();
            cmbEstado.DataSource = estados;
            cmbEstado.ValueMember = "nombre";
            cmbEstado.DisplayMember = "nombre";
            tiposCombustible = repositorioTiposCombustible.ObtenerTiposCombustible();
            estaciones = repositorioEstacion.ObtenerSucursales();
            cmbTipoCombustible.DataSource = tiposCombustible;
            cmbTipoCombustible.ValueMember = "nombre";
            cmbTipoCombustible.DisplayMember = "nombre";
            cmbCuit.DataSource = estaciones;
            cmbCuit.ValueMember = "cuit";
            cmbCuit.DisplayMember = "cuit";
            cmbCuit.SelectedValue = surtidor.cuit;
            cmbEstado.SelectedValue = surtidor.idEstado;
            cmbTipoCombustible.SelectedValue = surtidor.idTipoCombustible;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var datosSurtidor = new Surtidorr();
            datosSurtidor.numeroSurtidor = surtidor.numeroSurtidor;
            datosSurtidor.cuit = cmbCuit.SelectedValue.ToString();
            datosSurtidor.idTipoCombustible = cmbTipoCombustible.SelectedValue.ToString();
            datosSurtidor.idEstado = cmbEstado.SelectedValue.ToString();


            if (repositorio.Actualizar(datosSurtidor))
            {
                MessageBox.Show("Se actualizó con éxito");
                this.Dispose();
            }
        }
    }
}
