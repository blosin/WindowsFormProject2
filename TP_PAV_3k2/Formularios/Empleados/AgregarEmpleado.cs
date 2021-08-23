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
    public partial class AgregarEmpleado : Form
    {
        FormularioABMEmpleado form;
        Empleado empleado;
        RepositorioEmpleado repositorio;
        RepositorioTiposDoc repositorioTiposDoc;
        RepositorioEstacion repositorioEstacion;
        public AgregarEmpleado()
        {
            InitializeComponent();
            form = new FormularioABMEmpleado();
            empleado = new Empleado();
            repositorio = new RepositorioEmpleado();
            repositorioTiposDoc = new RepositorioTiposDoc();
            repositorioEstacion = new RepositorioEstacion();
        }
        public AgregarEmpleado(FormularioABMEmpleado form)
        {
            InitializeComponent();
            empleado = new Empleado();
            repositorio = new RepositorioEmpleado();
            repositorioTiposDoc = new RepositorioTiposDoc();
            repositorioEstacion = new RepositorioEstacion();
            this.form = form;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            empleado.nombre = txtNombre.Text;
            empleado.apellido = txtApellido.Text;
            if(cmbTipoDoc.SelectedValue==null)
            {
                MessageBox.Show("seleccione un tipo de Documento valido");
                    return;
            }
            else
            empleado.tipoDoc = cmbTipoDoc.SelectedValue.ToString();
            int nroDocumento;
            if (int.TryParse(txtNumero.Text, out nroDocumento))
                empleado.nroDoc = nroDocumento;
            else
            {
                MessageBox.Show("numero de documento erroneo");
                txtNumero.Text = null;
                txtNumero.Focus();
                return;
            }
            
            empleado.fechaNacimiento = dateFechaNacimiento.Value.Date;
            empleado.fechaAlta = DateTime.Today;
            
            if(cmbEstaciones.Text=="")
            {
                MessageBox.Show("debe seleccionar un cuit");
                return;
            }
            else
            {
                empleado.cuit = cmbEstaciones.SelectedValue.ToString();
            }
            int legajoSup = -1;
            if (cmbLegajoSup.SelectedValue == null)
            {
                empleado.legajoSuperior = legajoSup;
            }
            else
            {
                empleado.legajoSuperior = int.Parse(cmbLegajoSup.SelectedValue.ToString());                
            }
            /*if(int.TryParse(cmbLegajoSup.SelectedValue.ToString(), out legagoSup))
            {
                empleado.legajoSuperior = legagoSup;
            }*/
            
            if (empleado.nombreValido() == false)
            {
                MessageBox.Show("ingrese nombre valido");
                txtNombre.Text = null;
                txtNombre.Focus();
                return;
            }
            if (empleado.apellidoValido() == false)
            {
                MessageBox.Show("ingrese apellido valido");
                txtApellido.Text = null;
                txtApellido.Focus();
                return;
            }            
            if (empleado.fechaNacimientoValida() == false)
            {
                MessageBox.Show("ingrese fecha valida");
                return;
            }
            DataTable tablatemporal = repositorio.EmpleadoExistente(empleado.nroDoc.ToString());
            if (tablatemporal.Rows.Count == 0)
            {
                repositorio.Guardar(empleado);
                this.Dispose();
                form.ActualizarEmpleados();
            }
            else
                MessageBox.Show($"ya existe un empleado con ese numero de documento");
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            DataTable tiposDoc;
            DataTable Legajos;
            DataTable Estaciones;
            tiposDoc = repositorioTiposDoc.ObtenerTiposDocumento();
            cmbTipoDoc.DataSource = tiposDoc;
            cmbTipoDoc.ValueMember = "nombre";
            cmbTipoDoc.DisplayMember = "nombre";
            Legajos = repositorio.ObtenerSuperiores();
            cmbLegajoSup.DataSource = Legajos;
            cmbLegajoSup.ValueMember ="legajo";
            cmbLegajoSup.DisplayMember = "nombre";
            Estaciones = repositorioEstacion.ObtenerComboSucursales();
            cmbEstaciones.DataSource = Estaciones;
            cmbEstaciones.ValueMember = "cuit";
            cmbEstaciones.DisplayMember = "sucursales";
            cmbTipoDoc.SelectedIndex = -1;
            cmbLegajoSup.SelectedIndex = -1;
            cmbEstaciones.SelectedIndex = -1;
            dateFechaAlta.Value = DateTime.Today;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbTipoDoc.Text);
            
        }
    }
}
