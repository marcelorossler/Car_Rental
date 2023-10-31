using Npgsql;
using System.Data;

namespace Car_Rental
{
    public partial class Formulario_Veiculos : Form
    {
        public int CodigoVeiculos;
        public Formulario_Veiculos()
        {
            InitializeComponent();
        }

        private void AlterarRegistro()
        {
            try
            {
                // string de conexao
                string stringConexao = "Server=localhost; Port=5433; " +
                                    "User Id=postgres; Password=12345678; DataBase=dbCarRental;";

                // objeto de conexao
                NpgsqlConnection con = new NpgsqlConnection(stringConexao);

                // instrucao sql para o banco de dados
                string instrucao = "SELECT * FROM veiculo " +
                    "where codigo= " + CodigoVeiculos + " ; ";

                DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

                NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

                da.Fill(dt); // preenche data table com resultado

                txt_Marca.Text = dt.Rows[0]["marca"].ToString();
                txt_Modelo.Text = dt.Rows[0]["modelo"].ToString();
                txt_Cor.Text = dt.Rows[0]["cor"].ToString();
                txt_Placa.Text = dt.Rows[0]["placa"].ToString();

            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Pesquisar veiculo: " + erro.Message);
            }


        }
        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Marca.Text = "";
            txt_Modelo.Text = "";
            txt_Cor.Text = "";
            txt_Placa.Text = "";
        }

        private void Formulario_Veiculos_Load(object sender, EventArgs e)
        {
            if (CodigoVeiculos > 0)
            {
                AlterarRegistro();
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            string stringConexao = "Server=localhost; Port=5433; " +
                            "User Id=postgres; Password=12345678; DataBase=dbCarRental;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "insert into  veiculo ( marca,modelo,cor,placa) " +
                "values ('" + txt_Marca.Text + "','" + txt_Modelo.Text + "','" + txt_Cor.Text + "'," +
                "'" + txt_Placa.Text + "'); ";

            if (CodigoVeiculos > 0)
            {
                instrucao = $"update veiculo set marca  = '{txt_Marca.Text}', modelo = '{txt_Modelo.Text}'," +
                    $" cor = '{txt_Cor.Text}' , placa = '{txt_Placa.Text}'" +
                 $" where codigo = {CodigoVeiculos}";
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
    }
}
