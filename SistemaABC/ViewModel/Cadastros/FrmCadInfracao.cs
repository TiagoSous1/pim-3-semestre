using SistemaABCBusiness.Models;
using SistemaABCBusiness.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaABC.ViewModel.Cadastros
{
    public partial class FrmCadInfracao : Form
    {
        public FrmCadInfracao()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                TblInfracaoModel infracaoModel = new TblInfracaoModel(null, txtDescInfracao.Text, txtNmInfracao.Text, true);
                infracaoModel.State = EntityState.Add;
                MessageBox.Show(infracaoModel.saveChange(), "Sistema ABC");

                txtDescInfracao.Text = string.Empty;
                txtNmInfracao.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema ABC");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescInfracao.Text = string.Empty;
            txtNmInfracao.Text = string.Empty;
        }
    }
}
