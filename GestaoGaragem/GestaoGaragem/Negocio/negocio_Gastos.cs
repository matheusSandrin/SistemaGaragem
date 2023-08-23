using GestaoGaragem.Modelo;
using GestaoGaragem.Utilidade;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoGaragem.Negocio
{
    public class negocio_Gastos
    {
        private Utilidade_Conexao conexao;
        MySqlCommand comando = null;
        public negocio_Gastos(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }
        public void SalvarGastos(modelo_Gastos modelo_gastos)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO gastos (gastos_valor, gastos_data, gastos_descricao) " +
                    "VALUES (@gastos_valor, @gastos_data, @gastos_descricao)";
                cmd.Parameters.AddWithValue("gastos_valor", modelo_gastos.Gastos_valor);
                cmd.Parameters.AddWithValue("gastos_data", modelo_gastos.Gastos_data);
                cmd.Parameters.AddWithValue("gastos_descricao", modelo_gastos.Gastos_descricao);
                cmd.ExecuteNonQuery();
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
        public void EditarGastos(modelo_Gastos modelo_gastos)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE gastos SET gastos_valor = @gastos_valor, gastos_data = @gastos_data, gastos_descricao = @gastos_descricao WHERE gastos_id = @gastos_id";
                cmd.Parameters.AddWithValue("gastos_valor", modelo_gastos.Gastos_valor);
                cmd.Parameters.AddWithValue("gastos_data", modelo_gastos.Gastos_data);
                cmd.Parameters.AddWithValue("gastos_descricao", modelo_gastos.Gastos_descricao);
                cmd.Parameters.AddWithValue("gastos_id", modelo_gastos.Gastos_id);
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
        public modelo_Gastos CarregarGastos(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Gastos modelo_gastos = new modelo_Gastos();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM gastos WHERE gastos_id = @gastos_id;";
                cmd.Parameters.AddWithValue("@gastos_id", codigo);
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo_gastos.Gastos_id = Convert.ToInt32(registro["gastos_id"]);
                    modelo_gastos.Gastos_data = Convert.ToDateTime(registro["gastos_data"]);
                    modelo_gastos.Gastos_descricao = Convert.ToString(registro["gastos_descricao"]);
                    modelo_gastos.Gastos_valor = Convert.ToDecimal(registro["gastos_valor"]);
                }
                return modelo_gastos;
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

        public void ExcluirGastos(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM gastos WHERE gastos_id = @gastos_id";
                cmd.Parameters.AddWithValue("@gastos_id", codigo);
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
        public DataTable ListarGastos(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM gastos WHERE gastos_valor like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int VerificaGastos(String valor)
        {
            try
            {
                int r = 0;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM gastos WHERE gastos_id = @gastos_id;";
                cmd.Parameters.AddWithValue("@gastos_id", valor);
                conexao.AbrirConexao();
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["gastos_id"]);
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
