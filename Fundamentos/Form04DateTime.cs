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
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            this.txtFechaActual.Text = DateTime.Now.ToString();
        }

        private void Form04DateTime_Load(object sender, EventArgs e)
        {

        }

        private void txtFechaActual_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxCambiarFeca_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            if (this.cbxCambiarFeca.Checked == true)
            {
                this.txtFechaActual.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtFechaActual.Text = fecha.ToShortDateString();
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            fecha.AddDays(5);
            this.txtNuevaFecha.Text = fecha.ToString();
            if (this.cbxAnios.Checked == true)
            {
                fecha = fecha.AddYears(incremento);
            }else if(this.cbxMeses.Checked == true)
            {
                fecha = fecha.AddMonths(incremento);
            }
            else if (this.cbxDias.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            }
        }
    }
}
