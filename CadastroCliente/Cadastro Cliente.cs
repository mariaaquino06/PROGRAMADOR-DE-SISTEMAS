namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        private readonly BindingSource BindingSource = [];

        public Form1()
        {
            InitializeComponent();

            EnderecoCliente enderecoRayane = new EnderecoCliente() { logradouro = "Rua Brasil", numero = "1443", complemento = "Casa 02", bairro = "Jd. das Rosas", cidade = "São Pedro", estado = "SP", cep = "04899-002" };
            Cliente rayane = new Cliente() { id = 1, Nome = "Rayane Lima", datNasc = "26/05/2004", email = "ray.ane@email.com", telefone = "11 940028922", endereco = enderecoRayane, nomeSocial = "não se aplica", estrangeiro = false, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Preto, tipo = TipoCliente.PF };
            clientes.Add(rayane);

            EnderecoCliente enderecoMariaEduarda = new EnderecoCliente() { logradouro = "Rua Amador Bueno", numero = "89", complemento = "não se aplica", bairro = "Águia Branca", cidade = "São Paulo", estado = "SP", cep = "05831-000" };
            Cliente mariaEduarda = new Cliente() { id = 2, Nome = "Maria Eduarda", datNasc = "02/10/2006", email = "maria.aquino@email.com", telefone = "11 977737250", endereco = enderecoMariaEduarda, nomeSocial = "não se aplica", estrangeiro = true, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Branco, tipo = TipoCliente.PJ };
            clientes.Add(mariaEduarda);

            EnderecoCliente enderecoViviane = new EnderecoCliente() { logradouro = "Avenida Luiz Gushiken", numero = "1550", complemento = "Apto81", bairro = "Jd. São Luis", cidade = "São Paulo", estado = "SP", cep = "05923-111" };
            Cliente viviane = new Cliente() { id = 3, Nome = "Viviane Oliveira", datNasc = "18/03/1985", email = "vivi.oli@email.com", telefone = "11 980903357", endereco = enderecoViviane, nomeSocial = "não se aplica", estrangeiro = false, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Pardo, tipo = TipoCliente.PF };
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

            //Campo Nome Completo
            if (string.IsNullOrEmpty(textBoxNome.Text))
            {
                labelErro1.Text = "O campo 'Nome Completo' é obrigatório!";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            if (nomeCliente.Any(char.IsNumber))
            {
                labelErro1.Text = "O Nome só pode conter letras!";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Campo Data de Nascimento
            if (maskedTxtBoxNasc.Text == "  /  /" || DataNascCliente.Length < 10)
            {
                labelErro1.Text = "O Campo 'Data de Nascimento' é obrigatório";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Campo nº de Telefone
            if (telefoneCliente == "(  )      -" || telefoneCliente.Length < 15)
            {
                labelErro1.Text = "O Campo 'Telefone' é obrigatório";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Campo email
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                labelErro1.Text = "O Campo 'Email' é obrigatório";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            if (!emailCliente.EndsWith("@email.com"))
            {
                labelErro1.Text = "O Email deve conter @email.com!!!";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Campo genero
            if (string.IsNullOrEmpty(comboBoxGenero.Text))
            {
                labelErro1.Text = "O Campo 'Gênero' é obrigatório";
                labelErro1.ForeColor = Color.Red;
                return;
            }
          
            //Campo etnia
            if (string.IsNullOrEmpty(comboBoxEtnia.Text))
            {
                labelErro1.Text = "O Campo 'Etnia' é obrigatório";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Tipo de Cliente
            if (!radioButtonPF.Checked && !radioButtonPJ.Checked)
            {
                labelErro1.Text = "Selecione algum Tipo!!!";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Logradouro
            if (string.IsNullOrWhiteSpace(logradouroCliente))
            {
                labelErro2.Text = "O Logradouro é obrigatorio!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }

            //Numero
            if (string.IsNullOrWhiteSpace(numeroEnderecoCliente))
            {
                labelErro2.Text = "O Numero é obrigatorio!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }
            if (numeroEnderecoCliente.All(char.IsLetter))
            {
                labelErro2.Text = "O Numero não pode só conter letras!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }

            //Bairro
            if (string.IsNullOrWhiteSpace(bairroCliente))
            {
                labelErro2.Text = "O Bairro é obrigatorio!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }
            if (bairroCliente.Any(char.IsNumber))
            {
                labelErro2.Text = "O Bairro não pode conter numeros!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }

            //Municipio
            if (string.IsNullOrWhiteSpace(municipioCliente))
            {
                labelErro2.Text = "O Município é obrigatorio!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }
            if (municipioCliente.Any(char.IsNumber))
            {
                labelErro2.Text = "O Município não pode conter numeros!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }

            //Estados
            if (comboBoxEstado.SelectedItem == null)
            {
                labelErro2.Text = "Selecione algum Estado!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }

            //CEP
            if (cepCliente == "     -" || cepCliente.Length < 9)
            {
                labelErro2.Text = "O CEP é obrigatorio!!!";
                labelErro2.ForeColor = Color.Red;
                return;
            }
            
            
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
                labelErro2.Text = "Já existe um cliente cadastrado com esse e-mail e n° de telefone";
                labelErro2.ForeColor = Color.Red;
            }
            else
            {
                labelErro2.Text = "Cliente Cadastrado com Sucesso!";
                labelErro2.ForeColor = Color.Green;
            }

            BindingSource.ResetBindings(false);
        }
    
    
    
    }
}
