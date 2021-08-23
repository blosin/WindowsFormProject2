using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using TP_PAV_3k2.Formularios.Surtidor;
using TP_PAV_3k2.Repositorios;
using TP_PAV_3k2.Formularios.Soporte.Estado;
using TP_PAV_3k2.Formularios.Soporte.TipoDocumentos;
using TP_PAV_3k2.Formularios.Producto;
using TP_PAV_3k2.Formularios.OrdenDeCompra;
using TP_PAV_3k2.Formularios.Tickets;
using TP_PAV_3k2.Informes.StockFaltantes;
using TP_PAV_3k2.Informes.ProductosVendidos;
using TP_PAV_3k2.Informes.MesMasVenta;
using TP_PAV_3k2.Informes.IDetalleTicket;
using TP_PAV_3k2.Informes.CantidadLitrosVendidosXSurtidor;

namespace TP_PAV_3k2
{
    public partial class FormularioPrincipal : Form
    {
        RepositorioEstacion repositorio;
        RepositorioEmpleado repositorioEmpleados;
        PantallaLogIn Login = new PantallaLogIn();
        public FormularioPrincipal()
        {
            InitializeComponent();
            repositorio = new RepositorioEstacion();
            repositorioEmpleados = new RepositorioEmpleado();
        }
        //public static DataGridView grillaEmpleados = new DataGridView();
        public FormularioPrincipal(PantallaLogIn login)
        {
            InitializeComponent();
            Login = login;
        }
        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormularioABMEmpleado();
            formulario.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Login.Show();
        }

        private void agregarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormularioABMSucursal(this);
            formulario.ShowDialog();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            ActualizarSucursales();
            grdEstaciones.ClearSelection();


            /*//Inicializo las columnas de la grid de Estaciones Registradas.
            grdEstaciones.Columns.Add("clmCUIT","CUIT");
            grdEstaciones.Columns.Add("clmRazonSocial", "Razon Social");
            grdEstaciones.Columns.Add("clmCalle", "Calle");
            grdEstaciones.Columns.Add("clmNumero", "Numero");
            grdEstaciones.Columns.Add("clmFechaHablilitacion", "Fecha de Habilitación");
            */
            //Inicializo las columnas de la grid de Empleados.
            /*grdEmpleados.Columns.Add("clmLegajo","Legajo");
            grdEmpleados.Columns.Add("clmNombre", "Nombre");
            grdEmpleados.Columns.Add("clmApellido", "Apellido");
            grdEmpleados.Columns.Add("clmTipoDoc", "Tipo Documento");
            grdEmpleados.Columns.Add("clmNumeroDoc", "Número Documento");
            grdEmpleados.Columns.Add("clmFechaNac", "Fecha de Nacimiento");
            grdEmpleados.Columns.Add("clmFechaAlta", "Fecha de Alta");*/
        }
        public void ActualizarEmpleados(string cuit)
        {
            grdEmpleados.Rows.Clear();
            var empleados = repositorioEmpleados.ObtenerEmpleadosSucursal(cuit).Rows;
            ActualizarGrillaEmpleados(empleados);
        }
        private void ActualizarGrillaEmpleados(DataRowCollection registros)
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

                };

                grdEmpleados.Rows.Add(fila);
            }
        }

        public void ActualizarSucursales()
        {
            grdEstaciones.Rows.Clear();
            var sucursales = repositorio.ObtenerSucursales().Rows;
            ActualizarGrillaEstaciones(sucursales);
        }
        private void ActualizarGrillaEstaciones(DataRowCollection registros)
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

                };

                grdEstaciones.Rows.Add(fila);
            }
        }
        private void GrdEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agregarTipoCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TipoCombustibleForm = new ABMTipoCombustible(this);
            TipoCombustibleForm.ShowDialog();
            
        }

        private void agregarUnidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var UnidadMedida = new ABMUnidadMedida(this);
            UnidadMedida.ShowDialog();
           
        }

        private void agregarUrgenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Urgencia = new ABMUrgencia();
            Urgencia.ShowDialog();
            
        }

        private void aBMSurtidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new ABMSurtidores();
            formulario.ShowDialog();

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarSucursales();
        }

        private void administrarTiposDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tiposDoc = new fmTipoDocumento();
            tiposDoc.ShowDialog();
            
        }

        private void administrarEstadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estados = new ABMEstado();
            estados.ShowDialog();
            
        }

        

        

        private void grdEstaciones_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = grdEstaciones.Rows[e.RowIndex];

                string cuit = row.Cells["cuit"].Value.ToString();
                ActualizarEmpleados(cuit);
            }
            catch
            {
                
            }
            
                         
                

        }

        private void administrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new ABMProductos();
            formulario.ShowDialog();
        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdenDeCompra formulario = new OrdenDeCompra();
            formulario.ShowDialog();
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ticket formulario = new Ticket();
            formulario.ShowDialog();
        }

        private void verProductosFaltantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioStocks formulario = new formularioStocks();
            formulario.ShowDialog();
        }

        private void verProductosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductosVendidos formulario = new formProductosVendidos();
            formulario.ShowDialog();
        }

        private void mesConMasVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MesMasVentaForm formulario = new MesMasVentaForm();
            formulario.ShowDialog();
        }

        private void informedepruebaticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*TicketReporteform formulario = new TicketReporteform("8");
            formulario.ShowDialog();*/
        }

        private void litrosVendidosPorSurtidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CantidadLitrosVendidosform formulario = new CantidadLitrosVendidosform();
            formulario.ShowDialog();
        }
    }
}
