using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_PAV_3k2
{
    public partial class PantallaLogIn : Form
    {
        public PantallaLogIn()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {   
            //Valido por campos vacios.
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de Usuario");
                txtUsuario.Focus();
            }
            else if (txtContrasena.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña");
                txtContrasena.Focus();
            }
            else
            {
                FormularioPrincipal formulario = new FormularioPrincipal(this);
                formulario.Show();
                this.Hide();
            }

        }

        
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIngresar.PerformClick();
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIngresar.PerformClick();
            }
        }
    }
}
