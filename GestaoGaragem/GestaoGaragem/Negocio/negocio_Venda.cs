using GestaoGaragem.Modelo;
using GestaoGaragem.Utilidade;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoGaragem.Negocio
{
    public class negocio_Venda
    {
        private negocio_Veiculo negocioVeiculo;
        private Utilidade_Conexao conexao;
        MySqlCommand comando = null;
        public negocio_Venda(Utilidade_Conexao cx)
        {
            this.conexao = cx;
            this.negocioVeiculo = new negocio_Veiculo(cx);
        }
        public void SalvarVenda(modelo_Venda modelo_venda)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO vendas (venda_valor, venda_data, cliente_id, veiculo_id) " +
                    "VALUES (@venda_valor, @venda_data, @cliente_id, @veiculo_id)";
                cmd.Parameters.AddWithValue("venda_valor", modelo_venda.Venda_valor);
                cmd.Parameters.AddWithValue("venda_data", modelo_venda.Venda_data);
                cmd.Parameters.AddWithValue("cliente_id", modelo_venda.Cliente_id);
                cmd.Parameters.AddWithValue("veiculo_id", modelo_venda.Veiculo_id);
                cmd.ExecuteNonQuery();
                negocioVeiculo.AtualizarStatusVeiculo(modelo_venda.Veiculo_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Gravar" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
        public void EditarVenda(modelo_Venda modelo_venda)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE vendas SET venda_valor = @venda_valor, venda_data = @venda_data, cliente_id = @cliente_id, veiculo_id = @veiculo_id WHERE venda_id = @venda_id";
                cmd.Parameters.AddWithValue("venda_valor", modelo_venda.Venda_valor);
                cmd.Parameters.AddWithValue("venda_data", modelo_venda.Venda_data);
                cmd.Parameters.AddWithValue("cliente_id", modelo_venda.Cliente_id);
                cmd.Parameters.AddWithValue("veiculo_id", modelo_venda.Veiculo_id);
                cmd.Parameters.AddWithValue("venda_id", modelo_venda.Venda_id);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Editar" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
        public modelo_Venda CarregarVenda(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Venda modelo_venda = new modelo_Venda();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * " +
                "FROM vendas VEN " +
                "INNER JOIN veiculos VEI ON VEN.veiculo_id = VEI.veic_id ";

                cmd.Parameters.AddWithValue("@venda_id", codigo);
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo_venda.Venda_id = Convert.ToInt32(registro["venda_id"]);
                    modelo_venda.Venda_data = Convert.ToDateTime(registro["venda_data"]);
                    modelo_venda.Venda_valor = Convert.ToDecimal(registro["venda_valor"]);
                    modelo_venda.Veiculo_id = Convert.ToInt32(registro["veiculo_id"]);
                    modelo_venda.Cliente_id = Convert.ToInt32(registro["cliente_id"]);
                    modelo_venda.Veic_modelo = Convert.ToString(registro["veic_modelo"]);
                }
                return modelo_venda;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.FecharConexao();
            }
        }


        public void ExcluirVenda(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM vendas WHERE venda_id = @venda_id";
                cmd.Parameters.AddWithValue("@venda_id", codigo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Excluir" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
        public DataTable ListarVenda(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM vendas WHERE venda_valor like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int VerificaVenda(String valor)
        {
            try
            {
                int r = 0;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM vendas WHERE venda_id = @venda_id;";
                cmd.Parameters.AddWithValue("@venda_id", valor);
                conexao.AbrirConexao();
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["venda_id"]);
                }
                return r;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
    }
}
