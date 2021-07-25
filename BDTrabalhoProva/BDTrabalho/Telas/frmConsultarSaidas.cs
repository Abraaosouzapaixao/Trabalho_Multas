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
    public partial class frmConsultarSaidas : Form
    {
        public frmConsultarSaidas()
        {
            InitializeComponent();
        }

        private void txtPiloto_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void dtpDia_ValueChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }
            
        private void Buscar()
        {
            string piloto = txtPiloto.Text;
            DateTime dia = dtpDia.Value.Date;

            Business.RidBusiness ridBusiness = new Business.RidBusiness();
            List<Model.RidModel> lista = ridBusiness.fitrar(piloto, dia);

            dgvRids.DataSource = lista;


        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvRids_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
