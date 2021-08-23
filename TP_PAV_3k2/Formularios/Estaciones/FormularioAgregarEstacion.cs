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

namespace TP_PAV_3k2
{
    public partial class FormularioAgregarEstacion : Form
    {
        FormularioABMSucursal form;
        Estacion estacion;
        RepositorioEstacion repositorio;
        public FormularioAgregarEstacion()
        {
            InitializeComponent();
            form = new FormularioABMSucursal();
            estacion = new Estacion();
            repositorio = new RepositorioEstacion();
        }

        public FormularioAgregarEstacion(FormularioABMSucursal form)
        {
            InitializeComponent();            
            estacion = new Estacion();
            repositorio = new RepositorioEstacion();
            this.form = form;            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();   
        }

        private void BntAceptar_Click(object sender, EventArgs e)
        {
            estacion.razonSocial=txtRazonSocial.Text;
            estacion.calle=txtCalle.Text;
            estacion.cuit = txtCuit.Text;
            int defaul;
            
            estacion.fechaHabilitacion = fechaHabilitación.Value.Date;
            if(estacion.razonSocialValida()==false)
            {
                MessageBox.Show("ingrese razon social valida");
                txtRazonSocial.Text = null;
                txtRazonSocial.Focus();
                return;
            }            
            if(estacion.calleValida()==false)
            {
                MessageBox.Show("ingrese calle valida");
                txtCalle.Text = null;
                txtCalle.Focus();
                return;
            }
            if (int.TryParse(txtNumeroCalle.Text, out defaul))
            {
                estacion.numero = defaul;

            }
            else
            {
                txtNumeroCalle.Text = null;
                MessageBox.Show("numero erroneo");
                return;
            }
            if (estacion.numeroValido()==false)
            {
                MessageBox.Show("ingrese numero de calle valido");
                txtNumeroCalle.Text = null;
                txtNumeroCalle.Focus();
                return;
            }
            if(estacion.fechaValida()==false)
            {
                MessageBox.Show("ingrese fecha valida");
                return;
            }
            if (estacion.cuitValido() == false)
            {
                MessageBox.Show("ingrese cuit valido");
                txtCuit.Focus();
                return;

            }
            if (repositorio.existeEstacion(estacion.cuit))
            {
                repositorio.Guardar(estacion);
                this.Dispose();
                form.ActualizarSucursales();
            }
            else
            {
                MessageBox.Show("ya existe ese cuit");
                txtCuit.Focus();
                return;
            }

            
        }

        private void FormularioAgregarEstacion_Load(object sender, EventArgs e)
        {

        }
    }
}
