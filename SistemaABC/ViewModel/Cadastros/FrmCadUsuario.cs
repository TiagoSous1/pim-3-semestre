using SistemaABC.Entities;
using SistemaABCBusiness.Models;
using SistemaABCBusiness.Services;
using SistemaABCBusiness.ValueObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaABC.ViewModel
{
    public partial class FrmCadUsuario : Form
    {
        public FrmCadUsuario()
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
        private EntityRole entityRole;
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            string senha;
            if (txtUsuario.Text != string.Empty && txtNome.Text != string.Empty && txtCpf.Text != string.Empty && txtCnh.Text != string.Empty && txtRg.Text != string.Empty && txtSenha.Text != string.Empty && txtConfSenha.Text != string.Empty)
            {

                if (!ValidaDigitoCPF.ValidaCPF(txtCpf.Text))
                {
                    MessageBox.Show("Cpf digitado é invávlido!", "Sistema ABC");
                    return;
                }

                if (!ValidaCNH.ValidacaoCNH(txtCnh.Text))
                {
                    MessageBox.Show("CNH digitado é invávlido!", "Sistema ABC");
                    return;
                }

                if (txtSenha.Text != txtConfSenha.Text)
                {
                    MessageBox.Show("Senha digitadas estão incorretas!", "Sistema ABC");
                    return;
                }
                else
                {
                    senha = Descrypt.RetornarMD5(txtConfSenha.Text);
                }
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatorios, preencha de forma correta.", "Sistema ABC");
                return;
            }
            

            entityRole = (EntityRole)Enum.Parse(typeof(EntityRole), cmbRole.Text);

            string[] enderecoArray = cmbEndereco.Text.Split(',');
            string endereco = enderecoArray[0];

            TblUsuarioModel usuarioModel = new TblUsuarioModel(txtUsuario.Text, txtNome.Text, txtCpf.Text, txtRg.Text, txtCnh.Text, senha, txtEmail.Text, entityRole, int.Parse(endereco), true)
            {
                State = EntityState.Add
            };
            MessageBox.Show(usuarioModel.saveChange(),"Sistema ABC", MessageBoxButtons.OKCancel);

        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
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

            List<TblRoleModel> listRole;
            TblRoleModel roleModel = new TblRoleModel();
            listRole = roleModel.GetAll();


            foreach (var item in listRole)
            {
                string role;
                role = item.nmRole;
                cmbRole.Items.Add(role);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConfSenha.Text = string.Empty;
            txtCnh.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtRg.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            cmbEndereco.Text = string.Empty;
            cmbRole.Text = string.Empty;
        }
    }
}
