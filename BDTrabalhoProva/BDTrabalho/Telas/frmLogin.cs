using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDTrabalho
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "adm" && txtSenha.Text == "123")
            {
                frmMenu tela = new frmMenu();
                tela.Show();

                this.Close();

            }
            else
            {
                MessageBox.Show("crendencias inavalieda", "rid", MessageBoxButtons.OK);
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
