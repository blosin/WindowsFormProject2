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

namespace TP_PAV_3k2.Formularios.Estaciones
{
    public partial class ModificarEstaciones : Form
    {
        RepositorioEstacion repositorio;
        Estacion estacion;
        
        public ModificarEstaciones(string id)
        {
            InitializeComponent();
            repositorio = new RepositorioEstacion();
            estacion = repositorio.ObtenerSucursal(id);
        }

        private void ModificarEstaciones_Load(object sender, EventArgs e)
        {
            txtCuit.Text = estacion.cuit.ToString();
            txtRazonSocial.Text = estacion.razonSocial;
            txtNumeroCalle.Text = estacion.numero.ToString();
            txtCalle.Text = estacion.calle;
            fechaHabilitación.Value = estacion.fechaHabilitacion;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bntAceptar_Click(object sender, EventArgs e)
        {
            var datosEstacion = new Estacion();
            datosEstacion.cuit = estacion.cuit;
            datosEstacion.razonSocial = txtRazonSocial.Text;
            datosEstacion.calle = txtCalle.Text;
            int defaul;

            datosEstacion.fechaHabilitacion = fechaHabilitación.Value.Date;
            if (datosEstacion.razonSocialValida() == false)
            {
                MessageBox.Show("ingrese razon social valida");
                txtRazonSocial.Text = null;
                txtRazonSocial.Focus();
                return;
            }
            if (datosEstacion.calleValida() == false)
            {
                MessageBox.Show("ingrese calle valida");
                txtCalle.Text = null;
                txtCalle.Focus();
                return;
            }
            if (int.TryParse(txtNumeroCalle.Text, out defaul))
            {
                datosEstacion.numero = defaul;

            }
            else
            {
                txtNumeroCalle.Text = null;
                MessageBox.Show("numero erroneo");
                return;
            }
            if (datosEstacion.numeroValido() == false)
            {
                MessageBox.Show("ingrese numero de calle valido");
                txtNumeroCalle.Text = null;
                txtNumeroCalle.Focus();
                return;
            }
            if (datosEstacion.fechaValida() == false)
            {
                MessageBox.Show("ingrese fecha valida");
                return;
            }
            
            
            if (repositorio.Actualizar(datosEstacion))
            {
                MessageBox.Show("Se actualizó con éxito");
                this.Dispose();
            }
        }
    }
}
