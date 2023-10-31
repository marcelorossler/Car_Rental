using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btn_Veiculo_Click(object sender, EventArgs e)
        {

        }

        private void financeiro_Load(object sender, EventArgs e)
        {
            // string de conexao
            string stringConexao = "Server=localhost; Port=5433; " +
                                "User Id=postgres; Password=12345678; DataBase=dbCarRental;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "SELECT * FROM locacao " +
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


        private void Consulta()
        {


        }
    }

}
