namespace Car_Rental
{
    partial class Formulario_Veiculos
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
            txt_Marca = new TextBox();
            lbl_Marca = new Label();
            btn_Voltar = new Button();
            btn_Salvar = new Button();
            btn_Limpar = new Button();
            lbl_Placa = new Label();
            lbl_Cor = new Label();
            lbl_Modelo = new Label();
            txt_Cor = new TextBox();
            txt_Placa = new TextBox();
            txt_Modelo = new TextBox();
            SuspendLayout();
            // 
            // txt_Marca
            // 
            txt_Marca.Location = new Point(14, 67);
            txt_Marca.Margin = new Padding(3, 4, 3, 4);
            txt_Marca.Name = "txt_Marca";
            txt_Marca.Size = new Size(457, 27);
            txt_Marca.TabIndex = 4;
            // 
            // lbl_Marca
            // 
            lbl_Marca.AutoSize = true;
            lbl_Marca.Location = new Point(14, 43);
            lbl_Marca.Name = "lbl_Marca";
            lbl_Marca.Size = new Size(60, 20);
            lbl_Marca.TabIndex = 3;
            lbl_Marca.Text = "MARCA";
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.Gold;
            btn_Voltar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Voltar.Location = new Point(695, 67);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(150, 101);
            btn_Voltar.TabIndex = 11;
            btn_Voltar.Text = "VOLTAR";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // btn_Salvar
            // 
            btn_Salvar.BackColor = Color.Goldenrod;
            btn_Salvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salvar.Location = new Point(695, 227);
            btn_Salvar.Margin = new Padding(3, 4, 3, 4);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(150, 101);
            btn_Salvar.TabIndex = 12;
            btn_Salvar.Text = "SALVAR";
            btn_Salvar.UseVisualStyleBackColor = false;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.BackColor = Color.DarkGoldenrod;
            btn_Limpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpar.Location = new Point(695, 400);
            btn_Limpar.Margin = new Padding(3, 4, 3, 4);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(150, 101);
            btn_Limpar.TabIndex = 13;
            btn_Limpar.Text = "LIMPAR";
            btn_Limpar.UseVisualStyleBackColor = false;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // lbl_Placa
            // 
            lbl_Placa.AutoSize = true;
            lbl_Placa.Location = new Point(14, 433);
            lbl_Placa.Name = "lbl_Placa";
            lbl_Placa.Size = new Size(53, 20);
            lbl_Placa.TabIndex = 15;
            lbl_Placa.Text = "PLACA";
            // 
            // lbl_Cor
            // 
            lbl_Cor.AutoSize = true;
            lbl_Cor.Location = new Point(14, 309);
            lbl_Cor.Name = "lbl_Cor";
            lbl_Cor.Size = new Size(38, 20);
            lbl_Cor.TabIndex = 16;
            lbl_Cor.Text = "COR";
            // 
            // lbl_Modelo
            // 
            lbl_Modelo.AutoSize = true;
            lbl_Modelo.Location = new Point(14, 181);
            lbl_Modelo.Name = "lbl_Modelo";
            lbl_Modelo.Size = new Size(69, 20);
            lbl_Modelo.TabIndex = 17;
            lbl_Modelo.Text = "MODELO";
            // 
            // txt_Cor
            // 
            txt_Cor.Location = new Point(14, 333);
            txt_Cor.Margin = new Padding(3, 4, 3, 4);
            txt_Cor.Name = "txt_Cor";
            txt_Cor.Size = new Size(457, 27);
            txt_Cor.TabIndex = 18;
            // 
            // txt_Placa
            // 
            txt_Placa.Location = new Point(14, 457);
            txt_Placa.Margin = new Padding(3, 4, 3, 4);
            txt_Placa.Name = "txt_Placa";
            txt_Placa.Size = new Size(457, 27);
            txt_Placa.TabIndex = 19;
            // 
            // txt_Modelo
            // 
            txt_Modelo.Location = new Point(14, 205);
            txt_Modelo.Margin = new Padding(3, 4, 3, 4);
            txt_Modelo.Name = "txt_Modelo";
            txt_Modelo.Size = new Size(457, 27);
            txt_Modelo.TabIndex = 21;
            // 
            // Formulario_Veiculos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(914, 600);
            Controls.Add(txt_Modelo);
            Controls.Add(txt_Placa);
            Controls.Add(txt_Cor);
            Controls.Add(lbl_Modelo);
            Controls.Add(lbl_Cor);
            Controls.Add(lbl_Placa);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_Salvar);
            Controls.Add(btn_Voltar);
            Controls.Add(txt_Marca);
            Controls.Add(lbl_Marca);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Formulario_Veiculos";
            Text = "Formulario_Veiculos";
            Load += Formulario_Veiculos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Marca;
        private Label lbl_Marca;
        private Button btn_Voltar;
        private Button btn_Salvar;
        private Button btn_Limpar;
        private Label lbl_Placa;
        private Label lbl_Cor;
        private Label lbl_Modelo;
        private TextBox txt_Cor;
        private TextBox txt_Placa;
        private TextBox txt_Modelo;
    }
}