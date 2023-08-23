using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoGaragem.Utilidade;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace GestaoGaragem.Visual
{
    public partial class frmFinanceiro : MetroForm
    {
        private Utilidade_Conexao conexao = new Utilidade_Conexao(Utilidade_DadosConexao.StringConexao);
        public frmFinanceiro()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Obter as datas de início e fim do período selecionado pelo usuário
            DateTime dataInicio = dtPickerInicial.Value;
            DateTime dataFim = dtPickerFinal.Value; 

            // Pesquisar vendas no período
            decimal valorVendas = PesquisarVendas(dataInicio, dataFim);

            // Pesquisar gastos no período
            decimal valorGastos = PesquisarGastos(dataInicio, dataFim);

            // Exibir os resultados na interface
            txtValorVendas.Text = valorVendas.ToString("C2");
            txtValorGastos.Text = valorGastos.ToString("C2");
            txtLucro.Text = (valorVendas - valorGastos).ToString("C2");
        }

        private decimal PesquisarVendas(DateTime dataInicio, DateTime dataFim)
        {
            decimal totalVendas = 0;

            using (MySqlConnection conexao = new MySqlConnection(Utilidade_DadosConexao.StringConexao))
            {

                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT SUM(venda_valor) FROM vendas WHERE venda_data >= @dataInicio AND venda_data < @dataFim";
                cmd.Parameters.AddWithValue("@dataInicio", dataInicio);
                cmd.Parameters.AddWithValue("@dataFim", dataFim);

                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    totalVendas = Convert.ToDecimal(result);
                }
            }

            return totalVendas;
        }

        private decimal PesquisarGastos(DateTime dataInicio, DateTime dataFim)
        {
            decimal totalGastos = 0;

            using (MySqlConnection conexao = new MySqlConnection(Utilidade_DadosConexao.StringConexao))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT SUM(gastos_valor) FROM gastos WHERE gastos_data >= @dataInicio AND gastos_data < @dataFim";
                cmd.Parameters.AddWithValue("@dataInicio", dataInicio);
                cmd.Parameters.AddWithValue("@dataFim", dataFim);

                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    totalGastos = Convert.ToDecimal(result);
                }
            }

            return totalGastos;
        }


    }
}
