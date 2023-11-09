using Npgsql;
using System.Data;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Text.RegularExpressions;

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
                checkBoxSeguro.Checked = dt.Rows[0]["seguro_opcional"].ToString() == "sim" ? true : false;
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
            checkBoxSeguro.Checked = false;
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


            decimal valorTotal = decimal.Parse(mktxt_Valor_Total.Text.Trim().Replace("R$", " ").Replace(".", ","));
            decimal valorDiaria = decimal.Parse(mktxt_Valor_Diaria.Text.Trim().Replace("R$", " ").Replace(".", ","));

            string seguro = checkBoxSeguro.Checked ? "Sim" : "Nao";

            string instrucao = "insert into tabela(seguro)" +
                "values (" + seguro + ")";

            // instrucao sql para o banco de dados
            instrucao = "";

            if (CodigoLocacao > 0)
            {
                instrucao = $"update locacao set veiculo_escolhido = '{comboVeiculo.Text}', seguro_opcional = '{seguro}'" +
                    $" nome_cliente = '{comboCliente.Text}' , valor_da_diaria = '{valorDiaria}' , valor_total = '{valorTotal}'" +
                    $" inicio_locacao = '{maskedTextBox1.Text}', termino_locacao = '{mktxt_Termino_Locacao.Text}', placa_veiculo ='{mktxt_Placa.Text}'" +
                    $" where codigo = '{CodigoLocacao}'";
            }
            else
            {
                instrucao = "insert into locacao(veiculo_escolhido,seguro_opcional,nome_cliente,valor_da_diaria,valor_total,inicio_locacao,termino_locacao,placa_veiculo)" +
                "values ('" + comboVeiculo.Text + "','" + seguro + "','" + comboCliente.Text + "','" + valorDiaria + "'," +
                "'" + valorTotal + "','" + maskedTextBox1.Text + "','" + mktxt_Termino_Locacao.Text + "','" + mktxt_Placa.Text + "')";
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
            maskedTextBox1.Text = DateTime.Now.ToShortDateString();
            mktxt_Termino_Locacao.Text = DateTime.Now.ToShortDateString();

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
            string instrucao = "select marca || '  ' || modelo || '  ' || placa as descricao from veiculo where placa not in (select placa_veiculo from locacao " +
            "where inicio_locacao >= '" + maskedTextBox1.Text + "' and termino_locacao <= '" + mktxt_Termino_Locacao.Text + "')";

            DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

            da.Fill(dt); // preenche data table com resultado

            comboVeiculo.DataSource = dt;
            comboVeiculo.DisplayMember = "descricao";
            comboVeiculo.ValueMember = "descricao";
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}