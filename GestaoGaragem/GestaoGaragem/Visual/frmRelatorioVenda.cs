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
using GestaoGaragem.Utilidade;
using GestaoGaragem.Validacao;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace GestaoGaragem.Visual
{
    public partial class frmRelatorioVenda : MetroForm
    {
        public int codigo = 0;
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        public frmRelatorioVenda()
        {
            InitializeComponent();
        }

        private void frmRelatorioVenda_Load(object sender, EventArgs e)
        {
            // Gerar arquivo WORD/PDF/EXCEL
            cmbGerarArquivo.Items.Insert(0, "");
            cmbGerarArquivo.Items.Insert(1, "Gerar Pdf");
            cmbGerarArquivo.Items.Insert(2, "Gerar Word");
            cmbGerarArquivo.Items.Insert(3, "Gerar Excel");


            // Muda a cor do DATAGRIDVIEW
            dvgVenda.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dvgVenda.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dvgVenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dvgVenda.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Carrega as vendas

            CarregaVenda(codigo);
            btnPesquisar_Click(sender, e);

            // Formata as colunas do DataGridView
            dvgVenda.Columns["venda_id"].HeaderText = "Código";
            dvgVenda.Columns["venda_id"].Width = 70;
            dvgVenda.Columns["venda_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvgVenda.Columns["venda_valor"].HeaderText = "Valor da venda";
            dvgVenda.Columns["venda_valor"].Width = 150;
            dvgVenda.Columns["venda_valor"].DefaultCellStyle.Format = "C2";
            
            dvgVenda.Columns["venda_data"].HeaderText = "Data da venda";
            dvgVenda.Columns["venda_data"].Width = 150;
            dvgVenda.Columns["venda_data"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dvgVenda.Columns["venda_data"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvgVenda.Columns.Add("veic_modelo", "Modelo do veículo");
            dvgVenda.Columns["veic_modelo"].HeaderText = "Modelo do veículo";
            dvgVenda.Columns["veic_modelo"].Width = 120;


            dvgVenda.Columns["cliente_id"].Visible = false;
            dvgVenda.Columns["veiculo_id"].Visible = false;

        }

        public void CarregaVenda(int codigo)
        {
            validacao_Venda valida_venda = new validacao_Venda(conexao);
            dvgVenda.DataSource = valida_venda.CarregarVenda(codigo);
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_Venda valida_venda = new validacao_Venda(conexao);
                dvgVenda.DataSource = valida_venda.ListarVenda(txtPesquisaVenda.Text);
            }
            catch (Exception ex)
            {
                throw ex;
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

        private void dvgVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dvgVenda.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime dataInicial = dtPickerInicial.Value;
            DateTime dataFinal = dtPickerFinal.Value;

            // Executa a consulta no banco de dados e obtém os resultados
            int numeroVendas = ObterNumeroVendas(dataInicial, dataFinal);
            decimal somaValores = ObterSomaValores(dataInicial, dataFinal);

            // Exibe os resultados
            MessageBox.Show(this, $"Número de vendas: {numeroVendas}\nSoma dos valores das vendas: {somaValores:C2}", "RESUMO DE VENDAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private int ObterNumeroVendas(DateTime dataInicial, DateTime dataFinal)
        {
            using (MySqlConnection conexao = new MySqlConnection(Utilidade_DadosConexao.StringConexao))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT COUNT(*) FROM vendas WHERE venda_data >= @dataInicial AND venda_data <= @dataFinal";
                cmd.Parameters.AddWithValue("@dataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@dataFinal", dataFinal);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        private decimal ObterSomaValores(DateTime dataInicial, DateTime dataFinal)
        {
            using (MySqlConnection conexao = new MySqlConnection(Utilidade_DadosConexao.StringConexao))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT SUM(venda_valor) FROM vendas WHERE venda_data >= @dataInicial AND venda_data <= @dataFinal";
                cmd.Parameters.AddWithValue("@dataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@dataFinal", dataFinal);
                object resultado = cmd.ExecuteScalar();
                return resultado == DBNull.Value ? 0 : Convert.ToDecimal(resultado);
            }
        }
    }
}
