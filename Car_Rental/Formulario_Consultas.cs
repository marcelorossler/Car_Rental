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
    public partial class Formulario_Consultas : Form
    {
        public int CodigoLocacao;
        public Formulario_Consultas()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            string stringConexao = "Server=localhost; Port=5433; " +
                            "User Id=postgres; Password=12345678; DataBase=dbCarRental;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            // instrucao sql para o banco de dados
            string instrucao = "insert into  clientes ( nome,cpf) " +
                "values ('" + txt_Nome_Cliente.Text + "','" + mktxt_Cpf + "'); ";

            if (CodigoLocacao > 0)
            {
                instrucao = $"update Locacao set nome = '{txt_Nome_Cliente.Text}', cpf = '{mktxt_Cpf.Text}'"+
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
    }
}

