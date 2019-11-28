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

namespace SistemaABC.ViewModel
{
    public partial class FrmCadAbastecimento : Form
    {
        public FrmCadAbastecimento()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TblAbastecimentoModel abastecimentoModel = new TblAbastecimentoModel();

            abastecimentoModel.State = EntityState.Add;
            MessageBox.Show(abastecimentoModel.saveChange());

        }
    }
}
