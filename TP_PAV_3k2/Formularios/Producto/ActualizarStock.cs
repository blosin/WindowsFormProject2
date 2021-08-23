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
    public partial class ActualizarStock : Form
    {
        RepositorioProductos repositorio;
        Productoo producto;
        public ActualizarStock(string id)
        {
            InitializeComponent();
            repositorio = new RepositorioProductos();
            producto = repositorio.ObtenerProducto(id);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarStock_Load(object sender, EventArgs e)
        {
            lblProducto.Text = producto.Nombre;
            lblStock.Text = producto.Stock.ToString();
            lblStockResultante.Text = producto.Stock.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtStockAgregado.Text == "" && txtStockRemplazo.Text=="")
            {
                MessageBox.Show("ingrese un stock valido");                
                return;
            }
            else
            {
                if(txtStockAgregado.Text=="")
                {
                    int defaul;
                    if (int.TryParse(txtStockRemplazo.Text, out defaul))
                    {
                        producto.Stock = defaul;
                    }
                    else
                    {
                        MessageBox.Show("ingrese un stock valido");
                        txtStockRemplazo.Text = null;
                        txtStockRemplazo.Focus();
                        return;
                    }
                }

                if(txtStockRemplazo.Text=="")
                {
                    int defaul;
                    if (int.TryParse(txtStockAgregado.Text, out defaul))
                    {
                        producto.Stock += defaul;
                    }
                    else
                    {
                        MessageBox.Show("ingrese un stock valido");
                        txtStockAgregado.Text = null;
                        txtStockAgregado.Focus();
                        return;
                    }
                }                
            }
            if (producto.StockValido() == false)
            {
                MessageBox.Show("ingrese un stock valido");                
                return;
            }
            else
            {
                repositorio.ActualizarStock(producto);
                this.Dispose();
            }
        }

        private void txtStockAgregado_TextChanged(object sender, EventArgs e)
        {
            txtStockRemplazo.Enabled = false;
            
        }

        private void txtStockRemplazo_TextChanged(object sender, EventArgs e)
        {
            txtStockAgregado.Enabled = false;
        }

        /*public void stockactualizacion()
        {
            int defaul;
            if (int.TryParse(txtStockAgregado.Text, out defaul))
            {
                lblStockResultante.Text = (defaul + producto.Stock).ToString();
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtStockAgregado_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStockAgregado_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void txtStockAgregado_KeyUp(object sender, KeyEventArgs e)
        {
            int defaul;
            if (int.TryParse(txtStockAgregado.Text, out defaul))
            {
                lblStockResultante.Text = (defaul + producto.Stock).ToString();
            }
            else
            {
                txtStockAgregado.Text = "";
                lblStockResultante.Text = producto.Stock.ToString();
                txtStockAgregado.Focus();
                return;
            }
                
        }

        private void txtStockRemplazo_KeyUp(object sender, KeyEventArgs e)
        {
            int defaul;
            if (int.TryParse(txtStockRemplazo.Text, out defaul))
            {
                lblStockResultante.Text = defaul.ToString();
            }
            else
            {
                txtStockRemplazo.Text = "";
                lblStockResultante.Text = producto.Stock.ToString();
                txtStockRemplazo.Focus();
                return;
            }
        }
    }
}
