namespace ContadorDeClicks
{
    public partial class Form1 : Form
    {
        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtClick_Click(object sender, EventArgs e)
        {
            contador++;
            Display.Text = contador.ToString();
        }

        private void BtReset_Click(object sender, EventArgs e)
        {
            contador = 0;
            Display.Text = contador.ToString();
        }
    }
}
