namespace FORMS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = CaixaTextUsuario.Text;
            string senha = CaixaTextSenha.Text;

            if (usuario == null || usuario == "")
            {
                labelResultado.Text = "Usuario é obrigatório";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if(usuario == "maria.eoaquino" && senha == "12345")
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CaixaTextUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
