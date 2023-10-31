namespace Car_Rental
{
    partial class financeiro
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
            btn_Voltar = new Button();
            btn_Consultas = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.Orange;
            btn_Voltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voltar.Location = new Point(237, 233);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(170, 70);
            btn_Voltar.TabIndex = 1;
            btn_Voltar.Text = "VOLTAR";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // btn_Consultas
            // 
            btn_Consultas.BackColor = Color.YellowGreen;
            btn_Consultas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Consultas.Location = new Point(443, 233);
            btn_Consultas.Name = "btn_Consultas";
            btn_Consultas.Size = new Size(170, 70);
            btn_Consultas.TabIndex = 2;
            btn_Consultas.Text = "CONSULTAR";
            btn_Consultas.UseVisualStyleBackColor = false;
            btn_Consultas.Click += btn_Veiculo_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, nome_cliente, placa_veiculo, veiculo_escolhido, inicio_locacao, valor_da_diaria, seguro_opicional, termino_locacao, valor_total });
            dataGridView1.Location = new Point(17, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(884, 150);
            dataGridView1.TabIndex = 3;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "codigo";
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.Width = 50;
            // 
            // nome_cliente
            // 
            nome_cliente.DataPropertyName = "nome_cliente";
            nome_cliente.HeaderText = "Nome Cliente";
            nome_cliente.Name = "nome_cliente";
            nome_cliente.Width = 250;
            // 
            // placa_veiculo
            // 
            placa_veiculo.DataPropertyName = "placa_veiculo";
            placa_veiculo.HeaderText = "Placa do Veículo";
            placa_veiculo.Name = "placa_veiculo";
            placa_veiculo.Width = 70;
            // 
            // veiculo_escolhido
            // 
            veiculo_escolhido.DataPropertyName = "veiculo_escolhido";
            veiculo_escolhido.HeaderText = "Veículo Escolhido";
            veiculo_escolhido.Name = "veiculo_escolhido";
            veiculo_escolhido.Width = 120;
            // 
            // inicio_locacao
            // 
            inicio_locacao.DataPropertyName = "inicio_locacao";
            inicio_locacao.HeaderText = "Data Início Locação";
            inicio_locacao.Name = "inicio_locacao";
            inicio_locacao.Width = 70;
            // 
            // valor_da_diaria
            // 
            valor_da_diaria.DataPropertyName = "valor_da_diaria";
            valor_da_diaria.HeaderText = "Valor da Diária";
            valor_da_diaria.Name = "valor_da_diaria";
            valor_da_diaria.Width = 80;
            // 
            // seguro_opicional
            // 
            seguro_opicional.DataPropertyName = "seguro_opcional";
            seguro_opicional.HeaderText = "Seguro Opcional";
            seguro_opicional.Name = "seguro_opicional";
            seguro_opicional.Width = 50;
            // 
            // termino_locacao
            // 
            termino_locacao.DataPropertyName = "termino_locacao";
            termino_locacao.HeaderText = "Data Término Locação";
            termino_locacao.Name = "termino_locacao";
            termino_locacao.Width = 70;
            // 
            // valor_total
            // 
            valor_total.DataPropertyName = "valor_total";
            valor_total.HeaderText = "Valor Total";
            valor_total.Name = "valor_total";
            valor_total.Width = 80;
            // 
            // financeiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 334);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Consultas);
            Controls.Add(btn_Voltar);
            Name = "financeiro";
            Text = "financeiro";
            Load += financeiro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Voltar;
        private Button btn_Consultas;
        private DataGridView dataGridView1;
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