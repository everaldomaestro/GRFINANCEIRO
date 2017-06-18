using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Forms;

namespace App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmPrincipal formPrincipal = new frmPrincipal();
            formPrincipal.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
