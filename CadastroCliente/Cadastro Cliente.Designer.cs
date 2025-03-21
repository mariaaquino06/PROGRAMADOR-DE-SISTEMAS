namespace CadastroCliente
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
            labelCadastrese = new Label();
            labelNome = new Label();
            textBoxNome = new TextBox();
            labelDataNascimento = new Label();
            maskedTxtBoxNasc = new MaskedTextBox();
            maskedTxtBoxTelefone = new MaskedTextBox();
            labelTelefone = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            labelGenero = new Label();
            comboBoxGenero = new ComboBox();
            textBoxNomeSocial = new TextBox();
            labelNomeSoc = new Label();
            comboBoxEtnia = new ComboBox();
            labelEtnia = new Label();
            labelEstrangeiro = new Label();
            checkBoxNacionalidade = new CheckBox();
            labelEstrang = new Label();
            labelTipo = new Label();
            radioButtonPF = new RadioButton();
            radioButtonPJ = new RadioButton();
            labelDadosP = new Label();
            labelEnd = new Label();
            textBoxComplemento = new TextBox();
            labelBairro = new Label();
            textBoxBairro = new TextBox();
            labelNumeroCasa = new Label();
            textBoxCidade = new TextBox();
            labelCidade = new Label();
            textBoxNCasa = new TextBox();
            labelComplemento = new Label();
            textBoxLogradouro = new TextBox();
            labelLogradouro = new Label();
            labelEstado = new Label();
            comboBoxEstado = new ComboBox();
            labelCEP = new Label();
            maskedTxtBoxCEP = new MaskedTextBox();
            labelErro1 = new Label();
            labelErro2 = new Label();
            buttonCadastrar = new Button();
            pictureBox1 = new PictureBox();
            dataGridViewCliente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).BeginInit();
            SuspendLayout();
            // 
            // labelCadastrese
            // 
            labelCadastrese.AutoSize = true;
            labelCadastrese.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCadastrese.Location = new Point(104, 35);
            labelCadastrese.Name = "labelCadastrese";
            labelCadastrese.Size = new Size(139, 40);
            labelCadastrese.TabIndex = 0;
            labelCadastrese.Text = "Cadastro";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(12, 168);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(101, 15);
            labelNome.TabIndex = 1;
            labelNome.Text = "Nome Completo:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(15, 186);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(205, 23);
            textBoxNome.TabIndex = 2;
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDataNascimento.Location = new Point(12, 216);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.RightToLeft = RightToLeft.No;
            labelDataNascimento.Size = new Size(122, 15);
            labelDataNascimento.TabIndex = 3;
            labelDataNascimento.Text = "Data de Nascimento:";
            // 
            // maskedTxtBoxNasc
            // 
            maskedTxtBoxNasc.Location = new Point(15, 234);
            maskedTxtBoxNasc.Mask = "00/00/0000";
            maskedTxtBoxNasc.Name = "maskedTxtBoxNasc";
            maskedTxtBoxNasc.Size = new Size(76, 23);
            maskedTxtBoxNasc.TabIndex = 4;
            maskedTxtBoxNasc.ValidatingType = typeof(DateTime);
            // 
            // maskedTxtBoxTelefone
            // 
            maskedTxtBoxTelefone.Location = new Point(15, 285);
            maskedTxtBoxTelefone.Mask = "(00) 00000-0000";
            maskedTxtBoxTelefone.Name = "maskedTxtBoxTelefone";
            maskedTxtBoxTelefone.Size = new Size(90, 23);
            maskedTxtBoxTelefone.TabIndex = 6;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTelefone.Location = new Point(12, 267);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.RightToLeft = RightToLeft.No;
            labelTelefone.Size = new Size(59, 15);
            labelTelefone.TabIndex = 5;
            labelTelefone.Text = "Telefone:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(15, 331);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(205, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(15, 313);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "E-mail:";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGenero.Location = new Point(15, 357);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(52, 15);
            labelGenero.TabIndex = 9;
            labelGenero.Text = "Gênero:";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Feminino", "Masculino", "Trans", "Não Binário", "Outros" });
            comboBoxGenero.Location = new Point(15, 375);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(205, 23);
            comboBoxGenero.TabIndex = 10;
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(15, 425);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(205, 23);
            textBoxNomeSocial.TabIndex = 12;
            // 
            // labelNomeSoc
            // 
            labelNomeSoc.AutoSize = true;
            labelNomeSoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNomeSoc.Location = new Point(12, 407);
            labelNomeSoc.Name = "labelNomeSoc";
            labelNomeSoc.Size = new Size(79, 15);
            labelNomeSoc.TabIndex = 11;
            labelNomeSoc.Text = "Nome Social:";
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Items.AddRange(new object[] { "Branco", "Preto", "Pardo", "Amarelo", "Indigena ", "Outros" });
            comboBoxEtnia.Location = new Point(15, 469);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(205, 23);
            comboBoxEtnia.TabIndex = 14;
            // 
            // labelEtnia
            // 
            labelEtnia.AutoSize = true;
            labelEtnia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEtnia.Location = new Point(15, 451);
            labelEtnia.Name = "labelEtnia";
            labelEtnia.Size = new Size(37, 15);
            labelEtnia.TabIndex = 13;
            labelEtnia.Text = "Etnia:";
            // 
            // labelEstrangeiro
            // 
            labelEstrangeiro.AutoSize = true;
            labelEstrangeiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstrangeiro.Location = new Point(15, 495);
            labelEstrangeiro.Name = "labelEstrangeiro";
            labelEstrangeiro.Size = new Size(73, 15);
            labelEstrangeiro.TabIndex = 15;
            labelEstrangeiro.Text = "Estrangeiro:";
            // 
            // checkBoxNacionalidade
            // 
            checkBoxNacionalidade.AutoSize = true;
            checkBoxNacionalidade.Location = new Point(18, 514);
            checkBoxNacionalidade.Name = "checkBoxNacionalidade";
            checkBoxNacionalidade.Size = new Size(46, 19);
            checkBoxNacionalidade.TabIndex = 16;
            checkBoxNacionalidade.Text = "Sim";
            checkBoxNacionalidade.UseVisualStyleBackColor = true;
            // 
            // labelEstrang
            // 
            labelEstrang.AutoSize = true;
            labelEstrang.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelEstrang.Location = new Point(70, 518);
            labelEstrang.Name = "labelEstrang";
            labelEstrang.Size = new Size(200, 15);
            labelEstrang.TabIndex = 17;
            labelEstrang.Text = "*Caso não, apenas deixe em Branco";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTipo.Location = new Point(12, 542);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(93, 15);
            labelTipo.TabIndex = 18;
            labelTipo.Text = "Tipo de Cliente:";
            // 
            // radioButtonPF
            // 
            radioButtonPF.AutoSize = true;
            radioButtonPF.Location = new Point(17, 560);
            radioButtonPF.Name = "radioButtonPF";
            radioButtonPF.Size = new Size(93, 19);
            radioButtonPF.TabIndex = 19;
            radioButtonPF.TabStop = true;
            radioButtonPF.Text = "Pessoa Física";
            radioButtonPF.UseVisualStyleBackColor = true;
            // 
            // radioButtonPJ
            // 
            radioButtonPJ.AutoSize = true;
            radioButtonPJ.Location = new Point(116, 560);
            radioButtonPJ.Name = "radioButtonPJ";
            radioButtonPJ.Size = new Size(104, 19);
            radioButtonPJ.TabIndex = 20;
            radioButtonPJ.TabStop = true;
            radioButtonPJ.Text = "Pessoa Jurídica";
            radioButtonPJ.UseVisualStyleBackColor = true;
            // 
            // labelDadosP
            // 
            labelDadosP.AutoSize = true;
            labelDadosP.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDadosP.Location = new Point(12, 133);
            labelDadosP.Name = "labelDadosP";
            labelDadosP.Size = new Size(145, 25);
            labelDadosP.TabIndex = 21;
            labelDadosP.Text = "Dados Pessoais";
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEnd.Location = new Point(470, 133);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(95, 25);
            labelEnd.TabIndex = 22;
            labelEnd.Text = "Endereço";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(423, 285);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(205, 23);
            textBoxComplemento.TabIndex = 24;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBairro.Location = new Point(423, 313);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(44, 15);
            labelBairro.TabIndex = 23;
            labelBairro.Text = "Bairro:";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(423, 331);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(205, 23);
            textBoxBairro.TabIndex = 26;
            // 
            // labelNumeroCasa
            // 
            labelNumeroCasa.AutoSize = true;
            labelNumeroCasa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumeroCasa.Location = new Point(420, 216);
            labelNumeroCasa.Name = "labelNumeroCasa";
            labelNumeroCasa.Size = new Size(56, 15);
            labelNumeroCasa.TabIndex = 25;
            labelNumeroCasa.Text = "Número:";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(424, 376);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(205, 23);
            textBoxCidade.TabIndex = 28;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCidade.Location = new Point(424, 358);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(64, 15);
            labelCidade.TabIndex = 27;
            labelCidade.Text = "Município:";
            // 
            // textBoxNCasa
            // 
            textBoxNCasa.Location = new Point(423, 234);
            textBoxNCasa.Name = "textBoxNCasa";
            textBoxNCasa.Size = new Size(72, 23);
            textBoxNCasa.TabIndex = 30;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelComplemento.Location = new Point(423, 267);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(89, 15);
            labelComplemento.TabIndex = 29;
            labelComplemento.Text = "Complemento:";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(423, 186);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(205, 23);
            textBoxLogradouro.TabIndex = 32;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogradouro.Location = new Point(420, 168);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(207, 15);
            labelLogradouro.TabIndex = 31;
            labelLogradouro.Text = "Logradouro (Rua, Avenida, Estr. etc):";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEstado.Location = new Point(424, 407);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(46, 15);
            labelEstado.TabIndex = 33;
            labelEstado.Text = "Estado:";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            comboBoxEstado.Location = new Point(424, 425);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(124, 23);
            comboBoxEstado.TabIndex = 34;
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCEP.Location = new Point(424, 451);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(30, 15);
            labelCEP.TabIndex = 35;
            labelCEP.Text = "CEP:";
            // 
            // maskedTxtBoxCEP
            // 
            maskedTxtBoxCEP.Location = new Point(424, 469);
            maskedTxtBoxCEP.Mask = "00000-000";
            maskedTxtBoxCEP.Name = "maskedTxtBoxCEP";
            maskedTxtBoxCEP.Size = new Size(100, 23);
            maskedTxtBoxCEP.TabIndex = 36;
            // 
            // labelErro1
            // 
            labelErro1.AutoSize = true;
            labelErro1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErro1.Location = new Point(15, 603);
            labelErro1.Name = "labelErro1";
            labelErro1.Size = new Size(12, 17);
            labelErro1.TabIndex = 37;
            labelErro1.Text = ".";
            // 
            // labelErro2
            // 
            labelErro2.AutoSize = true;
            labelErro2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErro2.Location = new Point(420, 516);
            labelErro2.Name = "labelErro2";
            labelErro2.Size = new Size(12, 17);
            labelErro2.TabIndex = 38;
            labelErro2.Text = ".";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = Color.LightGray;
            buttonCadastrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCadastrar.Location = new Point(424, 579);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(106, 41);
            buttonCadastrar.TabIndex = 39;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imageUser;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewCliente
            // 
            dataGridViewCliente.AllowUserToAddRows = false;
            dataGridViewCliente.AllowUserToDeleteRows = false;
            dataGridViewCliente.AllowUserToOrderColumns = true;
            dataGridViewCliente.AllowUserToResizeRows = false;
            dataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCliente.Location = new Point(941, 168);
            dataGridViewCliente.MultiSelect = false;
            dataGridViewCliente.Name = "dataGridViewCliente";
            dataGridViewCliente.ReadOnly = true;
            dataGridViewCliente.Size = new Size(520, 269);
            dataGridViewCliente.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1531, 664);
            Controls.Add(dataGridViewCliente);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCadastrar);
            Controls.Add(labelErro2);
            Controls.Add(labelErro1);
            Controls.Add(maskedTxtBoxCEP);
            Controls.Add(labelCEP);
            Controls.Add(comboBoxEstado);
            Controls.Add(labelEstado);
            Controls.Add(textBoxLogradouro);
            Controls.Add(labelLogradouro);
            Controls.Add(textBoxNCasa);
            Controls.Add(labelComplemento);
            Controls.Add(textBoxCidade);
            Controls.Add(labelCidade);
            Controls.Add(textBoxBairro);
            Controls.Add(labelNumeroCasa);
            Controls.Add(textBoxComplemento);
            Controls.Add(labelBairro);
            Controls.Add(labelEnd);
            Controls.Add(labelDadosP);
            Controls.Add(radioButtonPJ);
            Controls.Add(radioButtonPF);
            Controls.Add(labelTipo);
            Controls.Add(labelEstrang);
            Controls.Add(checkBoxNacionalidade);
            Controls.Add(labelEstrangeiro);
            Controls.Add(comboBoxEtnia);
            Controls.Add(labelEtnia);
            Controls.Add(textBoxNomeSocial);
            Controls.Add(labelNomeSoc);
            Controls.Add(comboBoxGenero);
            Controls.Add(labelGenero);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(maskedTxtBoxTelefone);
            Controls.Add(labelTelefone);
            Controls.Add(maskedTxtBoxNasc);
            Controls.Add(labelDataNascimento);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(labelCadastrese);
            Name = "Form1";
            Text = "Cadastro Cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCadastrese;
        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelDataNascimento;
        private MaskedTextBox maskedTxtBoxNasc;
        private MaskedTextBox maskedTxtBoxTelefone;
        private Label labelTelefone;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private Label labelGenero;
        private ComboBox comboBoxGenero;
        private TextBox textBoxNomeSocial;
        private Label labelNomeSoc;
        private ComboBox comboBoxEtnia;
        private Label labelEtnia;
        private Label labelEstrangeiro;
        private CheckBox checkBoxNacionalidade;
        private Label labelEstrang;
        private Label labelTipo;
        private RadioButton radioButtonPF;
        private RadioButton radioButtonPJ;
        private Label labelDadosP;
        private Label labelEnd;
        private TextBox textBoxComplemento;
        private Label labelBairro;
        private TextBox textBoxBairro;
        private Label labelNumeroCasa;
        private TextBox textBoxCidade;
        private Label labelCidade;
        private TextBox textBoxNCasa;
        private Label labelComplemento;
        private TextBox textBoxLogradouro;
        private Label labelLogradouro;
        private Label labelEstado;
        private ComboBox comboBoxEstado;
        private Label labelCEP;
        private MaskedTextBox maskedTxtBoxCEP;
        private Label labelErro1;
        private Label labelErro2;
        private Button buttonCadastrar;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewCliente;
    }
}
