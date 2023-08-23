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
using GestaoGaragem.Utilidade;
using GestaoGaragem.Validacao;

namespace GestaoGaragem.Visual
{
    public partial class formRelatorioUsuario : MetroForm
    {
        public int codigo = 0;
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        public formRelatorioUsuario()
        {
            InitializeComponent();
        }
        //método load do form relatório usuário
        private void formRelatorioUsuario_Load(object sender, EventArgs e)
        {
            //gerar arquivo word/excel/pdf
            cmbGerarArquivo.Items.Insert(0, "");
            cmbGerarArquivo.Items.Insert(1, "Gerar Pdf");
            cmbGerarArquivo.Items.Insert(2, "Gerar Word");
            cmbGerarArquivo.Items.Insert(3, "Gerar Excel");

            //mudar a cor do DATAGRIDVIEW
            dvgUsuario.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dvgUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dvgUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dvgUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            //formata o datagridview
            btnPesquisar_Click(sender, e);
            dvgUsuario.Columns["user_id"].HeaderText = "Código";
            dvgUsuario.Columns["user_id"].Width = 100;
            dvgUsuario.Columns["user_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvgUsuario.Columns["user_usuario"].HeaderText = "Usuário";
            dvgUsuario.Columns["user_usuario"].Width = 500;
            dvgUsuario.Columns["user_password"].HeaderText = "Senha";
            dvgUsuario.Columns["user_password"].Width = 200;

        }
        public void CarregaUsuario(int codigo)
        {
            validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
            dvgUsuario.DataSource = valida_usuario.CarregarUsuario(codigo);
        }
        //método botão voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //método botão pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_Usuario valida_usuario = new validacao_Usuario(conexao);
                dvgUsuario.DataSource = valida_usuario.ListarUsuario(txtPesquisaUsuario.Text);

            } catch (Exception ex)
            {
                throw ex;
            }

        }
        //método double click no dgv user
        private void dvgUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                this.codigo = Convert.ToInt32(dvgUsuario.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbGerarArquivo.SelectedIndex) == -1)
            {
                MessageBox.Show(this, "\n Por favor, selecione uma opção de documento", "GERAR DOCUMENTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToString(cmbGerarArquivo.SelectedItem) == "")
            {
                MessageBox.Show(this, "\n\n Por favor, selecione uma opção de documento", "GERAR DOCUMENTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToString(cmbGerarArquivo.SelectedItem) == "Gerar Pdf")
            {
                MessageBox.Show(this, "\n\n Documento Pdf gerado com sucesso!", "GERAR DOCUMENTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToString(cmbGerarArquivo.SelectedItem) == "Gerar Word")
            {
                MessageBox.Show(this, "\n\n Documento Word gerado com sucesso!", "GERAR DOCUMENTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToString(cmbGerarArquivo.SelectedItem) == "Gerar Excel")
            {
                MessageBox.Show(this, "\n\n Documento Excel gerado com sucesso!", "GERAR DOCUMENTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
