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
    public partial class FrmCadVeiculos : Form
    {


        private string nmCompany;
        private long? idCompany;

        public FrmCadVeiculos()
        {
            InitializeComponent();
        }

        private void FrmCadVeiculos_Load(object sender, EventArgs e)
        {
            try
            {
                txtAno.MaxLength = 4;
                txtKilometro.MaxLength = 7;


                List<TblEmpresaModel> listEmpresa;
                TblEmpresaModel empresaModel = new TblEmpresaModel();
                listEmpresa = empresaModel.GetAll();
                string empresa;
                foreach (var item in listEmpresa)
                {
                    idCompany = item.idCompany;
                    nmCompany = item.nmCompany;

                    empresa = idCompany + "," + nmCompany;

                    cmbEmpresa.Items.Add(empresa);
                }
                cmbEmpresa.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema ABC");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAno.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            txtDescVeiculo.Text = string.Empty;
            txtKilometro.Text = string.Empty;
            cmbEmpresa.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                TblVeiculoModel veiculoModel = new TblVeiculoModel(null, txtDescVeiculo.Text,txtPlaca.Text, idCompany, int.Parse(txtKilometro.Text), int.Parse(txtAno.Text))
                {
                    State = EntityState.Add
                };
                MessageBox.Show(veiculoModel.saveChange(), "Sistema ABC");

                txtAno.Text = string.Empty;
                txtPlaca.Text = string.Empty;
                txtDescVeiculo.Text = string.Empty;
                txtKilometro.Text = string.Empty;
                cmbEmpresa.Text = string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema ABC");
            }
            


        }
    }
}
