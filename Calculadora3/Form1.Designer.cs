namespace Calculadora3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCalcular = new Button();
            textBox1 = new TextBox();
            textBoxResultado = new TextBox();
            textBox2 = new TextBox();
            labelOperador = new Label();
            labelIgual = new Label();
            radioButtonSoma = new RadioButton();
            radioButtonDivisão = new RadioButton();
            radioButtonMultiplicação = new RadioButton();
            radioButtonSubtracao = new RadioButton();
            labelErro = new Label();
            buttonNovoForm = new Button();
            SuspendLayout();
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(56, 12);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 0;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(48, 23);
            textBox1.TabIndex = 1;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(172, 58);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(48, 23);
            textBoxResultado.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(48, 23);
            textBox2.TabIndex = 3;
            // 
            // labelOperador
            // 
            labelOperador.AutoSize = true;
            labelOperador.Location = new Point(68, 61);
            labelOperador.Name = "labelOperador";
            labelOperador.Size = new Size(15, 15);
            labelOperador.TabIndex = 4;
            labelOperador.Text = "+";
            // 
            // labelIgual
            // 
            labelIgual.AutoSize = true;
            labelIgual.Location = new Point(151, 61);
            labelIgual.Name = "labelIgual";
            labelIgual.Size = new Size(15, 15);
            labelIgual.TabIndex = 5;
            labelIgual.Text = "=";
            // 
            // radioButtonSoma
            // 
            radioButtonSoma.AutoSize = true;
            radioButtonSoma.Location = new Point(14, 102);
            radioButtonSoma.Name = "radioButtonSoma";
            radioButtonSoma.Size = new Size(55, 19);
            radioButtonSoma.TabIndex = 6;
            radioButtonSoma.TabStop = true;
            radioButtonSoma.Text = "Soma";
            radioButtonSoma.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivisão
            // 
            radioButtonDivisão.AutoSize = true;
            radioButtonDivisão.Location = new Point(14, 177);
            radioButtonDivisão.Name = "radioButtonDivisão";
            radioButtonDivisão.Size = new Size(63, 19);
            radioButtonDivisão.TabIndex = 7;
            radioButtonDivisão.TabStop = true;
            radioButtonDivisão.Text = "Divisão";
            radioButtonDivisão.UseVisualStyleBackColor = true;
            // 
            // radioButtonMultiplicação
            // 
            radioButtonMultiplicação.AutoSize = true;
            radioButtonMultiplicação.Location = new Point(14, 152);
            radioButtonMultiplicação.Name = "radioButtonMultiplicação";
            radioButtonMultiplicação.Size = new Size(97, 19);
            radioButtonMultiplicação.TabIndex = 8;
            radioButtonMultiplicação.TabStop = true;
            radioButtonMultiplicação.Text = "Multiplicação";
            radioButtonMultiplicação.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubtracao
            // 
            radioButtonSubtracao.AutoSize = true;
            radioButtonSubtracao.Location = new Point(14, 127);
            radioButtonSubtracao.Name = "radioButtonSubtracao";
            radioButtonSubtracao.Size = new Size(78, 19);
            radioButtonSubtracao.TabIndex = 9;
            radioButtonSubtracao.TabStop = true;
            radioButtonSubtracao.Text = "Subtração";
            radioButtonSubtracao.UseVisualStyleBackColor = true;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(14, 210);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(10, 15);
            labelErro.TabIndex = 10;
            labelErro.Text = ".";
            // 
            // buttonNovoForm
            // 
            buttonNovoForm.Location = new Point(246, 260);
            buttonNovoForm.Name = "buttonNovoForm";
            buttonNovoForm.Size = new Size(75, 23);
            buttonNovoForm.TabIndex = 11;
            buttonNovoForm.Text = "Novo Form";
            buttonNovoForm.UseVisualStyleBackColor = true;
            buttonNovoForm.Click += buttonNovoForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonNovoForm);
            Controls.Add(labelErro);
            Controls.Add(radioButtonSubtracao);
            Controls.Add(radioButtonMultiplicação);
            Controls.Add(radioButtonDivisão);
            Controls.Add(radioButtonSoma);
            Controls.Add(labelIgual);
            Controls.Add(labelOperador);
            Controls.Add(textBox2);
            Controls.Add(textBoxResultado);
            Controls.Add(textBox1);
            Controls.Add(buttonCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalcular;
        private TextBox textBox1;
        private TextBox textBoxResultado;
        private TextBox textBox2;
        private Label labelOperador;
        private Label labelIgual;
        private RadioButton radioButtonSoma;
        private RadioButton radioButtonDivisão;
        private RadioButton radioButtonMultiplicação;
        private RadioButton radioButtonSubtracao;
        private Label labelErro;
        private Button buttonNovoForm;
    }
}
