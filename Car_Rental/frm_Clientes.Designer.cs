namespace Car_Rental
{
    partial class frm_Clientes
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
            btn_Alterar = new Button();
            btn_Excluir = new Button();
            btn_Incluir = new Button();
            btnVoltar = new Button();
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            cpf = new DataGridViewTextBoxColumn();
            endereco = new DataGridViewTextBoxColumn();
            nascimento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_Alterar
            // 
            btn_Alterar.BackColor = Color.YellowGreen;
            btn_Alterar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Alterar.ForeColor = Color.Black;
            btn_Alterar.Location = new Point(503, 312);
            btn_Alterar.Margin = new Padding(3, 4, 3, 4);
            btn_Alterar.Name = "btn_Alterar";
            btn_Alterar.Size = new Size(163, 68);
            btn_Alterar.TabIndex = 8;
            btn_Alterar.Text = "ALTERAR";
            btn_Alterar.UseVisualStyleBackColor = false;
            btn_Alterar.Click += btn_Alterar_Click;
            // 
            // btn_Excluir
            // 
            btn_Excluir.BackColor = Color.MediumSeaGreen;
            btn_Excluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Excluir.ForeColor = Color.Black;
            btn_Excluir.Location = new Point(731, 312);
            btn_Excluir.Margin = new Padding(3, 4, 3, 4);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(167, 68);
            btn_Excluir.TabIndex = 7;
            btn_Excluir.Text = "EXCLUIR";
            btn_Excluir.UseVisualStyleBackColor = false;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // btn_Incluir
            // 
            btn_Incluir.BackColor = Color.OliveDrab;
            btn_Incluir.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Incluir.ForeColor = Color.Black;
            btn_Incluir.Location = new Point(271, 312);
            btn_Incluir.Margin = new Padding(3, 4, 3, 4);
            btn_Incluir.Name = "btn_Incluir";
            btn_Incluir.Size = new Size(167, 68);
            btn_Incluir.TabIndex = 6;
            btn_Incluir.Text = "INCLUIR NOVO ";
            btn_Incluir.UseVisualStyleBackColor = false;
            btn_Incluir.Click += btn_Incluir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Green;
            btnVoltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(14, 312);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(173, 68);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "VOLTAR";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, nome, cpf, endereco, nascimento });
            dataGridView1.Location = new Point(14, 64);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(884, 200);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "codigo";
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.Width = 70;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Nome";
            nome.MinimumWidth = 6;
            nome.Name = "nome";
            nome.Width = 230;
            // 
            // cpf
            // 
            cpf.DataPropertyName = "cpf";
            cpf.HeaderText = "CPF";
            cpf.MinimumWidth = 6;
            cpf.Name = "cpf";
            cpf.Width = 125;
            // 
            // endereco
            // 
            endereco.DataPropertyName = "Endereco";
            endereco.HeaderText = "Endereço";
            endereco.MinimumWidth = 6;
            endereco.Name = "endereco";
            endereco.Width = 280;
            // 
            // nascimento
            // 
            nascimento.DataPropertyName = "nascimento";
            nascimento.HeaderText = "Data Nascimento";
            nascimento.MinimumWidth = 6;
            nascimento.Name = "nascimento";
            nascimento.Width = 125;
            // 
            // frm_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(918, 473);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Alterar);
            Controls.Add(btn_Excluir);
            Controls.Add(btn_Incluir);
            Controls.Add(btnVoltar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_Clientes";
            Text = "Clientes";
            Load += frm_Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Alterar;
        private Button btn_Excluir;
        private Button btn_Incluir;
        private Button btnVoltar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn cpf;
        private DataGridViewTextBoxColumn endereco;
        private DataGridViewTextBoxColumn nascimento;
    }
}