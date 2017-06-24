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
    public partial class frmCadBeneficiario : App.Forms.frmCadastrosPai
    {
        public frmCadBeneficiario()
        {
            InitializeComponent();            
        }

        protected override void btnInsert_Click(object sender, EventArgs e)
        {
            ativaControles(false);
            dgView.AllowUserToAddRows = true;
            MessageBox.Show( dgView.RowCount.ToString());
            dgView[dgView.CurrentCell.ColumnIndex ,dgView.CurrentCell.RowIndex].Selected = false;
            
        }

        protected override void btnGravar_Click(object sender, EventArgs e)
        {

        }

        protected override void btnEditar_Click(object sender, EventArgs e)
        {

        }

        protected override void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected override void btnPrimeiro_Click(object sender, EventArgs e)
        {

        }

        protected override void btnProximo_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[dsView, "BENEFICIARIO"];
            if (cm.Position < cm.Count - 1)
            {
                cm.Position++;
            }
        }

        protected override void btnAnterior_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[dsView, "BENEFICIARIO"].Position > 0)
            {
                this.BindingContext[dsView, "BENEFICIARIO"].Position--;
            }
        }

        protected override void btnUltimo_Click(object sender, EventArgs e)
        {

        }

        private void frmCadBeneficiario_Load(object sender, EventArgs e)
        {
            Conexao conBeneficiario = new Conexao();

            SqlCon = new SqlConnection(conBeneficiario.GetSQLStringCon());
            ds = new DataSet("Beneficiario");

            SqlDataAdapter selBeneficiario = new SqlDataAdapter
                ("SELECT * FROM BENEFICIARIO", SqlCon);

            selBeneficiario.TableMappings.Add("Table", "BENEFICIARIO");
            selBeneficiario.Fill(ds);

            dsView = ds.DefaultViewManager;

            dgView.DataSource = dsView;
            dgView.DataMember = "Beneficiario";
            dgView.Columns[0].HeaderText = "ID";
            dgView.Columns[0].Visible = false;
            dgView.Columns[1].HeaderText = "CNPJ/CPF";
            dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgView.Columns[2].HeaderText = "RAZÃO SOCIAL";
            dgView.Columns[3].HeaderText = "APELIDO";
            
            dgView[1, 0].Selected = true;
            //dgView.EditMode = DataGridViewEditMode.EditOnEnter;

            tbCNPJCPF.DataBindings.Add("Text", dsView, "BENEFICIARIO.BENEFICIARIO_CNPJCPF");
            tbNOMEFAN.DataBindings.Add("Text", dsView, "BENEFICIARIO.BENEFICIARIO_NOMEFAN");
            tbRAZAO.DataBindings.Add("Text", dsView, "BENEFICIARIO.BENEFICIARIO_RAZAOSOC");

            ativaControles(true);
        }

        private void ativaControles(bool cmd)
        {
            dgView.AllowUserToAddRows = !cmd;
            dgView.ReadOnly = cmd;

            foreach (Control c in groupBox2.Controls)
            {
                if(c is TextBox)
                {
                    (c as TextBox).ReadOnly = cmd;
                }
            }
        }
    }
}
