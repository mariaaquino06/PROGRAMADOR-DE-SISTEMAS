namespace Calculadora3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LimparTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private bool ValidarForm()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                labelErro.Text = "O valor 1 eh obrigatorio.";
                textBox1.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                labelErro.Text = "O valor 2 eh obrigatorio.";
                textBox2.Focus();
                return false;
            }

            try
            {
                double doubleValor1 = Convert.ToDouble(textBox1.Text);
                double doubleValor2 = Convert.ToDouble(textBox2.Text);

                return true;
            }
            catch
            {
                labelErro.Text = "Insira somente numeros";
                LimparTextBox();
                textBox1.Focus();
                return false;
            }
        }

        private static double Somar(double val1, double val2)
        {
            return val1 + val2;
        }

        private static double Subtrair(double val1, double val2)
        {
            return val1 - val2;
        }

        private static double Multiplicar(double val1, double val2)
        {
            return val1 * val2;
        }

        private static double Dividir(double val1, double val2)
        {
            return val1 / val2;
        }

        private void buttonCalcular_Click_1(object sender, EventArgs e)
        {
            textBoxResultado.Clear();
            labelErro.Text = "";

            if (!ValidarForm())
            {
                return;
            }

            double doubleValor1 = Convert.ToDouble(textBox1.Text);
            double doubleValor2 = Convert.ToDouble(textBox2.Text);
            double resultado;

            switch (labelOperador.Text)
            {
                case "+":
                    resultado = Somar(doubleValor1, doubleValor2);
                    break;
                case "-":
                    resultado = Subtrair(doubleValor1, doubleValor2);
                    break;
                case "*":
                    resultado = Multiplicar(doubleValor1, doubleValor2);
                    break;
                case "/":
                    resultado = Dividir(doubleValor1, doubleValor2);
                    break;
                default:
                    resultado = Somar(doubleValor1, doubleValor2);
                    break;
            }

            textBoxResultado.Text = Convert.ToString(resultado);
            LimparTextBox();
        }

        private void radioButtonSoma_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            labelOperador.Text = "+";
        }

        private void radioButtonSubtracao_CheckedChanged(object sender, EventArgs e)
        {
            labelOperador.Text = "-";
        }

        private void radioButtonMultiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            labelOperador.Text = "*";
        }

        private void radioButtonDivisao_CheckedChanged(object sender, EventArgs e)
        {
            labelOperador.Text = "/";
        }

        private void buttonNovoForm_Click(object sender, EventArgs e)
        {
            NovoForm novoForm = new NovoForm();
            novoForm.Show();

            this.Hide();
        }
    }
}
