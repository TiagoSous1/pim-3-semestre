using SistemaABCBusiness.Models;
using SistemaABCBusiness.ValueObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaABC.ViewModel
{
    public partial class FrmCadEmpresa : Form
    {
        public FrmCadEmpresa()
        {
            InitializeComponent();
        }

        private int? idAddress;
        private string street;
        private int? number;
        private string codeZip;
        private string neighborhood;
        private string city;
        private string nmState;
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string[] enderecoArray = cmbEndereco.Text.Split(',');
            string endereco = enderecoArray[0];

            TblEmpresaModel empresaModel = new TblEmpresaModel(txtRazao.Text,txtCnpj.Text,txtEstado.Text,int.Parse(endereco), long.Parse(txtTelefone.Text))
            { 
                State = EntityState.Add
            };
            MessageBox.Show(empresaModel.saveChange());

            txtCnpj.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtRazao.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            cmbEndereco.Text = string.Empty;


        }

        private void brnClear_Click(object sender, EventArgs e)
        {
            txtCnpj.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtRazao.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            cmbEndereco.Text = string.Empty;
        }

        private void FrmCadEmpresa_Load(object sender, EventArgs e)
        {

            List<TblEnderecoModel> listEndereco;
            TblEnderecoModel enderecoModel = new TblEnderecoModel();
            listEndereco = enderecoModel.GetAll();
            string endereco;
            foreach (var item in listEndereco)
            {

                idAddress = item.idAddress;
                street = item.street;
                number = item.number;
                codeZip = item.codeZip;
                neighborhood = item.neighborhood;
                city = item.city;
                nmState = item.nmState;

                endereco = idAddress + ", " + street + "-" + number + ", " + codeZip + ", " + neighborhood + ", " + city + ", " + nmState;

                cmbEndereco.Items.Add(endereco);
            }
        }
    }
}
