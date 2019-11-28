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
    public partial class FrmCadMultas : Form
    {
        private string nm;
        private long? id;


        public FrmCadMultas()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                string[] carroArray = cmbCarro.Text.Split(',');
                long idVehicle = long.Parse(carroArray[0]);

                string[] infractionArray = cmbInfracao.Text.Split(',');
                int idInfraction = int.Parse(infractionArray[0]);

                string[] CompanyArray = cmbInfracao.Text.Split(',');
                long idCompany = long.Parse(CompanyArray[0]);

                float preco = float.Parse(txtPreco.Text.Replace(".", ","));



                TblMultasModel multasModel = new TblMultasModel(null, idVehicle,idInfraction, dtpMulta.Value, txtCodBarra.Text,idCompany,preco);
                multasModel.State = EntityState.Add;
                MessageBox.Show(multasModel.saveChange(),"Sistema ABC");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema ABC");
            }
            
        }

        private void FrmCadMultas_Load(object sender, EventArgs e)
        {

            List<TblEmpresaModel> listEmpresa;
            TblEmpresaModel empresaModel = new TblEmpresaModel();
            listEmpresa = empresaModel.GetAll();
            string empresa;
            foreach (var item in listEmpresa)
            {
                id = item.idCompany;
                nm = item.nmCompany;

                empresa = id + "," + nm;

                cmbEmpresa.Items.Add(empresa);
            }
            cmbEmpresa.Text = "";

            List<TblInfracaoModel> listInfracao;
            TblInfracaoModel infracaoModel = new TblInfracaoModel();
            listInfracao = infracaoModel.GetAll();
            string infracao;
            foreach (var item in listInfracao)
            {
                id = item.idInfraction;
                nm = item.nmInfraction;

                infracao = id + "," + nm;

                cmbInfracao.Items.Add(infracao);
            }
            cmbInfracao.Text = "";

            List<TblVeiculoModel> listVeiculo;
            TblVeiculoModel veiculoModel = new TblVeiculoModel();
            listVeiculo = veiculoModel.GetAll();
            string veiculo;
            foreach (var item in listVeiculo)
            {
                id = item.idVehicle;
                nm = item.board;

                veiculo = id + "," + nm;

                cmbCarro.Items.Add(veiculo);
            }
            cmbInfracao.Text = "";

        }
    }
}
