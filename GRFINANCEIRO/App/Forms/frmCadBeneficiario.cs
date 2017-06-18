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

            Conexao conBeneficiario = new Conexao();

            //string Con = conBeneficiario.GetSQLStringCon();

            SqlCon = new SqlConnection(conBeneficiario.GetSQLStringCon());
            //MessageBox.Show(conBeneficiario.GetSQLStringCon());
            ds = new DataSet("Beneficiario");

            SqlDataAdapter selBeneficiario = new SqlDataAdapter
                ("SELECT * FROM BENEFICIARIO", SqlCon);

            selBeneficiario.TableMappings.Add("Table", "BENEFICIARIO");
            selBeneficiario.Fill(ds);

            dsView = ds.DefaultViewManager;

            dgView.DataSource = dsView ;
            dgView.DataMember = "Beneficiario";
            dgView.Columns[0].HeaderText = "ID";
            dgView.Columns[0].Visible = false;
            dgView.Columns[1].HeaderText = "CNPJ/CPF";
            dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgView.Columns[2].HeaderText = "RAZÃO SOCIAL";
            dgView.Columns[3].HeaderText = "APELIDO";

            tbCNPJCPF.DataBindings.Add("Text", dsView, "BENEFICIARIO.BENEFICIARIO_CNPJCPF");
            tbNOMEFAN.DataBindings.Add("Text", dsView, "BENEFICIARIO.BENEFICIARIO_NOMEFAN");
            tbRAZAO.DataBindings.Add("Text", dsView, "BENEFICIARIO.BENEFICIARIO_RAZAOSOC");
        }
    }
}
