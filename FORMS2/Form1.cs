namespace FORMS2
{
    public partial class Form1 : Form
    {

        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.vittar", "sukuna.silva" };
        List<string> ListaSenhas = new List<string>() { "bruna", "12345", "777" };
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
                labelResultado.Text = "Usuario � obrigat�rio!";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            if (senha == null || senha == "")
            {
                labelResultado.Text = "Senha � Obrigat�ria";
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
            if (posicaousuarioEncontrado > -1 && senha == ListaSenhas[posicaousuarioEncontrado])
            {
                labelResultado.Text = "Autenticado com Sucesso";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "Usu�rio ou Senha incorretos";
                labelResultado.ForeColor = Color.Red;
            }


        }

        private void buttonNewCadastro_Click(object sender, EventArgs e)
        {
            string novoUsuario = textBoxUser.Text; 
            string novaSenha = textBoxSenha.Text;
            bool usuarioEncontrado = false;
            
            if (string.IsNullOrEmpty(novoUsuario))
            {
                labelResultado2.Text = "Usu�rio � obrigat�rio!!";
                labelResultado2.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(novaSenha))
            {
                labelResultado2.Text = "Senha � Obrigat�ria";
                labelResultado2.ForeColor = Color.Red;
                return;
            }
            
            for (int i = 0;i < listaUsuarios.Count;i++)
            {
                if (novoUsuario == listaUsuarios[i])
                {
                    usuarioEncontrado = true;
                }
            }

            if (!usuarioEncontrado)
            {
               listaUsuarios.Add(novoUsuario);
               ListaSenhas.Add(novaSenha);
               labelResultado2.Text = "Usu�rio cadastrado com sucesso!";
                labelResultado2.ForeColor = Color.Green;

            }
            else
            {
                labelResultado2.Text = "J� existe um usu�rio cadastrado";
                labelResultado2.ForeColor = Color.Red;
            }
        }
    }

}
