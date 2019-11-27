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
    public partial class FrmCadPecas : Form
    {
        public FrmCadPecas()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            float preco = float.Parse(txtPreco.Text);
            DateTime dataCompra = dtpDataCompra.Value;

            TblPecasModel pecasModel = new TblPecasModel(preco, dataCompra, null,null);
            pecasModel.State = EntityState.Add;
            pecasModel.saveChange();
        }
    }
}
