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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
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
            lbl_Nome_Cliente = new Label();
            lbl_Placa_Veiculo = new Label();
            lbl_Data_Final = new Label();
            lbl_Data_Inicio = new Label();
            lbl_Opcao_Consulta = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            ComboxCliente = new ComboBox();
            ComboxPlaca = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.SlateGray;
            btn_Voltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voltar.Location = new Point(313, 413);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(225, 74);
            btn_Voltar.TabIndex = 1;
            btn_Voltar.Text = "VOLTAR";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, nome_cliente, placa_veiculo, veiculo_escolhido, inicio_locacao, valor_da_diaria, seguro_opicional, termino_locacao, valor_total });
            dataGridView1.Location = new Point(12, 110);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1135, 281);
            dataGridView1.TabIndex = 3;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "codigo";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            codigo.DefaultCellStyle = dataGridViewCellStyle1;
            codigo.FillWeight = 50F;
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.Width = 65;
            // 
            // nome_cliente
            // 
            nome_cliente.DataPropertyName = "nome_cliente";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopLeft;
            nome_cliente.DefaultCellStyle = dataGridViewCellStyle2;
            nome_cliente.HeaderText = "Nome Cliente";
            nome_cliente.MinimumWidth = 6;
            nome_cliente.Name = "nome_cliente";
            nome_cliente.Width = 255;
            // 
            // placa_veiculo
            // 
            placa_veiculo.DataPropertyName = "placa_veiculo";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            placa_veiculo.DefaultCellStyle = dataGridViewCellStyle3;
            placa_veiculo.HeaderText = "Placa  Veículo";
            placa_veiculo.MinimumWidth = 6;
            placa_veiculo.Name = "placa_veiculo";
            placa_veiculo.Width = 85;
            // 
            // veiculo_escolhido
            // 
            veiculo_escolhido.DataPropertyName = "veiculo_escolhido";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopLeft;
            veiculo_escolhido.DefaultCellStyle = dataGridViewCellStyle4;
            veiculo_escolhido.HeaderText = "Veículo ";
            veiculo_escolhido.MinimumWidth = 6;
            veiculo_escolhido.Name = "veiculo_escolhido";
            veiculo_escolhido.Width = 240;
            // 
            // inicio_locacao
            // 
            inicio_locacao.DataPropertyName = "inicio_locacao";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopLeft;
            inicio_locacao.DefaultCellStyle = dataGridViewCellStyle5;
            inicio_locacao.HeaderText = "Data Início Locação";
            inicio_locacao.MinimumWidth = 6;
            inicio_locacao.Name = "inicio_locacao";
            inicio_locacao.Resizable = DataGridViewTriState.True;
            inicio_locacao.Width = 95;
            // 
            // valor_da_diaria
            // 
            valor_da_diaria.DataPropertyName = "valor_da_diaria";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopCenter;
            valor_da_diaria.DefaultCellStyle = dataGridViewCellStyle6;
            valor_da_diaria.HeaderText = "Valor Diária";
            valor_da_diaria.MinimumWidth = 6;
            valor_da_diaria.Name = "valor_da_diaria";
            valor_da_diaria.Width = 70;
            // 
            // seguro_opicional
            // 
            seguro_opicional.DataPropertyName = "seguro_opcional";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopCenter;
            seguro_opicional.DefaultCellStyle = dataGridViewCellStyle7;
            seguro_opicional.HeaderText = "Seguro ";
            seguro_opicional.MinimumWidth = 6;
            seguro_opicional.Name = "seguro_opicional";
            seguro_opicional.Width = 60;
            // 
            // termino_locacao
            // 
            termino_locacao.DataPropertyName = "termino_locacao";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.TopLeft;
            termino_locacao.DefaultCellStyle = dataGridViewCellStyle8;
            termino_locacao.HeaderText = "Data Término Locação";
            termino_locacao.MinimumWidth = 6;
            termino_locacao.Name = "termino_locacao";
            termino_locacao.Width = 95;
            // 
            // valor_total
            // 
            valor_total.DataPropertyName = "valor_total";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.TopCenter;
            valor_total.DefaultCellStyle = dataGridViewCellStyle9;
            valor_total.HeaderText = "Valor Total";
            valor_total.MinimumWidth = 6;
            valor_total.Name = "valor_total";
            valor_total.Width = 90;
            // 
            // btn_Consultar
            // 
            btn_Consultar.BackColor = Color.SlateGray;
            btn_Consultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Consultar.Location = new Point(618, 413);
            btn_Consultar.Margin = new Padding(3, 4, 3, 4);
            btn_Consultar.Name = "btn_Consultar";
            btn_Consultar.Size = new Size(222, 74);
            btn_Consultar.TabIndex = 4;
            btn_Consultar.Text = "CONSULTAR";
            btn_Consultar.UseVisualStyleBackColor = false;
            btn_Consultar.Click += btn_Consultar_Click;
            // 
            // lbl_Nome_Cliente
            // 
            lbl_Nome_Cliente.AutoSize = true;
            lbl_Nome_Cliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nome_Cliente.Location = new Point(15, 29);
            lbl_Nome_Cliente.Name = "lbl_Nome_Cliente";
            lbl_Nome_Cliente.Size = new Size(149, 23);
            lbl_Nome_Cliente.TabIndex = 7;
            lbl_Nome_Cliente.Text = "Nome do Cliente: ";
            // 
            // lbl_Placa_Veiculo
            // 
            lbl_Placa_Veiculo.AutoSize = true;
            lbl_Placa_Veiculo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Placa_Veiculo.Location = new Point(638, 29);
            lbl_Placa_Veiculo.Name = "lbl_Placa_Veiculo";
            lbl_Placa_Veiculo.Size = new Size(139, 23);
            lbl_Placa_Veiculo.TabIndex = 9;
            lbl_Placa_Veiculo.Text = "Placa do Veículo:";
            // 
            // lbl_Data_Final
            // 
            lbl_Data_Final.AutoSize = true;
            lbl_Data_Final.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Data_Final.Location = new Point(1007, 29);
            lbl_Data_Final.Name = "lbl_Data_Final";
            lbl_Data_Final.Size = new Size(90, 23);
            lbl_Data_Final.TabIndex = 42;
            lbl_Data_Final.Text = "Data Final:";
            // 
            // lbl_Data_Inicio
            // 
            lbl_Data_Inicio.AutoSize = true;
            lbl_Data_Inicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Data_Inicio.Location = new Point(845, 29);
            lbl_Data_Inicio.Name = "lbl_Data_Inicio";
            lbl_Data_Inicio.Size = new Size(101, 23);
            lbl_Data_Inicio.TabIndex = 40;
            lbl_Data_Inicio.Text = "Data Início: ";
            // 
            // lbl_Opcao_Consulta
            // 
            lbl_Opcao_Consulta.AutoSize = true;
            lbl_Opcao_Consulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Opcao_Consulta.Location = new Point(371, 55);
            lbl_Opcao_Consulta.Name = "lbl_Opcao_Consulta";
            lbl_Opcao_Consulta.Size = new Size(196, 28);
            lbl_Opcao_Consulta.TabIndex = 44;
            lbl_Opcao_Consulta.Text = " Opções de Consulta ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(836, 56);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 27);
            dateTimePicker1.TabIndex = 45;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(996, 56);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(110, 27);
            dateTimePicker2.TabIndex = 46;
            // 
            // ComboxCliente
            // 
            ComboxCliente.FormattingEnabled = true;
            ComboxCliente.Location = new Point(15, 58);
            ComboxCliente.Name = "ComboxCliente";
            ComboxCliente.Size = new Size(277, 28);
            ComboxCliente.TabIndex = 48;
            // 
            // ComboxPlaca
            // 
            ComboxPlaca.FormattingEnabled = true;
            ComboxPlaca.Location = new Point(650, 58);
            ComboxPlaca.Name = "ComboxPlaca";
            ComboxPlaca.Size = new Size(106, 28);
            ComboxPlaca.TabIndex = 49;
            // 
            // financeiro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1163, 500);
            Controls.Add(ComboxPlaca);
            Controls.Add(ComboxCliente);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_Opcao_Consulta);
            Controls.Add(lbl_Data_Final);
            Controls.Add(lbl_Data_Inicio);
            Controls.Add(lbl_Placa_Veiculo);
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
        private ComboBox ComboxCliente;
        private ComboBox ComboxPlaca;
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