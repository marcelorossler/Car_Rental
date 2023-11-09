using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Npgsql;




namespace Car_Rental
{
    public partial class financeiro : Form
    {
        public financeiro()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void financeiro_Load(object sender, EventArgs e)
        {

            CarregaClientes();
            CarregaPlaca();

            ComboxCliente.Text = "";
            ComboxPlaca.Text = "";

            Consulta();
        }

        private void Consulta()
        {
            // string de conexao
            string stringConexao = "Server=localhost; Port=5432; " + "User Id=postgres; Password=12345678; DataBase=CarRental;";

            // objeto de conexao
            using (NpgsqlConnection con = new NpgsqlConnection(stringConexao))
            {
                con.Open();

                string instrucao = "SELECT * FROM locacao where codigo > 0 ";

                if (ComboxCliente.SelectedItem != null && ComboxCliente.Text != null)
                {
                    instrucao += $" and nome_cliente ilike '%{ComboxCliente.Text}%' ";
                }

                if (ComboxPlaca.SelectedItem != null && ComboxPlaca.Text != null)
                {
                    instrucao += $" and placa_veiculo = '{ComboxPlaca.Text}' ";
                }


                if (dateTimePicker1.Value != null && dateTimePicker2.Value != null)
                {
                    instrucao += $" and inicio_locacao >= '{dateTimePicker1.Value.ToShortDateString()}'" +
                       $" and termino_locacao <= '{dateTimePicker2.Value.ToShortDateString()}'";
                }

                instrucao += " order by codigo ";

                DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

                using (NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        // preenche data table com resultado
                        da.Fill(dt);
                    }
                }

                dataGridView1.DataSource = dt; // carrega na lista da tela
            }
        }



        private void btn_Consultar_Click(object sender, EventArgs e)

        {
            Consulta();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

        }

        private void CarregaClientes()
        {
            // string de conexao
            string stringConexao = "Server=localhost; Port=5432; " +
                                "User Id=postgres; Password=12345678; DataBase=CarRental;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = " SELECT * FROM clientes ";

            DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

            da.Fill(dt); // preenche data table com resultado

            ComboxCliente.DataSource = dt;
            ComboxCliente.DisplayMember = "nome";
            ComboxCliente.ValueMember = "codigo";
        }

        private void CarregaPlaca()
        {
            // string de conexao
            string stringConexao = "Server=localhost; Port=5432; " +
                                "User Id=postgres; Password=12345678; DataBase=CarRental;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "SELECT * FROM veiculo";

            DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

            da.Fill(dt); // preenche data table com resultado

            ComboxPlaca.DataSource = dt;
            ComboxPlaca.DisplayMember = "placa";
            ComboxPlaca.ValueMember = "codigo";
        }


    }


}

