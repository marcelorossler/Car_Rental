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
            string stringConexao = "Server=localhost; Port=5432; " + "User Id=postgres; Password=12345678; DataBase=CarRental;";

            // objeto de conexao
            NpgsqlConnection con = new NpgsqlConnection(stringConexao);

            string instrucao = "SELECT * FROM locacao where codigo > 0 ";

            if (txt_Nome_Cliente.Text != "")
            {
                instrucao += $" and nome_cliente ilike '%{txt_Nome_Cliente.Text}%' ";
            }

            if (txt_Placa_Veiculo.Text != "")
            {
                instrucao += $" and placa_veiculo = '{txt_Placa_Veiculo.Text}' ";
            }

            if (dateTimePicker1.Value.ToShortDateString() != "" && dateTimePicker2.Value.ToShortDateString() != "")
            {

                instrucao += $" and inicio_locacao >=  '{dateTimePicker1.Value.ToShortDateString()}'" +
                   $" and termino_locacao <= '{dateTimePicker2.Value.ToShortDateString()}'";

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


        class Locacao
        {
            public string VeiculoEscolhido { get; set; }
            public DateTime Data { get; set; }
            public DateTime InicioLocacao { get; set; }
            public DateTime TerminoLocacao { get; set; }
        }

        private void btn_Criar_Locacao_Click(object sender, EventArgs e)
        {

          List<Locacao> locacoes = new List<Locacao>();

            // Capturar o veículo escolhido do usuário
            Console.Write("Digite o veículo escolhido: ");
            string veiculoEscolhido = Console.ReadLine();

            // Capturar a data do usuário
            Console.Write("Digite a data da locação (dd-MM-yyyy): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
            {
                // Capturar a data de início da locação do usuário
                Console.Write("Digite a data de início da locação (dd-MM-yyyy): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime inicioLocacao))
                {
                    // Capturar a data de término da locação do usuário
                    Console.Write("Digite a data de término da locação (dd-MM-yyyy): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime terminoLocacao))
                    {
                        // Verificar se o veículo já está locado no mesmo período
                        bool isConflict = locacoes.Exists(l =>
                            l.VeiculoEscolhido == veiculoEscolhido &&
                            ((data >= l.InicioLocacao && data <= l.TerminoLocacao) ||
                            (terminoLocacao >= l.InicioLocacao && terminoLocacao <= l.TerminoLocacao)));

                        if (isConflict)
                        {
                            Console.WriteLine("O veículo já está locado durante esse período. Criação de locação não permitida.");
                        }
                        else
                        {
                            // Criar a nova locação
                            Locacao novaLocacao = new Locacao
                            {
                                VeiculoEscolhido = veiculoEscolhido,
                                Data = data,
                                InicioLocacao = inicioLocacao,
                                TerminoLocacao = terminoLocacao
                            };

                            locacoes.Add(novaLocacao);
                            Console.WriteLine("Locação criada com sucesso.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Data de término inválida.");
                    }
                }
                else
                {
                    Console.WriteLine("Data de início inválida.");
                }
            }
            else
            {
                Console.WriteLine("Data inválida.");
            }

        }



    }


}

