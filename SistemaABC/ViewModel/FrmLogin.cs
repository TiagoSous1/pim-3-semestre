using SistemaABCBusiness.Models;
using SistemaABCBusiness.Services;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string senha;
                bool authen;
                var listUsuario = new List<TblUsuarioModel>();
                string senhabanco;
                Descrypt descrypt = new Descrypt();
                TblUsuarioModel usuarioModel = new TblUsuarioModel();
                listUsuario = usuarioModel.GetSelectUser(txtPassword.Text);
                senhabanco = listUsuario[0].dePassword;
                senha = Descrypt.RetornarMD5(txtPassword.Text);
                authen = descrypt.ComparaMD5(senhabanco, senha);

                if (authen)
                {
                    Hide();
                    FrmMenu frm = new FrmMenu();
                    frm.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválida", "Sistema ABC");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Sistema ABC");
            }            
        }
    }
}
