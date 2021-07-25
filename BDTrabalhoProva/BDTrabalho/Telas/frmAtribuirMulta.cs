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
    public partial class frmAtribuirMulta : Form
    {
        public frmAtribuirMulta()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Decimal valor = nudValor.Value;
            int pontos = Convert.ToInt32(cboPontos.Text);

            Business.RidBusiness ridBusiness = new Business.RidBusiness();
            ridBusiness.AtribuirMulta(id, valor, pontos);
            MessageBox.Show("Com Sucesso Parça");
            this.Close();


        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
