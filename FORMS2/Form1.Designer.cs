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
            textBoxUser = new TextBox();
            textBoxSenha = new TextBox();
            buttonNewCadastro = new Button();
            labelNewUser = new Label();
            labelNewSenha = new Label();
            labelResultado2 = new Label();
            SuspendLayout();
            // 
            // CaixaTextUsuario
            // 
            CaixaTextUsuario.ForeColor = SystemColors.ActiveCaption;
            CaixaTextUsuario.Location = new Point(67, 39);
            CaixaTextUsuario.Name = "CaixaTextUsuario";
            CaixaTextUsuario.ScrollBars = ScrollBars.Both;
            CaixaTextUsuario.Size = new Size(182, 23);
            CaixaTextUsuario.TabIndex = 0;
            // 
            // CaixaTextSenha
            // 
            CaixaTextSenha.Location = new Point(67, 98);
            CaixaTextSenha.Name = "CaixaTextSenha";
            CaixaTextSenha.Size = new Size(182, 23);
            CaixaTextSenha.TabIndex = 2;
            // 
            // ButtonEntrar
            // 
            ButtonEntrar.BackColor = SystemColors.ControlLightLight;
            ButtonEntrar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonEntrar.Location = new Point(119, 127);
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
            labelUsuario.Location = new Point(119, 18);
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
            labelSenha.Location = new Point(129, 80);
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
            labelResultado.Location = new Point(67, 208);
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
            label1.Location = new Point(34, 169);
            label1.Name = "label1";
            label1.Size = new Size(269, 14);
            label1.TabIndex = 7;
            label1.Text = "É novo por aqui? Cadastre-se clicando no campo ao lado";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(594, 39);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(176, 23);
            textBoxUser.TabIndex = 9;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(594, 98);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(176, 23);
            textBoxSenha.TabIndex = 10;
            // 
            // buttonNewCadastro
            // 
            buttonNewCadastro.BackColor = SystemColors.ControlLightLight;
            buttonNewCadastro.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNewCadastro.Location = new Point(623, 127);
            buttonNewCadastro.Name = "buttonNewCadastro";
            buttonNewCadastro.Size = new Size(103, 31);
            buttonNewCadastro.TabIndex = 11;
            buttonNewCadastro.Text = "Cadastre-se";
            buttonNewCadastro.UseVisualStyleBackColor = false;
            buttonNewCadastro.Click += buttonNewCadastro_Click;
            // 
            // labelNewUser
            // 
            labelNewUser.AutoSize = true;
            labelNewUser.BackColor = Color.Transparent;
            labelNewUser.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewUser.ForeColor = SystemColors.ButtonHighlight;
            labelNewUser.Location = new Point(632, 18);
            labelNewUser.Name = "labelNewUser";
            labelNewUser.Size = new Size(94, 15);
            labelNewUser.TabIndex = 12;
            labelNewUser.Text = "Novo Usuário";
            // 
            // labelNewSenha
            // 
            labelNewSenha.AutoSize = true;
            labelNewSenha.BackColor = Color.Transparent;
            labelNewSenha.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNewSenha.ForeColor = SystemColors.ButtonHighlight;
            labelNewSenha.Location = new Point(632, 80);
            labelNewSenha.Name = "labelNewSenha";
            labelNewSenha.Size = new Size(93, 15);
            labelNewSenha.TabIndex = 13;
            labelNewSenha.Text = "Defina Senha";
            // 
            // labelResultado2
            // 
            labelResultado2.AutoSize = true;
            labelResultado2.BackColor = Color.Transparent;
            labelResultado2.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelResultado2.ForeColor = SystemColors.ButtonHighlight;
            labelResultado2.Location = new Point(568, 208);
            labelResultado2.Name = "labelResultado2";
            labelResultado2.Size = new Size(14, 18);
            labelResultado2.TabIndex = 14;
            labelResultado2.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1054, 498);
            Controls.Add(labelResultado2);
            Controls.Add(labelNewSenha);
            Controls.Add(labelNewUser);
            Controls.Add(buttonNewCadastro);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUser);
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
        private TextBox textBoxUser;
        private TextBox textBoxSenha;
        private Button buttonNewCadastro;
        private Label labelNewUser;
        private Label labelNewSenha;
        private Label labelResultado2;
    }
}
