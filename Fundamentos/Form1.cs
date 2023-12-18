namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "Alo presidente";

            this.txtNombre.TextAlign = HorizontalAlignment.Center;
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }
    }
}