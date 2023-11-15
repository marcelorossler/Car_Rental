using Newtonsoft.Json;
using Npgsql;
using System.Data;


namespace Car_Rental;

public partial class Veiculos : Form
{
    public Veiculos()
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
        string instrucao = $"delete from veiculo where codigo =" + linhaSelecionada;


        NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con);


        con.Open();


        try
        {
            //executar comando
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro excluído com sucesso!");
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

    private void btn_Cadastrar_Click(object sender, EventArgs e)
    {
        Formulario_Veiculos form = new Formulario_Veiculos();
        form.ShowDialog();
    }
    private async Task CarregarClientes()
    {
        try
        {
            HttpClient _httpClient = new HttpClient(); // objeto de retorno

            HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:7188/Veiculo"); // indicar endereço endpoint/controller
            response.EnsureSuccessStatusCode(); // padroniza os codigos

            string responseBody = await response.Content.ReadAsStringAsync(); // executar e traz a resposta

            List<Veiculo_Response> cliente = JsonConvert.DeserializeObject<List<Veiculo_Response>>(responseBody); // transformo o resultado

            dataGridView1.DataSource = cliente; // carrega na lista da tela
        }
        catch
        {
        }
    }
    private void Veiculos_Load(object sender, EventArgs e)
    {
        CarregarClientes();

         // string de conexao
         string stringConexao = "Server=localhost; Port=5432; " +
                             "User Id=postgres; Password=12345678; DataBase=CarRental;";

         // objeto de conexao
         NpgsqlConnection con = new NpgsqlConnection(stringConexao);

         // instrucao sql para o banco de dados
         string instrucao = "SELECT * FROM veiculo " +
             "order by codigo";

         DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

         NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

         NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

         da.Fill(dt); // preenche data table com resultado

         // Fecha conexao com o banco
         con.Close();
         con.Dispose();

         dataGridView1.DataSource = dt; // carrega na lista da tela
     }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
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

                Formulario_Veiculos form = new Formulario_Veiculos();
                form.CodigoVeiculos = linhaSelecionada;
                form.ShowDialog();

            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha para Excluir.");

            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja Excluir? ", "Tela de Veiculos",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Delete();
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    dataGridView1.Rows.Remove(selectedRow);

                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    
}