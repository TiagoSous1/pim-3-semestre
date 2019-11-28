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
    public partial class FrmMultas : Form
    {
        public FrmMultas()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadMultas frm = new FrmCadMultas();
            frm.Show();
        }

        private void FrmMultas_Load(object sender, EventArgs e)
        {
            TblMultasModel multasModel = new TblMultasModel();
            dgvUsers.DataSource = multasModel.GetAll();
        }
    }
}
