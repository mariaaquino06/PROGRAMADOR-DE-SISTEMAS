namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        private readonly BindingSource BindingSource = [];

        public Form1()
        {
            InitializeComponent();
            //primeira lista de clientes
            EnderecoCliente enderecoRayane = new EnderecoCliente() { logradouro = "Rua Brasil", numero = "1443", complemento = "Casa 02", bairro = "Jd. das Rosas", cidade = "S�o Pedro", estado = "SP", cep = "04899-002" };
            Cliente rayane = new Cliente() { id = 1, Nome = "Rayane Lima", datNasc = "26/05/2004", email = "ray.ane@email.com", telefone = "11 940028922", endereco = enderecoRayane, nomeSocial = "n�o se aplica", estrangeiro = false, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Preto, tipo = TipoCliente.PF };
            clientes.Add(rayane);

            EnderecoCliente enderecoMariaEduarda = new EnderecoCliente() { logradouro = "Rua Amador Bueno", numero = "89", complemento = "n�o se aplica", bairro = "�guia Branca", cidade = "S�o Paulo", estado = "SP", cep = "05831-000" };
            Cliente mariaEduarda = new Cliente() { id = 2, Nome = "Maria Eduarda", datNasc = "02/10/2006", email = "maria.aquino@email.com", telefone = "11 977737250", nomeSocial = "n�o se aplica", estrangeiro = true, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Branco, tipo = TipoCliente.PJ, endereco = enderecoMariaEduarda };
            clientes.Add(mariaEduarda);

            EnderecoCliente enderecoViviane = new EnderecoCliente() { logradouro = "Avenida Luiz Gushiken", numero = "1550", complemento = "Apto81", bairro = "Jd. S�o Luis", cidade = "S�o Paulo", estado = "SP", cep = "05923-111" };
            Cliente viviane = new Cliente() { id = 3, Nome = "Viviane Oliveira", datNasc = "18/03/1985", email = "vivi.oli@email.com", telefone = "11 980903357", endereco = enderecoViviane, nomeSocial = "n�o se aplica", estrangeiro = false, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Pardo, tipo = TipoCliente.PF };
            clientes.Add(viviane);

            BindingSource.DataSource = clientes;
            dataGridViewCliente.DataSource = BindingSource;
        }
        public bool LimparErro()
        {
            labelErro1.Text = "";
            return true;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string nomeCliente = textBoxNome.Text;
            string DataNascCliente = maskedTxtBoxNasc.Text;
            string telefoneCliente = maskedTxtBoxTelefone.Text;
            string emailCliente = textBoxEmail.Text;
            string logradouroCliente = textBoxLogradouro.Text;
            string numeroEnderecoCliente = textBoxNCasa.Text;
            string bairroCliente = textBoxBairro.Text;
            string municipioCliente = textBoxCidade.Text;
            string cepCliente = maskedTxtBoxCEP.Text;

            if (!LimparErro())
            {
                return;
            }

            //Validacao Campo Nome Completo
            if (string.IsNullOrEmpty(textBoxNome.Text))
            {
                labelErro1.Text = "O campo 'Nome Completo' � obrigat�rio!";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            if (nomeCliente.Any(char.IsNumber))
            {
                labelErro1.Text = "O Nome s� pode conter letras!";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Validacao Validacao Campo Data de Nascimento
            if (maskedTxtBoxNasc.Text == "  /  /" || DataNascCliente.Length < 10)
            {
                labelErro1.Text = "O Campo 'Data de Nascimento' � obrigat�rio";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Campo n� de Telefone
            if (telefoneCliente == "(  )      -" || telefoneCliente.Length < 15)
            {
                labelErro1.Text = "O Campo 'Telefone' � obrigat�rio";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Validacao Campo email
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                labelErro1.Text = "O Campo 'Email' � obrigat�rio";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            if (!emailCliente.EndsWith("@email.com"))
            {
                labelErro1.Text = "O Email deve conter @email.com!!!";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Validacao Campo genero
            if (string.IsNullOrEmpty(comboBoxGenero.Text))
            {
                labelErro1.Text = "O Campo 'G�nero' � obrigat�rio";
                labelErro1.ForeColor = Color.Red;
                return;
            }

            //Validacao Campo etnia
            if (string.IsNullOrEmpty(comboBoxEtnia.Text))
            {
                labelErro1.Text = "O Campo 'Etnia' � obrigat�rio";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Validacao Tipo de Cliente
            if (!radioButtonPF.Checked && !radioButtonPJ.Checked)
            {
                labelErro1.Text = "Selecione algum Tipo!!!";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Validacao Logradouro
            if (string.IsNullOrWhiteSpace(logradouroCliente))
            {
                labelErro2.Text = "O Logradouro � obrigatorio!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }

            //Validacao Numero
            if (string.IsNullOrWhiteSpace(numeroEnderecoCliente))
            {
                labelErro2.Text = "O Numero � obrigatorio!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }
            if (numeroEnderecoCliente.All(char.IsLetter))
            {
                labelErro2.Text = "O Numero n�o pode s� conter letras!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }

            //Validacao Bairro
            if (string.IsNullOrWhiteSpace(bairroCliente))
            {
                labelErro2.Text = "O Bairro � obrigatorio!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }
            if (bairroCliente.Any(char.IsNumber))
            {
                labelErro2.Text = "O Bairro n�o pode conter numeros!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }

            //Validacao Municipio
            if (string.IsNullOrWhiteSpace(municipioCliente))
            {
                labelErro2.Text = "O Munic�pio � obrigatorio!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }
            if (municipioCliente.Any(char.IsNumber))
            {
                labelErro2.Text = "O Munic�pio n�o pode conter numeros!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }

            //Validacao Estados
            if (comboBoxEstado.SelectedItem == null)
            {
                labelErro2.Text = "Selecione algum Estado!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }

            //Validacao CEP
            if (cepCliente == "     -" || cepCliente.Length < 9)
            {
                labelErro2.Text = "O CEP � obrigatorio!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }

            //Validacao p n ter cliente duplicado
            int ClienteCadastrado = -1;

            for (int i = 0; i < clientes.Count; i++)
            {
                if (emailCliente == clientes[i].email || telefoneCliente == clientes[i].telefone)
                {
                    ClienteCadastrado = i;
                }
            }
            if (ClienteCadastrado > -1)
            {
                labelErro2.Text = "J� existe um cliente cadastrado com esse e-mail e n� de telefone";
                labelErro2.ForeColor = Color.Red;
            }
            else
            {
                labelErro2.Text = "Cliente Cadastrado com Sucesso!";
                labelErro2.ForeColor = Color.Green;
            }

            //Add cliente comboBoxGenero
            GeneroCliente generoCliente;
            switch (comboBoxGenero.SelectedIndex)
            {
                case 0:
                    generoCliente = GeneroCliente.Feminino;
                    break;

                case 1:
                    generoCliente = GeneroCliente.Masculino;
                    break;

                case 2:
                    generoCliente = GeneroCliente.Trans;
                    break;

                case 3:
                    generoCliente = GeneroCliente.NaoBinario;
                    break;

                default:
                    generoCliente = GeneroCliente.Outros;
                    break;


            }

            //Add cliente novo comboBox Etnia
            EtniaCliente etnia;
            switch (comboBoxEtnia.SelectedIndex)
            {
                case 0:
                    etnia = EtniaCliente.Branco;
                    break;

                case 1:
                    etnia = EtniaCliente.Indigena;
                    break;

                case 2:
                    etnia = EtniaCliente.Pardo;
                    break;

                case 3:
                    etnia = EtniaCliente.Preto;
                    break;

                case 4:
                    etnia = EtniaCliente.Amarelo;
                    break;

                default:
                    etnia = EtniaCliente.Outros;
                    break;
            }

            //Add cliente radioButtonTipo
            TipoCliente tipoCliente;
            if (radioButtonPF.Checked)
            {
                tipoCliente = TipoCliente.PF;
            }
            else
            {
                tipoCliente = TipoCliente.PJ;
            }

            for (int i = 0; i < clientes.Count; i++)
            {
                if (emailCliente == clientes[i].email || telefoneCliente == clientes[i].telefone)
                {
                    ClienteCadastrado = i;
                }
            }
            if (ClienteCadastrado > -1)
            {
                labelErro2.Text = "J� existe um cliente cadastrado com esse e-mail e n� de telefone";
                labelErro2.ForeColor = Color.Red;
            }
            else
            {
                EnderecoCliente enderecoNovoCliente = new EnderecoCliente() { logradouro = textBoxLogradouro.Text, numero = textBoxNCasa.Text, complemento = textBoxComplemento.Text, bairro = textBoxBairro.Text, cidade = textBoxCidade.Text, estado = comboBoxEstado.Text, cep = maskedTxtBoxCEP.Text };
                clientes.Add(new Cliente() { id = clientes.ElementAt(clientes.Count - 1).id + 1, Nome = textBoxNome.Text, datNasc = maskedTxtBoxNasc.Text, email = textBoxEmail.Text, telefone = maskedTxtBoxTelefone.Text, genero = generoCliente, nomeSocial = textBoxNomeSocial.Text, etnia = etnia, estrangeiro = checkBoxNacionalidade.Checked, tipo = tipoCliente, endereco = enderecoNovoCliente });
                labelErro2.Text = "Cliente Cadastrado com Sucesso!";
                labelErro2.ForeColor = Color.Green;
                BindingSource.ResetBindings(false);
            }
            //Adicionar novo cliente^

        }

       
    }
}
