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
    public partial class frmRelatorioFormaPagto : MetroForm
    {
        public int codigo = 0;
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        public frmRelatorioFormaPagto()
        {
            InitializeComponent();
        }

        private void frmRelatorioFormaPagto_Load(object sender, EventArgs e)
        {
            //gerar arquivo word/excel/pdf
            cmbGerarArquivo.Items.Insert(0, "");
            cmbGerarArquivo.Items.Insert(1, "Gerar Pdf");
            cmbGerarArquivo.Items.Insert(2, "Gerar Word");
            cmbGerarArquivo.Items.Insert(3, "Gerar Excel");

            //mudar a cor do DATAGRIDVIEW
            dvgFormaPagto.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dvgFormaPagto.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dvgFormaPagto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dvgFormaPagto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            //formata o datagridview
            btnPesquisar_Click(sender, e);
            dvgFormaPagto.Columns["forma_id"].HeaderText = "Código";
            dvgFormaPagto.Columns["forma_id"].Width = 100;
            dvgFormaPagto.Columns["forma_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvgFormaPagto.Columns["forma_descricao"].HeaderText = "Forma de Pagamento";
            dvgFormaPagto.Columns["forma_descricao"].Width = 500;
        }
        public void CarregaFormaPagto(int codigo)
        {
            validacao_FormaPagto valida_formaPagto = new validacao_FormaPagto(conexao);
            dvgFormaPagto.DataSource = valida_formaPagto.CarregarFormaPagto(codigo);
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_FormaPagto valida_formaPagto = new validacao_FormaPagto(conexao);
                dvgFormaPagto.DataSource = valida_formaPagto.ListarFormaPagto(txtPesquisaFormaPagto.Text);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //método botão voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void dvgFormaPagto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dvgFormaPagto.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
