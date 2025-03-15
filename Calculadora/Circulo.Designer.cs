namespace Calculadora
{
    partial class Circulo
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
            groupBoxCirculo = new GroupBox();
            buttonCalcular = new Button();
            radioButtonPerimetro = new RadioButton();
            labelResultadoC = new Label();
            labelRaioC = new Label();
            textBoxResultadoC = new TextBox();
            textBoxRaioC = new TextBox();
            radioButtonAreaC = new RadioButton();
            radioButtonDiametroC = new RadioButton();
            groupBoxEsfera = new GroupBox();
            comboBoxOpcao = new ComboBox();
            labelErro = new Label();
            radioButtonVolume = new RadioButton();
            groupBoxCirculo.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCirculo
            // 
            groupBoxCirculo.Controls.Add(radioButtonVolume);
            groupBoxCirculo.Controls.Add(buttonCalcular);
            groupBoxCirculo.Controls.Add(radioButtonPerimetro);
            groupBoxCirculo.Controls.Add(labelResultadoC);
            groupBoxCirculo.Controls.Add(labelRaioC);
            groupBoxCirculo.Controls.Add(textBoxResultadoC);
            groupBoxCirculo.Controls.Add(textBoxRaioC);
            groupBoxCirculo.Controls.Add(radioButtonAreaC);
            groupBoxCirculo.Controls.Add(radioButtonDiametroC);
            groupBoxCirculo.Location = new Point(12, 81);
            groupBoxCirculo.Name = "groupBoxCirculo";
            groupBoxCirculo.Size = new Size(369, 162);
            groupBoxCirculo.TabIndex = 0;
            groupBoxCirculo.TabStop = false;
            groupBoxCirculo.Text = "groupBox Círculo";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(294, 6);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 7;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // radioButtonPerimetro
            // 
            radioButtonPerimetro.AutoSize = true;
            radioButtonPerimetro.Location = new Point(238, 85);
            radioButtonPerimetro.Name = "radioButtonPerimetro";
            radioButtonPerimetro.Size = new Size(77, 19);
            radioButtonPerimetro.TabIndex = 6;
            radioButtonPerimetro.TabStop = true;
            radioButtonPerimetro.Text = "Perímetro";
            radioButtonPerimetro.UseVisualStyleBackColor = true;
            // 
            // labelResultadoC
            // 
            labelResultadoC.AutoSize = true;
            labelResultadoC.Location = new Point(6, 68);
            labelResultadoC.Name = "labelResultadoC";
            labelResultadoC.Size = new Size(62, 15);
            labelResultadoC.TabIndex = 5;
            labelResultadoC.Text = "Resultado:";
            // 
            // labelRaioC
            // 
            labelRaioC.AutoSize = true;
            labelRaioC.Location = new Point(5, 31);
            labelRaioC.Name = "labelRaioC";
            labelRaioC.Size = new Size(33, 15);
            labelRaioC.TabIndex = 4;
            labelRaioC.Text = "Raio:";
            // 
            // textBoxResultadoC
            // 
            textBoxResultadoC.Location = new Point(95, 68);
            textBoxResultadoC.Name = "textBoxResultadoC";
            textBoxResultadoC.Size = new Size(100, 23);
            textBoxResultadoC.TabIndex = 3;
            // 
            // textBoxRaioC
            // 
            textBoxRaioC.Location = new Point(95, 31);
            textBoxRaioC.Name = "textBoxRaioC";
            textBoxRaioC.Size = new Size(100, 23);
            textBoxRaioC.TabIndex = 2;
            // 
            // radioButtonAreaC
            // 
            radioButtonAreaC.AutoSize = true;
            radioButtonAreaC.Location = new Point(238, 35);
            radioButtonAreaC.Name = "radioButtonAreaC";
            radioButtonAreaC.Size = new Size(49, 19);
            radioButtonAreaC.TabIndex = 1;
            radioButtonAreaC.TabStop = true;
            radioButtonAreaC.Text = "Área";
            radioButtonAreaC.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiametroC
            // 
            radioButtonDiametroC.AutoSize = true;
            radioButtonDiametroC.Location = new Point(238, 60);
            radioButtonDiametroC.Name = "radioButtonDiametroC";
            radioButtonDiametroC.Size = new Size(74, 19);
            radioButtonDiametroC.TabIndex = 0;
            radioButtonDiametroC.TabStop = true;
            radioButtonDiametroC.Text = "Diâmetro";
            radioButtonDiametroC.UseVisualStyleBackColor = true;
            // 
            // groupBoxEsfera
            // 
            groupBoxEsfera.Location = new Point(12, 270);
            groupBoxEsfera.Name = "groupBoxEsfera";
            groupBoxEsfera.Size = new Size(369, 168);
            groupBoxEsfera.TabIndex = 1;
            groupBoxEsfera.TabStop = false;
            groupBoxEsfera.Text = "groupBox Esfera";
            // 
            // comboBoxOpcao
            // 
            comboBoxOpcao.FormattingEnabled = true;
            comboBoxOpcao.Items.AddRange(new object[] { "Círculo", "Esfera" });
            comboBoxOpcao.Location = new Point(12, 25);
            comboBoxOpcao.Name = "comboBoxOpcao";
            comboBoxOpcao.Size = new Size(121, 23);
            comboBoxOpcao.TabIndex = 2;
            comboBoxOpcao.SelectedIndexChanged += comboBoxOpcao_Click;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(200, 31);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(10, 15);
            labelErro.TabIndex = 3;
            labelErro.Text = ".";
            // 
            // radioButtonVolume
            // 
            radioButtonVolume.AutoSize = true;
            radioButtonVolume.Location = new Point(238, 110);
            radioButtonVolume.Name = "radioButtonVolume";
            radioButtonVolume.Size = new Size(65, 19);
            radioButtonVolume.TabIndex = 8;
            radioButtonVolume.TabStop = true;
            radioButtonVolume.Text = "Volume";
            radioButtonVolume.UseVisualStyleBackColor = true;
            // 
            // Circulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelErro);
            Controls.Add(comboBoxOpcao);
            Controls.Add(groupBoxEsfera);
            Controls.Add(groupBoxCirculo);
            Name = "Circulo";
            Text = "Form1";
            groupBoxCirculo.ResumeLayout(false);
            groupBoxCirculo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCirculo;
        private GroupBox groupBoxEsfera;
        private ComboBox comboBoxOpcao;
        private RadioButton radioButtonAreaC;
        private RadioButton radioButtonDiametroC;
        private Label labelResultadoC;
        private Label labelRaioC;
        private TextBox textBoxResultadoC;
        private TextBox textBoxRaioC;
        private Label labelErro;
        private RadioButton radioButtonPerimetro;
        private Button buttonCalcular;
        private RadioButton radioButtonVolume;
    }
}