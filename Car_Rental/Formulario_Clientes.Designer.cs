namespace Car_Rental
{
    partial class Formulario_Clientes
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
            btn_Salvar = new Button();
            lbl_Nome = new Label();
            txt_Nome = new TextBox();
            txt_Endereco = new TextBox();
            lbl_Endereco = new Label();
            lbl_Nascimento = new Label();
            lbl_Cpf = new Label();
            btn_Limpar = new Button();
            btn_Voltar = new Button();
            mskd_txbox_Cpf = new MaskedTextBox();
            maskd_txtBox_Nascimento = new MaskedTextBox();
            SuspendLayout();
            // 
            // btn_Salvar
            // 
            btn_Salvar.BackColor = Color.LightPink;
            btn_Salvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salvar.Location = new Point(573, 173);
            btn_Salvar.Margin = new Padding(3, 4, 3, 4);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(150, 66);
            btn_Salvar.TabIndex = 0;
            btn_Salvar.Text = "SALVAR";
            btn_Salvar.UseVisualStyleBackColor = false;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Location = new Point(53, 89);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(52, 20);
            lbl_Nome.TabIndex = 1;
            lbl_Nome.Text = "NOME";
            // 
            // txt_Nome
            // 
            txt_Nome.Location = new Point(53, 113);
            txt_Nome.Margin = new Padding(3, 4, 3, 4);
            txt_Nome.Name = "txt_Nome";
            txt_Nome.Size = new Size(457, 27);
            txt_Nome.TabIndex = 2;
            txt_Nome.TextChanged += txt_Nome_TextChanged;
            // 
            // txt_Endereco
            // 
            txt_Endereco.Location = new Point(53, 331);
            txt_Endereco.Margin = new Padding(3, 4, 3, 4);
            txt_Endereco.Name = "txt_Endereco";
            txt_Endereco.Size = new Size(457, 27);
            txt_Endereco.TabIndex = 4;
            // 
            // lbl_Endereco
            // 
            lbl_Endereco.AutoSize = true;
            lbl_Endereco.Location = new Point(53, 307);
            lbl_Endereco.Name = "lbl_Endereco";
            lbl_Endereco.Size = new Size(84, 20);
            lbl_Endereco.TabIndex = 3;
            lbl_Endereco.Text = "ENDEREÇO";
            // 
            // lbl_Nascimento
            // 
            lbl_Nascimento.AutoSize = true;
            lbl_Nascimento.Location = new Point(191, 188);
            lbl_Nascimento.Name = "lbl_Nascimento";
            lbl_Nascimento.Size = new Size(105, 20);
            lbl_Nascimento.TabIndex = 5;
            lbl_Nascimento.Text = " NASCIMENTO";
            // 
            // lbl_Cpf
            // 
            lbl_Cpf.AutoSize = true;
            lbl_Cpf.Location = new Point(53, 188);
            lbl_Cpf.Name = "lbl_Cpf";
            lbl_Cpf.Size = new Size(33, 20);
            lbl_Cpf.TabIndex = 7;
            lbl_Cpf.Text = "CPF";
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.LavenderBlush;
            btn_Limpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpar.Location = new Point(573, 298);
            btn_Limpar.Margin = new Padding(3, 4, 3, 4);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(150, 60);
            btn_Limpar.TabIndex = 9;
            btn_Limpar.Text = "LIMPAR";
            btn_Limpar.UseVisualStyleBackColor = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.PaleVioletRed;
            btn_Voltar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voltar.Location = new Point(573, 39);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(150, 70);
            btn_Voltar.TabIndex = 10;
            btn_Voltar.Text = "VOLTAR";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // mskd_txbox_Cpf
            // 
            mskd_txbox_Cpf.Location = new Point(53, 212);
            mskd_txbox_Cpf.Margin = new Padding(3, 4, 3, 4);
            mskd_txbox_Cpf.Mask = "000.000.000-00";
            mskd_txbox_Cpf.Name = "mskd_txbox_Cpf";
            mskd_txbox_Cpf.Size = new Size(95, 27);
            mskd_txbox_Cpf.TabIndex = 11;
            // 
            // maskd_txtBox_Nascimento
            // 
            maskd_txtBox_Nascimento.Location = new Point(191, 212);
            maskd_txtBox_Nascimento.Margin = new Padding(3, 4, 3, 4);
            maskd_txtBox_Nascimento.Mask = "00/00/0000";
            maskd_txtBox_Nascimento.Name = "maskd_txtBox_Nascimento";
            maskd_txtBox_Nascimento.Size = new Size(95, 27);
            maskd_txtBox_Nascimento.TabIndex = 12;
            maskd_txtBox_Nascimento.ValidatingType = typeof(DateTime);
            // 
            // Formulario_Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(816, 446);
            Controls.Add(maskd_txtBox_Nascimento);
            Controls.Add(mskd_txbox_Cpf);
            Controls.Add(btn_Voltar);
            Controls.Add(btn_Limpar);
            Controls.Add(lbl_Cpf);
            Controls.Add(lbl_Nascimento);
            Controls.Add(txt_Endereco);
            Controls.Add(lbl_Endereco);
            Controls.Add(txt_Nome);
            Controls.Add(lbl_Nome);
            Controls.Add(btn_Salvar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Formulario_Clientes";
            Text = "Formulario_Clientes";
            Load += Formulario_Clientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Salvar;
        private Label lbl_Nome;
        private TextBox txt_Nome;
        private TextBox txt_Endereco;
        private Label lbl_Endereco;
        private Label lbl_Nascimento;
        private Label lbl_Cpf;
        private Button btn_Limpar;
        private Button btn_Voltar;
        private MaskedTextBox mskd_txbox_Cpf;
        private MaskedTextBox maskd_txtBox_Nascimento;
    }
}