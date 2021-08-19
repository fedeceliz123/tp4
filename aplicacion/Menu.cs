using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace aplicacion
{
    public partial class Menu : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParanm);
        private void panelSup_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /// <summary>
        /// mover la ventana desde el panel
        /// </summary>
        /// 

        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CerrarSubMenu()
        {
            panelSubCompras.Visible = false;
            panelSubEventos.Visible = false;
            panelSubPersonal.Visible = false;
            panelSubReportes.Visible = false;
        }
        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (panelSubCompras.Visible == false)
            {
                CerrarSubMenu();

                panelSubCompras.Visible = true;
            }
            else
            {
                panelSubCompras.Visible = false;
            }
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            if (panelSubEventos.Visible == false)
            {
                CerrarSubMenu();

                panelSubEventos.Visible = true;
            }
            else
            {
                panelSubEventos.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (panelSubPersonal.Visible == false)
            {
                CerrarSubMenu();
                panelSubPersonal.Visible = true;
            }
            else
            {
                panelSubPersonal.Visible = false;
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (panelSubReportes.Visible == false)
            {
                CerrarSubMenu();

                panelSubReportes.Visible = true;
            }
            else
            {
                panelSubReportes.Visible = false;
            }
        }

    }
}
