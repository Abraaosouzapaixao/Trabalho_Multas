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
    public partial class frmRemoverSaida : Form
    {
        public frmRemoverSaida()
        {
            InitializeComponent();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if(txtId.Text == string.Empty)
            {
                this.LimparCampos();
                return;
            }
            int id = Convert.ToInt32(txtId.Text);

            Business.RidBusiness ridBusiness = new Business.RidBusiness();
            Model.RidModel model = ridBusiness.BuscarPorid(id);

            if (model != null)
            {
                txtPiloto.Text = model.Piloto;
                dtpDia.Value = model.Dia;
                panelConfirmacao.Visible = true;

            }
            else
            {
                this.LimparCampos();
            }
        }
        private void LimparCampos()
        {
            txtPiloto.Clear();
            dtpDia.Value = DateTime.Now;
            panelConfirmacao.Visible = false;
        }


        private void btnSim_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            Business.RidBusiness ridBusiness = new Business.RidBusiness();
            ridBusiness.RemoverSaida(id);

            MessageBox.Show("Removeu com sucesso Brow");
            this.Close();
        }



        private void btnNao_Click(object sender, EventArgs e)
        {
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
