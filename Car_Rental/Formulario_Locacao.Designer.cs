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
            lbl_Veiculo = new Label();
            lbl_Termino_Locacao = new Label();
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
            comboCliente = new ComboBox();
            comboVeiculo = new ComboBox();
            checkBoxSeguro = new CheckBox();
            lblSeguro = new Label();
            label1 = new Label();
            lbl_CadastrarNome = new Label();
            txt_CadstrarNome = new TextBox();
            SuspendLayout();
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.SkyBlue;
            btn_Voltar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voltar.Location = new Point(290, 318);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(134, 57);
            btn_Voltar.TabIndex = 11;
            btn_Voltar.Text = "VOLTAR";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // btn_Salvar
            // 
            btn_Salvar.BackColor = Color.LightSteelBlue;
            btn_Salvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salvar.Location = new Point(511, 318);
            btn_Salvar.Margin = new Padding(3, 4, 3, 4);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(130, 57);
            btn_Salvar.TabIndex = 12;
            btn_Salvar.Text = "SALVAR";
            btn_Salvar.UseVisualStyleBackColor = false;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.SteelBlue;
            btn_Limpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpar.Location = new Point(78, 318);
            btn_Limpar.Margin = new Padding(3, 4, 3, 4);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(130, 57);
            btn_Limpar.TabIndex = 13;
            btn_Limpar.Text = "LIMPAR";
            btn_Limpar.UseVisualStyleBackColor = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // lbl_Veiculo
            // 
            lbl_Veiculo.AutoSize = true;
            lbl_Veiculo.Location = new Point(124, 123);
            lbl_Veiculo.Name = "lbl_Veiculo";
            lbl_Veiculo.Size = new Size(122, 20);
            lbl_Veiculo.TabIndex = 14;
            lbl_Veiculo.Text = "Consulta Veículo ";
            // 
            // lbl_Termino_Locacao
            // 
            lbl_Termino_Locacao.AutoSize = true;
            lbl_Termino_Locacao.Location = new Point(386, 227);
            lbl_Termino_Locacao.Name = "lbl_Termino_Locacao";
            lbl_Termino_Locacao.Size = new Size(122, 20);
            lbl_Termino_Locacao.TabIndex = 16;
            lbl_Termino_Locacao.Text = "Término Locação";
            // 
            // lbl_Nome_Cliente
            // 
            lbl_Nome_Cliente.AutoSize = true;
            lbl_Nome_Cliente.Location = new Point(122, 37);
            lbl_Nome_Cliente.Name = "lbl_Nome_Cliente";
            lbl_Nome_Cliente.Size = new Size(115, 20);
            lbl_Nome_Cliente.TabIndex = 20;
            lbl_Nome_Cliente.Text = "Consulta Nome ";
            // 
            // lbl_Inicio_Locacao
            // 
            lbl_Inicio_Locacao.AutoSize = true;
            lbl_Inicio_Locacao.Location = new Point(44, 227);
            lbl_Inicio_Locacao.Name = "lbl_Inicio_Locacao";
            lbl_Inicio_Locacao.Size = new Size(104, 20);
            lbl_Inicio_Locacao.TabIndex = 22;
            lbl_Inicio_Locacao.Text = "Início Locacão";
            // 
            // lbl_Valor_Diaria
            // 
            lbl_Valor_Diaria.AutoSize = true;
            lbl_Valor_Diaria.Location = new Point(225, 225);
            lbl_Valor_Diaria.Name = "lbl_Valor_Diaria";
            lbl_Valor_Diaria.Size = new Size(87, 20);
            lbl_Valor_Diaria.TabIndex = 25;
            lbl_Valor_Diaria.Text = "Valor Diária";
            // 
            // mktxt_Termino_Locacao
            // 
            mktxt_Termino_Locacao.Location = new Point(401, 251);
            mktxt_Termino_Locacao.Margin = new Padding(3, 4, 3, 4);
            mktxt_Termino_Locacao.Mask = "00/00/0000";
            mktxt_Termino_Locacao.Name = "mktxt_Termino_Locacao";
            mktxt_Termino_Locacao.Size = new Size(86, 27);
            mktxt_Termino_Locacao.TabIndex = 29;
            mktxt_Termino_Locacao.ValidatingType = typeof(DateTime);
            // 
            // mktxt_Valor_Diaria
            // 
            mktxt_Valor_Diaria.Location = new Point(225, 251);
            mktxt_Valor_Diaria.Margin = new Padding(3, 4, 3, 4);
            mktxt_Valor_Diaria.Mask = "$000,00";
            mktxt_Valor_Diaria.Name = "mktxt_Valor_Diaria";
            mktxt_Valor_Diaria.Size = new Size(87, 27);
            mktxt_Valor_Diaria.TabIndex = 30;
            mktxt_Valor_Diaria.ValidatingType = typeof(DateTime);
            // 
            // lbl_Valor_Total
            // 
            lbl_Valor_Total.AutoSize = true;
            lbl_Valor_Total.Location = new Point(566, 227);
            lbl_Valor_Total.Name = "lbl_Valor_Total";
            lbl_Valor_Total.Size = new Size(95, 20);
            lbl_Valor_Total.TabIndex = 26;
            lbl_Valor_Total.Text = "Total à Pagar";
            // 
            // mktxt_Valor_Total
            // 
            mktxt_Valor_Total.Location = new Point(580, 251);
            mktxt_Valor_Total.Margin = new Padding(3, 4, 3, 4);
            mktxt_Valor_Total.Mask = "$0000,00";
            mktxt_Valor_Total.Name = "mktxt_Valor_Total";
            mktxt_Valor_Total.Size = new Size(81, 27);
            mktxt_Valor_Total.TabIndex = 31;
            mktxt_Valor_Total.ValidatingType = typeof(DateTime);
            // 
            // mktxt_Placa
            // 
            mktxt_Placa.Location = new Point(416, 147);
            mktxt_Placa.Margin = new Padding(3, 4, 3, 4);
            mktxt_Placa.Mask = "AAA 0A00";
            mktxt_Placa.Name = "mktxt_Placa";
            mktxt_Placa.Size = new Size(81, 27);
            mktxt_Placa.TabIndex = 32;
            mktxt_Placa.ValidatingType = typeof(DateTime);
            // 
            // lbl_Placa
            // 
            lbl_Placa.AutoSize = true;
            lbl_Placa.Location = new Point(225, 72);
            lbl_Placa.Name = "lbl_Placa";
            lbl_Placa.Size = new Size(118, 20);
            lbl_Placa.TabIndex = 33;
            lbl_Placa.Text = "Placa do Veículo";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(51, 251);
            maskedTextBox1.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(88, 27);
            maskedTextBox1.TabIndex = 34;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // comboCliente
            // 
            comboCliente.FormattingEnabled = true;
            comboCliente.Location = new Point(14, 61);
            comboCliente.Margin = new Padding(3, 4, 3, 4);
            comboCliente.Name = "comboCliente";
            comboCliente.Size = new Size(335, 28);
            comboCliente.TabIndex = 35;
            comboCliente.SelectedIndexChanged += comboCliente_SelectedIndexChanged;
            // 
            // comboVeiculo
            // 
            comboVeiculo.FormattingEnabled = true;
            comboVeiculo.Location = new Point(14, 147);
            comboVeiculo.Margin = new Padding(3, 4, 3, 4);
            comboVeiculo.Name = "comboVeiculo";
            comboVeiculo.Size = new Size(335, 28);
            comboVeiculo.TabIndex = 36;
            // 
            // checkBoxSeguro
            // 
            checkBoxSeguro.AutoSize = true;
            checkBoxSeguro.Location = new Point(605, 147);
            checkBoxSeguro.Name = "checkBoxSeguro";
            checkBoxSeguro.Size = new Size(78, 24);
            checkBoxSeguro.TabIndex = 37;
            checkBoxSeguro.Text = "Aceitar";
            checkBoxSeguro.UseVisualStyleBackColor = true;
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Location = new Point(580, 121);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(125, 20);
            lblSeguro.TabIndex = 38;
            lblSeguro.Text = "Opção de Seguro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 122);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 39;
            label1.Text = "Cadastrar Placa Veículo";
            // 
            // lbl_CadastrarNome
            // 
            lbl_CadastrarNome.AutoSize = true;
            lbl_CadastrarNome.Location = new Point(451, 35);
            lbl_CadastrarNome.Name = "lbl_CadastrarNome";
            lbl_CadastrarNome.Size = new Size(167, 20);
            lbl_CadastrarNome.TabIndex = 41;
            lbl_CadastrarNome.Text = "Cadastrar Nome Cliente";
            // 
            // txt_CadstrarNome
            // 
            txt_CadstrarNome.Location = new Point(372, 61);
            txt_CadstrarNome.Name = "txt_CadstrarNome";
            txt_CadstrarNome.Size = new Size(333, 27);
            txt_CadstrarNome.TabIndex = 42;
            // 
            // Formulario_Locacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 388);
            Controls.Add(txt_CadstrarNome);
            Controls.Add(lbl_CadastrarNome);
            Controls.Add(label1);
            Controls.Add(lblSeguro);
            Controls.Add(checkBoxSeguro);
            Controls.Add(comboVeiculo);
            Controls.Add(comboCliente);
            Controls.Add(maskedTextBox1);
            Controls.Add(lbl_Placa);
            Controls.Add(mktxt_Placa);
            Controls.Add(mktxt_Valor_Total);
            Controls.Add(mktxt_Valor_Diaria);
            Controls.Add(mktxt_Termino_Locacao);
            Controls.Add(lbl_Valor_Total);
            Controls.Add(lbl_Valor_Diaria);
            Controls.Add(lbl_Inicio_Locacao);
            Controls.Add(lbl_Nome_Cliente);
            Controls.Add(lbl_Termino_Locacao);
            Controls.Add(lbl_Veiculo);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_Salvar);
            Controls.Add(btn_Voltar);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lbl_Veiculo;
        private Label lbl_Termino_Locacao;
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
        private ComboBox comboCliente;
        private ComboBox comboVeiculo;
        private CheckBox checkBoxSeguro;
        private Label lblSeguro;
        private Label label1;
        private Label lbl_CadastrarNome;
        private TextBox txt_CadstrarNome;
    }
}