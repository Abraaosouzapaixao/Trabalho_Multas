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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void lblNovaSaida_Click(object sender, EventArgs e)
        {
            frmNovaSaida  tela = new frmNovaSaida();
            tela.Show();
        }

        private void lblMarcarChegada_Click(object sender, EventArgs e)
        {
            frmMarcarChegada tela = new frmMarcarChegada();
            tela.Show();
        }

        private void lblAtribuirMulta_Click(object sender, EventArgs e)
        {
            frmAtribuirMulta tela = new frmAtribuirMulta();
            tela.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarSaidas tela = new frmConsultarSaidas();
            tela.Show();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            frmRemoverSaida tela = new frmRemoverSaida();
            tela.Show();
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
