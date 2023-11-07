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
            lbl_Data_Final = new Label();
            lbl_Data_Inicio = new Label();
            lbl_Opcao_Consulta = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btn_Limpar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.White;
            btn_Voltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voltar.Location = new Point(112, 431);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(205, 53);
            btn_Voltar.TabIndex = 1;
            btn_Voltar.Text = "VOLTAR";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, nome_cliente, placa_veiculo, veiculo_escolhido, inicio_locacao, valor_da_diaria, seguro_opicional, termino_locacao, valor_total });
            dataGridView1.Location = new Point(12, 172);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1128, 239);
            dataGridView1.TabIndex = 3;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "codigo";
            codigo.FillWeight = 50F;
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.Width = 50;
            // 
            // nome_cliente
            // 
            nome_cliente.DataPropertyName = "nome_cliente";
            nome_cliente.HeaderText = "Nome Cliente";
            nome_cliente.MinimumWidth = 6;
            nome_cliente.Name = "nome_cliente";
            nome_cliente.Width = 230;
            // 
            // placa_veiculo
            // 
            placa_veiculo.DataPropertyName = "placa_veiculo";
            placa_veiculo.HeaderText = "Placa  Veículo";
            placa_veiculo.MinimumWidth = 6;
            placa_veiculo.Name = "placa_veiculo";
            placa_veiculo.Width = 125;
            // 
            // veiculo_escolhido
            // 
            veiculo_escolhido.DataPropertyName = "veiculo_escolhido";
            veiculo_escolhido.HeaderText = "Veículo ";
            veiculo_escolhido.MinimumWidth = 6;
            veiculo_escolhido.Name = "veiculo_escolhido";
            veiculo_escolhido.Width = 200;
            // 
            // inicio_locacao
            // 
            inicio_locacao.DataPropertyName = "inicio_locacao";
            inicio_locacao.HeaderText = "Data Início Locação";
            inicio_locacao.MinimumWidth = 6;
            inicio_locacao.Name = "inicio_locacao";
            inicio_locacao.Resizable = DataGridViewTriState.True;
            inicio_locacao.Width = 125;
            // 
            // valor_da_diaria
            // 
            valor_da_diaria.DataPropertyName = "valor_da_diaria";
            valor_da_diaria.HeaderText = "Valor Diária";
            valor_da_diaria.MinimumWidth = 6;
            valor_da_diaria.Name = "valor_da_diaria";
            valor_da_diaria.Width = 80;
            // 
            // seguro_opicional
            // 
            seguro_opicional.DataPropertyName = "seguro_opcional";
            seguro_opicional.HeaderText = "Seguro ";
            seguro_opicional.MinimumWidth = 6;
            seguro_opicional.Name = "seguro_opicional";
            seguro_opicional.Width = 60;
            // 
            // termino_locacao
            // 
            termino_locacao.DataPropertyName = "termino_locacao";
            termino_locacao.HeaderText = "Data Término Locação";
            termino_locacao.MinimumWidth = 6;
            termino_locacao.Name = "termino_locacao";
            termino_locacao.Width = 125;
            // 
            // valor_total
            // 
            valor_total.DataPropertyName = "valor_total";
            valor_total.HeaderText = "Valor Total";
            valor_total.MinimumWidth = 6;
            valor_total.Name = "valor_total";
            valor_total.Width = 80;
            // 
            // btn_Consultar
            // 
            btn_Consultar.BackColor = Color.White;
            btn_Consultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Consultar.Location = new Point(451, 431);
            btn_Consultar.Margin = new Padding(3, 4, 3, 4);
            btn_Consultar.Name = "btn_Consultar";
            btn_Consultar.Size = new Size(205, 53);
            btn_Consultar.TabIndex = 4;
            btn_Consultar.Text = "Consultar";
            btn_Consultar.UseVisualStyleBackColor = false;
            btn_Consultar.Click += btn_Consultar_Click;
            // 
            // txt_Nome_Cliente
            // 
            txt_Nome_Cliente.Location = new Point(153, 95);
            txt_Nome_Cliente.Margin = new Padding(3, 4, 3, 4);
            txt_Nome_Cliente.Name = "txt_Nome_Cliente";
            txt_Nome_Cliente.Size = new Size(277, 27);
            txt_Nome_Cliente.TabIndex = 8;
            // 
            // lbl_Nome_Cliente
            // 
            lbl_Nome_Cliente.AutoSize = true;
            lbl_Nome_Cliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nome_Cliente.Location = new Point(14, 96);
            lbl_Nome_Cliente.Name = "lbl_Nome_Cliente";
            lbl_Nome_Cliente.Size = new Size(149, 23);
            lbl_Nome_Cliente.TabIndex = 7;
            lbl_Nome_Cliente.Text = "Nome do Cliente: ";
            // 
            // txt_Placa_Veiculo
            // 
            txt_Placa_Veiculo.Location = new Point(585, 94);
            txt_Placa_Veiculo.Margin = new Padding(3, 4, 3, 4);
            txt_Placa_Veiculo.Name = "txt_Placa_Veiculo";
            txt_Placa_Veiculo.Size = new Size(106, 27);
            txt_Placa_Veiculo.TabIndex = 10;
            // 
            // lbl_Placa_Veiculo
            // 
            lbl_Placa_Veiculo.AutoSize = true;
            lbl_Placa_Veiculo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Placa_Veiculo.Location = new Point(451, 96);
            lbl_Placa_Veiculo.Name = "lbl_Placa_Veiculo";
            lbl_Placa_Veiculo.Size = new Size(139, 23);
            lbl_Placa_Veiculo.TabIndex = 9;
            lbl_Placa_Veiculo.Text = "Placa do Veículo:";
            // 
            // lbl_Data_Final
            // 
            lbl_Data_Final.AutoSize = true;
            lbl_Data_Final.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Data_Final.Location = new Point(912, 97);
            lbl_Data_Final.Name = "lbl_Data_Final";
            lbl_Data_Final.Size = new Size(90, 23);
            lbl_Data_Final.TabIndex = 42;
            lbl_Data_Final.Text = "Data Final:";
            // 
            // lbl_Data_Inicio
            // 
            lbl_Data_Inicio.AutoSize = true;
            lbl_Data_Inicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Data_Inicio.Location = new Point(697, 96);
            lbl_Data_Inicio.Name = "lbl_Data_Inicio";
            lbl_Data_Inicio.Size = new Size(101, 23);
            lbl_Data_Inicio.TabIndex = 40;
            lbl_Data_Inicio.Text = "Data Início: ";
            // 
            // lbl_Opcao_Consulta
            // 
            lbl_Opcao_Consulta.AutoSize = true;
            lbl_Opcao_Consulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Opcao_Consulta.Location = new Point(386, 25);
            lbl_Opcao_Consulta.Name = "lbl_Opcao_Consulta";
            lbl_Opcao_Consulta.Size = new Size(321, 28);
            lbl_Opcao_Consulta.TabIndex = 44;
            lbl_Opcao_Consulta.Text = "***   Escolha Opção de Consulta  ***";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(790, 92);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 27);
            dateTimePicker1.TabIndex = 45;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(995, 92);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(110, 27);
            dateTimePicker2.TabIndex = 46;
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.White;
            btn_Limpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpar.Location = new Point(785, 431);
            btn_Limpar.Margin = new Padding(3, 4, 3, 4);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(205, 53);
            btn_Limpar.TabIndex = 47;
            btn_Limpar.Text = "LIMPAR ";
            btn_Limpar.UseVisualStyleBackColor = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // financeiro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1152, 533);
            Controls.Add(btn_Limpar);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_Opcao_Consulta);
            Controls.Add(lbl_Data_Final);
            Controls.Add(lbl_Data_Inicio);
            Controls.Add(txt_Placa_Veiculo);
            Controls.Add(lbl_Placa_Veiculo);
            Controls.Add(txt_Nome_Cliente);
            Controls.Add(lbl_Nome_Cliente);
            Controls.Add(btn_Consultar);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Voltar);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lbl_Data_Final;
        private Label lbl_Data_Inicio;
        private Label lbl_Opcao_Consulta;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btn_Limpar;
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