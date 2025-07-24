using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmBienvenidoDIT : Form
    {
        public frmBienvenidoDIT()
        {
            InitializeComponent();
        }


        //Este codigo es para poder  mover la pantallita que sale al ejecutarse
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        

        private void pbRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbRestaurar.Visible = false;
            pbMaximizar.Visible = true;
        }

        private void pbMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCerrarVentana_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbRestaurar.Visible = true;
            pbMaximizar.Visible = false;
        }

        private void pnlBarraTituloDIT_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
