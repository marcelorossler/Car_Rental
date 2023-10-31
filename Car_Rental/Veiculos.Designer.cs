namespace Car_Rental
{
    partial class Veiculos
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
            btn_Cadastrar = new Button();
            btn_Alterar = new Button();
            btn_Voltar = new Button();
            btn_Excluir = new Button();
            codigo = new DataGridViewTextBoxColumn();
            marca = new DataGridViewTextBoxColumn();
            modelo = new DataGridViewTextBoxColumn();
            cor = new DataGridViewTextBoxColumn();
            placa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, marca, modelo, cor, placa });
            dataGridView1.Location = new Point(12, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(714, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.BackColor = Color.Green;
            btn_Cadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cadastrar.Location = new Point(219, 237);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(120, 60);
            btn_Cadastrar.TabIndex = 1;
            btn_Cadastrar.Text = "CADASTRAR NOVO";
            btn_Cadastrar.UseVisualStyleBackColor = false;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // btn_Alterar
            // 
            btn_Alterar.BackColor = Color.Yellow;
            btn_Alterar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Alterar.Location = new Point(414, 237);
            btn_Alterar.Name = "btn_Alterar";
            btn_Alterar.Size = new Size(120, 60);
            btn_Alterar.TabIndex = 2;
            btn_Alterar.Text = "ALTERAR";
            btn_Alterar.UseVisualStyleBackColor = false;
            btn_Alterar.Click += btn_Alterar_Click;
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.Orange;
            btn_Voltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voltar.Location = new Point(12, 237);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(120, 60);
            btn_Voltar.TabIndex = 3;
            btn_Voltar.Text = "VOLTAR";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // btn_Excluir
            // 
            btn_Excluir.BackColor = Color.Red;
            btn_Excluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Excluir.Location = new Point(606, 237);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(120, 60);
            btn_Excluir.TabIndex = 4;
            btn_Excluir.Text = "EXCLUIR";
            btn_Excluir.UseVisualStyleBackColor = false;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // codigo
            // 
            codigo.DataPropertyName = "codigo";
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.Width = 70;
            // 
            // marca
            // 
            marca.DataPropertyName = "Marca";
            marca.HeaderText = "Marca";
            marca.Name = "marca";
            marca.Width = 200;
            // 
            // modelo
            // 
            modelo.DataPropertyName = "modelo";
            modelo.HeaderText = "Modelo";
            modelo.Name = "modelo";
            modelo.Width = 200;
            // 
            // cor
            // 
            cor.DataPropertyName = "cor";
            cor.HeaderText = "Cor";
            cor.Name = "cor";
            // 
            // placa
            // 
            placa.DataPropertyName = "placa";
            placa.HeaderText = "Placa";
            placa.Name = "placa";
            // 
            // Veiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 350);
            Controls.Add(btn_Excluir);
            Controls.Add(btn_Voltar);
            Controls.Add(btn_Alterar);
            Controls.Add(btn_Cadastrar);
            Controls.Add(dataGridView1);
            Name = "Veiculos";
            Text = "Veiculos";
            Load += Veiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_Cadastrar;
        private Button btn_Alterar;
        private Button btn_Voltar;
        private Button btn_Excluir;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn marca;
        private DataGridViewTextBoxColumn modelo;
        private DataGridViewTextBoxColumn cor;
        private DataGridViewTextBoxColumn placa;
    }
}