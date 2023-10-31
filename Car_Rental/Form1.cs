namespace Car_Rental
{
    public partial class frm_Car_Rental : Form
    {
        public frm_Car_Rental()
        {
            InitializeComponent();
        }

        private void frm_Car_Rental_Load(object sender, EventArgs e)
        {

        }

        private void btn_Consulta_Clientes_Click(object sender, EventArgs e)
        {
            frm_Clientes form = new frm_Clientes();
            form.ShowDialog();

        }
        private void btn_Consulta_Veiculos_Click(object sender, EventArgs e)
        {
            Veiculos form = new Veiculos();
            form.ShowDialog();
        }

        private void btn_Consulta_Locacoes_Click(object sender, EventArgs e)
        {
            Locacao form = new Locacao ();
            form.ShowDialog();

        }

        private void tn_Consulta_Financeiro_Click(object sender, EventArgs e)
        {
            financeiro form = new financeiro();
            form.ShowDialog();

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(" Deseja realmente fechar o Programa ? ");
                Close();
            }

            {
                Application.Exit();
            }

        }



    }
}