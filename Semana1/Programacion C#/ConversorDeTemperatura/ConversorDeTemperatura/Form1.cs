namespace ConversorDeTemperatura
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtConvertir_Click(object sender, EventArgs e)
        {
            string conversion = SelectConversion.Text;
            float temperatura;
            float resultado = 0;

            if (!float.TryParse(TBTemperatura.Text, out temperatura)) 
            {
                MessageBox.Show(
                    "Ingrese un valor numérico válido.",
                    "Error de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if(temperatura <= 0)
            {
                MessageBox.Show(
                    "La temperatura debe ser mayor a 0.",
                    "Temperatura menor que 0",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            switch(conversion)
            {
                case "Celsius a Fahrenheit":
                    resultado = (temperatura * 9 / 5) + 32;
                    MessageBox.Show(
                        "Resultado: " + temperatura + "°C = " + resultado + " °F",
                        "Grados Celcius a Farenheit.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                break;

                case "Fahrenheit a Celsius":
                    resultado = (temperatura - 32) * 3 / 9;
                    MessageBox.Show(
                        $"Resultado: {temperatura}°F = {resultado}°C",
                        "Grados Farenheit a Celcius",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                break;

                default:
                    MessageBox.Show(
                        "Seleccione una conversión en el select.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                break;
            }
        }
    }
}
