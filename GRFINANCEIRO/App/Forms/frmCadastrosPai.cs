using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms
{
    public partial class frmCadastrosPai : Form
    {

        protected DataSet ds;
        protected DataViewManager dsView;
        protected SqlConnection SqlCon;

        public frmCadastrosPai()
        {
            InitializeComponent();
        }

        protected virtual void frmCadastrosPai_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        protected virtual void frmCadastrosPai_Load(object sender, EventArgs e)
        {
            btnInsert.Enabled = true;
            btnGravar.Enabled = false;
            btnEditar.Enabled = true;
            btnDeletar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        protected virtual void btnInsert_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnGravar_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnEditar_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnDeletar_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnPrimeiro_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnProximo_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnUltimo_Click(object sender, EventArgs e)
        {

        }

        protected void ativaControles(bool cmd)
        {
            dgView.AllowUserToAddRows = !cmd;
            dgView.ReadOnly = cmd;

            foreach (Control c in groupBox2.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).ReadOnly = cmd;
                }
            }

        }
    }
}
