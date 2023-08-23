using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace GestaoGaragem.Visual
{
    public partial class formRelatorio : MetroForm
    {
        public formRelatorio()
        {
            InitializeComponent();
        }
        //chama tela de relatório de usuário
        private void btnRelatorioUsuario_Click(object sender, EventArgs e)
        {
            formRelatorioUsuario f = new formRelatorioUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnRelatorioFormaPagto_Click(object sender, EventArgs e)
        {
            frmRelatorioFormaPagto f = new frmRelatorioFormaPagto();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnRelatorioCliente_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente f = new frmRelatorioCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnRelatorioVeiculo_Click(object sender, EventArgs e)
        {
            frmRelatorioVeiculo f = new frmRelatorioVeiculo();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnRelatorioVenda_Click(object sender, EventArgs e)
        {
            frmRelatorioVenda f = new frmRelatorioVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            frmRelatorioGastos f = new frmRelatorioGastos();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
