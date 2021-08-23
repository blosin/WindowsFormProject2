using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; //Para el uso de los ArrayLists como data Source del Combo.
using TP_PAV_3k2.Repositorios;
using TP_PAV_3k2.Formularios.Empleados;
using TP_PAV_3k2.Clases;

namespace TP_PAV_3k2
{
    public partial class FormularioABMEmpleado : Form
    {
        RepositorioEmpleado repositorio;
        FormularioPrincipal formulario;

        public FormularioABMEmpleado()
        {
            InitializeComponent();
            repositorio = new RepositorioEmpleado();
            formulario = new FormularioPrincipal();
        }
        public FormularioABMEmpleado(FormularioPrincipal formularioTemporal)
        {
            InitializeComponent();
            repositorio = new RepositorioEmpleado();
            formulario = formularioTemporal;
        }

        private void AbmEmpleado_Load(object sender, EventArgs e)
        {
            ActualizarEmpleados();
        }

        private void BntAgregar_Click(object sender, EventArgs e)
        {
            AgregarEmpleado form = new AgregarEmpleado(this);
            form.ShowDialog();

        }
        public void ActualizarEmpleados()
        {
            grdEmpleados.Rows.Clear();
            var empleados = repositorio.ObtenerEmpleados().Rows;
            ActualizarGrilla(empleados);
        }
        private void ActualizarGrilla(DataRowCollection registros)
        {
            foreach (DataRow registro in registros)
            {
                if (registro.HasErrors)
                    continue; // no corto el ciclo
                var fila = new string[] {
                    registro.ItemArray[0].ToString(),
                    registro.ItemArray[1].ToString(),
                    registro.ItemArray[2].ToString(),
                    registro.ItemArray[3].ToString(),
                    registro.ItemArray[4].ToString(),
                    registro.ItemArray[5].ToString(),
                    registro.ItemArray[6].ToString(),
                    registro.ItemArray[7].ToString(),
                    registro.ItemArray[8].ToString(),

                };

                grdEmpleados.Rows.Add(fila);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //formulario.ActualizarEmpleados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var seleccion = grdEmpleados.SelectedRows;
            if (seleccion.Count == 0 || seleccion.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccion)
            {
                var nombre = fila.Cells["nombre"].Value;
                var apellido = fila.Cells["apellido"].Value;
                var legajo = fila.Cells["legajo"].Value;
                DataTable tablatemporal =repositorio.SoySupervisorActivo(legajo.ToString());
                if (tablatemporal.Rows.Count==0)
                {
                    var confirmacion = MessageBox.Show($"¿Esta seguro que desea elimiar a {nombre} {apellido}? ",
                       "Confirme operacion",
                       MessageBoxButtons.YesNo);
                    if (confirmacion.Equals(DialogResult.No))
                        return;

                    if (repositorio.Eliminar(legajo.ToString()))
                    {
                        MessageBox.Show("Se elimino exitosamente");
                        ActualizarEmpleados();
                    }
                }
                else
                    MessageBox.Show($"el empleado '{nombre}' '{apellido} es supervisor de otros");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var seleccion = grdEmpleados.SelectedRows;
            if (seleccion.Count == 0 || seleccion.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una fila");
                return;
            }
            foreach (DataGridViewRow fila in seleccion)
            {
                var legajo = fila.Cells[0].Value;

                var ventana = new ModificarEmpleado(legajo.ToString());
                ventana.ShowDialog();
                ActualizarEmpleados();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarEmpleados();
        }
    }
}
