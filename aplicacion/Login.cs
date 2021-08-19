using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
using System.Runtime.InteropServices;

namespace aplicacion
{
    public partial class Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParanm);





        public Login()
        {
            InitializeComponent();
        }

        private void LlenarTB(TextBox Tb)
        {

            Tb.Text = "";
            Tb.ForeColor = Color.White;
        }

        private void TBLibre(TextBox tb, string placeholder)
        {
            if (tb.Text == "")
            {
                tb.Text = placeholder;
                tb.ForeColor = Color.LightGray;
                

            }
        }

      




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "Usuario")
            {
                LlenarTB(tbUsuario);

            }
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            TBLibre(tbUsuario, "Usuario");
        }

        private void tbClave_Enter(object sender, EventArgs e)
        {
            if (tbClave.Text == "Contraseña")
            {

                LlenarTB(tbClave);
            }
            tbClave.UseSystemPasswordChar = true;
            pbClave.Enabled = true;
        }

        private void tbClave_Leave(object sender, EventArgs e)
        {
            if (tbClave.Text == "")
            {

            tbClave.UseSystemPasswordChar = false;
            }
            TBLibre(tbClave, "Contraseña");
            pbClave.Enabled = false;
        }

        private void pbClave_Click(object sender, EventArgs e)
        {
            if (tbClave.UseSystemPasswordChar == false)
            {
                tbClave.UseSystemPasswordChar = true;
            }
            else
            {
                tbClave.UseSystemPasswordChar = false;
            }
        }

        NegocioLogin nl = new NegocioLogin();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
        Entidades.Login log = new Entidades.Login();

            log.nombre_usuario = tbUsuario.Text;
            log.contraseña = tbClave.Text;


            if (nl.ingresar(log)!=0)
            {
                Carga carga = new Carga();
                carga.Show();

                Menu menu = new Menu();
                menu.lblNombre.Text = "Federico Celiz";
                menu.Show();

                this.WindowState = FormWindowState.Minimized;
               
            }
            else
            {
                MensajeOK mensaje = new MensajeOK();
                mensaje.lblMensaje.Text = "Verifique su usuario y contraseña";
                mensaje.Show();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
