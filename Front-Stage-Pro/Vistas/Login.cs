using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front_Stage_Pro.Vistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        string user = "fede";
        string pas = "1234";

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            if(tbUsuario.Text==user && tbClave.Text==pas)
            {
                                             
                btnIngresar.DialogResult = DialogResult.Yes;
                //Carga carga = new Carga();

                //carga.Show();
            }
            else
            {
                MessageBox.Show("qweq");
            }
            
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

            Menu menu = new Menu();
            menu.Close();
        }

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "Usuario")
            {
            LlenarTB(tbUsuario);

            }

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
                tbClave.UseSystemPasswordChar = true;
                
            }
        }

        private void tbClave_Enter(object sender, EventArgs e)
        {
            if (tbClave.Text == "Contraseña")
            {

            LlenarTB(tbClave);
            }
            tbClave.UseSystemPasswordChar = false;
            pbClave.Enabled = true;
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            TBLibre(tbUsuario, "Usuario");
        }

        private void tbClave_Leave(object sender, EventArgs e)
        {

            TBLibre(tbClave, "Contraseña");
            pbClave.Enabled = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if(tbClave.UseSystemPasswordChar == false)
            {
                tbClave.UseSystemPasswordChar = true;
            }
            else
            {
                tbClave.UseSystemPasswordChar = false;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Carga carga = new Carga();
            carga.Show();
        }
    }
}
