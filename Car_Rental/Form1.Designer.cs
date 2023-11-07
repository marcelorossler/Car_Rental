namespace Car_Rental
{
    partial class frm_Car_Rental
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Consulta_Clientes = new Button();
            btn_Sair = new Button();
            btn_Consulta_Veiculos = new Button();
            tn_Consulta_Financeiro = new Button();
            btn_Consulta_Locacoes = new Button();
            SuspendLayout();
            // 
            // btn_Consulta_Clientes
            // 
            btn_Consulta_Clientes.BackColor = SystemColors.ActiveCaption;
            btn_Consulta_Clientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Consulta_Clientes.Location = new Point(77, 203);
            btn_Consulta_Clientes.Margin = new Padding(3, 4, 3, 4);
            btn_Consulta_Clientes.Name = "btn_Consulta_Clientes";
            btn_Consulta_Clientes.Size = new Size(149, 93);
            btn_Consulta_Clientes.TabIndex = 0;
            btn_Consulta_Clientes.Text = " consultas    CLIENTES";
            btn_Consulta_Clientes.UseVisualStyleBackColor = false;
            btn_Consulta_Clientes.Click += btn_Consulta_Clientes_Click;
            // 
            // btn_Sair
            // 
            btn_Sair.BackColor = Color.LightCoral;
            btn_Sair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Sair.Location = new Point(317, 269);
            btn_Sair.Margin = new Padding(3, 4, 3, 4);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(149, 93);
            btn_Sair.TabIndex = 1;
            btn_Sair.Text = "SAIR";
            btn_Sair.UseVisualStyleBackColor = false;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // btn_Consulta_Veiculos
            // 
            btn_Consulta_Veiculos.BackColor = SystemColors.ActiveBorder;
            btn_Consulta_Veiculos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Consulta_Veiculos.Location = new Point(77, 87);
            btn_Consulta_Veiculos.Margin = new Padding(3, 4, 3, 4);
            btn_Consulta_Veiculos.Name = "btn_Consulta_Veiculos";
            btn_Consulta_Veiculos.Size = new Size(149, 93);
            btn_Consulta_Veiculos.TabIndex = 2;
            btn_Consulta_Veiculos.Text = "consultas   VEÍCULOS";
            btn_Consulta_Veiculos.UseVisualStyleBackColor = false;
            btn_Consulta_Veiculos.Click += btn_Consulta_Veiculos_Click;
            // 
            // tn_Consulta_Financeiro
            // 
            tn_Consulta_Financeiro.BackColor = SystemColors.GradientInactiveCaption;
            tn_Consulta_Financeiro.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tn_Consulta_Financeiro.Location = new Point(77, 436);
            tn_Consulta_Financeiro.Margin = new Padding(3, 4, 3, 4);
            tn_Consulta_Financeiro.Name = "tn_Consulta_Financeiro";
            tn_Consulta_Financeiro.Size = new Size(149, 93);
            tn_Consulta_Financeiro.TabIndex = 3;
            tn_Consulta_Financeiro.Text = "Consultas do Sistema";
            tn_Consulta_Financeiro.UseVisualStyleBackColor = false;
            tn_Consulta_Financeiro.Click += tn_Consulta_Financeiro_Click;
            // 
            // btn_Consulta_Locacoes
            // 
            btn_Consulta_Locacoes.BackColor = SystemColors.GradientActiveCaption;
            btn_Consulta_Locacoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Consulta_Locacoes.Location = new Point(77, 319);
            btn_Consulta_Locacoes.Margin = new Padding(3, 4, 3, 4);
            btn_Consulta_Locacoes.Name = "btn_Consulta_Locacoes";
            btn_Consulta_Locacoes.Size = new Size(149, 93);
            btn_Consulta_Locacoes.TabIndex = 4;
            btn_Consulta_Locacoes.Text = "consultas  LOCAÇÕES";
            btn_Consulta_Locacoes.UseVisualStyleBackColor = false;
            btn_Consulta_Locacoes.Click += btn_Consulta_Locacoes_Click;
            // 
            // frm_Car_Rental
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(534, 600);
            Controls.Add(btn_Consulta_Locacoes);
            Controls.Add(tn_Consulta_Financeiro);
            Controls.Add(btn_Consulta_Veiculos);
            Controls.Add(btn_Sair);
            Controls.Add(btn_Consulta_Clientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_Car_Rental";
            Text = "CAR RENTAL";
            Load += frm_Car_Rental_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Consulta_Clientes;
        private Button btn_Sair;
        private Button btn_Consulta_Veiculos;
        private Button tn_Consulta_Financeiro;
        private Button btn_Consulta_Locacoes;
    }
}