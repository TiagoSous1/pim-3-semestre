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
            string descPecas = txtDescPecas.Text;

            TblPecasModel pecasModel = new TblPecasModel(preco, dataCompra, dataCompra,null,descPecas);
            pecasModel.State = EntityState.Add;
            MessageBox.Show(pecasModel.saveChange());

            txtCod.Text = string.Empty;
            txtDescPecas.Text = string.Empty;
            txtNomePecas.Text = string.Empty;
            txtPreco.Text = string.Empty;
            dtpDataCompra.Value = DateTime.Now;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCod.Text = string.Empty;
            txtDescPecas.Text = string.Empty;
            txtNomePecas.Text = string.Empty;
            txtPreco.Text = string.Empty;
            dtpDataCompra.Value = DateTime.Now;
        }
    }
}
