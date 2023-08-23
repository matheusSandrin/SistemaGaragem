using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoGaragem.Negocio;
using MetroFramework.Forms;
using GestaoGaragem.Utilidade;
using GestaoGaragem.Modelo;
using GestaoGaragem.Validacao;

namespace GestaoGaragem.Visual
{
    public partial class formCadastroUsuario : MetroForm
    {
        private Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        private string usuario, operacao;
        
        public formCadastroUsuario()
        {
            InitializeComponent();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

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

            if(op == 1)
            {
                btnNovo.Enabled = true;
                btnPesquisar.Enabled = true;
                btnVoltar.Enabled = true;
            }
            if(op == 2)
            {
                btnGravar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if(op == 3)
            {
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }
        //método que verifica usuario cadastrado no banco de dados
        public void VerificaUsuario(String usuario)
        {
            int r = 0;
            validacao_Usuario validacao_usuario = new validacao_Usuario(conexao);
            r = validacao_usuario.VerificaUsuario(txtUsuario.Text);
            if(r > 0)
            {
                MessageBox.Show(this, "Já existe um usuário cadastrado", "VERIFICAÇÃO DE USUÁRIO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaCampos();
                txtUsuario.Focus();
            }

        }
        //função habilita campos do form
        public void HabilitaCampos()
        {
            txtUsuario.Enabled = true;
            txtPassword.Enabled = true;
        }
        //função desabilita campos do form
        public void DesabilitaCampos()
        {
            txtUsuario.Enabled = false;
            txtPassword.Enabled = false;
        }

        public void LimpaCampos()
        {
            txtId.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";

        }
        //metodo de voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formCadastroUsuario_Load(object sender, EventArgs e)
        {

            this.DesabilitaCampos();
            this.AlterarBotao(1);
        }
        //método botão novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.operacao = "cadastrar";
            this.HabilitaCampos();
            this.txtUsuario.Focus();
            this.AlterarBotao(2);
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.HabilitaCampos();
            this.AlterarBotao(2);
            this.txtUsuario.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try 
            {
                conexao.AbrirConexao();
                modelo_Usuario modelo_usuario = new modelo_Usuario();
                modelo_usuario.User_usuario = txtUsuario.Text;
                modelo_usuario.User_password = txtPassword.Text;
                validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
                if(operacao == "cadastrar")
                {
                    valida_usuario.SalvarUsuario(modelo_usuario);
                    MessageBox.Show(this, "\n Usuário cadastrado com sucesso", "Cadastro de usuário",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.LimpaCampos();
                    this.DesabilitaCampos();

                }
                else
                {
                    modelo_usuario.User_id = Convert.ToInt32(txtId.Text);
                    valida_usuario.EditarUsuario(modelo_usuario);
                    MessageBox.Show(this, "\n Usuário editado com sucesso", "Edição de usuário",
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
                DialogResult resultado = MessageBox.Show(this, "\n\n Deseja realmente excluir o cadastro selecionado?", "CONFIRMAR EXCLUSÃO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado.ToString() == "Yes")
                {
                    validacao_Usuario valida_Usuario = new validacao_Usuario(conexao);
                    valida_Usuario.ExcluirUsuario(Convert.ToInt32(txtId.Text));
                    MessageBox.Show(this, "\n Usuário excluído com sucesso", "EXCLUSÃO DE USUÁRIO",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.AlterarBotao(1);
                    this.LimpaCampos();
                    this.DesabilitaCampos();
                }

            } catch (Exception ex)
            {
                MessageBox.Show(this, "\n\n Não foi possivel deleter usuário do banco de dados. \n Detalhes:" + ex.Message,
                    "ERROR AO REALIZAR OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUsuario.Focus();
                this.AlterarBotao(3);
            }
        }
        //método botão pesquisar formulário de usuário
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            formRelatorioUsuario fRelatorioUsuario = new formRelatorioUsuario();
            fRelatorioUsuario.ShowDialog();
            if (fRelatorioUsuario.codigo != 0)
            {
                validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
                modelo_Usuario modelo_usuario = valida_usuario.CarregarUsuario(fRelatorioUsuario.codigo);
                txtId.Text = modelo_usuario.User_id.ToString();
                txtUsuario.Text = modelo_usuario.User_usuario;
                txtPassword.Text = modelo_usuario.User_password;
                AlterarBotao(3);
            } else
            {
                LimpaCampos();
                txtUsuario.Focus();
                AlterarBotao(1);
            }
            fRelatorioUsuario.Dispose();

        }
        //método para pular para outro textbox
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }

        }
        //evento que verifica usuário no banco de dados
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            VerificaUsuario(usuario);
        }

        //método botão cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaCampos();
            this.txtUsuario.Focus();
            this.DesabilitaCampos();
            this.AlterarBotao(1);
        }
    }
}
