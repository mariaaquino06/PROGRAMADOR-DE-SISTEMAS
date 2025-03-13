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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Quadrado", "Retângulo", "Cubo" });
            comboBox1.Location = new Point(202, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 33);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Forma Geométrica";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.White;
            comboBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Perímetro", "Área", "Volume" });
            comboBox2.Location = new Point(202, 225);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(191, 33);
            comboBox2.TabIndex = 2;
            comboBox2.Text = "Cálculo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(120, 22);
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
            label2.Location = new Point(234, 59);
            label2.Name = "label2";
            label2.Size = new Size(161, 15);
            label2.TabIndex = 4;
            label2.Text = "Quadrado, Retângulo e Cubo";
            // 
            // NovoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(673, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            ForeColor = SystemColors.Control;
            Name = "NovoForm";
            Text = "NovoForm";
            TransparencyKey = Color.Transparent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
    }
}