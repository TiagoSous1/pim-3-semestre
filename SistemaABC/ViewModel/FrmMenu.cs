using SistemaABC.Entities;
using SistemaABC.ViewModel.Exibicao;
using System;
using System.Windows.Forms;

namespace SistemaABC.ViewModel
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            FrmUsuario form = new FrmUsuario();
            OpenNewForm openNew = new OpenNewForm();
            openNew.AbrirFormEnPanel(form, panelFull);

            //FrmCadUsuario frm = new FrmCadUsuario();
            //frm.Show();

        }


    }
}
