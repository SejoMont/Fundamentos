using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form2PosicionColores : Form
    {
        public Form2PosicionColores()
        {
            InitializeComponent();
        }

        private void Form2PosicionColores_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int X = int.Parse(this.txtPosX.Text);
            int Y = int.Parse(this.txtPosY.Text);

            this.btnPosicion.Location = new Point(X, Y);

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);

            this.BackColor = Color.FromArgb(255, rojo, verde, azul);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
