namespace CalculadoraDeIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            float peso;
            float altura;
            float imc;
            string imcText;

            if (!float.TryParse(TbPeso.Text, out peso))
            {
                MessageBox.Show(
                    "Ingrese un valor numérico válido.",
                    "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (!float.TryParse(TbAltura.Text, out altura))
            {
                MessageBox.Show(
                    "Ingrese un valor numérico válido.",
                    "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (altura <= 0)
            {
                MessageBox.Show(
                    "La altura debe ser mayor que 0.",
                    "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                imcText = "Bajo Peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                imcText = "Normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                imcText = "Sobrepeso";
            }
            else
            {
                imcText = "Obesidad";
            }

            MessageBox.Show(
                $"Tu IMC es {imc:F2} y tu peso es: {imcText}.",
                "Resultado",
                MessageBoxButtons.OK
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
