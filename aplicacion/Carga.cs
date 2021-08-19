using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion
{
    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
        }

        private void Carga_Load(object sender, EventArgs e)
        {


            pictureBox1.Image = Image.FromFile(@"D:\Recursos\cargando.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        Menu Menu = new Menu();
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
            this.Close();
        }
    }
}
