namespace Car_Rental
{
    partial class Formulario_Locacao
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
            btn_Salvar = new Button();
            btn_Limpar = new Button();
            txt_Veiculo = new TextBox();
            lbl_Veiculo = new Label();
            lbl_Termino_Locacao = new Label();
            txt_Seguro_Opcional = new TextBox();
            lbl_Seguro_Opcional = new Label();
            txt_Nome_Cliente = new TextBox();
            lbl_Nome_Cliente = new Label();
            lbl_Inicio_Locacao = new Label();
            lbl_Valor_Diaria = new Label();
            mktxt_Termino_Locacao = new MaskedTextBox();
            mktxt_Valor_Diaria = new MaskedTextBox();
            lbl_Valor_Total = new Label();
            mktxt_Valor_Total = new MaskedTextBox();
            mktxt_Placa = new MaskedTextBox();
            lbl_Placa = new Label();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.Orange;
            btn_Voltar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voltar.Location = new Point(468, 25);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(131, 76);
            btn_Voltar.TabIndex = 11;
            btn_Voltar.Text = "VOLTAR";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // btn_Salvar
            // 
            btn_Salvar.BackColor = Color.Green;
            btn_Salvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salvar.Location = new Point(468, 126);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(131, 76);
            btn_Salvar.TabIndex = 12;
            btn_Salvar.Text = "SALVAR";
            btn_Salvar.UseVisualStyleBackColor = false;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.Yellow;
            btn_Limpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpar.Location = new Point(468, 234);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(131, 76);
            btn_Limpar.TabIndex = 13;
            btn_Limpar.Text = "LIMPAR";
            btn_Limpar.UseVisualStyleBackColor = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // txt_Veiculo
            // 
            txt_Veiculo.Location = new Point(12, 110);
            txt_Veiculo.Name = "txt_Veiculo";
            txt_Veiculo.Size = new Size(171, 23);
            txt_Veiculo.TabIndex = 15;
            // 
            // lbl_Veiculo
            // 
            lbl_Veiculo.AutoSize = true;
            lbl_Veiculo.Location = new Point(12, 92);
            lbl_Veiculo.Name = "lbl_Veiculo";
            lbl_Veiculo.Size = new Size(99, 15);
            lbl_Veiculo.TabIndex = 14;
            lbl_Veiculo.Text = "Veículo Escolhido";
            // 
            // lbl_Termino_Locacao
            // 
            lbl_Termino_Locacao.AutoSize = true;
            lbl_Termino_Locacao.Location = new Point(299, 161);
            lbl_Termino_Locacao.Name = "lbl_Termino_Locacao";
            lbl_Termino_Locacao.Size = new Size(113, 15);
            lbl_Termino_Locacao.TabIndex = 16;
            lbl_Termino_Locacao.Text = "Término da Locação";
            // 
            // txt_Seguro_Opcional
            // 
            txt_Seguro_Opcional.Location = new Point(17, 265);
            txt_Seguro_Opcional.Name = "txt_Seguro_Opcional";
            txt_Seguro_Opcional.Size = new Size(71, 23);
            txt_Seguro_Opcional.TabIndex = 19;
            // 
            // lbl_Seguro_Opcional
            // 
            lbl_Seguro_Opcional.AutoSize = true;
            lbl_Seguro_Opcional.Location = new Point(12, 247);
            lbl_Seguro_Opcional.Name = "lbl_Seguro_Opcional";
            lbl_Seguro_Opcional.Size = new Size(95, 15);
            lbl_Seguro_Opcional.TabIndex = 18;
            lbl_Seguro_Opcional.Text = "Seguro Opcional";
            // 
            // txt_Nome_Cliente
            // 
            txt_Nome_Cliente.Location = new Point(12, 46);
            txt_Nome_Cliente.Name = "txt_Nome_Cliente";
            txt_Nome_Cliente.Size = new Size(400, 23);
            txt_Nome_Cliente.TabIndex = 21;
            // 
            // lbl_Nome_Cliente
            // 
            lbl_Nome_Cliente.AutoSize = true;
            lbl_Nome_Cliente.Location = new Point(12, 28);
            lbl_Nome_Cliente.Name = "lbl_Nome_Cliente";
            lbl_Nome_Cliente.Size = new Size(97, 15);
            lbl_Nome_Cliente.TabIndex = 20;
            lbl_Nome_Cliente.Text = "Nome do Cliente";
            // 
            // lbl_Inicio_Locacao
            // 
            lbl_Inicio_Locacao.AutoSize = true;
            lbl_Inicio_Locacao.Location = new Point(12, 161);
            lbl_Inicio_Locacao.Name = "lbl_Inicio_Locacao";
            lbl_Inicio_Locacao.Size = new Size(99, 15);
            lbl_Inicio_Locacao.TabIndex = 22;
            lbl_Inicio_Locacao.Text = "Início da Locacão";
            // 
            // lbl_Valor_Diaria
            // 
            lbl_Valor_Diaria.AutoSize = true;
            lbl_Valor_Diaria.Location = new Point(165, 160);
            lbl_Valor_Diaria.Name = "lbl_Valor_Diaria";
            lbl_Valor_Diaria.Size = new Size(82, 15);
            lbl_Valor_Diaria.TabIndex = 25;
            lbl_Valor_Diaria.Text = "Valor da Diária";
            // 
            // mktxt_Termino_Locacao
            // 
            mktxt_Termino_Locacao.Location = new Point(308, 179);
            mktxt_Termino_Locacao.Mask = "00/00/0000";
            mktxt_Termino_Locacao.Name = "mktxt_Termino_Locacao";
            mktxt_Termino_Locacao.Size = new Size(70, 23);
            mktxt_Termino_Locacao.TabIndex = 29;
            mktxt_Termino_Locacao.ValidatingType = typeof(DateTime);
            // 
            // mktxt_Valor_Diaria
            // 
            mktxt_Valor_Diaria.Location = new Point(175, 179);
            mktxt_Valor_Diaria.Mask = "$000,00";
            mktxt_Valor_Diaria.Name = "mktxt_Valor_Diaria";
            mktxt_Valor_Diaria.Size = new Size(59, 23);
            mktxt_Valor_Diaria.TabIndex = 30;
            mktxt_Valor_Diaria.ValidatingType = typeof(DateTime);
            // 
            // lbl_Valor_Total
            // 
            lbl_Valor_Total.AutoSize = true;
            lbl_Valor_Total.Location = new Point(289, 247);
            lbl_Valor_Total.Name = "lbl_Valor_Total";
            lbl_Valor_Total.Size = new Size(118, 15);
            lbl_Valor_Total.TabIndex = 26;
            lbl_Valor_Total.Text = "Valor Total à ser Pago";
            // 
            // mktxt_Valor_Total
            // 
            mktxt_Valor_Total.Location = new Point(319, 265);
            mktxt_Valor_Total.Mask = "$0000,00";
            mktxt_Valor_Total.Name = "mktxt_Valor_Total";
            mktxt_Valor_Total.Size = new Size(59, 23);
            mktxt_Valor_Total.TabIndex = 31;
            mktxt_Valor_Total.ValidatingType = typeof(DateTime);
            // 
            // mktxt_Placa
            // 
            mktxt_Placa.Location = new Point(147, 265);
            mktxt_Placa.Mask = "AAA 0A00";
            mktxt_Placa.Name = "mktxt_Placa";
            mktxt_Placa.Size = new Size(87, 23);
            mktxt_Placa.TabIndex = 32;
            mktxt_Placa.ValidatingType = typeof(DateTime);
            // 
            // lbl_Placa
            // 
            lbl_Placa.AutoSize = true;
            lbl_Placa.Location = new Point(141, 247);
            lbl_Placa.Name = "lbl_Placa";
            lbl_Placa.Size = new Size(93, 15);
            lbl_Placa.TabIndex = 33;
            lbl_Placa.Text = "Placa do Veículo";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(18, 179);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(70, 23);
            maskedTextBox1.TabIndex = 34;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // Formulario_Locacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 329);
            Controls.Add(maskedTextBox1);
            Controls.Add(lbl_Placa);
            Controls.Add(mktxt_Placa);
            Controls.Add(mktxt_Valor_Total);
            Controls.Add(mktxt_Valor_Diaria);
            Controls.Add(mktxt_Termino_Locacao);
            Controls.Add(lbl_Valor_Total);
            Controls.Add(lbl_Valor_Diaria);
            Controls.Add(lbl_Inicio_Locacao);
            Controls.Add(txt_Nome_Cliente);
            Controls.Add(lbl_Nome_Cliente);
            Controls.Add(txt_Seguro_Opcional);
            Controls.Add(lbl_Seguro_Opcional);
            Controls.Add(lbl_Termino_Locacao);
            Controls.Add(txt_Veiculo);
            Controls.Add(lbl_Veiculo);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_Salvar);
            Controls.Add(btn_Voltar);
            Name = "Formulario_Locacao";
            Text = "Formulario_Locação";
            Load += Formulario_Locacao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Voltar;
        private Button btn_Salvar;
        private Button btn_Limpar;
        private TextBox txt_Veiculo;
        private Label lbl_Veiculo;
        private Label lbl_Termino_Locacao;
        private TextBox txt_Seguro_Opcional;
        private Label lbl_Seguro_Opcional;
        private TextBox txt_Nome_Cliente;
        private Label lbl_Nome_Cliente;
        private Label lbl_Inicio_Locacao;
        private Label lbl_Valor_Diaria;
        private TextBox txt_Valor_Total;
        private MaskedTextBox mktxt_Termino_Locacao;
        private MaskedTextBox mktxt_Valor_Diaria;
        private Label lbl_Valor_Total;
        private MaskedTextBox mktxt_Valor_Total;
        private MaskedTextBox mktxt_Placa;
        private Label lbl_Placa;
        private MaskedTextBox maskedTextBox1;
    }
}