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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void AbrirFormhijo(object formhijo)
        {
            if (this.panelGeneral.Controls.Count > 0)
                this.panelGeneral.Controls.RemoveAt(0);

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelGeneral.Controls.Add(fh);
            this.panelGeneral.Tag = fh;

            fh.Show();

        }

        public void CerrarSubMenu()
        {
            subCompras.Visible = false;
            panelEventos.Visible = false;
            panelEmpleados.Visible = false;
            panelReportes.Visible = false;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {


            if (subCompras.Visible == false)
            {
                CerrarSubMenu();

                subCompras.Visible = true;
            }
            else 
            {
                subCompras.Visible = false;
            }

        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            if (panelEventos.Visible == false)
            {
                CerrarSubMenu();
                panelEventos.Visible = true;
            }
            else
            {
                panelEventos.Visible = false;
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (panelEmpleados.Visible == false)
            {
                CerrarSubMenu();
                panelEmpleados.Visible = true;
            }
            else
            {
                panelEmpleados.Visible = false;
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (panelReportes.Visible == false)
            {
                CerrarSubMenu();
                panelReportes.Visible = true;

            }
            else
            {
                panelReportes.Visible = false;
            }


        }

        private void Menu_Load(object sender, EventArgs e)
        {
            

            AbrirFormhijo(new Inicio());

            Login login = new Login();
            
            if(login.ShowDialog()==DialogResult.Yes)
            {
                panelmen.Enabled = true;
                panelGeneral.Enabled = true;
                Carga carga = new Carga();
                carga.Show();

            }

        }
    }
}
