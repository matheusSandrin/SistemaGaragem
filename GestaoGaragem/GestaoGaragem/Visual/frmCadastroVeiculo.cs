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
    public partial class frmCadastroVeiculo : MetroForm
    {
        private Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        private string usuario, operacao;
        public frmCadastroVeiculo()
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
        //habilita campos
        public void HabilitaCampos()
        {
            txtId.Enabled = false;
            txtModeloVeic.Enabled = true;
            txtDataDeCompra.Enabled = true;
            txtMarcaVeic.Enabled = true;
            txtAno.Enabled = true;
            txtPlaca.Enabled = true;
            txtKm.Enabled = true;
            txtValorPago.Enabled = true;
            txtValorVenda.Enabled = true;
        }
        //desabilita campos
        public void DesabilitaCampos()
        {
            txtId.Enabled = false;
            txtModeloVeic.Enabled = false;
            txtDataDeCompra.Enabled = false;
            txtMarcaVeic.Enabled = false;
            txtAno.Enabled = false;
            txtPlaca.Enabled = false;
            txtKm.Enabled = false;
            txtValorPago.Enabled = false;
            txtValorVenda.Enabled = false;
        }
        //limpa campos
        public void LimpaCampos()
        {
            txtId.Text = "";
            txtModeloVeic.Text = "";
            txtDataDeCompra.Text = "";
            txtMarcaVeic.Text = "";
            txtAno.Text = "";
            txtPlaca.Text = "";
            txtKm.Text = "";
            txtValorPago.Text = "";
            txtValorVenda.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            this.txtModeloVeic.Focus();
            this.DesabilitaCampos();
            this.AlterarBotao(1);
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.HabilitaCampos();
            this.txtModeloVeic.Focus();
            this.AlterarBotao(2);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlterarBotao(2);
            this.txtModeloVeic.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show(this, "\n\n Deseja realmente excluir o cadastro selecionado?", "CONFIRMAR EXCLUSÃO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado.ToString() == "Yes")
                {
                    validacao_Veiculo valida_veiculo = new validacao_Veiculo(conexao);
                    valida_veiculo.ExcluirVeiculo(Convert.ToInt32(txtId.Text));
                    MessageBox.Show(this, "\n Veículo excluído com sucesso", "EXCLUSÃO DE VEÍCULO",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlterarBotao(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "\n\n Não foi possivel deletar o Veículo do banco de dados. \n Detalhes:" + ex.Message,
                    "ERROR AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtModeloVeic.Focus();
                this.AlterarBotao(3);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Veiculo modelo_veiculo = new modelo_Veiculo();
                modelo_veiculo.Veic_datacompra = Convert.ToDateTime(txtDataDeCompra.Text);
                modelo_veiculo.Veic_modelo = txtModeloVeic.Text;
                modelo_veiculo.Veic_marca = txtMarcaVeic.Text;
                modelo_veiculo.Veic_ano = Convert.ToInt32(txtAno.Text);
                modelo_veiculo.Veic_placa = txtPlaca.Text;
                modelo_veiculo.Veic_km = Convert.ToDecimal(txtKm.Text);
                modelo_veiculo.Veic_precopago = Convert.ToDecimal(txtValorPago.Text);
                modelo_veiculo.Veic_precovenda = Convert.ToDecimal(txtValorVenda.Text);

                validacao_Veiculo valida_veiculo = new validacao_Veiculo(conexao);
                if (operacao == "cadastrar")
                {
                    valida_veiculo.SalvarVeiculo(modelo_veiculo);
                    MessageBox.Show(this, "\n Veículo cadastrado com sucesso", "Cadastro de Veículo",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();

                }
                else
                {
                    modelo_veiculo.Veic_id = Convert.ToInt32(txtId.Text);
                    valida_veiculo.ValidarEditarVeiculo(modelo_veiculo);
                    MessageBox.Show(this, "\n Veículo editado com sucesso", "Edição de Veículo",
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmRelatorioVeiculo fRelatorioVeiculo = new frmRelatorioVeiculo();
            fRelatorioVeiculo.ShowDialog();
            if (fRelatorioVeiculo.codigo != 0)
            {
                validacao_Veiculo valida_veiculo = new validacao_Veiculo(conexao);
                modelo_Veiculo modelo_veiculo = valida_veiculo.CarregarVeiculo(fRelatorioVeiculo.codigo);
                txtId.Text = modelo_veiculo.Veic_id.ToString();
                txtDataDeCompra.Text = modelo_veiculo.Veic_datacompra.ToShortDateString();
                txtModeloVeic.Text = modelo_veiculo.Veic_modelo;
                txtMarcaVeic.Text = modelo_veiculo.Veic_marca;
                txtAno.Text = modelo_veiculo.Veic_ano.ToString();
                txtPlaca.Text = modelo_veiculo.Veic_placa;
                txtKm.Text = modelo_veiculo.Veic_km.ToString();
                txtValorPago.Text = modelo_veiculo.Veic_precopago.ToString();
                txtValorVenda.Text = modelo_veiculo.Veic_precovenda.ToString();
                AlterarBotao(3);
            }
            else
            {
                LimpaCampos();
                txtModeloVeic.Focus();
                AlterarBotao(1);
            }
            fRelatorioVeiculo.Dispose();
        }

        private void frmCadastroVeiculo_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlterarBotao(1);
        }

        
    }
}
