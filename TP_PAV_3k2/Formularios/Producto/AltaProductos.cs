using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_3k2.Clases;
using System.Windows.Forms;
using TP_PAV_3k2.Repositorios;

namespace TP_PAV_3k2.Formularios.Producto
{
    public partial class AltaProductos : Form
    {
        RepositorioTipoCombustible repositorioTiposCombustible;
        RepositorioUnidadDeMedida repositorioMedidas;
        Productoo producto;
        RepositorioProductos repositorioProductos;
        ABMProductos form;
        public AltaProductos()
        {
            InitializeComponent();
            producto = new Productoo();
            repositorioTiposCombustible = new RepositorioTipoCombustible();
            repositorioMedidas = new RepositorioUnidadDeMedida();
            form = new ABMProductos();
            repositorioProductos = new RepositorioProductos();
        }
        public AltaProductos(ABMProductos form)
        {
            InitializeComponent();
            producto = new Productoo();
            repositorioProductos = new RepositorioProductos();
            repositorioTiposCombustible = new RepositorioTipoCombustible();
            repositorioMedidas = new RepositorioUnidadDeMedida();
            this.form = form;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUnidadMedida_Click(object sender, EventArgs e)
        {
            var ventana = new AltaUnidadDeMedida();
            ventana.ShowDialog();
            cargarCombo();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ventana = new AltaTipoCombustible();
            ventana.ShowDialog();
            cargarCombo();

        }

       

        private void rbProducto_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregarCombustible.Enabled = false;
            btnUnidadMedida.Enabled = false;
            cmbNombre.Enabled = false;
            cmbUnidades.Enabled = false;
            panel1.Controls.Remove(cmbNombre);
            panel1.Controls.Add(txtNombre);
            
        }

        
        private void rbCombustible_CheckedChanged_1(object sender, EventArgs e)
        {
            btnAgregarCombustible.Enabled = true;
            btnUnidadMedida.Enabled = true;
            panel1.Controls.Add(cmbNombre);
            panel1.Controls.Remove(txtNombre);
            cmbNombre.Enabled = true;
            cmbUnidades.Enabled = true;
        }

        private void AltaProductos_Load(object sender, EventArgs e)
        {
            cargarCombo();
            dtpActualizacion.Value = DateTime.Today;
        }
        public void cargarCombo()
        {
            DataTable TiposCombustible;
            DataTable UnidadesMdida;
            TiposCombustible = repositorioTiposCombustible.ObtenerTiposCombustible();
            cmbNombre.DataSource = TiposCombustible;
            cmbNombre.ValueMember = "nombre";
            cmbNombre.DisplayMember = "nombre";
            UnidadesMdida = repositorioMedidas.ObtenerUnidadesMedida();
            cmbUnidades.DataSource = UnidadesMdida;
            cmbUnidades.ValueMember = "nombre";
            cmbUnidades.DisplayMember = "nombre";
            cmbUnidades.SelectedIndex = -1;
            cmbNombre.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if(rbCombustible.Checked)
            {                
                if (cmbNombre.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un nombre");
                    return;
                }
                else
                producto.Nombre = cmbNombre.SelectedValue.ToString();

                producto.Descripcion = txtDescripcion.Text;
                if(producto.DescripcionValida()==false)
                {
                    MessageBox.Show("Debe ingresar una descripcion");
                    txtDescripcion.Text = null;
                    txtDescripcion.Focus();
                    return;
                }

                if(txtStock.Text==null)
                {
                    MessageBox.Show("ingrese un stock valido");
                    txtStock.Focus();
                    return;
                }
                else
                {
                    int defaul;
                    if(int.TryParse(txtStock.Text, out defaul))
                    {
                        producto.Stock = defaul;
                    }
                    else
                    {
                        MessageBox.Show("ingrese un stock valido");
                        txtStock.Text = null;
                        txtStock.Focus();
                        return;
                    }
                }
                if(producto.StockValido()==false)
                {
                    MessageBox.Show("ingrese un stock valido");
                    txtStock.Text = null;
                    txtStock.Focus();
                    return;
                }
                //ACAAAAAA
                if (txtPrecioCompra.Text == null)
                {
                    MessageBox.Show("ingrese precio de compra de compra");
                    txtPrecioCompra.Focus();
                    return;
                }
                else
                {
                    decimal defaul;
                    if (decimal.TryParse(txtPrecioCompra.Text, out defaul))
                    {
                        producto.PrecioCompra = defaul;
                    }
                    else
                    {
                        MessageBox.Show("ingrese precio compra valido");
                        txtPrecioCompra.Text = null;
                        txtPrecioCompra.Focus();
                        return;
                    }
                }

                if (producto.PrecioCompraValido() == false)
                {
                    MessageBox.Show("ingrese precio compra valido");
                    txtPrecioCompra.Text = null;
                    txtPrecioCompra.Focus();
                    return;
                }
                //ACAA2
                if (txtPrecioVenta.Text == null)
                {
                    MessageBox.Show("ingrese un precio de venta");
                    txtPrecioVenta.Focus();
                    return;
                }
                else
                {
                    decimal defaul;
                    if (decimal.TryParse(txtPrecioVenta.Text, out defaul))
                    {
                        producto.PrecioVenta = defaul;
                    }
                    else
                    {
                        MessageBox.Show("ingrese precio de venta valido");
                        txtPrecioVenta.Text = null;
                        txtPrecioVenta.Focus();
                        return;
                    }
                }
                if (producto.PrecioVentaValido() == false)
                {
                    MessageBox.Show("ingrese precio de venta valido");
                    txtPrecioVenta.Text = null;
                    txtPrecioVenta.Focus();
                    return;
                }
                //ACAAAAAA33333

                producto.FechaUltimaActualizacion =DateTime.Today;

               
                if (cmbUnidades.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar una unidad de medida");
                    return;
                }
                else
                producto.UnidadMedida = cmbUnidades.SelectedValue.ToString();
                DataTable tablatemporal = repositorioProductos.SoyProductoExistente(producto.Nombre);
                if (tablatemporal.Rows.Count == 0 && producto.PrecioCompra<producto.PrecioVenta)
                {
                    repositorioProductos.Guardar(producto);
                    this.Dispose();
                    form.ActualizarProductos();
                    return;
                }
                else
                {
                    if(producto.PrecioCompra > producto.PrecioVenta)
                    {
                        MessageBox.Show("El precio de venta no puede ser menor al de compra");
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"ya existe un producto con ese nombre");
                        return;
                    }
                   
                }
                   
                    
                

            }

            if(rbProducto.Checked)
            {
                producto.Nombre = txtNombre.Text;
                if(producto.NombreValido()==false)
                {
                    MessageBox.Show("Debe ingresar un nombre valido");
                    txtNombre.Text = null;
                    txtNombre.Focus();
                    return;
                }
               
                producto.Descripcion = txtDescripcion.Text;
                if (producto.DescripcionValida() == false)
                {
                    MessageBox.Show("Debe ingresar una descripcion");
                    txtDescripcion.Text = null;
                    txtDescripcion.Focus();
                    return;
                }

                if (txtStock.Text == null)
                {
                    MessageBox.Show("ingrese un stock valido");
                    txtStock.Focus();
                    return;
                }
                else
                {
                    int defaul;
                    if (int.TryParse(txtStock.Text, out defaul))
                    {
                        producto.Stock = defaul;
                    }
                    else
                    {
                        MessageBox.Show("ingrese un stock valido");
                        txtStock.Text = null;
                        txtStock.Focus();
                        return;
                    }
                }
                if (producto.StockValido() == false)
                {
                    MessageBox.Show("ingrese un stock valido");
                    txtStock.Text = null;
                    txtStock.Focus();
                    return;
                }

                if (txtPrecioCompra.Text == null)
                {
                    MessageBox.Show("ingrese precio de compra de compra");
                    txtPrecioCompra.Focus();
                    return;
                }
                else
                {
                    decimal defaul;
                    if (decimal.TryParse(txtPrecioCompra.Text, out defaul))
                    {
                        producto.PrecioCompra = defaul;
                    }
                    else
                    {
                        MessageBox.Show("ingrese precio compra valido");
                        txtPrecioCompra.Text = null;
                        txtPrecioCompra.Focus();
                        return;
                    }
                }

                if (producto.PrecioCompraValido() == false)
                {
                    MessageBox.Show("ingrese precio compra valido");
                    txtPrecioCompra.Text = null;
                    txtPrecioCompra.Focus();
                    return;
                }

                if (txtPrecioVenta.Text == null)
                {
                    MessageBox.Show("ingrese un precio de venta");
                    txtPrecioVenta.Focus();
                    return;
                }
                else
                {
                    decimal defaul;
                    if (decimal.TryParse(txtPrecioVenta.Text, out defaul))
                    {
                        producto.PrecioVenta = defaul;
                    }
                    else
                    {
                        MessageBox.Show("ingrese precio de venta valido");
                        txtPrecioVenta.Text = null;
                        txtPrecioVenta.Focus();
                        return;
                    }
                }
                if (producto.PrecioVentaValido() == false)
                {
                    MessageBox.Show("ingrese precio de venta valido");
                    txtPrecioVenta.Text = null;
                    txtPrecioVenta.Focus();
                    return;
                }

                producto.FechaUltimaActualizacion =DateTime.Today;

                DataTable tablatemporal = repositorioProductos.SoyProductoExistente(producto.Nombre);
                if (tablatemporal.Rows.Count == 0 && producto.PrecioCompra < producto.PrecioVenta)
                {
                    repositorioProductos.Guardar(producto);
                    this.Dispose();
                    form.ActualizarProductos();
                    return;
                }
                else
                {
                    if (producto.PrecioCompra > producto.PrecioVenta)
                    {
                        MessageBox.Show("El precio de venta no puede ser menor al de compra");
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"ya existe un producto con ese nombre");
                        return;
                    }
                }
                

            }

            MessageBox.Show("seleccione una opcion");
        }
    }
}
