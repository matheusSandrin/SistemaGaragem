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
    public partial class formCadastro : MetroForm
    {
        public formCadastro()
        {
            InitializeComponent();
        }

        private void formCadastro_Load(object sender, EventArgs e)
        {

        }
        //Chama o formulário cadastro de usuário
        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            formCadastroUsuario f = new formCadastroUsuario();
            f.ShowDialog();
            f.Dispose();
        }
        //chama formulário cadastro forma pagto
        private void btnFormaPagto_Click(object sender, EventArgs e)
        {
            frmFormaPagto f = new frmFormaPagto();
            f.ShowDialog();
            f.Dispose();
        }
        //chama formulário cadastro de cliente
        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }
        //chama formulário cadastro de veículo
        private void btnCadastroVeiculo_Click(object sender, EventArgs e)
        {
            frmCadastroVeiculo f = new frmCadastroVeiculo();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
