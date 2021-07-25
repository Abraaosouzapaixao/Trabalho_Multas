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
    public partial class frmNovaSaida : Form
    {
        public frmNovaSaida()
        {

            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Model.RidModel model = new Model.RidModel();
            model.Piloto = txtPiloto.Text;
            model.Carro = txtCarro.Text;
            model.Dia = dtpDia.Value.Date;
            model.Saida = TimeSpan.Parse(txtSaida.Text);
            model.TeveMulta = false;

            Business.RidBusiness ridBusiness = new Business.RidBusiness();
            ridBusiness.NovaSaida(model);

            MessageBox.Show("saida registrada com sucesso");
            this.Close();
        }
        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click_1(object sender, EventArgs e)
        {

            Model.RidModel model = new Model.RidModel();
            model.Piloto = txtPiloto.Text;
            model.Carro = txtCarro.Text;
            model.Dia = dtpDia.Value.Date;
            model.Saida = TimeSpan.Parse(txtSaida.Text);
            model.TeveMulta = false;

            Business.RidBusiness ridBusiness = new Business.RidBusiness();
            ridBusiness.NovaSaida(model);

            MessageBox.Show("saida registrada com sucesso");
            this.Close();
        }

        private void LblFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}









