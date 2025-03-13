namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            string numero1 = textBox1.Text;
            string numero2 = textBox2.Text;

            if (!numero1.All(char.IsNumber))
            {
                labelErro.Text = "O valor 1 deve ser um numero";
                return;
            }

            double doubleNumero1 = Convert.ToDouble(numero1);
            double doubleNumero2 = Convert.ToDouble(numero2);

            double resultado = doubleNumero1 + doubleNumero2;

            labelErro.Text = resultado.ToString();

        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            string numero1 = textBox1.Text;
            string numero2 = textBox2.Text;

            if (!numero1.All(char.IsNumber))
            {
                labelErro.Text = "O valor 1 deve ser um numero";
                return;
            }

            double doubleNumero1 = Convert.ToDouble(numero1);
            double doubleNumero2 = Convert.ToDouble(numero2);

            double resultado = doubleNumero1 * doubleNumero2;

            labelErro.Text = resultado.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            string numero1 = textBox1.Text;
            string numero2 = textBox2.Text;

            if (!numero1.All(char.IsNumber))
            {
                labelErro.Text = "O valor 1 deve ser um numero";
                return;
            }

            double doubleNumero1 = Convert.ToDouble(numero1);
            double doubleNumero2 = Convert.ToDouble(numero2);

            double resultado = doubleNumero1 / doubleNumero2;

            labelErro.Text = resultado.ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            string numero1 = textBox1.Text;
            string numero2 = textBox2.Text;

            if (!numero1.All(char.IsNumber))
            {
                labelErro.Text = "O valor 1 deve ser um numero";
                return;
            }

            double doubleNumero1 = Convert.ToDouble(numero1);
            double doubleNumero2 = Convert.ToDouble(numero2);

            double resultado = doubleNumero1 - doubleNumero2;

            labelErro.Text = resultado.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor1 = textBoxValor1.Text;
            string valor2 = textBoxValor2.Text;

            if (!valor1.All(char.IsNumber))
            {
                labelErro.Text = "O valor 1 deve ser um numero";
                return;
            }
            if (!valor2.All(char.IsNumber))
            {
                labelErro2.Text = "O valor 2 deve ser um numero";
                return;
            }

            double doublevalor1 = Convert.ToDouble(valor1);
            double doublevalor2 = Convert.ToDouble(valor2);
            double resultado;


            switch (comboBox1.SelectedItem?.ToString())
            {
                case "Soma":
                    resultado = doublevalor1 + doublevalor2;
                    textBoxResultado2.Text = resultado.ToString();
                    break;
                case "Subtração":
                    resultado = doublevalor1 - doublevalor2;
                    textBoxResultado2.Text = resultado.ToString();
                    break;
                case "Multiplicação":
                    resultado = doublevalor1 * doublevalor2;
                    textBoxResultado2.Text = resultado.ToString();
                    break;
                case "Divisão":
                    if (doublevalor1 != 0 || doublevalor2 != 0)
                    {
                        resultado = doublevalor1 / doublevalor2;
                        textBoxResultado2.Text = resultado.ToString();
                    }
                    else
                    {
                        labelErro2.Text = "O valor inserido deve ser diferente de 0";
                    }
                    break;
                default:
                    labelErro2.Text = "Selecione uma operação";
                    break;
            }

        }

        private void comboBoxOpera_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem?.ToString())
            {
                case "Soma":
                    labelOperador2.Text = "+";
                    break;
                case "Subtração":
                    labelOperador2.Text = "-";
                    break;
                case "Multiplicação":
                    labelOperador2.Text = "*";
                    break;
                case "Divisão":
                    labelOperador2.Text = "/";
                    break;
            }
        }

        private void buttonNovoForm_Click(object sender, EventArgs e)
        {
            NovoForm novoForm = new NovoForm();
            novoForm.Show();

            this.Hide();
        }
    }
}
