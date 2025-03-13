using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace FORMS2
{
    public partial class Form1 : Form
    {
        List<Usuario> usuarios = new List<Usuario>();
        public Form1()
        {
            InitializeComponent();
            usuarios.Add(new Usuario() { text = "neymar.jr@email.com", Senha = "Brun@123" });
            usuarios.Add(new Usuario() { Email = "pablo.vitar@email.com", Senha = "12345Abc!" });
            usuarios.Add(new Usuario() { Email = "sukuna.silva@email.com", Senha = "Sete7Sete!" });
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
            int posicaousuarioEncontrado = listaUsuarios.IndexOf(usuarioBuscado);

            
            if (posicaousuarioEncontrado > -1 && senha == ListaSenhas[posicaousuarioEncontrado])
            {
                labelResultado.Text = "Autenticado com Sucesso";
                labelResultado.ForeColor = Color.Green;
                textBoxUser.Clear();
                textBoxSenha.Clear();
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

            if (novaSenha.Length < 8)
            {
                labelResultado2.Text = "A senha deve ter pelo menos 8 caracteres";
                labelResultado2.ForeColor = Color.Red;
                return;
            }

            if (!novaSenha.Any(char.IsUpper))
            {
                labelResultado2.Text = "A senha deve ter pelo menos uma letra maiuscula";
                labelResultado2.ForeColor = Color.Red;
                return;
            }

            if (!novaSenha.Any(char.IsLower))
            {
                labelResultado2.Text = "A senha deve ter pelo menos uma letra minuscula";
                labelResultado2.ForeColor = Color.Red;
                return;
            }

            if (!novaSenha.Any(char.IsDigit))
            {
                labelResultado2.Text = "A senha deve ter pelo menos um numero";
                labelResultado2.ForeColor = Color.Red;
                return;
            }

            if (!novaSenha.Any(char.IsPunctuation) && !novaSenha.Any(char.IsSymbol) && !novaSenha.Contains("@"))
            {
                labelResultado2.Text = "A senha deve ter pelo menos um caracter especial";
                labelResultado2.ForeColor = Color.Red;
                return;
            }

            if (novaSenha.Contains(' '))
            {
                labelResultado2.Text = "A senha nao deve ter espacos em branco";
                labelResultado2.ForeColor = Color.Red;
                return;
            }

            if (listaUsuarios.Contains(novoUsuario))
            {
                labelResultado2.Text = "Já existe um usuário cadastrado";
                labelResultado2.ForeColor = Color.Red;
                return;
            }

            listaUsuarios.Add(novoUsuario);
            ListaSenhas.Add(novaSenha);
            labelResultado2.Text = "Usuário cadastrado com sucesso!";
            labelResultado2.ForeColor = Color.Green;
            textBoxUser.Clear();
            textBoxSenha.Clear();






        }   
    }

}
