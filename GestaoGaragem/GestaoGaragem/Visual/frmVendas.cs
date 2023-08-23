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
using GestaoGaragem.Negocio;
using GestaoGaragem.Utilidade;
using GestaoGaragem.Validacao;
using MetroFramework.Forms;

namespace GestaoGaragem.Visual
{
    public partial class frmVendas : MetroForm
    {
        private Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        private string usuario, operacao;
        private negocio_Cliente clienteNegocio;
        private negocio_Veiculo veiculoNegocio;
        public frmVendas()
        {
            InitializeComponent();
            // Inicializar instâncias das classes de negócio // Substitua pelo objeto de conexão real
            clienteNegocio = new negocio_Cliente(conexao);
            veiculoNegocio = new negocio_Veiculo(conexao);

        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlterarBotao(1);
            DataTable tabelaClientes = clienteNegocio.ListarCliente("");
            comboBoxCliente.DataSource = tabelaClientes;
            comboBoxCliente.DisplayMember = "cli_nome";
            comboBoxCliente.ValueMember = "cli_id";

            // Buscar veículos
            DataTable tabelaVeiculos = veiculoNegocio.ListarVeiculo("");
            comboBoxVeiculo.DataSource = tabelaVeiculos;
            comboBoxVeiculo.DisplayMember = "veic_modelo";
            comboBoxVeiculo.ValueMember = "veic_id";
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
            comboBoxCliente.Enabled = true;
            comboBoxVeiculo.Enabled = true;
            txtDataVenda.Enabled = true;
            txtValorVenda.Enabled = true;
        }
        //desabilita campos
        public void DesabilitaCampos()
        {
            txtId.Enabled = false;
            comboBoxCliente.Enabled = false;
            comboBoxVeiculo.Enabled = false;
            txtDataVenda.Enabled = false;
            txtValorVenda.Enabled = false;
        }
        //limpa campos
        public void LimpaCampos()
        {
            txtId.Text = "";
            comboBoxCliente.Text = "";
            comboBoxVeiculo.Text = "";
            txtDataVenda.Text = "";
            txtValorVenda.Text = "";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.HabilitaCampos();
            this.comboBoxCliente.Focus();
            this.AlterarBotao(2);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlterarBotao(2);
            this.comboBoxCliente.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show(this, "\n\n Deseja realmente excluir o cadastro selecionado?", "CONFIRMAR EXCLUSÃO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado.ToString() == "Yes")
                {
                    validacao_Venda valida_venda = new validacao_Venda(conexao);
                    valida_venda.ExcluirVenda(Convert.ToInt32(txtId.Text));
                    MessageBox.Show(this, "\n Venda excluída com sucesso", "EXCLUSÃO DE VENDA",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlterarBotao(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "\n\n Não foi possivel deletar a Venda do banco de dados. \n Detalhes:" + ex.Message,
                    "ERROR AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.comboBoxCliente.Focus();
                this.AlterarBotao(3);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            try
            {
                conexao.AbrirConexao();
                modelo_Venda venda = new modelo_Venda();
                venda.Veiculo_id = Convert.ToInt32(comboBoxVeiculo.SelectedValue);
                venda.Cliente_id = Convert.ToInt32(comboBoxCliente.SelectedValue);
                venda.Venda_data = Convert.ToDateTime(txtDataVenda.Text);
                venda.Venda_valor = Convert.ToDecimal(txtValorVenda.Text);

               // negocio_Venda vendaNegocio = new negocio_Venda(conexao);
                validacao_Venda valida_venda = new validacao_Venda(conexao); // Instanciação correta da classe validacao_Venda

                if (operacao == "cadastrar")
                {
                    // vendaNegocio.SalvarVenda(venda);
                    valida_venda.SalvarVenda(venda);
                    MessageBox.Show(this, "\n Veículo cadastrado com sucesso", "Cadastro de Veículo",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();

                    // Marcar o veículo como indisponível
                    //int veiculoId = Convert.ToInt32(comboBoxVeiculo.SelectedValue);
                    // modelo_Veiculo veiculo = veiculoNegocio.CarregarVeiculo(veiculoId);
                    // veiculo.Veic_disponivel = false;
                    // veiculoNegocio.EditarVeiculo(veiculo);

                    // Atualizar a exibição dos veículos no ComboBox de veículos
                    // DataTable tabelaVeiculos = veiculoNegocio.ListarVeiculo("");
                    // comboBoxVeiculo.DataSource = tabelaVeiculos;
                    // comboBoxVeiculo.DisplayMember = "veic_modelo";
                    //comboBoxVeiculo.ValueMember = "veic_id";
                }
                else
                {
                    venda.Venda_id = Convert.ToInt32(txtId.Text);
                    valida_venda.ValidarEditarVenda(venda); // Chamar o método ValidarEditarVenda
                    MessageBox.Show(this, "\n Venda editada com sucesso", "Edição de Venda",
                            MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                this.LimpaCampos();
                this.AlterarBotao(1);
                this.DesabilitaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "\n\n Não foi possível efetuar a operação. \n Detalhes:" + ex.Message, "ERRO AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conexao.FecharConexao();
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmRelatorioVenda fRelatorioVenda = new frmRelatorioVenda();
            fRelatorioVenda.ShowDialog();
            if (fRelatorioVenda.codigo != 0)
            {
                validacao_Venda valida_venda = new validacao_Venda(conexao);
                modelo_Venda modelo_venda = valida_venda.CarregarVenda(fRelatorioVenda.codigo);
                txtId.Text = modelo_venda.Venda_id.ToString();
                txtDataVenda.Text = modelo_venda.Venda_data.ToShortDateString();
                txtValorVenda.Text = modelo_venda.Venda_valor.ToString();
                comboBoxCliente.Text = modelo_venda.Cliente_id.ToString();
                comboBoxVeiculo.Text = modelo_venda.Veiculo_id.ToString();
                AlterarBotao(3);
            }
            else
            {
                LimpaCampos();
                txtDataVenda.Focus();
                AlterarBotao(1);
            }
            fRelatorioVenda.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            this.txtDataVenda.Focus();
            this.DesabilitaCampos();
            this.AlterarBotao(1);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
