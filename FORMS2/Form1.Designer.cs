namespace FORMS2
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
            CaixaTextUsuario = new TextBox();
            CaixaTextSenha = new TextBox();
            ButtonEntrar = new Button();
            labelUsuario = new Label();
            labelSenha = new Label();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // CaixaTextUsuario
            // 
            CaixaTextUsuario.Location = new Point(12, 34);
            CaixaTextUsuario.Name = "CaixaTextUsuario";
            CaixaTextUsuario.Size = new Size(182, 23);
            CaixaTextUsuario.TabIndex = 0;
            CaixaTextUsuario.TextChanged += CaixaTextUsuario_TextChanged;
            // 
            // CaixaTextSenha
            // 
            CaixaTextSenha.Location = new Point(12, 77);
            CaixaTextSenha.Name = "CaixaTextSenha";
            CaixaTextSenha.Size = new Size(182, 23);
            CaixaTextSenha.TabIndex = 2;
            // 
            // ButtonEntrar
            // 
            ButtonEntrar.BackColor = SystemColors.ControlLightLight;
            ButtonEntrar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonEntrar.Location = new Point(12, 115);
            ButtonEntrar.Name = "ButtonEntrar";
            ButtonEntrar.Size = new Size(86, 31);
            ButtonEntrar.TabIndex = 3;
            ButtonEntrar.Text = "Entrar";
            ButtonEntrar.UseVisualStyleBackColor = false;
            ButtonEntrar.Click += ButtonEntrar_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = SystemColors.ActiveCaptionText;
            labelUsuario.Location = new Point(12, 16);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(62, 15);
            labelUsuario.TabIndex = 4;
            labelUsuario.Text = "Usuário:\r\n";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSenha.ForeColor = SystemColors.ActiveCaptionText;
            labelSenha.Location = new Point(12, 59);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(52, 15);
            labelSenha.TabIndex = 5;
            labelSenha.Text = "Senha:";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(35, 149);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 6;
            labelResultado.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(325, 332);
            Controls.Add(labelResultado);
            Controls.Add(labelSenha);
            Controls.Add(labelUsuario);
            Controls.Add(ButtonEntrar);
            Controls.Add(CaixaTextSenha);
            Controls.Add(CaixaTextUsuario);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CaixaTextUsuario;
        private TextBox CaixaTextSenha;
        private Button ButtonEntrar;
        private Label labelUsuario;
        private Label labelSenha;
        private Label labelResultado;
    }
}
