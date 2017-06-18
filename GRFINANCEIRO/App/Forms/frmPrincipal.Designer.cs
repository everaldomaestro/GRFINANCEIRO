namespace App.Forms
{
    partial class frmPrincipal
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
            this.statusPrincipal = new System.Windows.Forms.StatusStrip();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beneficiárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.métodoDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusPrincipal
            // 
            this.statusPrincipal.Location = new System.Drawing.Point(0, 553);
            this.statusPrincipal.Name = "statusPrincipal";
            this.statusPrincipal.Size = new System.Drawing.Size(636, 22);
            this.statusPrincipal.TabIndex = 0;
            this.statusPrincipal.Text = "statusStrip1";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(636, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beneficiárioToolStripMenuItem,
            this.pagadorToolStripMenuItem,
            this.métodoDePagamentoToolStripMenuItem,
            this.formaDePagamentoToolStripMenuItem,
            this.tipoDePagamentoToolStripMenuItem,
            this.toolStripSeparator1,
            this.pagamentosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // beneficiárioToolStripMenuItem
            // 
            this.beneficiárioToolStripMenuItem.Name = "beneficiárioToolStripMenuItem";
            this.beneficiárioToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.beneficiárioToolStripMenuItem.Text = "Beneficiário";
            this.beneficiárioToolStripMenuItem.Click += new System.EventHandler(this.beneficiárioToolStripMenuItem_Click);
            // 
            // pagadorToolStripMenuItem
            // 
            this.pagadorToolStripMenuItem.Name = "pagadorToolStripMenuItem";
            this.pagadorToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.pagadorToolStripMenuItem.Text = "Pagador";
            // 
            // métodoDePagamentoToolStripMenuItem
            // 
            this.métodoDePagamentoToolStripMenuItem.Name = "métodoDePagamentoToolStripMenuItem";
            this.métodoDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.métodoDePagamentoToolStripMenuItem.Text = "Método de Pagamento";
            // 
            // formaDePagamentoToolStripMenuItem
            // 
            this.formaDePagamentoToolStripMenuItem.Name = "formaDePagamentoToolStripMenuItem";
            this.formaDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.formaDePagamentoToolStripMenuItem.Text = "Forma de Pagamento";
            // 
            // tipoDePagamentoToolStripMenuItem
            // 
            this.tipoDePagamentoToolStripMenuItem.Name = "tipoDePagamentoToolStripMenuItem";
            this.tipoDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tipoDePagamentoToolStripMenuItem.Text = "Tipo de Pagamento";
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.pagamentosToolStripMenuItem.Text = "Pagamentos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 575);
            this.Controls.Add(this.statusPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Gerenciador Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusPrincipal;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beneficiárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem métodoDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formaDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}