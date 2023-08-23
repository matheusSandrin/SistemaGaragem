using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoGaragem.Utilidade;
using GestaoGaragem.Validacao;
using MetroFramework.Forms;

namespace GestaoGaragem.Visual
{
    public partial class frmRelatorioCliente : MetroForm
    {
        public int codigo = 0;
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        public frmRelatorioCliente()
        {
            InitializeComponent();
        }

        private void frmRelatorioCliente_Load(object sender, EventArgs e)
        {
            //Gerar arquivo WORD/PDF/EXCEL
            cmbGerarArquivo.Items.Insert(0, "");
            cmbGerarArquivo.Items.Insert(1, "Gerar Pdf");
            cmbGerarArquivo.Items.Insert(2, "Gerar Word");
            cmbGerarArquivo.Items.Insert(3, "Gerar Excel");

            //Muda a cor do DATAGRIDVIEW
            dvgCliente.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dvgCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dvgCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dvgCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            CarregaCliente(codigo);

            //Formata o DATAGRIDVIEW
            btnPesquisar_Click(sender, e);
            dvgCliente.Columns["cli_dataCadastro"].HeaderText = "Data de Cadastro";
            dvgCliente.Columns["cli_dataCadastro"].Width = 140;

            dvgCliente.Columns["cli_id"].HeaderText = "Código";
            dvgCliente.Columns["cli_id"].Width = 70;
            dvgCliente.Columns["cli_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvgCliente.Columns["cli_cpf"].HeaderText = "Cpf do Cliente";
            dvgCliente.Columns["cli_cpf"].Width = 140;

            dvgCliente.Columns["cli_nome"].HeaderText = "Nome do Cliente";
            dvgCliente.Columns["cli_nome"].Width = 270;

            dvgCliente.Columns["cli_foneCelular"].HeaderText = "Telefone do Cliente";
            dvgCliente.Columns["cli_foneCelular"].Width = 137;

            //Disabilita a coluna
            dvgCliente.Columns["cli_cep"].Visible = false;
            dvgCliente.Columns["cli_endereco"].Visible = false;
            dvgCliente.Columns["cli_numero"].Visible = false;
            dvgCliente.Columns["cli_complemento"].Visible = false;
            dvgCliente.Columns["cli_bairro"].Visible = false;
            dvgCliente.Columns["cli_cidade"].Visible = false;
            dvgCliente.Columns["cli_estado"].Visible = false;
            dvgCliente.Columns["cli_email"].Visible = false;
            dvgCliente.Columns["cli_observacao"].Visible = false;
        }
        public void CarregaCliente(int codigo)
        {
            validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
            dvgCliente.DataSource = valida_cliente.CarregarCliente(codigo);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_Cliente valida_cliente = new validacao_Cliente(conexao);
                dvgCliente.DataSource = valida_cliente.ListarCliente(txtPesquisaCliente.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        private void dvgCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dvgCliente.Rows[e.RowIndex].Cells[0].Value);
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
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (Convert.ToString(cmbGerarArquivo.SelectedItem) == "Gerar Word")
            {
                MessageBox.Show(this, "\n\n Documento Word gerado com sucesso!", "GERAR DOCUMENTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (Convert.ToString(cmbGerarArquivo.SelectedItem) == "Gerar Excel")
            {
                MessageBox.Show(this, "\n\n Documento Excel gerado com sucesso!", "GERAR DOCUMENTOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
