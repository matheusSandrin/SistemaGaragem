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
using GestaoGaragem.Visual;

namespace GestaoGaragem
{
    public partial class frmPrincipal : MetroForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            formCadastro f = new formCadastro();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            formRelatorio f = new formRelatorio();
            f.ShowDialog();
            f.Dispose();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculaJuros_Click(object sender, EventArgs e)
        {
            frmCalculaJurosSimples f = new frmCalculaJurosSimples();
            f.ShowDialog();
            f.Dispose();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmVendas f = new frmVendas();
            f.ShowDialog();
            f.Dispose();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            frmGastos f = new frmGastos();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            frmFinanceiro f = new frmFinanceiro();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
