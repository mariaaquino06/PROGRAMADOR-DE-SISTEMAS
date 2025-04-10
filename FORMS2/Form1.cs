using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace FORMS2
{
    public partial class Form1 : Form
    {   
        MySqlConnection Connnection;

        List<Usuario> usuarios = new List<Usuario>();
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

            // Verifica se o usuário e senha estão corretos
            // Inicializa a variável autenticado como false
            bool autenticado = false;

            try
            {
                Connection.Open();

                string query = $"SELECT senha FROM usuario WHERE email = '{usuarioBuscado}';";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                autenticado = reader.Read() && reader.GetString(0) == senha;
            }
            catch
            {
                MessageBox.Show("Erro de banco de dados");
            }
            finally
            {
                Connection.Close();
            }

            // Verifica se o usuário e senha não foram encontrados
            if (!autenticado)
            {
                // Exibe mensagem de erro
                labelResultado.Text = "Usuario ou Senha incorretos...";
                // Muda a cor da mensagem para vermelho
                labelResultado.ForeColor = Color.Red;
                // Encerra a execução do método
                return;
            }

            // Se o usuário e senha foram encontrados, exibe mensagem de sucesso
            labelResultado.Text = "Autenticado com sucesso!";
            // Muda a cor da mensagem para verde
            labelResultado.ForeColor = Color.Green;

            // Limpa os campos de texto
            textBoxUsuario.Clear();
            textBoxSenha.Clear();

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
