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
            codigo = new DataGridViewTextBoxColumn();
            marca = new DataGridViewTextBoxColumn();
            modelo = new DataGridViewTextBoxColumn();
            cor = new DataGridViewTextBoxColumn();
            placa = new DataGridViewTextBoxColumn();
            btn_Cadastrar = new Button();
            btn_Alterar = new Button();
            btn_Voltar = new Button();
            btn_Excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, marca, modelo, cor, placa });
            dataGridView1.Location = new Point(14, 53);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 200);
            dataGridView1.TabIndex = 0;
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
            // marca
            // 
            marca.DataPropertyName = "Marca";
            marca.HeaderText = "Marca";
            marca.MinimumWidth = 6;
            marca.Name = "marca";
            marca.Width = 200;
            // 
            // modelo
            // 
            modelo.DataPropertyName = "modelo";
            modelo.HeaderText = "Modelo";
            modelo.MinimumWidth = 6;
            modelo.Name = "modelo";
            modelo.Width = 200;
            // 
            // cor
            // 
            cor.DataPropertyName = "cor";
            cor.HeaderText = "Cor";
            cor.MinimumWidth = 6;
            cor.Name = "cor";
            cor.Width = 125;
            // 
            // placa
            // 
            placa.DataPropertyName = "placa";
            placa.HeaderText = "Placa";
            placa.MinimumWidth = 6;
            placa.Name = "placa";
            placa.Width = 125;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.BackColor = Color.LightBlue;
            btn_Cadastrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cadastrar.Location = new Point(226, 295);
            btn_Cadastrar.Margin = new Padding(3, 4, 3, 4);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(137, 80);
            btn_Cadastrar.TabIndex = 1;
            btn_Cadastrar.Text = "CADASTRAR NOVO";
            btn_Cadastrar.UseVisualStyleBackColor = false;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // btn_Alterar
            // 
            btn_Alterar.BackColor = Color.LightSkyBlue;
            btn_Alterar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Alterar.Location = new Point(443, 295);
            btn_Alterar.Margin = new Padding(3, 4, 3, 4);
            btn_Alterar.Name = "btn_Alterar";
            btn_Alterar.Size = new Size(137, 80);
            btn_Alterar.TabIndex = 2;
            btn_Alterar.Text = "ALTERAR";
            btn_Alterar.UseVisualStyleBackColor = false;
            btn_Alterar.Click += btn_Alterar_Click;
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.SteelBlue;
            btn_Voltar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voltar.Location = new Point(14, 295);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(137, 80);
            btn_Voltar.TabIndex = 3;
            btn_Voltar.Text = "VOLTAR";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // btn_Excluir
            // 
            btn_Excluir.BackColor = Color.SkyBlue;
            btn_Excluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Excluir.Location = new Point(653, 295);
            btn_Excluir.Margin = new Padding(3, 4, 3, 4);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(137, 80);
            btn_Excluir.TabIndex = 4;
            btn_Excluir.Text = "EXCLUIR";
            btn_Excluir.UseVisualStyleBackColor = false;
            btn_Excluir.Click += btn_Excluir_Click;
            // 
            // Veiculos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(808, 422);
            Controls.Add(btn_Excluir);
            Controls.Add(btn_Voltar);
            Controls.Add(btn_Alterar);
            Controls.Add(btn_Cadastrar);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
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