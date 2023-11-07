using Npgsql;
using System.Data;
using System.Globalization;

namespace Car_Rental
{
    public partial class Formulario_Locacao : Form
    {
        public int CodigoLocacao;
        public Formulario_Locacao()
        {
            InitializeComponent();
        }

        private void AlterarRegistro()
        {
            try
            {
                // string de conexao
                string stringConexao = "Server=localhost; Port=5432; " + "User Id=postgres; Password=12345678; DataBase=CarRental;";

                // objeto de conexao
                NpgsqlConnection con = new NpgsqlConnection(stringConexao);

                // instrucao sql para o banco de dados
                string instrucao = "SELECT * FROM locacao " +
                    "where codigo= " + CodigoLocacao + " ; ";

                DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

                NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

                da.Fill(dt); // preenche data table com resultado

                comboVeiculo.Text = dt.Rows[0]["veiculo_escolhido"].ToString();
                comboCliente.Text = dt.Rows[0]["nome_cliente"].ToString();
                txt_Seguro_Opcional.Text = dt.Rows[0]["seguro_opcional"].ToString();
                maskedTextBox1.Text = dt.Rows[0]["inicio_locacao"].ToString();

                mktxt_Termino_Locacao.Text = dt.Rows[0]["termino_locacao"].ToString();
                mktxt_Valor_Diaria.Text = dt.Rows[0]["valor_da_diaria"].ToString();
                mktxt_Valor_Total.Text = dt.Rows[0]["valor_total"].ToString();

            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Pesquisar locacao: " + erro.Message);
            }

        }
        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Seguro_Opcional.Text = "";
            maskedTextBox1.Text = "";
            mktxt_Termino_Locacao.Text = "";
            mktxt_Valor_Diaria.Text = "";
            mktxt_Valor_Total.Text = "";

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            string stringConexao = "Server=localhost; Port=5432; " +
                            "User Id=postgres; Password=12345678; DataBase=CarRental;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            DateTime dataInicio;
            bool sucesso = DateTime.TryParseExact(maskedTextBox1.Text, "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataInicio);

            if (sucesso == false)
            {
                // A string não pôde ser convertida para DateTime.
            }

            DateTime dataTermino;
            bool correto = DateTime.TryParseExact(maskedTextBox1.Text, "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataTermino);

            if (correto == false)
            {
                // A string não pôde ser convertida para DateTime.
            }

            // instrucao sql para o banco de dados
            string instrucao = "insert into  locacao ( veiculo_escolhido,seguro_opcional,nome_cliente,valor_da_diaria,valor_total,inicio_locacao,termino_locacao,placa_veiculo) " +
                "values ('" + comboVeiculo.Text + "','" + txt_Seguro_Opcional.Text + "','" + comboCliente.Text + "'," +
                "'" + mktxt_Valor_Diaria.Text + "','" + mktxt_Valor_Total.Text + "','" + dataInicio.ToShortDateString() + "'," +
                "'" + dataTermino.ToShortDateString() + "','" + mktxt_Placa.Text + "'";

            if (CodigoLocacao > 0)
            {
                instrucao = $"update locacao set codigo  = '{comboVeiculo.Text}', seguro_opcional = '{txt_Seguro_Opcional.Text}'," +
                    $" nome_cliente = '{comboCliente.Text}' , valor_da_diaria = '{mktxt_Valor_Diaria.Text}' , valor_total = '{mktxt_Valor_Total}'" +
                    $" inicio_locacao = '{maskedTextBox1}', termino_locacao = '{mktxt_Termino_Locacao.Text}'" +
                    $" where codigo = '{CodigoLocacao}' , placa_veiculo = '{mktxt_Placa.Text}'";
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

        private void Formulario_Locacao_Load(object sender, EventArgs e)
        {
            CarregaClientes();
            CarregaVeiculo();

            if (CodigoLocacao > 0)
            {
                AlterarRegistro();
            }
        }

        private void CarregaVeiculo()
        {
            // string de conexao
            string stringConexao = "Server=localhost; Port=5432; " +
                                "User Id=postgres; Password=12345678; DataBase=CarRental;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "SELECT marca ||'    - '|| modelo ||' -    '|| placa as descricao, codigo FROM veiculo ";

            DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

            da.Fill(dt); // preenche data table com resultado

            comboVeiculo.DataSource = dt;
            comboVeiculo.DisplayMember = "descricao";
            comboVeiculo.ValueMember = "codigo";
        }

        private void CarregaClientes()
        {
            // string de conexao
            string stringConexao = "Server=localhost; Port=5432; " +
                                "User Id=postgres; Password=12345678; DataBase=CarRental;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "SELECT * FROM clientes ";

            DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

            da.Fill(dt); // preenche data table com resultado

            comboCliente.DataSource = dt;
            comboCliente.DisplayMember = "nome";
            comboCliente.ValueMember = "codigo";
        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}