using MySql.Data.MySqlClient;
namespace WFGravarDadosMySQL
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Criando conexão com MySQL
                string data_source = "" +
                    "datasource = localhost; " +
                    "username = root ; " +
                    "password = ; " +
                    "database=db_agenda";

;               Conexao = new MySqlConnection(data_source);

                string sql = "INSET INTO contato (nome, telefone, email)" + "VALUES + ('" + txtNome.Text + "', '" + txtTelefone.Text + "','" + txtEmail.Text + "')";

                //Executando comando Insert
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Sucesso!");
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}