namespace App.Forms
{
    partial class frmCadBeneficiario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCNPJCPF = new System.Windows.Forms.TextBox();
            this.tbNOMEFAN = new System.Windows.Forms.TextBox();
            this.tbRAZAO = new System.Windows.Forms.TextBox();
            this.tpCadastro.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpCadastro
            // 
            this.tpCadastro.Size = new System.Drawing.Size(566, 453);
            // 
            // groupBox1
            // 
            this.groupBox1.Text = "Beneficiário";
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(574, 479);
            // 
            // tpConsultar
            // 
            this.tpConsultar.Size = new System.Drawing.Size(566, 453);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(6, 394);
            // 
            // btnProximo
            // 
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbRAZAO);
            this.groupBox2.Controls.Add(this.tbNOMEFAN);
            this.groupBox2.Controls.Add(this.tbCNPJCPF);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Size = new System.Drawing.Size(548, 86);
            this.groupBox2.Text = "Dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNPJ/CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RAZÃO SOCIAL";
            // 
            // tbCNPJCPF
            // 
            this.tbCNPJCPF.Location = new System.Drawing.Point(99, 23);
            this.tbCNPJCPF.Name = "tbCNPJCPF";
            this.tbCNPJCPF.Size = new System.Drawing.Size(163, 20);
            this.tbCNPJCPF.TabIndex = 3;
            // 
            // tbNOMEFAN
            // 
            this.tbNOMEFAN.Location = new System.Drawing.Point(329, 23);
            this.tbNOMEFAN.Name = "tbNOMEFAN";
            this.tbNOMEFAN.Size = new System.Drawing.Size(206, 20);
            this.tbNOMEFAN.TabIndex = 4;
            // 
            // tbRAZAO
            // 
            this.tbRAZAO.Location = new System.Drawing.Point(99, 49);
            this.tbRAZAO.Name = "tbRAZAO";
            this.tbRAZAO.Size = new System.Drawing.Size(436, 20);
            this.tbRAZAO.TabIndex = 5;
            // 
            // frmCadBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(574, 504);
            this.Name = "frmCadBeneficiario";
            this.Load += new System.EventHandler(this.frmCadBeneficiario_Load);
            this.tpCadastro.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRAZAO;
        private System.Windows.Forms.TextBox tbNOMEFAN;
        private System.Windows.Forms.TextBox tbCNPJCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
