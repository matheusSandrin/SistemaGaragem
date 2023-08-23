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
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace GestaoGaragem.Visual
{
    public partial class frmCadastroCliente : MetroForm
    {
        private Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        private string usuario, operacao;
        utilidade_FormataCampos utilidade_formataCampos = new utilidade_FormataCampos();
        public frmCadastroCliente()
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
            txtId.Enabled = false;
            txtDataCadastro.Enabled = true;
            txtCpf.Enabled = true;
            txtNomeCliente.Enabled = true;
            txtCep.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            txtObservacoes.Enabled = true;
        }
        //função desabilita campos do form
        public void DesabilitaCampos()
        {
            txtId.Enabled = false;
            txtDataCadastro.Enabled = false;
            txtCpf.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtCep.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            txtObservacoes.Enabled = false;
        }

        public void LimpaCampos()
        {
            txtId.Text = "";
            txtDataCadastro.Text = "";
            txtCpf.Text = "";
            txtNomeCliente.Text = "";
            txtCep.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtObservacoes.Text = "";
        }
        //método voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //método botão novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.HabilitaCampos();
            this.txtDataCadastro.Focus();
            this.AlterarBotao(2);
        }
        //método botão cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            this.txtDataCadastro.Focus();
            this.DesabilitaCampos();
            this.AlterarBotao(1);
        }
        //método botão editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlterarBotao(2);
            this.txtDataCadastro.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show(this, "\n\n Deseja realmente excluir o cadastro selecionado?", "CONFIRMAR EXCLUSÃO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado.ToString() == "Yes")
                {
                    validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
                    valida_cliente.ExcluirCliente(Convert.ToInt32(txtId.Text));
                    MessageBox.Show(this, "\n Cliente excluído com sucesso", "EXCLUSÃO DE CLIENTE",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlterarBotao(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "\n\n Não foi possivel deletar o cliente do banco de dados. \n Detalhes:" + ex.Message,
                    "ERROR AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtDataCadastro.Focus();
                this.AlterarBotao(3);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Cliente modelo_cliente = new modelo_Cliente();
                modelo_cliente.Cli_dataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                modelo_cliente.Cli_cpf = txtCpf.Text;
                modelo_cliente.Cli_nome = txtNomeCliente.Text;
                modelo_cliente.Cli_cep = txtCep.Text;
                modelo_cliente.Cli_endereco = txtEndereco.Text;
                modelo_cliente.Cli_numero = Convert.ToInt32(txtNumero.Text);
                modelo_cliente.Cli_complemento = txtComplemento.Text;
                modelo_cliente.Cli_bairro = txtBairro.Text;
                modelo_cliente.Cli_cidade = txtCidade.Text;
                modelo_cliente.Cli_estado = txtEstado.Text;
                modelo_cliente.Cli_foneCelular = txtTelefone.Text;
                modelo_cliente.Cli_email = txtEmail.Text;
                modelo_cliente.Cli_observacao = txtObservacoes.Text;
                
                validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
                if (operacao == "cadastrar")
                {
                    valida_cliente.SalvarCliente(modelo_cliente);
                    MessageBox.Show(this, "\n Cliente cadastrado com sucesso", "Cadastro de Cliente",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();

                }
                else
                {
                    modelo_cliente.Cli_id = Convert.ToInt32(txtId.Text);
                    valida_cliente.EditarCliente(modelo_cliente);
                    MessageBox.Show(this, "\n Cliente editado com sucesso", "Edição de Cliente",
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
        //método botão pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente fRelatorioCliente = new frmRelatorioCliente();
            fRelatorioCliente.ShowDialog();
            if (fRelatorioCliente.codigo != 0)
            {
                validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
                modelo_Cliente modelo_cliente = valida_cliente.CarregarCliente(fRelatorioCliente.codigo);
                txtId.Text = modelo_cliente.Cli_id.ToString();
                txtDataCadastro.Text = modelo_cliente.Cli_dataCadastro.ToShortDateString();
                txtCpf.Text = modelo_cliente.Cli_cpf;
                txtNomeCliente.Text = modelo_cliente.Cli_nome;
                txtCep.Text = modelo_cliente.Cli_cep;
                txtEndereco.Text = modelo_cliente.Cli_endereco;
                txtNumero.Text = modelo_cliente.Cli_numero.ToString();
                txtComplemento.Text = modelo_cliente.Cli_complemento;
                txtBairro.Text = modelo_cliente.Cli_bairro;
                txtCidade.Text = modelo_cliente.Cli_cidade;
                txtEstado.Text = modelo_cliente.Cli_estado;
                txtTelefone.Text = modelo_cliente.Cli_foneCelular;
                txtEmail.Text = modelo_cliente.Cli_email;
                txtObservacoes.Text = modelo_cliente.Cli_observacao;
                AlterarBotao(3);
            }
            else
            {
                LimpaCampos();
                txtDataCadastro.Focus();
                AlterarBotao(1);
            }
            fRelatorioCliente.Dispose();

        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)8)
            {
                utilidade_FormataCampos.Campos edit = utilidade_FormataCampos.Campos.CEP;
                utilidade_formataCampos.Maskara(edit, txtCep);
            }
        }

        //método load
        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.DesabilitaCampos();
            this.AlterarBotao(1);
        }
    }
}
