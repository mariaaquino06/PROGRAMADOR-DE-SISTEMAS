using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

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
            if (posicaousuarioEncontrado > -1 && senha == ListaSenhas[posicaousuarioEncontrado])
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

        private void buttonNewCadastro_Click(object sender, EventArgs e)
        {
            string novoUsuario = textBoxUser.Text; 
            string novaSenha = textBoxSenha.Text;
            bool usuarioEncontrado = false;
            
            
            if (string.IsNullOrEmpty(novoUsuario))
            {
                labelResultado2.Text = "Usuário é obrigatório!!";
                labelResultado2.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(novaSenha))
            {
                labelResultado2.Text = "Senha é Obrigatória";
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
               labelResultado2.Text = "Usuário cadastrado com sucesso!";
               labelResultado2.ForeColor = Color.Green;

            }
            else
            {
                labelResultado2.Text = "Já existe um usuário cadastrado";
                labelResultado2.ForeColor = Color.Red;
            }

            if (!Regex.IsMatch(novaSenha, @"[0-9]"))
            {
                labelResultado2.Text = "A senha deve conter pelo menos 1 número.";
                labelResultado2.ForeColor = Color.Red;
            }
            if (!Regex.IsMatch(novaSenha, @"[!@#$%^&*(),.?""{}|<>]"))
            {
                labelResultado2.Text = "A senha deve conter pelo menos 1 caractere especial.";
                labelResultado2.ForeColor = Color.Red;
            }
            if (!Regex.IsMatch(novaSenha, @"[A-Z]"))
            {
                labelResultado2.Text = "A senha deve conter pelo menos 1 letra maiúscula.";
                labelResultado2.ForeColor = Color.Red;
            }
            if (!Regex.IsMatch(novaSenha, @"[a-z]"))
            {
                labelResultado2.Text = "A senha deve conter pelo menos 1 letra minúscula.";
                labelResultado2.ForeColor = Color.Red;
            }
            if (novaSenha.Contains(" "))
            {
                labelResultado2.Text = "A senha não pode conter espaços.";
                labelResultado2.ForeColor = Color.Red;
            }
            
                

            

        }   
    }

}
