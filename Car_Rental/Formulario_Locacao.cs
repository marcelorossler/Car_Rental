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
                string stringConexao = "Server=localhost; Port=5433; " +
                                    "User Id=postgres; Password=12345678; DataBase=dbCarRental;";

                // objeto de conexao
                NpgsqlConnection con = new NpgsqlConnection(stringConexao);

                // instrucao sql para o banco de dados
                string instrucao = "SELECT * FROM locacao " +
                    "where codigo= " + CodigoLocacao + " ; ";

                DataTable dt = new DataTable(); // tabela virtual pra armazenar resultado

                NpgsqlCommand cmd = new NpgsqlCommand(instrucao, con); // passa por parametro a instrucao sql

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd); // nunca muda

                da.Fill(dt); // preenche data table com resultado

                txt_Veiculo.Text = dt.Rows[0]["veiculo_escolhido"].ToString();
                txt_Nome_Cliente.Text = dt.Rows[0]["nome_cliente"].ToString();
                txt_Seguro_Opcional.Text = dt.Rows[0]["seguro_opcional"].ToString();
                mktxt_Inicio_Locacao.Text = dt.Rows[0]["inicio_locacao"].ToString();
                mktxt_Termino_Locacao.Text = dt.Rows[0]["termino_locacao"].ToString();
                mktxt_Valor_Diaria.Text = dt.Rows[0]["valor_da_diaria"].ToString();
                mktxt_Valor_Total.Text = dt.Rows[0]["valor_total"].ToString();
                mktxt_Placa.Text = dt.Rows[0]["placa_veiculo"].ToString();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Pesquisar locacao: " + erro.Message);
            }


        }

        private void mkTxt_Inicio_Locacao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Veiculo.Text = "";
            txt_Nome_Cliente.Text = "";
            txt_Seguro_Opcional.Text = "";
            mktxt_Inicio_Locacao.Text = "";
            mktxt_Termino_Locacao.Text = "";
            mktxt_Valor_Diaria.Text = "";
            mktxt_Valor_Total.Text = "";
            mktxt_Placa.Text = "";
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            string stringConexao = "Server=localhost; Port=5433; " +
                            "User Id=postgres; Password=12345678; DataBase=dbCarRental;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "insert into  locacao ( veiculo_escolhido,seguro_opcional,nome_cliente,valor_da_diaria,valor_total,inicio_locacao,termino_locacao,placa_veiculo) " +
                "values ('" + txt_Veiculo.Text + "','" + txt_Seguro_Opcional.Text + "','" + txt_Nome_Cliente.Text + "'," +
                "'" + mktxt_Valor_Diaria.Text + "','" + mktxt_Valor_Total.Text + "','" + mktxt_Inicio_Locacao.Text + "'," +
                "'" + mktxt_Termino_Locacao.Text + "','" + mktxt_Placa.Text + "'); ";

            if (CodigoLocacao > 0)
            {
                instrucao = $"update locacao set veiculo_escolhido  = '{txt_Veiculo.Text}', seguro_opcional = '{txt_Seguro_Opcional.Text}'," +
                    $" nome_cliente = '{txt_Nome_Cliente.Text}' , valor_da_diaria = '{mktxt_Valor_Diaria.Text}' , valor_total = '{mktxt_Valor_Total}'" +
                    $" inicio_locacao = '{mktxt_Inicio_Locacao.Text}', termino_locacao = '{mktxt_Termino_Locacao.Text}', placa_veiculo{mktxt_Placa.Text}'" +
                    $" where codigo = {CodigoLocacao}";
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
            if (CodigoLocacao > 0)
            {
                AlterarRegistro();
            }
        }
    }
}
