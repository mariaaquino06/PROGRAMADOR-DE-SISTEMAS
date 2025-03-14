﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora3
{
    public partial class NovoForm : Form
    {
        public NovoForm()
        {
            InitializeComponent();
        }

        private void comboBoxOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOpcao.SelectedItem == null)
            {
                labelErro.Text = "Selecione uma Opção";
                return;
            }

            if (comboBoxOpcao.SelectedItem.ToString() == "Quadrado")
            {
                groupBoxQuadrado.Visible = true;
                groupBoxRetangulo.Visible = false;
                groupBoxQuadrado.BringToFront();
                groupBoxRetangulo.SendToBack();
                return;
            }

            if (comboBoxOpcao.SelectedItem.ToString() == "Retângulo")
            {
                groupBoxQuadrado.Visible = false;
                groupBoxRetangulo.Visible = true;
                groupBoxQuadrado.SendToBack();
                groupBoxRetangulo.BringToFront();
                return;
            }
        }

        

       
    }
}
