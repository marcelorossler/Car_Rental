using Npgsql;
using System.Data;


namespace Car_Rental
{
    public partial class Formulario_Clientes : Form
    {
        public int CodigoClientes;
        public Formulario_Clientes()
        {
            InitializeComponent();
        }

        private void Formulario_Clientes_Load(object sender, EventArgs e)
        {
            if (CodigoClientes > 0)
            {
                AlterarRegistro();
            }
        }

        private void AlterarRegistro()
        {
            try
            {
                // string de conexao
                string stringConexao = "Server=localhost; Port=5432; " +
                                    "User Id=postgres; Password=12345678; DataBase=CarRental;";

                // objeto de conexao
                NpgsqlConnection con = new NpgsqlConnection(stringConexao);

                // instrucao sql para o banco de dados
                string instrucao = "SELECT * FROM clientes " +
                    "where codigo= " + CodigoClientes + " ; ";

                DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

                NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

                da.Fill(dt); // preenche data table com resultado

                txt_Nome.Text = dt.Rows[0]["nome"].ToString();
                mskd_txbox_Cpf.Text = dt.Rows[0]["cpf"].ToString();
                txt_Endereco.Text = dt.Rows[0]["endereco"].ToString();
                maskd_txtBox_Nascimento.Text = dt.Rows[0]["nascimento"].ToString();

            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Pesquisar Clientes: " + erro.Message);
            }

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Nome.Text = "";
            mskd_txbox_Cpf.Text = "";
            txt_Endereco.Text = "";
            maskd_txtBox_Nascimento.Text = "";
        }
        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string stringConexao = "Server=localhost; Port=5432; " +
                            "User Id=postgres; Password=12345678; DataBase=CarRental;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "insert into  clientes ( nome,endereco,cpf,nascimento) " +
                "values ('" + txt_Nome.Text + "','" + txt_Endereco.Text + "','" + mskd_txbox_Cpf.Text + "'," +
                "'" + maskd_txtBox_Nascimento.Text + "'); ";

            if (CodigoClientes > 0)
            {
                instrucao = $"update clientes set nome = '{txt_Nome.Text}', endereco = '{txt_Endereco.Text}'," +
                    $" cpf = '{mskd_txbox_Cpf.Text}' , nascimento = '{maskd_txtBox_Nascimento.Text}'" +
                 $" where codigo = {CodigoClientes}";
            }

            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con);

            con.Open();

            try
            {
                //executar comando
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Registro Salvo com SUCESSO ! ");
                Close();
            }
            catch (Exception ex)
            {
                // se ocorrer erro da uma msg
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //fecha a conexao
                con.Close(); con.Dispose();
            }


        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

    }
}





