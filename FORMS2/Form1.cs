namespace FORMS2
{
    public partial class Form1 : Form
    {

        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.vittar", "sukuna.silva" };
        public Form1()
        {
            InitializeComponent();
        }
        private void ButtonEntrar_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = CaixaTextUsuario.Text;
            string senha = CaixaTextSenha.Text;
            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = "Usuario é obrigatório!";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            if (senha == null || senha == "")
            {
                labelResultado.Text = "Senha é Obrigatória";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            int posicaousuarioEncontrado = -1;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuarioBuscado == listaUsuarios[i])
                {
                    posicaousuarioEncontrado = i;
                }

            }
            if (usuarioBuscado == listaUsuarios[posicaousuarioEncontrado] && senha == "12345")
            {
                labelResultado.Text = "Autenticado com Sucesso";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "Usuário ou Senha incorretos";
                labelResultado.ForeColor = Color.Red;
            }


        }
    }

}
