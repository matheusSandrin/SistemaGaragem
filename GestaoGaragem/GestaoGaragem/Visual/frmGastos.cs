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
    public partial class frmGastos : MetroForm
    {
        private Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        private string usuario, operacao;
        public frmGastos()
        {
            InitializeComponent();
        }

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
        public void HabilitaCampos()
        {
            txtId.Enabled = false;
            txtValorGasto.Enabled = true;
            txtDataGasto.Enabled = true;
            txtDescricao.Enabled = true;
        }
        //desabilita campos
        public void DesabilitaCampos()
        {
            txtId.Enabled = false;
            txtValorGasto.Enabled = false;
            txtDataGasto.Enabled = false;
            txtDescricao.Enabled = false;
        }
        //limpa campos
        public void LimpaCampos()
        {
            txtId.Text = "";
            txtValorGasto.Text = "";
            txtDataGasto.Text = "";
            txtDescricao.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            this.txtValorGasto.Focus();
            this.DesabilitaCampos();
            this.AlterarBotao(1);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlterarBotao(2);
            this.txtValorGasto.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show(this, "\n\n Deseja realmente excluir o cadastro selecionado?", "CONFIRMAR EXCLUSÃO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado.ToString() == "Yes")
                {
                    validacao_Gastos valida_gastos = new validacao_Gastos(conexao);
                    valida_gastos.ExcluirGastos(Convert.ToInt32(txtId.Text));
                    MessageBox.Show(this, "\n Gasto excluído com sucesso", "EXCLUSÃO DE GASTO",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlterarBotao(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "\n\n Não foi possivel deletar o Gasto do banco de dados. \n Detalhes:" + ex.Message,
                    "ERROR AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtValorGasto.Focus();
                this.AlterarBotao(3);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Gastos modelo_gastos = new modelo_Gastos();
                modelo_gastos.Gastos_data = Convert.ToDateTime(txtDataGasto.Text);
                modelo_gastos.Gastos_valor= Convert.ToDecimal(txtValorGasto.Text);
                modelo_gastos.Gastos_descricao = txtDescricao.Text;

                validacao_Gastos valida_gastos = new validacao_Gastos(conexao);
                if (operacao == "cadastrar")
                {
                    valida_gastos.SalvarGastos(modelo_gastos);
                    MessageBox.Show(this, "\n Gasto cadastrado com sucesso", "Cadastro de Gastos",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();

                }
                else
                {
                    modelo_gastos.Gastos_id = Convert.ToInt32(txtId.Text);
                    valida_gastos.ValidarEditarGastos(modelo_gastos);
                    MessageBox.Show(this, "\n Gasto editado com sucesso", "Edição de Gasto",
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

        private void frmGastos_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlterarBotao(1);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmRelatorioGastos fRelatorioGastos = new frmRelatorioGastos();
            fRelatorioGastos.ShowDialog();
            if (fRelatorioGastos.codigo != 0)
            {
                validacao_Gastos valida_gastos = new validacao_Gastos(conexao);
                modelo_Gastos modelo_gastos = valida_gastos.CarregarGastos(fRelatorioGastos.codigo);
                txtId.Text = modelo_gastos.Gastos_id.ToString();
                txtDataGasto.Text = modelo_gastos.Gastos_data.ToShortDateString();
                txtValorGasto.Text = modelo_gastos.Gastos_valor.ToString();
                txtDescricao.Text = modelo_gastos.Gastos_descricao;
                AlterarBotao(3);
            }
            else
            {
                LimpaCampos();
                txtDataGasto.Focus();
                AlterarBotao(1);
            }
            fRelatorioGastos.Dispose();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.HabilitaCampos();
            this.txtValorGasto.Focus();
            this.AlterarBotao(2);

        }
    }
}
