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
    public partial class frmRelatorioVeiculo : MetroForm
    {
        public int codigo = 0;
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        public frmRelatorioVeiculo()
        {
            InitializeComponent();
        }

        private void frmRelatorioVeiculo_Load(object sender, EventArgs e)
        {
            //Gerar arquivo WORD/PDF/EXCEL
            cmbGerarArquivo.Items.Insert(0, "");
            cmbGerarArquivo.Items.Insert(1, "Gerar Pdf");
            cmbGerarArquivo.Items.Insert(2, "Gerar Word");
            cmbGerarArquivo.Items.Insert(3, "Gerar Excel");

            //Muda a cor do DATAGRIDVIEW
            dvgVeiculo.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dvgVeiculo.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dvgVeiculo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dvgVeiculo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            CarregaVeiculo(codigo);

            //Formata o DATAGRIDVIEW
            btnPesquisar_Click(sender, e);
            dvgVeiculo.Columns["veic_modelo"].HeaderText = "Modelo do veículo";
            dvgVeiculo.Columns["veic_modelo"].Width = 140;

            dvgVeiculo.Columns["veic_id"].HeaderText = "Código";
            dvgVeiculo.Columns["veic_id"].Width = 70;
            dvgVeiculo.Columns["veic_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvgVeiculo.Columns["veic_marca"].HeaderText = "Marca do veículo";
            dvgVeiculo.Columns["veic_marca"].Width = 140;

            dvgVeiculo.Columns["veic_precovenda"].HeaderText = "Valor do veículo";
            dvgVeiculo.Columns["veic_precovenda"].Width = 270;

            dvgVeiculo.Columns["veic_ano"].HeaderText = "Ano do veículo";
            dvgVeiculo.Columns["veic_ano"].Width = 137;

            //Disabilita a coluna
            dvgVeiculo.Columns["veic_placa"].Visible = false;
            dvgVeiculo.Columns["veic_km"].Visible = false;
            dvgVeiculo.Columns["veic_precopago"].Visible = false;
            dvgVeiculo.Columns["veic_datacompra"].Visible = false;
        }
        public void CarregaVeiculo(int codigo)
        {
            validacao_Veiculo valida_veiculo = new validacao_Veiculo(conexao);
            dvgVeiculo.DataSource = valida_veiculo.CarregarVeiculo(codigo);
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_Veiculo valida_veiculo = new validacao_Veiculo(conexao);
                dvgVeiculo.DataSource = valida_veiculo.ListarVeiculo(txtPesquisaVeiculo.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void dvgVeiculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dvgVeiculo.Rows[e.RowIndex].Cells[0].Value);
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
