using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoGaragem.Modelo;
using GestaoGaragem.Utilidade;
using GestaoGaragem.Validacao;
using MetroFramework.Forms;

namespace GestaoGaragem.Visual
{
    public partial class frmFormaPagto : MetroForm
    {
        private Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        private string usuario, operacao;
        public frmFormaPagto()
        {
            InitializeComponent();
        }
        //função altera estado dos botões
        public void AlterarBotao(int op)
        {
            btnVoltar.Enabled = false;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;

            if (op == 1)
            {
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                btnVoltar.Enabled = true;
            }
            if (op == 2)
            {
                btnGravar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }
        //função habilita campos do form
        public void HabilitaCampos()
        {
            txtFormaPagto.Enabled = true;
        }
        //função desabilita campos do form
        public void DesabilitaCampos()
        {
            txtFormaPagto.Enabled = false;
        }
        //função limpa campos do form
        public void LimpaCampos()
        {
            txtId.Text = "";
            txtFormaPagto.Text = "";

        }
        //método load do form
        private void frmFormaPagto_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlterarBotao(1);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.HabilitaCampos();
            this.AlterarBotao(2);
            this.txtFormaPagto.Focus();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlterarBotao(2);
            this.txtFormaPagto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            this.txtFormaPagto.Focus();
            this.DesabilitaCampos();
            this.AlterarBotao(1);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_FormaPagto modelo_formaPagto = new modelo_FormaPagto();
                modelo_formaPagto.Forma_descricao = txtFormaPagto.Text;
                validacao_FormaPagto valida_formaPagto = new validacao_FormaPagto(conexao);
                if (operacao == "cadastrar")
                {
                    valida_formaPagto.SalvarFormaPagto(modelo_formaPagto);
                    MessageBox.Show(this, "\n Forma de pagamento cadastrada com sucesso", "Cadastro de usuário",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();

                }
                else
                {
                    modelo_formaPagto.Forma_id = Convert.ToInt32(txtId.Text);
                    valida_formaPagto.EditarFormaPagto(modelo_formaPagto);
                    MessageBox.Show(this, "\n Forma de pagamento cadastrada com sucesso", "Edição de usuário",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                this.LimpaCampos();
                this.AlterarBotao(1);
                this.DesabilitaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "\n\n Não foi possivel efetuar a operação. \n Detalhes:" + ex.Message, "ERROR AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show(this, "\n\n Deseja realmente excluir o pagamento selecionado?", "CONFIRMAR EXCLUSÃO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado.ToString() == "Yes")
                {
                    validacao_FormaPagto valida_formaPagto = new validacao_FormaPagto(conexao);
                    valida_formaPagto.ExcluirFormaPagto(Convert.ToInt32(txtId.Text));
                    MessageBox.Show(this, "\n Pagamento excluído com sucesso", "EXCLUSÃO DE PAGAMENTO",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlterarBotao(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "\n\n Não foi possivel deleter o pagamento do banco de dados. \n Detalhes:" + ex.Message,
                    "ERROR AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtFormaPagto.Focus();
                this.AlterarBotao(3);
            }
        }
        //método botão pesquisar formulário de pagamento
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmRelatorioFormaPagto fRelatorioFormaPagto = new frmRelatorioFormaPagto();
            fRelatorioFormaPagto.ShowDialog();
            if (fRelatorioFormaPagto.codigo != 0)
            {
                validacao_FormaPagto valida_formaPagto = new validacao_FormaPagto(conexao);
                modelo_FormaPagto modelo_formaPagto = valida_formaPagto.CarregarFormaPagto(fRelatorioFormaPagto.codigo);
                txtId.Text = modelo_formaPagto.Forma_id.ToString();
                txtFormaPagto.Text = modelo_formaPagto.Forma_descricao;
                AlterarBotao(3);
            }
            else
            {
                LimpaCampos();
                txtFormaPagto.Focus();
                AlterarBotao(1);
            }
            fRelatorioFormaPagto.Dispose();
        }

        //método botão voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
