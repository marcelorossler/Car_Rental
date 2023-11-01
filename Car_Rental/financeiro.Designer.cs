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
            btn_Consultar = new Button();
            txt_Nome_Cliente = new TextBox();
            lbl_Nome_Cliente = new Label();
            txt_Placa_Veiculo = new TextBox();
            lbl_Placa_Veiculo = new Label();
            mkTxt_Data_Final = new MaskedTextBox();
            lbl_Data_Final = new Label();
            mktxt_Inicio_Locacao = new MaskedTextBox();
            lbl_Data_Inicio = new Label();
            lbl_Opcao_Consulta = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.White;
            btn_Voltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voltar.Location = new Point(248, 323);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(179, 40);
            btn_Voltar.TabIndex = 1;
            btn_Voltar.Text = "VOLTAR";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, nome_cliente, placa_veiculo, veiculo_escolhido, inicio_locacao, valor_da_diaria, seguro_opicional, termino_locacao, valor_total });
            dataGridView1.Location = new Point(12, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(894, 179);
            dataGridView1.TabIndex = 3;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "codigo";
            codigo.FillWeight = 50F;
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
            placa_veiculo.HeaderText = "Placa  Veículo";
            placa_veiculo.Name = "placa_veiculo";
            placa_veiculo.Width = 70;
            // 
            // veiculo_escolhido
            // 
            veiculo_escolhido.DataPropertyName = "veiculo_escolhido";
            veiculo_escolhido.HeaderText = "Veículo ";
            veiculo_escolhido.Name = "veiculo_escolhido";
            veiculo_escolhido.Width = 120;
            // 
            // inicio_locacao
            // 
            inicio_locacao.DataPropertyName = "inicio_locacao";
            inicio_locacao.HeaderText = "Data Início Locação";
            inicio_locacao.Name = "inicio_locacao";
            inicio_locacao.Resizable = DataGridViewTriState.True;
            inicio_locacao.Width = 70;
            // 
            // valor_da_diaria
            // 
            valor_da_diaria.DataPropertyName = "valor_da_diaria";
            valor_da_diaria.HeaderText = "Valor Diária";
            valor_da_diaria.Name = "valor_da_diaria";
            valor_da_diaria.Width = 80;
            // 
            // seguro_opicional
            // 
            seguro_opicional.DataPropertyName = "seguro_opcional";
            seguro_opicional.HeaderText = "Seguro ";
            seguro_opicional.Name = "seguro_opicional";
            seguro_opicional.Width = 60;
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
            // btn_Consultar
            // 
            btn_Consultar.BackColor = Color.White;
            btn_Consultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Consultar.Location = new Point(510, 323);
            btn_Consultar.Name = "btn_Consultar";
            btn_Consultar.Size = new Size(179, 40);
            btn_Consultar.TabIndex = 4;
            btn_Consultar.Text = "Consultar";
            btn_Consultar.UseVisualStyleBackColor = false;
            btn_Consultar.Click += btn_Consultar_Click;
            // 
            // txt_Nome_Cliente
            // 
            txt_Nome_Cliente.Location = new Point(120, 71);
            txt_Nome_Cliente.Name = "txt_Nome_Cliente";
            txt_Nome_Cliente.Size = new Size(257, 23);
            txt_Nome_Cliente.TabIndex = 8;
            // 
            // lbl_Nome_Cliente
            // 
            lbl_Nome_Cliente.AutoSize = true;
            lbl_Nome_Cliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nome_Cliente.Location = new Point(12, 72);
            lbl_Nome_Cliente.Name = "lbl_Nome_Cliente";
            lbl_Nome_Cliente.Size = new Size(114, 17);
            lbl_Nome_Cliente.TabIndex = 7;
            lbl_Nome_Cliente.Text = "Nome do Cliente: ";
            // 
            // txt_Placa_Veiculo
            // 
            txt_Placa_Veiculo.Location = new Point(498, 71);
            txt_Placa_Veiculo.Name = "txt_Placa_Veiculo";
            txt_Placa_Veiculo.Size = new Size(93, 23);
            txt_Placa_Veiculo.TabIndex = 10;
            // 
            // lbl_Placa_Veiculo
            // 
            lbl_Placa_Veiculo.AutoSize = true;
            lbl_Placa_Veiculo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Placa_Veiculo.Location = new Point(395, 72);
            lbl_Placa_Veiculo.Name = "lbl_Placa_Veiculo";
            lbl_Placa_Veiculo.Size = new Size(106, 17);
            lbl_Placa_Veiculo.TabIndex = 9;
            lbl_Placa_Veiculo.Text = "Placa do Veículo:";
            // 
            // mkTxt_Data_Final
            // 
            mkTxt_Data_Final.Location = new Point(835, 67);
            mkTxt_Data_Final.Mask = "00/00/0000";
            mkTxt_Data_Final.Name = "mkTxt_Data_Final";
            mkTxt_Data_Final.Size = new Size(62, 23);
            mkTxt_Data_Final.TabIndex = 43;
            mkTxt_Data_Final.ValidatingType = typeof(DateTime);
            // 
            // lbl_Data_Final
            // 
            lbl_Data_Final.AutoSize = true;
            lbl_Data_Final.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Data_Final.Location = new Point(769, 73);
            lbl_Data_Final.Name = "lbl_Data_Final";
            lbl_Data_Final.Size = new Size(68, 17);
            lbl_Data_Final.TabIndex = 42;
            lbl_Data_Final.Text = "Data Final:";
            // 
            // mktxt_Inicio_Locacao
            // 
            mktxt_Inicio_Locacao.Location = new Point(680, 67);
            mktxt_Inicio_Locacao.Mask = "00/00/0000";
            mktxt_Inicio_Locacao.Name = "mktxt_Inicio_Locacao";
            mktxt_Inicio_Locacao.Size = new Size(66, 23);
            mktxt_Inicio_Locacao.TabIndex = 41;
            mktxt_Inicio_Locacao.ValidatingType = typeof(DateTime);
            // 
            // lbl_Data_Inicio
            // 
            lbl_Data_Inicio.AutoSize = true;
            lbl_Data_Inicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Data_Inicio.Location = new Point(610, 72);
            lbl_Data_Inicio.Name = "lbl_Data_Inicio";
            lbl_Data_Inicio.Size = new Size(76, 17);
            lbl_Data_Inicio.TabIndex = 40;
            lbl_Data_Inicio.Text = "Data Início: ";
            // 
            // lbl_Opcao_Consulta
            // 
            lbl_Opcao_Consulta.AutoSize = true;
            lbl_Opcao_Consulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Opcao_Consulta.Location = new Point(338, 19);
            lbl_Opcao_Consulta.Name = "lbl_Opcao_Consulta";
            lbl_Opcao_Consulta.Size = new Size(259, 21);
            lbl_Opcao_Consulta.TabIndex = 44;
            lbl_Opcao_Consulta.Text = "***   Escolha Opção de Consulta  ***";
            // 
            // financeiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(926, 400);
            Controls.Add(lbl_Opcao_Consulta);
            Controls.Add(mkTxt_Data_Final);
            Controls.Add(lbl_Data_Final);
            Controls.Add(mktxt_Inicio_Locacao);
            Controls.Add(lbl_Data_Inicio);
            Controls.Add(txt_Placa_Veiculo);
            Controls.Add(lbl_Placa_Veiculo);
            Controls.Add(txt_Nome_Cliente);
            Controls.Add(lbl_Nome_Cliente);
            Controls.Add(btn_Consultar);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Voltar);
            Name = "financeiro";
            Text = "FINANCEIRO";
            Load += financeiro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Voltar;
        private DataGridView dataGridView1;
        private Button btn_Consultar;
        private TextBox txt_Nome_Cliente;
        private Label lbl_Nome_Cliente;
        private TextBox txt_Placa_Veiculo;
        private Label lbl_Placa_Veiculo;
        private MaskedTextBox mkTxt_Data_Final;
        private Label lbl_Data_Final;
        private MaskedTextBox mktxt_Inicio_Locacao;
        private Label lbl_Data_Inicio;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nome_cliente;
        private DataGridViewTextBoxColumn placa_veiculo;
        private DataGridViewTextBoxColumn veiculo_escolhido;
        private DataGridViewTextBoxColumn inicio_locacao;
        private DataGridViewTextBoxColumn valor_da_diaria;
        private DataGridViewTextBoxColumn seguro_opicional;
        private DataGridViewTextBoxColumn termino_locacao;
        private DataGridViewTextBoxColumn valor_total;
        private Label lbl_Opcao_Consulta;
    }
}