using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;
using Npgsql;

namespace Car_Rental
{
    public partial class frm_Clientes : Form
    {
        public frm_Clientes()
        {
            InitializeComponent();
        }


        private void Delete()
        {

            string stringConexao = "Server=localhost; Port=5432; " +
                         "User Id=postgres; Password=12345678; DataBase=CarRental;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;

            int linhaSelecionada = int.Parse(dr["codigo"].ToString());

            // instrucao sql para o banco de dados
            string instrucao = $"delete from clientes where codigo =" + linhaSelecionada;


            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con);


            con.Open();


            try
            {
                //executar comando
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluido com sucesso!");
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
        private async Task CarregarCliente()
        {
            try
            {
                HttpClient _httpClient = new HttpClient(); // objeto de retorno

                HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:7188/Cliente"); // indicar endereço endpoint/controller
                response.EnsureSuccessStatusCode(); // padroniza os codigos

                string responseBody = await response.Content.ReadAsStringAsync(); // executar e traz a resposta

                List<Cliente_Response> cliente = JsonConvert.DeserializeObject<List<Cliente_Response>>(responseBody); // transformo o resultado

                dataGridView1.DataSource = cliente; // carrega na lista da tela
            }
            catch
            {
            }
        }
        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            CarregarCliente();

            /*// string de conexao
            string stringConexao = "Server=localhost; Port=5432; " +
                                "User Id=postgres; Password=12345678; DataBase=CarRental;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "SELECT * FROM clientes " +
                "order by codigo";

            DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

            da.Fill(dt); // preenche data table com resultado

            // Fecha conexao com o banco
            con.Close();
            con.Dispose();

            dataGridView1.DataSource = dt; // carrega na lista da tela */
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha para Excluir.");

            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja Excluir? ", "Tela de Clientes",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Delete();
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    dataGridView1.Rows.Remove(selectedRow);

                }

            }


        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha para Alteração.");

            }
            else
            {

                DataRowView dr = (DataRowView)dataGridView1.Rows[dataGridView1.SelectedRows[0]
                    .Index].DataBoundItem;

                int linhaSelecionada = int.Parse(dr["codigo"].ToString());

                MessageBox.Show("código Selecionado para Alteração é : " + linhaSelecionada);

                Formulario_Clientes form = new Formulario_Clientes();
                form.CodigoClientes = linhaSelecionada;
                form.ShowDialog();

            }
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            Formulario_Clientes form = new Formulario_Clientes();
            form.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
