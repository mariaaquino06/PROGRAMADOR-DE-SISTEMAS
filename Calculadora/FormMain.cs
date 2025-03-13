using System.Drawing.Text;

namespace Calculadora
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void LimparTextBox()
        {
            textBoxNro1.Clear();
            textBoxNro2.Clear();
        }

        private bool ValidarForm()
        {
            if (string.IsNullOrWhiteSpace(textBoxNro1.Text))
            {
                labelErro.Text = "O valor 1 eh obrigatorio.";
                textBoxNro1.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxNro2.Text))
            {
                labelErro.Text = "O valor 2 eh obrigatorio.";
                textBoxNro2.Focus();
                return false;
            }

            try
            {
                double doubleValor1 = Convert.ToDouble(textBoxNro1.Text);
                double doubleValor2 = Convert.ToDouble(textBoxNro2.Text);

                return true;
            }
            catch
            {
                labelErro.Text = "Insira somente numeros";
                LimparTextBox();
                textBoxNro1.Focus();
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

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            textBoxResultado.Clear();
            labelErro.Text = "";

            if (!ValidarForm())
            {
                return;
            }

            double doubleValor1 = Convert.ToDouble(textBoxNro1.Text);
            double doubleValor2 = Convert.ToDouble(textBoxNro2.Text);
            double resultado;

            switch (labelOperacao.Text)
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
            textBoxNro1.Visible = true;
            labelOperacao.Text = "+";
        }

        private void radioButtonSubtracao_CheckedChanged(object sender, EventArgs e)
        {

            labelOperacao.Text = "-";
        }

        private void radioButtonMultiplicacao_CheckedChanged(object sender, EventArgs e)
        {

            labelOperacao.Text = "*";
        }

        private void radioButtonDivisao_CheckedChanged(object sender, EventArgs e)
        {

            labelOperacao.Text = "/";
        }

        private void LimparTextBox2()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private bool ValidarForm2()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                labelErro2.Text = "O valor 1 eh obrigatorio.";
                textBox1.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                labelErro2.Text = "O valor 2 eh obrigatorio.";
                textBox2.Focus();
                return false;
            }

            try
            {
                double doubleValor3 = Convert.ToDouble(textBox1.Text);
                double doubleValor4 = Convert.ToDouble(textBox2.Text);

                return true;
            }
            catch
            {
                labelErro2.Text = "Insira somente numeros";
                LimparTextBox();
                textBox1.Focus();
                return false;
            }
        }

        private static double Somar2(double val3, double val4)
        {
            return val3 + val4;
        }

        private static double Subtrair2(double val3, double val4)
        {
            return val3 - val4;
        }

        private static double Multiplicar2(double val3, double val4)
        {
            return val3 * val4;
        }
        private static double Dividir2(double val3, double val4)
        {
            return val3 / val4;
        }

        private void buttonCalcular2_Click(object sender, EventArgs e)
        {
            textBoxResultado2.Clear();
            labelErro2.Text = "";

            if (!ValidarForm())
            {
                return;
            }

            double doubleValor3 = Convert.ToDouble(textBox1.Text);
            double doubleValor4 = Convert.ToDouble(textBox2.Text);
            double resultado;

            switch (comboBox1.Text)
            {
                case "+":
                    resultado = Somar(doubleValor3, doubleValor4);
                    break;
                case "-":
                    resultado = Subtrair(doubleValor3, doubleValor4);
                    break;
                case "*":
                    resultado = Multiplicar(doubleValor3, doubleValor4);
                    break;
                case "/":
                    resultado = Dividir(doubleValor3, doubleValor4);
                    break;
                default:
                    resultado = Somar(doubleValor3, doubleValor4);
                    break;
            }
        }

        private void buttonNovaCalculadora_Click(object sender, EventArgs e)
        {
          

       
        }
    }















}
