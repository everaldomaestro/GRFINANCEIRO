using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Domain;
using System.Data.SqlClient;

namespace App.Forms
{
    public partial class frmCadBeneficiario : frmCadastrosPai
    {
        public frmCadBeneficiario()
        {
            InitializeComponent();
        }

        private static string tbl = "BENEFICIARIO";

        private void frmCadBeneficiario_Load(object sender, EventArgs e)
        {
            Conexao con = new Conexao();

            SqlCon = new SqlConnection(con.GetSQLStringCon());
            ds = new DataSet(tbl);

            SqlDataAdapter daTbl = new SqlDataAdapter
                ("SELECT * FROM "+tbl+"", SqlCon);

            daTbl.TableMappings.Add("Table", tbl);
            daTbl.Fill(ds);

            dsView = ds.DefaultViewManager;

            dgView.DataSource = dsView;
            dgView.DataMember = tbl;
            dgView.AllowUserToAddRows = false;

            //Linkando os controles-tabela
            dgView.Columns[0].HeaderText = "ID";
            dgView.Columns[0].Visible = false;
            dgView.Columns[1].HeaderText = "CNPJ/CPF";
            dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgView.Columns[2].HeaderText = "RAZÃO SOCIAL";
            dgView.Columns[3].HeaderText = "APELIDO";

            tbCNPJCPF.DataBindings.Add("Text", dsView, tbl + ".BENEFICIARIO_CNPJCPF");
            tbNOMEFAN.DataBindings.Add("Text", dsView, tbl + ".BENEFICIARIO_NOMEFAN");
            tbRAZAO.DataBindings.Add("Text", dsView, tbl + ".BENEFICIARIO_RAZAOSOC");

            ativaControles(true);
        }

        protected override void btnPrimeiro_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsView, tbl].Position = 0;
        }

        protected override void btnAnterior_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[dsView, tbl].Position > 0)
            {
                this.BindingContext[dsView, tbl].Position--;
            }
        }

        protected override void btnProximo_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[dsView, tbl];
            if (cm.Position < cm.Count - 1)
            {
                cm.Position++;
            }
        }

        protected override void btnUltimo_Click(object sender, EventArgs e)
        {
            this.BindingContext[dsView, tbl].Position = 
                this.BindingContext[dsView, tbl].Count;
        }
    }
}
