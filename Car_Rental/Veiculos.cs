using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    public partial class Veiculos : Form
    {      
        public Veiculos()
        {
            InitializeComponent();
        }

        private void Delete()
        {
            string stringConexao = "Server=localhost; Port=5433; " +
                         "User Id=postgres; Password=12345678; DataBase=dbCarRental;";

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

        private void Veiculos_Load(object sender, EventArgs e)
        {

            // string de conexao
            string stringConexao = "Server=localhost; Port=5433; " +
                                "User Id=postgres; Password=12345678; DataBase=dbCarRental;";

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
}
