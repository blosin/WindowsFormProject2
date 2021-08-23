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

namespace TP_PAV_3k2.Formularios.Producto
{
    public partial class ModificarProducto : Form
    {
        RepositorioProductos repositorio;
        Productoo producto;
        RepositorioUnidadDeMedida repositorioUnidadMedida;
        RepositorioTipoCombustible repositorioTipoCombustible;

        public ModificarProducto(string id)
        {
            InitializeComponent();
            repositorio = new RepositorioProductos();
            producto = repositorio.ObtenerProducto(id);
            repositorioUnidadMedida = new RepositorioUnidadDeMedida();
            repositorioTipoCombustible = new RepositorioTipoCombustible();            
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            if(producto.UnidadMedida=="")
            {
                panel1.Controls.Remove(cmbNombre);
                panel1.Controls.Remove(cmbUnidades);
                panel1.Controls.Remove(lblUnidad);
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                txtPrecioCompra.Text = producto.PrecioCompra.ToString();
                txtPrecioVenta.Text = producto.PrecioVenta.ToString();
                dtpActualizacion.Value = producto.FechaUltimaActualizacion;

            }
            else
            {
                panel1.Controls.Remove(txtNombre);
                DataTable tiposCombustible;
                DataTable unidadesMedida;
                tiposCombustible = repositorioTipoCombustible.ObtenerTiposCombustible();
                unidadesMedida = repositorioUnidadMedida.ObtenerUnidadesMedida();

                cmbNombre.DataSource = tiposCombustible;
                cmbNombre.ValueMember = "nombre";
                cmbNombre.DisplayMember = "nombre";

                cmbUnidades.DataSource = unidadesMedida;
                cmbUnidades.ValueMember = "nombre";
                cmbUnidades.DisplayMember = "nombre";

                cmbNombre.SelectedValue = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                txtPrecioCompra.Text = producto.PrecioCompra.ToString();
                txtPrecioVenta.Text = producto.PrecioVenta.ToString();
                dtpActualizacion.Value = producto.FechaUltimaActualizacion;
                cmbUnidades.SelectedValue = producto.UnidadMedida;
            }         
           
            
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var datosProducto = new Productoo();
            if (producto.UnidadMedida=="")
            {
                datosProducto.Id = producto.Id;
                datosProducto.Nombre = txtNombre.Text;
                datosProducto.UnidadMedida=null;
                if (datosProducto.NombreValido()==false)
                {
                    MessageBox.Show("ingrese nombre valido");
                    txtNombre.Text = null;
                    txtNombre.Focus();
                    return;
                }

                datosProducto.Descripcion = txtDescripcion.Text;
                if (datosProducto.DescripcionValida() == false)
                {
                    MessageBox.Show("Debe ingresar una descripcion");
                    txtDescripcion.Text = null;
                    txtDescripcion.Focus();
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
                        datosProducto.PrecioCompra = defaul;
                    }
                    else
                    {
                        MessageBox.Show("ingrese precio compra valido");
                        txtPrecioCompra.Text = null;
                        txtPrecioCompra.Focus();
                        return;
                    }
                    if (datosProducto.PrecioCompraValido() == false)
                    {
                        MessageBox.Show("ingrese precio compra valido");
                        txtPrecioCompra.Text = null;
                        txtPrecioCompra.Focus();
                        return;
                    }
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
                        datosProducto.PrecioVenta = defaul;
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

                datosProducto.FechaUltimaActualizacion = DateTime.Today;
                datosProducto.Stock = producto.Stock;

                if (repositorio.Actualizar(datosProducto))
                {
                    MessageBox.Show("Se actualizó con éxito");
                    this.Dispose();
                }
            }
            else
            {
                datosProducto.Id = producto.Id;
                datosProducto.Nombre = cmbNombre.SelectedValue.ToString();
                datosProducto.Descripcion = txtDescripcion.Text;
                if (datosProducto.DescripcionValida() == false)
                {
                    MessageBox.Show("Debe ingresar una descripcion");
                    txtDescripcion.Text = null;
                    txtDescripcion.Focus();
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
                        datosProducto.PrecioCompra = defaul;
                    }
                    else
                    {
                        MessageBox.Show("ingrese precio compra valido");
                        txtPrecioCompra.Text = null;
                        txtPrecioCompra.Focus();
                        return;
                    }
                    if (datosProducto.PrecioCompraValido() == false)
                    {
                        MessageBox.Show("ingrese precio compra valido");
                        txtPrecioCompra.Text = null;
                        txtPrecioCompra.Focus();
                        return;
                    }
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
                        datosProducto.PrecioVenta = defaul;
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
                datosProducto.Stock = producto.Stock;
                datosProducto.FechaUltimaActualizacion = DateTime.Today;
                datosProducto.UnidadMedida = cmbUnidades.SelectedValue.ToString();
                if (repositorio.Actualizar(datosProducto))
                {
                    MessageBox.Show("Se actualizó con éxito");
                    this.Dispose();
                }


            }

            
            
            

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
