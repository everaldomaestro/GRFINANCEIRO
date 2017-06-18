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

        private void frmCadastrosPai_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
