namespace Car_Rental
{
    partial class Formulario_Consultas
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
            txt_Nome_Cliente = new TextBox();
            lbl_Nome_Cliente = new Label();
            txt_Dados_Veiculo = new TextBox();
            lbl_Dados_Veiculo = new Label();
            mktxt_Inicio = new MaskedTextBox();
            lbl_Data_Inicio = new Label();
            lbl_Cpf = new Label();
            mktxt_Cpf = new MaskedTextBox();
            label1 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            lbl_Valor_Locacao = new Label();
            mktxt_Termino = new MaskedTextBox();
            lbl_Data_Termino = new Label();
            btn_Voltar = new Button();
            btn_Consultar = new Button();
            btn_Limpar = new Button();
            SuspendLayout();
            // 
            // txt_Nome_Cliente
            // 
            txt_Nome_Cliente.Location = new Point(12, 54);
            txt_Nome_Cliente.Name = "txt_Nome_Cliente";
            txt_Nome_Cliente.Size = new Size(400, 23);
            txt_Nome_Cliente.TabIndex = 23;
            // 
            // lbl_Nome_Cliente
            // 
            lbl_Nome_Cliente.AutoSize = true;
            lbl_Nome_Cliente.Location = new Point(12, 36);
            lbl_Nome_Cliente.Name = "lbl_Nome_Cliente";
            lbl_Nome_Cliente.Size = new Size(147, 15);
            lbl_Nome_Cliente.TabIndex = 22;
            lbl_Nome_Cliente.Text = "Consulta Nome do Cliente";
            // 
            // txt_Dados_Veiculo
            // 
            txt_Dados_Veiculo.Location = new Point(12, 122);
            txt_Dados_Veiculo.Name = "txt_Dados_Veiculo";
            txt_Dados_Veiculo.Size = new Size(400, 23);
            txt_Dados_Veiculo.TabIndex = 25;
            // 
            // lbl_Dados_Veiculo
            // 
            lbl_Dados_Veiculo.AutoSize = true;
            lbl_Dados_Veiculo.Location = new Point(12, 104);
            lbl_Dados_Veiculo.Name = "lbl_Dados_Veiculo";
            lbl_Dados_Veiculo.Size = new Size(131, 15);
            lbl_Dados_Veiculo.TabIndex = 24;
            lbl_Dados_Veiculo.Text = "Consulta Dados Veiculo";
            // 
            // mktxt_Inicio
            // 
            mktxt_Inicio.Location = new Point(12, 194);
            mktxt_Inicio.Mask = "00/00/0000";
            mktxt_Inicio.Name = "mktxt_Inicio";
            mktxt_Inicio.Size = new Size(87, 23);
            mktxt_Inicio.TabIndex = 30;
            mktxt_Inicio.ValidatingType = typeof(DateTime);
            // 
            // lbl_Data_Inicio
            // 
            lbl_Data_Inicio.AutoSize = true;
            lbl_Data_Inicio.Location = new Point(7, 176);
            lbl_Data_Inicio.Name = "lbl_Data_Inicio";
            lbl_Data_Inicio.Size = new Size(79, 15);
            lbl_Data_Inicio.TabIndex = 29;
            lbl_Data_Inicio.Text = "Data de Início";
            // 
            // lbl_Cpf
            // 
            lbl_Cpf.AutoSize = true;
            lbl_Cpf.Location = new Point(428, 36);
            lbl_Cpf.Name = "lbl_Cpf";
            lbl_Cpf.Size = new Size(83, 15);
            lbl_Cpf.TabIndex = 31;
            lbl_Cpf.Text = "Cpf do Cliente";
            // 
            // mktxt_Cpf
            // 
            mktxt_Cpf.Location = new Point(428, 54);
            mktxt_Cpf.Mask = "000,000,000-00";
            mktxt_Cpf.Name = "mktxt_Cpf";
            mktxt_Cpf.Size = new Size(87, 23);
            mktxt_Cpf.TabIndex = 32;
            mktxt_Cpf.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(428, 104);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 33;
            label1.Text = "Placa Veículo";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(424, 122);
            maskedTextBox2.Mask = "0000 0A00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(87, 23);
            maskedTextBox2.TabIndex = 34;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(273, 194);
            maskedTextBox3.Mask = "$00000,00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(87, 23);
            maskedTextBox3.TabIndex = 35;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // lbl_Valor_Locacao
            // 
            lbl_Valor_Locacao.AutoSize = true;
            lbl_Valor_Locacao.Location = new Point(273, 176);
            lbl_Valor_Locacao.Name = "lbl_Valor_Locacao";
            lbl_Valor_Locacao.Size = new Size(112, 15);
            lbl_Valor_Locacao.TabIndex = 36;
            lbl_Valor_Locacao.Text = "Valores de Locações";
            // 
            // mktxt_Termino
            // 
            mktxt_Termino.Location = new Point(139, 194);
            mktxt_Termino.Mask = "00/00/0000";
            mktxt_Termino.Name = "mktxt_Termino";
            mktxt_Termino.Size = new Size(87, 23);
            mktxt_Termino.TabIndex = 38;
            mktxt_Termino.ValidatingType = typeof(DateTime);
            // 
            // lbl_Data_Termino
            // 
            lbl_Data_Termino.AutoSize = true;
            lbl_Data_Termino.Location = new Point(134, 176);
            lbl_Data_Termino.Name = "lbl_Data_Termino";
            lbl_Data_Termino.Size = new Size(93, 15);
            lbl_Data_Termino.TabIndex = 37;
            lbl_Data_Termino.Text = "Data de Término";
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.Orange;
            btn_Voltar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voltar.Location = new Point(28, 252);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(131, 76);
            btn_Voltar.TabIndex = 39;
            btn_Voltar.Text = "VOLTAR";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // btn_Consultar
            // 
            btn_Consultar.BackColor = Color.Green;
            btn_Consultar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Consultar.Location = new Point(210, 252);
            btn_Consultar.Name = "btn_Consultar";
            btn_Consultar.Size = new Size(131, 76);
            btn_Consultar.TabIndex = 40;
            btn_Consultar.Text = "CONSULTAR";
            btn_Consultar.UseVisualStyleBackColor = false;
            btn_Consultar.Click += btn_Consultar_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.Yellow;
            btn_Limpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpar.Location = new Point(384, 252);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(131, 76);
            btn_Limpar.TabIndex = 41;
            btn_Limpar.Text = "LIMPAR";
            btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // Formulario_Consultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 375);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_Consultar);
            Controls.Add(btn_Voltar);
            Controls.Add(mktxt_Termino);
            Controls.Add(lbl_Data_Termino);
            Controls.Add(lbl_Valor_Locacao);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(label1);
            Controls.Add(mktxt_Cpf);
            Controls.Add(lbl_Cpf);
            Controls.Add(mktxt_Inicio);
            Controls.Add(lbl_Data_Inicio);
            Controls.Add(txt_Dados_Veiculo);
            Controls.Add(lbl_Dados_Veiculo);
            Controls.Add(txt_Nome_Cliente);
            Controls.Add(lbl_Nome_Cliente);
            Name = "Formulario_Consultas";
            Text = "Formulario_Consultas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nome_Cliente;
        private Label lbl_Nome_Cliente;
        private TextBox txt_Dados_Veiculo;
        private Label lbl_Dados_Veiculo;
        private MaskedTextBox mktxt_Inicio;
        private Label lbl_Data_Inicio;
        private Label lbl_Cpf;
        private MaskedTextBox mktxt_Cpf;
        private Label label1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private Label lbl_Valor_Locacao;
        private MaskedTextBox mktxt_Termino;
        private Label lbl_Data_Termino;
        private Button btn_Voltar;
        private Button btn_Consultar;
        private Button btn_Limpar;
    }
}