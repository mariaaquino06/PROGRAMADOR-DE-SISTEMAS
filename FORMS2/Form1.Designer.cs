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
            label1 = new Label();
            buttonCadastro = new Button();
            SuspendLayout();
            // 
            // CaixaTextUsuario
            // 
            CaixaTextUsuario.Location = new Point(397, 82);
            CaixaTextUsuario.Name = "CaixaTextUsuario";
            CaixaTextUsuario.Size = new Size(182, 23);
            CaixaTextUsuario.TabIndex = 0;
            // 
            // CaixaTextSenha
            // 
            CaixaTextSenha.Location = new Point(397, 141);
            CaixaTextSenha.Name = "CaixaTextSenha";
            CaixaTextSenha.Size = new Size(182, 23);
            CaixaTextSenha.TabIndex = 2;
            // 
            // ButtonEntrar
            // 
            ButtonEntrar.BackColor = SystemColors.ControlLightLight;
            ButtonEntrar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonEntrar.Location = new Point(449, 170);
            ButtonEntrar.Name = "ButtonEntrar";
            ButtonEntrar.Size = new Size(71, 31);
            ButtonEntrar.TabIndex = 3;
            ButtonEntrar.Text = "Entrar";
            ButtonEntrar.UseVisualStyleBackColor = false;
            ButtonEntrar.Click += ButtonEntrar_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.BackColor = Color.Transparent;
            labelUsuario.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = SystemColors.ButtonHighlight;
            labelUsuario.Location = new Point(449, 61);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(62, 15);
            labelUsuario.TabIndex = 4;
            labelUsuario.Text = "Usuário:\r\n";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.BackColor = Color.Transparent;
            labelSenha.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSenha.ForeColor = SystemColors.ButtonHighlight;
            labelSenha.Location = new Point(459, 123);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(52, 15);
            labelSenha.TabIndex = 5;
            labelSenha.Text = "Senha:";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.BackColor = Color.Transparent;
            labelResultado.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelResultado.ForeColor = SystemColors.ButtonHighlight;
            labelResultado.Location = new Point(397, 275);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(14, 18);
            labelResultado.TabIndex = 6;
            labelResultado.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(364, 212);
            label1.Name = "label1";
            label1.Size = new Size(261, 14);
            label1.TabIndex = 7;
            label1.Text = "É novo por aqui? Cadastre-se clicando no botão abaixo";
            // 
            // buttonCadastro
            // 
            buttonCadastro.BackColor = SystemColors.ControlLightLight;
            buttonCadastro.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastro.Location = new Point(436, 229);
            buttonCadastro.Name = "buttonCadastro";
            buttonCadastro.Size = new Size(103, 31);
            buttonCadastro.TabIndex = 8;
            buttonCadastro.Text = "Cadastre-se";
            buttonCadastro.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1054, 498);
            Controls.Add(buttonCadastro);
            Controls.Add(label1);
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
        private Label label1;
        private Button buttonCadastro;
    }
}
