using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaABC.ViewModel.Exibicao
{
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void btnCadEmpresa_Click(object sender, EventArgs e)
        {
            FrmCadEmpresa cadEmpresa = new FrmCadEmpresa();
            cadEmpresa.Show();
        }
    }
}
