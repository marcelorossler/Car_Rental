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
            Consulta();
        }


        private void Consulta()
        {
            // string de conexao
            string stringConexao = "Server=localhost; Port=5433; " +
                                "User Id=postgres; Password=12345678; DataBase=dbCarRental;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            string instrucao = "SELECT * FROM locacao where codigo > 0 ";

            if (txt_Nome_Cliente.Text != "")
            {
                instrucao += $" and nome_cliente = '{txt_Nome_Cliente.Text}' ";
            }

            if (txt_Placa_Veiculo.Text != "")
            {
                instrucao += $" and placa_veiculo = '{txt_Placa_Veiculo.Text}' ";
            }
            // IF abaixo com sua Instrução não funciona "Consulta" de Inicio e Término de locação 

            if (dateTimePicker1.Value.ToShortDateString() != "" && dateTimePicker2.Value.ToShortDateString() != "")
            {

                instrucao += $" and inicio_locacao >=  '{dateTimePicker1.Value.ToShortDateString()}'" + 
                   $" and termino_locacao <= '{dateTimePicker2.Value.ToShortDateString()}'";

                // inicio >= '10/11/2023' and termino <=  '20/11/2023'
            }


            instrucao += " order by codigo ";

            DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

            NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

            da.Fill(dt); // preenche data table com resultado

            // Fecha conexao com o banco
            con.Close();
            con.Dispose();

            dataGridView1.DataSource = dt; // carrega na lista da tela
        }

        private void btn_Consultar_Click(object sender, EventArgs e)

        {
            Consulta();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
               txt_Nome_Cliente.Text = "";
               txt_Placa_Veiculo.Text = "";
            
        }
    }

}