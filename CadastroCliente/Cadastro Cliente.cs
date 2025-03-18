namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        public Form1()
        {
            InitializeComponent();
            EnderecoCliente enderecoC1 = new EnderecoCliente() { logradouro = "Rua Brasil", numero = "1443", complemento = "Casa 02", bairro = "Jd. das Rosas", cidade = "São Pedro", estado ="SP", cep = "04899-002" };
            EnderecoCliente enderecoC2 = new EnderecoCliente() { logradouro = "Rua Amador Bueno", numero = "89", complemento = "não se aplica", bairro = "Águia Branca", cidade = "São Paulo", estado = "SP", cep = "05831-000" };
            EnderecoCliente enderecoC3 = new EnderecoCliente() { logradouro = "Avenida Luiz Gushiken", numero = "1550", complemento = "Apto81", bairro = "Jd. São Luis", cidade = "São Paulo", estado="SP", cep = "05923-111" }; 
            clientes.Add(new Cliente() { id = 1, Nome = "Rayane", datNasc = "26/05/2004", email = "ray.ane@senacsp.com.br", telefone = "11 940028922", endereco = enderecoC1 ,nomeSocial = "não se aplica", estrangeiro = false, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Preto, tipo = TipoCliente.PF });
            clientes.Add(new Cliente() { id = 2, Nome = "Maria Eduarda", datNasc = "02/10/2006", email = "maria.aquino@senacsp.com.br", telefone = "11 977737250", endereco = enderecoC2, nomeSocial = "não se aplica", estrangeiro = true, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Branco, tipo = TipoCliente.PJ });
            clientes.Add(new Cliente() { id = 3, Nome = "Viviane Oliveira", datNasc = "18/02/1985", email = "vivi.oli@senacsp.com.br", telefone = "11 980903357", endereco = enderecoC3, nomeSocial = "não se aplica", estrangeiro = false, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Pardo, tipo = TipoCliente.PF });





        }
        
    
    
    
    }
}
