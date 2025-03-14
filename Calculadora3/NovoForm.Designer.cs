namespace Calculadora3
{
    partial class NovoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxOpcao = new ComboBox();
            textBoxLargura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxAltura = new TextBox();
            textBoxComprimento = new TextBox();
            textBoxResultado = new TextBox();
            labelLargura = new Label();
            labelAltura = new Label();
            labelComprimento = new Label();
            labelResultado = new Label();
            radioButtonVolume = new RadioButton();
            radioButtonArea = new RadioButton();
            radioButtonPerimetro = new RadioButton();
            labelErro = new Label();
            labelLado = new Label();
            textBoxLado = new TextBox();
            labelResultadoQuadrado = new Label();
            textBoxResultadoQuadrado = new TextBox();
            radioButtonPerimetroQuadrado = new RadioButton();
            radioButtonAreaQuadrado = new RadioButton();
            radioButtonVolumeQuadrado = new RadioButton();
            groupBoxQuadrado = new GroupBox();
            groupBoxRetangulo = new GroupBox();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            labelLarguraRet = new Label();
            radioButton2 = new RadioButton();
            textBox2 = new TextBox();
            radioButton3 = new RadioButton();
            label4 = new Label();
            buttonCalcQuadrado = new Button();
            groupBoxQuadrado.SuspendLayout();
            groupBoxRetangulo.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxOpcao
            // 
            comboBoxOpcao.BackColor = Color.White;
            comboBoxOpcao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxOpcao.FormattingEnabled = true;
            comboBoxOpcao.Items.AddRange(new object[] { "Quadrado", "Retângulo" });
            comboBoxOpcao.Location = new Point(12, 77);
            comboBoxOpcao.Name = "comboBoxOpcao";
            comboBoxOpcao.Size = new Size(191, 33);
            comboBoxOpcao.TabIndex = 0;
            comboBoxOpcao.Text = "Forma Geométrica";
            comboBoxOpcao.SelectedIndexChanged += comboBoxOpcao_SelectedIndexChanged;
            // 
            // textBoxLargura
            // 
            textBoxLargura.Location = new Point(103, 130);
            textBoxLargura.Name = "textBoxLargura";
            textBoxLargura.Size = new Size(116, 23);
            textBoxLargura.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(123, -1);
            label1.Name = "label1";
            label1.Size = new Size(447, 37);
            label1.TabIndex = 3;
            label1.Text = "Cálculo Perímetro, Área e Volume";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(234, 36);
            label2.Name = "label2";
            label2.Size = new Size(161, 15);
            label2.TabIndex = 4;
            label2.Text = "Quadrado, Retângulo e Cubo";
            // 
            // textBoxAltura
            // 
            textBoxAltura.Location = new Point(103, 164);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(116, 23);
            textBoxAltura.TabIndex = 5;
            // 
            // textBoxComprimento
            // 
            textBoxComprimento.Location = new Point(103, 196);
            textBoxComprimento.Name = "textBoxComprimento";
            textBoxComprimento.Size = new Size(116, 23);
            textBoxComprimento.TabIndex = 6;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(103, 229);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(116, 23);
            textBoxResultado.TabIndex = 7;
            // 
            // labelLargura
            // 
            labelLargura.AutoSize = true;
            labelLargura.ForeColor = SystemColors.ActiveCaptionText;
            labelLargura.Location = new Point(12, 138);
            labelLargura.Name = "labelLargura";
            labelLargura.Size = new Size(50, 15);
            labelLargura.TabIndex = 8;
            labelLargura.Text = "Largura:";
            // 
            // labelAltura
            // 
            labelAltura.AutoSize = true;
            labelAltura.ForeColor = SystemColors.ActiveCaptionText;
            labelAltura.Location = new Point(12, 167);
            labelAltura.Name = "labelAltura";
            labelAltura.Size = new Size(42, 15);
            labelAltura.TabIndex = 9;
            labelAltura.Text = "Altura:";
            // 
            // labelComprimento
            // 
            labelComprimento.AutoSize = true;
            labelComprimento.ForeColor = SystemColors.ActiveCaptionText;
            labelComprimento.Location = new Point(12, 200);
            labelComprimento.Name = "labelComprimento";
            labelComprimento.Size = new Size(85, 15);
            labelComprimento.TabIndex = 10;
            labelComprimento.Text = "Comprimento:";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.ForeColor = SystemColors.ActiveCaptionText;
            labelResultado.Location = new Point(12, 237);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(62, 15);
            labelResultado.TabIndex = 11;
            labelResultado.Text = "Resultado:";
            // 
            // radioButtonVolume
            // 
            radioButtonVolume.AutoSize = true;
            radioButtonVolume.ForeColor = SystemColors.ActiveCaptionText;
            radioButtonVolume.Location = new Point(243, 146);
            radioButtonVolume.Name = "radioButtonVolume";
            radioButtonVolume.Size = new Size(65, 19);
            radioButtonVolume.TabIndex = 12;
            radioButtonVolume.TabStop = true;
            radioButtonVolume.Text = "Volume";
            radioButtonVolume.UseVisualStyleBackColor = true;
            // 
            // radioButtonArea
            // 
            radioButtonArea.AutoSize = true;
            radioButtonArea.ForeColor = SystemColors.ActiveCaptionText;
            radioButtonArea.Location = new Point(243, 171);
            radioButtonArea.Name = "radioButtonArea";
            radioButtonArea.Size = new Size(49, 19);
            radioButtonArea.TabIndex = 13;
            radioButtonArea.TabStop = true;
            radioButtonArea.Text = "Área";
            radioButtonArea.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerimetro
            // 
            radioButtonPerimetro.AutoSize = true;
            radioButtonPerimetro.ForeColor = SystemColors.ActiveCaptionText;
            radioButtonPerimetro.Location = new Point(243, 196);
            radioButtonPerimetro.Name = "radioButtonPerimetro";
            radioButtonPerimetro.Size = new Size(77, 19);
            radioButtonPerimetro.TabIndex = 14;
            radioButtonPerimetro.TabStop = true;
            radioButtonPerimetro.Text = "Perímetro";
            radioButtonPerimetro.UseVisualStyleBackColor = true;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.ForeColor = SystemColors.ActiveCaptionText;
            labelErro.Location = new Point(15, 462);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(10, 15);
            labelErro.TabIndex = 15;
            labelErro.Text = ".";
            // 
            // labelLado
            // 
            labelLado.AutoSize = true;
            labelLado.ForeColor = SystemColors.ActiveCaptionText;
            labelLado.Location = new Point(5, 37);
            labelLado.Name = "labelLado";
            labelLado.Size = new Size(36, 15);
            labelLado.TabIndex = 17;
            labelLado.Text = "Lado:";
            // 
            // textBoxLado
            // 
            textBoxLado.Location = new Point(93, 34);
            textBoxLado.Name = "textBoxLado";
            textBoxLado.Size = new Size(116, 23);
            textBoxLado.TabIndex = 16;
            // 
            // labelResultadoQuadrado
            // 
            labelResultadoQuadrado.AutoSize = true;
            labelResultadoQuadrado.ForeColor = SystemColors.ActiveCaptionText;
            labelResultadoQuadrado.Location = new Point(2, 79);
            labelResultadoQuadrado.Name = "labelResultadoQuadrado";
            labelResultadoQuadrado.Size = new Size(62, 15);
            labelResultadoQuadrado.TabIndex = 19;
            labelResultadoQuadrado.Text = "Resultado:";
            // 
            // textBoxResultadoQuadrado
            // 
            textBoxResultadoQuadrado.Location = new Point(93, 71);
            textBoxResultadoQuadrado.Name = "textBoxResultadoQuadrado";
            textBoxResultadoQuadrado.Size = new Size(116, 23);
            textBoxResultadoQuadrado.TabIndex = 18;
            // 
            // radioButtonPerimetroQuadrado
            // 
            radioButtonPerimetroQuadrado.AutoSize = true;
            radioButtonPerimetroQuadrado.ForeColor = SystemColors.ActiveCaptionText;
            radioButtonPerimetroQuadrado.Location = new Point(215, 81);
            radioButtonPerimetroQuadrado.Name = "radioButtonPerimetroQuadrado";
            radioButtonPerimetroQuadrado.Size = new Size(77, 19);
            radioButtonPerimetroQuadrado.TabIndex = 22;
            radioButtonPerimetroQuadrado.TabStop = true;
            radioButtonPerimetroQuadrado.Text = "Perímetro";
            radioButtonPerimetroQuadrado.UseVisualStyleBackColor = true;
            // 
            // radioButtonAreaQuadrado
            // 
            radioButtonAreaQuadrado.AutoSize = true;
            radioButtonAreaQuadrado.ForeColor = SystemColors.ActiveCaptionText;
            radioButtonAreaQuadrado.Location = new Point(215, 56);
            radioButtonAreaQuadrado.Name = "radioButtonAreaQuadrado";
            radioButtonAreaQuadrado.Size = new Size(49, 19);
            radioButtonAreaQuadrado.TabIndex = 21;
            radioButtonAreaQuadrado.TabStop = true;
            radioButtonAreaQuadrado.Text = "Área";
            radioButtonAreaQuadrado.UseVisualStyleBackColor = true;
            // 
            // radioButtonVolumeQuadrado
            // 
            radioButtonVolumeQuadrado.AutoSize = true;
            radioButtonVolumeQuadrado.ForeColor = SystemColors.ActiveCaptionText;
            radioButtonVolumeQuadrado.Location = new Point(215, 31);
            radioButtonVolumeQuadrado.Name = "radioButtonVolumeQuadrado";
            radioButtonVolumeQuadrado.Size = new Size(65, 19);
            radioButtonVolumeQuadrado.TabIndex = 20;
            radioButtonVolumeQuadrado.TabStop = true;
            radioButtonVolumeQuadrado.Text = "Volume";
            radioButtonVolumeQuadrado.UseVisualStyleBackColor = true;
            // 
            // groupBoxQuadrado
            // 
            groupBoxQuadrado.Controls.Add(buttonCalcQuadrado);
            groupBoxQuadrado.Controls.Add(textBoxLado);
            groupBoxQuadrado.Controls.Add(radioButtonPerimetroQuadrado);
            groupBoxQuadrado.Controls.Add(labelLado);
            groupBoxQuadrado.Controls.Add(radioButtonAreaQuadrado);
            groupBoxQuadrado.Controls.Add(textBoxResultadoQuadrado);
            groupBoxQuadrado.Controls.Add(radioButtonVolumeQuadrado);
            groupBoxQuadrado.Controls.Add(labelResultadoQuadrado);
            groupBoxQuadrado.Location = new Point(353, 107);
            groupBoxQuadrado.Name = "groupBoxQuadrado";
            groupBoxQuadrado.Size = new Size(300, 161);
            groupBoxQuadrado.TabIndex = 23;
            groupBoxQuadrado.TabStop = false;
            groupBoxQuadrado.Text = "Quadrado";
            // 
            // groupBoxRetangulo
            // 
            groupBoxRetangulo.Controls.Add(textBox1);
            groupBoxRetangulo.Controls.Add(radioButton1);
            groupBoxRetangulo.Controls.Add(labelLarguraRet);
            groupBoxRetangulo.Controls.Add(radioButton2);
            groupBoxRetangulo.Controls.Add(textBox2);
            groupBoxRetangulo.Controls.Add(radioButton3);
            groupBoxRetangulo.Controls.Add(label4);
            groupBoxRetangulo.Location = new Point(353, 300);
            groupBoxRetangulo.Name = "groupBoxRetangulo";
            groupBoxRetangulo.Size = new Size(300, 161);
            groupBoxRetangulo.TabIndex = 24;
            groupBoxRetangulo.TabStop = false;
            groupBoxRetangulo.Text = "Retangulo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 16;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.ActiveCaptionText;
            radioButton1.Location = new Point(215, 81);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(77, 19);
            radioButton1.TabIndex = 22;
            radioButton1.TabStop = true;
            radioButton1.Text = "Perímetro";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelLarguraRet
            // 
            labelLarguraRet.AutoSize = true;
            labelLarguraRet.ForeColor = SystemColors.ActiveCaptionText;
            labelLarguraRet.Location = new Point(5, 37);
            labelLarguraRet.Name = "labelLarguraRet";
            labelLarguraRet.Size = new Size(47, 15);
            labelLarguraRet.TabIndex = 17;
            labelLarguraRet.Text = "Largura";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ActiveCaptionText;
            radioButton2.Location = new Point(215, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 19);
            radioButton2.TabIndex = 21;
            radioButton2.TabStop = true;
            radioButton2.Text = "Área";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(116, 23);
            textBox2.TabIndex = 18;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = SystemColors.ActiveCaptionText;
            radioButton3.Location = new Point(215, 31);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(65, 19);
            radioButton3.TabIndex = 20;
            radioButton3.TabStop = true;
            radioButton3.Text = "Volume";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(6, 79);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 19;
            label4.Text = "Altura";
            // 
            // buttonCalcQuadrado
            // 
            buttonCalcQuadrado.ForeColor = SystemColors.ActiveCaptionText;
            buttonCalcQuadrado.Location = new Point(112, 116);
            buttonCalcQuadrado.Name = "buttonCalcQuadrado";
            buttonCalcQuadrado.Size = new Size(75, 23);
            buttonCalcQuadrado.TabIndex = 23;
            buttonCalcQuadrado.Text = "Calcular";
            buttonCalcQuadrado.UseVisualStyleBackColor = true;
            // 
            // NovoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(806, 616);
            Controls.Add(groupBoxRetangulo);
            Controls.Add(groupBoxQuadrado);
            Controls.Add(labelErro);
            Controls.Add(radioButtonPerimetro);
            Controls.Add(radioButtonArea);
            Controls.Add(radioButtonVolume);
            Controls.Add(labelResultado);
            Controls.Add(labelComprimento);
            Controls.Add(labelAltura);
            Controls.Add(labelLargura);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxComprimento);
            Controls.Add(textBoxAltura);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxLargura);
            Controls.Add(comboBoxOpcao);
            ForeColor = SystemColors.Control;
            Name = "NovoForm";
            Text = "NovoForm";
            TransparencyKey = Color.White;
            groupBoxQuadrado.ResumeLayout(false);
            groupBoxQuadrado.PerformLayout();
            groupBoxRetangulo.ResumeLayout(false);
            groupBoxRetangulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxOpcao;
        private TextBox textBoxLargura;
        private Label label1;
        private Label label2;
        private TextBox textBoxAltura;
        private TextBox textBoxComprimento;
        private TextBox textBoxResultado;
        private Label labelLargura;
        private Label labelAltura;
        private Label labelComprimento;
        private Label labelResultado;
        private RadioButton radioButtonVolume;
        private RadioButton radioButtonArea;
        private RadioButton radioButtonPerimetro;
        private Label labelErro;
        private Label labelLado;
        private TextBox textBoxLado;
        private Label labelResultadoQuadrado;
        private TextBox textBoxResultadoQuadrado;
        private RadioButton radioButtonPerimetroQuadrado;
        private RadioButton radioButtonAreaQuadrado;
        private RadioButton radioButtonVolumeQuadrado;
        private GroupBox groupBoxQuadrado;
        private GroupBox groupBoxRetangulo;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private Label labelLarguraRet;
        private RadioButton radioButton2;
        private TextBox textBox2;
        private RadioButton radioButton3;
        private Label label4;
        private Button buttonCalcQuadrado;
    }
}