namespace Car_Rental
{
    partial class Locacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            nome_cliente = new DataGridViewTextBoxColumn();
            placa_veiculo = new DataGridViewTextBoxColumn();
            veiculo_escolhido = new DataGridViewTextBoxColumn();
            inicio_locacao = new DataGridViewTextBoxColumn();
            valor_da_diaria = new DataGridViewTextBoxColumn();
            seguro_opicional = new DataGridViewTextBoxColumn();
            termino_locacao = new DataGridViewTextBoxColumn();
            valor_total = new DataGridViewTextBoxColumn();
            btn_Cadastrar = new Button();
            btn_Alterar_Dados = new Button();
            btn_Voltar = new Button();
            btn_Excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, nome_cliente, placa_veiculo, veiculo_escolhido, inicio_locacao, valor_da_diaria, seguro_opicional, termino_locacao, valor_total });
            dataGridView1.Location = new Point(12, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1134, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "codigo";
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.Width = 70;
            // 
            // nome_cliente
            // 
            nome_cliente.DataPropertyName = "nome_cliente";
            nome_cliente.HeaderText = "Nome Cliente";
            nome_cliente.Name = "nome_cliente";
            nome_cliente.Width = 300;
            // 
            // placa_veiculo
            // 
            placa_veiculo.DataPropertyName = "placa_veiculo";
            placa_veiculo.HeaderText = "Placa do Veículo";
            placa_veiculo.Name = "placa_veiculo";
            // 
            // veiculo_escolhido
            // 
            veiculo_escolhido.DataPropertyName = "veiculo_escolhido";
            veiculo_escolhido.HeaderText = "Veículo Escolhido";
            veiculo_escolhido.Name = "veiculo_escolhido";
            veiculo_escolhido.Width = 150;
            // 
            // inicio_locacao
            // 
            inicio_locacao.DataPropertyName = "inicio_locacao";
            inicio_locacao.HeaderText = "Data Início Locação";
            inicio_locacao.Name = "inicio_locacao";
            // 
            // valor_da_diaria
            // 
            valor_da_diaria.DataPropertyName = "valor_da_diaria";
            valor_da_diaria.HeaderText = "Valor da Diária";
            valor_da_diaria.Name = "valor_da_diaria";
            // 
            // seguro_opicional
            // 
            seguro_opicional.DataPropertyName = "seguro_opcional";
            seguro_opicional.HeaderText = "Seguro Opcional";
            seguro_opicional.Name = "seguro_opicional";
            seguro_opicional.Width = 70;
            // 
            // termino_locacao
            // 
            termino_locacao.DataPropertyName = "termino_locacao";
            termino_locacao.HeaderText = "Data Término Locação";
            termino_locacao.Name = "termino_locacao";
            // 
            // valor_total
            // 
            valor_total.DataPropertyName = "valor_total";
            valor_total.HeaderText = "Valor Total";
            valor_total.Name = "valor_total";
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.BackColor = Color.Green;
            btn_Cadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cadastrar.Location = new Point(273, 213);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(122, 62);
            btn_Cadastrar.TabIndex = 1;
            btn_Cadastrar.Text = "Cadastrar Novo";
            btn_Cadastrar.UseVisualStyleBackColor = false;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // btn_Alterar_Dados
            // 
            btn_Alterar_Dados.BackColor = Color.Yellow;
            btn_Alterar_Dados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Alterar_Dados.Location = new Point(462, 213);
            btn_Alterar_Dados.Name = "btn_Alterar_Dados";
            btn_Alterar_Dados.Size = new Size(122, 62);
            btn_Alterar_Dados.TabIndex = 2;
            btn_Alterar_Dados.Text = "Alterar Dados";
            btn_Alterar_Dados.UseVisualStyleBackColor = false;
            btn_Alterar_Dados.Click += btn_Alterar_Dados_Click;
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.Orange;
            btn_Voltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voltar.Location = new Point(88, 213);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(122, 62);
            btn_Voltar.TabIndex = 3;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // btn_Excluir
            // 
            btn_Excluir.BackColor = Color.Red;
            btn_Excluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Excluir.Location = new Point(634, 213);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(122, 62);
            btn_Excluir.TabIndex = 4;
            btn_Excluir.Text = "Excluir";
            btn_Excluir.UseVisualStyleBackColor = false;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // Locacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 320);
            Controls.Add(btn_Excluir);
            Controls.Add(btn_Voltar);
            Controls.Add(btn_Alterar_Dados);
            Controls.Add(btn_Cadastrar);
            Controls.Add(dataGridView1);
            Name = "Locacao";
            Text = "Locação";
            Load += Locacao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_Cadastrar;
        private Button btn_Alterar_Dados;
        private Button btn_Voltar;
        private Button btn_Excluir;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nome_cliente;
        private DataGridViewTextBoxColumn placa_veiculo;
        private DataGridViewTextBoxColumn veiculo_escolhido;
        private DataGridViewTextBoxColumn inicio_locacao;
        private DataGridViewTextBoxColumn valor_da_diaria;
        private DataGridViewTextBoxColumn seguro_opicional;
        private DataGridViewTextBoxColumn termino_locacao;
        private DataGridViewTextBoxColumn valor_total;
    }
}