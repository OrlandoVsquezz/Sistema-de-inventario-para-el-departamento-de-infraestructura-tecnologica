using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if(txtCorreo.Text == "ejemplo.dit@gmail.com")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.White;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if(txtCorreo.Text == "")
            {
                txtCorreo.Text = "ejemplo.dit@gmail.com";
                txtCorreo.ForeColor = Color.Gray;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(txtCorreo.Text != "ejemplo.dit@gmail.com")
            {
                if (txtContraseña.Text != "Contraseña")
                { 
                }
                else
                {
                    lblError.Text = "      " + "Por favor ingrese una contraseña";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "      " + "Por favor ingrese un correo";
                lblError.Visible = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
    }
}
