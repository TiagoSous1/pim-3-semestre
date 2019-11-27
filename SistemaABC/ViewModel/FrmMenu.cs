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
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            FrmEmpresa form = new FrmEmpresa();
            OpenNewForm openNew = new OpenNewForm();
            openNew.AbrirFormEnPanel(form, panelFull);
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            FrmMotorista form = new FrmMotorista();
            OpenNewForm openNew = new OpenNewForm();
            openNew.AbrirFormEnPanel(form, panelFull);
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            FrmVeiculos form = new FrmVeiculos();
            OpenNewForm openNew = new OpenNewForm();
            openNew.AbrirFormEnPanel(form, panelFull);
        }

        private void btnParts_Click(object sender, EventArgs e)
        {
            FrmPecas form = new FrmPecas();
            OpenNewForm openNew = new OpenNewForm();
            openNew.AbrirFormEnPanel(form, panelFull);
        }
    }
}
