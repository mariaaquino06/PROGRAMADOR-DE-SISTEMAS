namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();

        public Form1()
        {
            InitializeComponent();

            EnderecoCliente enderecoRayane = new EnderecoCliente() { logradouro = "Rua Brasil", numero = "1443", complemento = "Casa 02", bairro = "Jd. das Rosas", cidade = "S�o Pedro", estado = "SP", cep = "04899-002" };
            Cliente rayane = new Cliente() { id = 1, Nome = "Rayane Lima", datNasc = "26/05/2004", email = "ray.ane@senacsp.com.br", telefone = "11 940028922", endereco = enderecoRayane, nomeSocial = "n�o se aplica", estrangeiro = false, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Preto, tipo = TipoCliente.PF };
            clientes.Add(rayane);

            EnderecoCliente enderecoMariaEduarda = new EnderecoCliente() { logradouro = "Rua Amador Bueno", numero = "89", complemento = "n�o se aplica", bairro = "�guia Branca", cidade = "S�o Paulo", estado = "SP", cep = "05831-000" };
            Cliente mariaEduarda = new Cliente() { id = 2, Nome = "Maria Eduarda", datNasc = "02/10/2006", email = "maria.aquino@senacsp.com.br", telefone = "11 977737250", endereco = enderecoMariaEduarda, nomeSocial = "n�o se aplica", estrangeiro = true, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Branco, tipo = TipoCliente.PJ };
            clientes.Add(mariaEduarda);

            EnderecoCliente enderecoViviane = new EnderecoCliente() { logradouro = "Avenida Luiz Gushiken", numero = "1550", complemento = "Apto81", bairro = "Jd. S�o Luis", cidade = "S�o Paulo", estado = "SP", cep = "05923-111" };
            Cliente viviane = new Cliente() { id = 3, Nome = "Viviane Oliveira", datNasc = "18/03/1985", email = "vivi.oli@senacsp.com.br", telefone = "11 980903357", endereco = enderecoViviane, nomeSocial = "n�o se aplica", estrangeiro = false, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Pardo, tipo = TipoCliente.PF };
            clientes.Add(viviane);
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            //Campo Nome Completo
            if (string.IsNullOrEmpty(textBoxNome.Text))
            {
                labelErro1.Text = "O campo 'Nome Completo' � obrigat�rio!";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Campo Data de Nascimento
            if (string.IsNullOrEmpty(maskedTxtBoxNasc.Text))
            {
                labelErro1.Text = "O Campo 'Data de Nascimento' � obrigat�rio";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Campo n� de Telefone
            if (string.IsNullOrEmpty(maskedTxtBoxTelefone.Text))
            {
                labelErro1.Text = "O Campo 'Telefone' � obrigat�rio";
                labelErro1.ForeColor = Color.Red;
                return;
            }
            //Campo email
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                labelErro1.Text = "O Campo 'Email' � obrigat�rio";
                labelErro1.ForeColor = Color.Red;
                return;
            }



        
        
        
        }
    
    
    
    }
}
