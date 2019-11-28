using SistemaABC.ViewModel.Cadastros;
using SistemaABCBusiness.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaABC.ViewModel.Exibicao
{
    public partial class FrmInfracao : Form
    {
        public FrmInfracao()
        {
            InitializeComponent();
        }

        private void FrmInfracao_Load(object sender, EventArgs e)
        {
            TblInfracaoModel infracaoModel = new TblInfracaoModel();
            dgvUsers.DataSource = infracaoModel.GetAll();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadInfracao frm = new FrmCadInfracao();
            frm.Show();
        }
    }
}
