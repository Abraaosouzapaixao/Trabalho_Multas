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
    public partial class frmMarcarChegada : Form
    {
        public frmMarcarChegada()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            TimeSpan chegada = TimeSpan.Parse(txtChegada.Text);
            string obsevacao = txtObs.Text;

                

            Business.RidBusiness ridBusiness = new Business.RidBusiness();
            ridBusiness.MarcarChegada(id, chegada, obsevacao);

            MessageBox.Show("chegada registrada com sucesso");
            this.Close();
        }


        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtChegada_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
