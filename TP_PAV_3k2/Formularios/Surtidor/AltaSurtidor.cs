using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_3k2.Clases;
using TP_PAV_3k2.Repositorios;

namespace TP_PAV_3k2.Formularios.Surtidor
{
    public partial class AltaSurtidor : Form
    {
       
        RepositorioSurtidor repositorioSurtidor;
        Surtidorr surtidor;
        ABMSurtidores form;
        public AltaSurtidor()
        {
            InitializeComponent();
            repositorioSurtidor = new RepositorioSurtidor();
            form = new ABMSurtidores();
            surtidor = new Surtidorr();
        }

        public AltaSurtidor(ABMSurtidores form)
        {
            InitializeComponent();
            surtidor = new Surtidorr();
            repositorioSurtidor = new RepositorioSurtidor();            
            this.form = form;
        }

        public void cargarComboTipoCombustible()
        {
            DataTable tablacombo = new DataTable();
            tablacombo=repositorioSurtidor.ObtenerTiposCombustible();
            cmbTipoCombustible.DataSource = tablacombo;
            cmbTipoCombustible.ValueMember = "nombre";
            cmbTipoCombustible.DisplayMember = "nombre";
        }
        public void cargarComboEstado()
        {
            DataTable tablacombo = new DataTable();
            tablacombo = repositorioSurtidor.ObtenerEstados();
            cmbEstado.DataSource = tablacombo;
            cmbEstado.ValueMember = "nombre";
            cmbEstado.DisplayMember = "nombre";
        }
        public void cargarComboCuit()
        {
            DataTable tablacombo = new DataTable();
            tablacombo = repositorioSurtidor.ObtenerComboSucursales();
            cmbCuit.DataSource = tablacombo;
            cmbCuit.ValueMember = "cuit";
            cmbCuit.DisplayMember = "sucursales";
        }
        private void Surtidor_Load(object sender, EventArgs e)
        {
            cargarComboTipoCombustible();
            cargarComboEstado();
            cargarComboCuit();
            cmbCuit.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            cmbTipoCombustible.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (cmbCuit.SelectedValue == null)
            {
                MessageBox.Show("seleccione un cuit valido");
                return;
            }
            else
            surtidor.cuit = cmbCuit.SelectedValue.ToString();

            if (cmbTipoCombustible.SelectedValue == null)
            {
                MessageBox.Show("seleccione un tipo de combustible valido");
                return;
            }
            else
            surtidor.idTipoCombustible = cmbTipoCombustible.SelectedValue.ToString();

            if (cmbEstado.SelectedValue == null)
            {
                MessageBox.Show("seleccione un estado valido");
                return;
            }
            else
            surtidor.idEstado= cmbEstado.SelectedValue.ToString();


            repositorioSurtidor.Guardar(surtidor);
            this.Dispose();
            form.ActualizarSurtidores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
