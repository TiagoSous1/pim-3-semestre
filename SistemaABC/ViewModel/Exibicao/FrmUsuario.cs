using System;
using System.Windows.Forms;
using SistemaABCBusiness.Models;

namespace SistemaABC.ViewModel.Exibicao
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            TblUsuarioModel usuarioModel = new TblUsuarioModel();
            dgvUsers.DataSource = usuarioModel.GetAll();
        }

        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            FrmCadUsuario frm = new FrmCadUsuario();
            frm.Show();
        }
    }
}
