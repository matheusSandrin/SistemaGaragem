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
    public class negocio_Veiculo
    {
        private Utilidade_Conexao conexao;
        MySqlCommand comando = null;
        public negocio_Veiculo(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }
        public void SalvarVeiculo(modelo_Veiculo modelo_veiculo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO veiculos (veic_modelo, veic_marca, veic_ano, veic_placa, veic_km, veic_precopago, veic_precovenda, veic_datacompra) " +
                    "VALUES ( @veic_modelo, @veic_marca, @veic_ano, @veic_placa, @veic_km, @veic_precopago, @veic_precovenda, @veic_datacompra); SELECT @@IDENTITY";
                cmd.Parameters.AddWithValue("veic_modelo", modelo_veiculo.Veic_modelo);
                cmd.Parameters.AddWithValue("veic_marca", modelo_veiculo.Veic_marca);
                cmd.Parameters.AddWithValue("veic_ano", modelo_veiculo.Veic_ano);
                cmd.Parameters.AddWithValue("veic_placa", modelo_veiculo.Veic_placa);
                cmd.Parameters.AddWithValue("veic_km", modelo_veiculo.Veic_km);
                cmd.Parameters.AddWithValue("veic_precopago", modelo_veiculo.Veic_precopago);
                cmd.Parameters.AddWithValue("veic_precovenda", modelo_veiculo.Veic_precovenda);
                cmd.Parameters.AddWithValue("veic_datacompra", modelo_veiculo.Veic_datacompra);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco com dados", "Gravar" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
        public void EditarVeiculo(modelo_Veiculo modelo_veiculo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE veiculos SET veic_modelo = @veic_modelo, veic_marca = @veic_marca, veic_ano = @veic_ano, veic_placa = @veic_placa, veic_km = @veic_km, veic_precopago = @veic_precopago," +
                    "veic_datacompra = @veic_datacompra, veic_precovenda = @veic_precovenda, veic_disponivel = @veic_disponivel WHERE veic_id = @veic_id";
                cmd.Parameters.AddWithValue("veic_modelo", modelo_veiculo.Veic_modelo);
                cmd.Parameters.AddWithValue("veic_marca", modelo_veiculo.Veic_marca);
                cmd.Parameters.AddWithValue("veic_ano", modelo_veiculo.Veic_ano);
                cmd.Parameters.AddWithValue("veic_placa", modelo_veiculo.Veic_placa);
                cmd.Parameters.AddWithValue("veic_km", modelo_veiculo.Veic_km);
                cmd.Parameters.AddWithValue("veic_precopago", modelo_veiculo.Veic_precopago);
                cmd.Parameters.AddWithValue("veic_precovenda", modelo_veiculo.Veic_precovenda);
                cmd.Parameters.AddWithValue("veic_datacompra", modelo_veiculo.Veic_datacompra);
                cmd.Parameters.AddWithValue("veic_id", modelo_veiculo.Veic_id);
                cmd.Parameters.AddWithValue("veic_disponivel", true);

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
        public void ExcluirVeiculo(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM veiculos WHERE veic_id = @veic_id";
                cmd.Parameters.AddWithValue("@veic_id", codigo);
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
        public DataTable ListarVeiculo(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM veiculos WHERE veic_modelo like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
            public void AtualizarStatusVeiculo(int Veiculo_id)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE veiculos SET veic_disponivel = @veic_disponivel WHERE veic_id = @veic_id";
                cmd.Parameters.AddWithValue("veic_disponivel", false);
                cmd.Parameters.AddWithValue("veic_id", Veiculo_id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Atualizar Status Veículo" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public modelo_Veiculo CarregarVeiculo(int codigo)
        {
             try
    {
        conexao.AbrirConexao();
        modelo_Veiculo modelo_veiculo = new modelo_Veiculo();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conexao.Conexao;
        cmd.CommandText = "SELECT * FROM veiculos WHERE veic_id = @veic_id AND veic_disponivel = true;";
        cmd.Parameters.AddWithValue("@veic_id", codigo);
        MySqlDataReader registro = cmd.ExecuteReader();
        if (registro.HasRows)
        {
            registro.Read();
            modelo_veiculo.Veic_id = Convert.ToInt32(registro["veic_id"]);
            modelo_veiculo.Veic_modelo = Convert.ToString(registro["veic_modelo"]);
            modelo_veiculo.Veic_marca = Convert.ToString(registro["veic_marca"]);
            modelo_veiculo.Veic_ano = Convert.ToInt32(registro["veic_ano"]);
            modelo_veiculo.Veic_km = Convert.ToDecimal(registro["veic_km"]);
            modelo_veiculo.Veic_datacompra = Convert.ToDateTime(registro["veic_datacompra"]);
            modelo_veiculo.Veic_placa = Convert.ToString(registro["veic_placa"]);
            modelo_veiculo.Veic_precopago = Convert.ToDecimal(registro["veic_precopago"]);
            modelo_veiculo.Veic_precovenda = Convert.ToDecimal(registro["veic_precovenda"]);
            modelo_veiculo.Veic_disponivel = Convert.ToBoolean(registro["veic_disponivel"]);
        }

        return modelo_veiculo;
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
        public int VerificaVeiculo(String valor)
        {
            try
            {
                int r = 0;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM veiculos WHERE veic_id = @veic_id;";
                cmd.Parameters.AddWithValue("@veic_id", valor);
                conexao.AbrirConexao();
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["veic_id"]);
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

