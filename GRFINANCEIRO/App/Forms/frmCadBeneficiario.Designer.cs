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
            this.tbCNPJCPF = new System.Windows.Forms.TextBox();
            this.tbNOMEFAN = new System.Windows.Forms.TextBox();
            this.tbRAZAO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.tpCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tpCadastro
            // 
            this.tpCadastro.Size = new System.Drawing.Size(566, 452);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgView);
            this.groupBox1.Size = new System.Drawing.Size(550, 211);
            this.groupBox1.Text = "Beneficiário";
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(574, 478);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // tpConsultar
            // 
            this.tpConsultar.Size = new System.Drawing.Size(566, 452);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(6, 397);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbRAZAO);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbNOMEFAN);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbCNPJCPF);
            this.groupBox2.Location = new System.Drawing.Point(6, 309);
            this.groupBox2.Size = new System.Drawing.Size(550, 82);
            this.groupBox2.Text = "Dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNPJ/CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELIDO";
            // 
            // tbCNPJCPF
            // 
            this.tbCNPJCPF.Location = new System.Drawing.Point(101, 22);
            this.tbCNPJCPF.Name = "tbCNPJCPF";
            this.tbCNPJCPF.Size = new System.Drawing.Size(118, 20);
            this.tbCNPJCPF.TabIndex = 2;
            // 
            // tbNOMEFAN
            // 
            this.tbNOMEFAN.Location = new System.Drawing.Point(284, 22);
            this.tbNOMEFAN.Name = "tbNOMEFAN";
            this.tbNOMEFAN.Size = new System.Drawing.Size(253, 20);
            this.tbNOMEFAN.TabIndex = 3;
            // 
            // tbRAZAO
            // 
            this.tbRAZAO.Location = new System.Drawing.Point(101, 48);
            this.tbRAZAO.Name = "tbRAZAO";
            this.tbRAZAO.Size = new System.Drawing.Size(436, 20);
            this.tbRAZAO.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "RAZÃO SOCIAL";
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(6, 19);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(531, 186);
            this.dgView.TabIndex = 0;
            // 
            // frmCadBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(574, 503);
            this.Name = "frmCadBeneficiario";
            this.Text = "Cadastro de Beneficiário";
            this.Load += new System.EventHandler(this.frmCadBeneficiario_Load);
            this.tpCadastro.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNOMEFAN;
        private System.Windows.Forms.TextBox tbCNPJCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRAZAO;
        private System.Windows.Forms.DataGridView dgView;
    }
}
