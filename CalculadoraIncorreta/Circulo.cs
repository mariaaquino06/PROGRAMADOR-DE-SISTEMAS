using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Circulo : Form
    {
        public Circulo()
        {
            InitializeComponent();
        }

        private bool ValidarForm()
        {
            labelErro.Text = "";
            return false;
            
        
        
        }

        private void comboBoxOpcao_Click(object sender, EventArgs e)
        {
            if (comboBoxOpcao.SelectedItem == null)
            {
                labelErro.Text = "Selecione um opção";
                return;
            }
            if (comboBoxOpcao.SelectedItem.ToString() == "Círculo")
            {
                groupBoxCirculo.Visible = true;
                groupBoxEsfera.Visible = false;
                groupBoxCirculo.BringToFront();
                groupBoxEsfera.SendToBack();
                return;
            }
            if (comboBoxOpcao.SelectedItem.ToString() == "Esfera")
            {
                groupBoxCirculo.Visible = false;
                groupBoxEsfera.Visible = true;
                groupBoxCirculo.SendToBack();
                groupBoxEsfera.BringToFront();
                return;
            }
        }
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (!radioButtonPerimetro.Checked && 
                !radioButtonDiametroC.Checked &&
                !radioButtonAreaC.Checked && 
                !radioButtonVolume.Checked)
                
            {
                labelErro.Text = "Selecione uma Opção";
                return;
            }
            string raio = textBoxRaioC.Text;

            if (string.IsNullOrEmpty(raio) || !raio.All(char.IsNumber))
            {
                labelErro.Text = "Insira um raio de um número válido";
                return;
            }

            double raioDoNumero = Convert.ToDouble(raio);
            double resultado;

            if (radioButtonDiametroC.Checked)
            {
                resultado = 2 * raioDoNumero;
                textBoxResultadoC.Text = Math.Round(resultado).ToString();
                return;

            }

            if (radioButtonPerimetro.Checked)
            {
                resultado = 2 * Math.PI * raioDoNumero;
                textBoxResultadoC.Text = Math.Round(resultado).ToString();
                return;
            }

            if (radioButtonAreaC.Checked)
            {
                resultado = Math.PI * Math.Pow(raioDoNumero, 2);
                textBoxResultadoC.Text = Math.Floor(resultado).ToString();
                return;
            }

            if (radioButtonVolume.Checked)
            {
                resultado = (4/3) * Math.PI*Math.Pow(raioDoNumero, 3);
                textBoxResultadoC.Text = Math.Floor(resultado).ToString();
            }
        }
    }
}
