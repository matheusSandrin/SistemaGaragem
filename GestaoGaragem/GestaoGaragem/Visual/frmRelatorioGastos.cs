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
using MySql.Data.MySqlClient;

namespace GestaoGaragem.Visual
{
    public partial class frmRelatorioGastos : MetroForm
    {
        public int codigo = 0;
        Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        public frmRelatorioGastos()
        {
            InitializeComponent();
        }

        private void frmRelatorioGastos_Load(object sender, EventArgs e)
        {
            //Gerar arquivo WORD/PDF/EXCEL
            cmbGerarArquivo.Items.Insert(0, "");
            cmbGerarArquivo.Items.Insert(1, "Gerar Pdf");
            cmbGerarArquivo.Items.Insert(2, "Gerar Word");
            cmbGerarArquivo.Items.Insert(3, "Gerar Excel");

            //Muda a cor do DATAGRIDVIEW
            dvgGastos.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dvgGastos.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
            dvgGastos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dvgGastos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            CarregarGastos(codigo);

            //Formata o DATAGRIDVIEW
            btnPesquisar_Click(sender, e);

            dvgGastos.Columns["gastos_id"].HeaderText = "Código";
            dvgGastos.Columns["gastos_id"].Width = 70;
            dvgGastos.Columns["gastos_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dvgGastos.Columns["gastos_data"].HeaderText = "Data";
            dvgGastos.Columns["gastos_data"].Width = 140;

            dvgGastos.Columns["gastos_descricao"].HeaderText = "Descrição do gasto";
            dvgGastos.Columns["gastos_descricao"].Width = 467;

            dvgGastos.Columns["gastos_valor"].HeaderText = "Valor do gasto";
            dvgGastos.Columns["gastos_valor"].Width = 137;

        }
        public void CarregarGastos(int codigo)
        {
            validacao_Gastos valida_gastos = new validacao_Gastos(conexao);
            dvgGastos.DataSource = valida_gastos.CarregarGastos(codigo);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                validacao_Gastos valida_gastos = new validacao_Gastos(conexao);
                dvgGastos.DataSource = valida_gastos.ListarGastos(txtPesquisaVeiculo.Text);
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

        private void dvgGastos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dvgGastos.Rows[e.RowIndex].Cells[0].Value);
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
            MessageBox.Show(this, $"Número de gastos: {numeroVendas}\nSoma dos valores dos gastos: {somaValores:C2}", "RESUMO DE GASTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private int ObterNumeroVendas(DateTime dataInicial, DateTime dataFinal)
        {
            using (MySqlConnection conexao = new MySqlConnection(Utilidade_DadosConexao.StringConexao))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT COUNT(*) FROM gastos WHERE gastos_data >= @dataInicial AND gastos_data <= @dataFinal";
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
                cmd.CommandText = "SELECT SUM(gastos_valor) FROM gastos WHERE gastos_data >= @dataInicial AND gastos_data <= @dataFinal";
                cmd.Parameters.AddWithValue("@dataInicial", dataInicial);
                cmd.Parameters.AddWithValue("@dataFinal", dataFinal);
                object resultado = cmd.ExecuteScalar();
                return resultado == DBNull.Value ? 0 : Convert.ToDecimal(resultado);
            }
        }
    }
}
