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

namespace TP_PAV_3k2.Formularios.Empleados
{
    public partial class ModificarEmpleado : Form
    {
        RepositorioEmpleado repositorio;
        Empleado empleado;
        RepositorioTiposDoc repositorioTiposDoc;
        RepositorioEstacion repositorioEstacion;

        public ModificarEmpleado(string legajo)
        {
            InitializeComponent();
            repositorio = new RepositorioEmpleado();
            empleado = repositorio.ObtenerEmpleado(legajo);
            repositorioTiposDoc = new RepositorioTiposDoc();
            repositorioEstacion = new RepositorioEstacion();
        }

        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {
            lblLegajo.Text =empleado.legajo.ToString();
            txtNombre.Text = empleado.nombre;
            txtApellido.Text = empleado.apellido;
            txtNumero.Text = empleado.nroDoc.ToString();
            dateFechaNacimiento.Value = empleado.fechaNacimiento;
            dateFechaAlta.Value = empleado.fechaAlta;
            DataTable tiposDoc;
            DataTable Legajos;
            DataTable Estaciones;
            tiposDoc = repositorioTiposDoc.ObtenerTiposDocumento();
            cmbTipoDoc.DataSource = tiposDoc;
            cmbTipoDoc.ValueMember = "nombre";
            cmbTipoDoc.DisplayMember = "nombre";
            Legajos = repositorio.ObtenerSuperiores();
            Estaciones = repositorioEstacion.ObtenerComboSucursales();
            cmbLegajoSup.DataSource = Legajos;
            cmbLegajoSup.ValueMember = "legajo";
            cmbLegajoSup.DisplayMember = "nombre";
            cmbEstacion.DataSource = Estaciones;
            cmbEstacion.ValueMember = "cuit";
            cmbEstacion.DisplayMember = "sucursales";
            cmbTipoDoc.SelectedValue = empleado.tipoDoc;
            cmbLegajoSup.SelectedValue = empleado.legajoSuperior;
            cmbEstacion.SelectedValue = empleado.cuit;
                         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var datosEmpleado = new Empleado();
            datosEmpleado.legajo = empleado.legajo;
            datosEmpleado.nombre = txtNombre.Text;
            datosEmpleado.apellido = txtApellido.Text;
            datosEmpleado.tipoDoc = cmbTipoDoc.SelectedValue.ToString();
            int nroDocumento;
            if (int.TryParse(txtNumero.Text, out nroDocumento))
                datosEmpleado.nroDoc = nroDocumento;
            else
            {
                MessageBox.Show("numero de documento erroneo");
                txtNumero.Text = null;
                txtNumero.Focus();
                return;
            }
            datosEmpleado.fechaNacimiento = dateFechaNacimiento.Value.Date;
            datosEmpleado.fechaAlta = dateFechaAlta.Value.Date;

            int legajoSup = -1;
            if (cmbLegajoSup.SelectedValue == null)
            {
                datosEmpleado.legajoSuperior = legajoSup;
            }
            else
            {
                datosEmpleado.legajoSuperior = int.Parse(cmbLegajoSup.SelectedValue.ToString());
            }

            if (datosEmpleado.nombreValido() == false)
            {
                MessageBox.Show("ingrese razon social valida");
                txtNombre.Text = null;
                txtNombre.Focus();
                return;
            }
            if (datosEmpleado.apellidoValido() == false)
            {
                MessageBox.Show("ingrese calle valida");
                txtApellido.Text = null;
                txtApellido.Focus();
                return;
            }
            if (datosEmpleado.fechaNacimientoValida() == false)
            {
                MessageBox.Show("ingrese fecha de nacimiento valida");
                return;
            }
            if(datosEmpleado.fechaAltaValida()==false)
            {
                MessageBox.Show("ingrese fecha de alta valida");
                return;
            }
            datosEmpleado.cuit = cmbEstacion.SelectedValue.ToString();
            /*if(cmbLegajoSup.SelectedValue==null)
            {
                MessageBox.Show("funcionabien");
                return;
            }*/
            
           
           if (repositorio.Actualizar(datosEmpleado))
           {
              MessageBox.Show("Se actualizó con éxito");
              this.Dispose();
           }
            
        }
    }
}
