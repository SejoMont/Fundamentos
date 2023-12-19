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
    public partial class Form06ValidarMail : Form
    {
        public Form06ValidarMail()
        {
            InitializeComponent();
        }

        private void btnComprobarCorreo_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;

            if (correo.Contains("@"))
            {
                if (correo.StartsWith("@") || correo.EndsWith("@"))
                {
                    MessageBox.Show("El @ no puede ir ni al principio ni al final");
                }
                else if (correo.Count(c => c == '@') > 1)
                {
                    MessageBox.Show("No puede haber más de una @ en la dirección de correo");
                }
                else if (correo.Contains("."))
                {
                    int indexDot = correo.IndexOf('.');

                    if (indexDot > correo.IndexOf('@'))
                    {
                        string dominio = correo.Substring(indexDot + 1);

                        if (dominio.Length >= 2 && dominio.Length <= 4)
                        {
                            MessageBox.Show("Correo electrónico válido");
                        }
                        else
                        {
                            MessageBox.Show("El dominio debe tener de 2 a 4 caracteres");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe existir un punto después del @ en la dirección de correo");
                    }
                }
                else
                {
                    MessageBox.Show("Falta el punto en la dirección de correo");
                }
            }
            else
            {
                MessageBox.Show("Falta el @ en la dirección de correo");
            }
        }
    }
}
