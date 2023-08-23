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
    public class negocio_FormaPagto
    {
        private Utilidade_Conexao conexao;
        MySqlCommand comando = null;

        public negocio_FormaPagto(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        public void SalvarFormaPagto(modelo_FormaPagto mod_formaPagto)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO formapagto (forma_descricao) VALUES (@forma_descricao); SELECT @@IDENTITY";
                cmd.Parameters.AddWithValue("forma_descricao", mod_formaPagto.Forma_descricao);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados", "Gravar" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
        public void EditarFormPagto(modelo_FormaPagto mod_formaPagto)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE formapagto SET forma_descricao = @forma_descricao WHERE forma_id = @forma_id";
                cmd.Parameters.AddWithValue("@forma_descricao", mod_formaPagto.Forma_descricao);
                cmd.Parameters.AddWithValue("@forma_id", mod_formaPagto.Forma_id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Editar" + ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
        public void ExcluirFromaPagto(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM formapagto WHERE forma_id = @forma_id";
                cmd.Parameters.AddWithValue("@forma_id", codigo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados", "Excluir" + ex.Message,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }
        public DataTable ListarFromaPagto(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM formapagto WHERE forma_descricao like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public modelo_FormaPagto CarregarFormaPagto(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_FormaPagto modelo_pagto = new modelo_FormaPagto();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM formapagto WHERE forma_id = @forma_id;";
                cmd.Parameters.AddWithValue("@forma_id", codigo);
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo_pagto.Forma_id = Convert.ToInt32(registro["forma_id"]);
                    modelo_pagto.Forma_descricao = Convert.ToString(registro["forma_descricao"]);
                }
                return modelo_pagto;
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
        public int VerificaFormaPagto(String valor)
        {
            try
            {
                int r = 0;
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao.Conexao;
                comando.CommandText = "SELECT * FROM formapagto WHERE forma_descricao = @forma_descricao;";
                comando.Parameters.AddWithValue("@forma_descricao", valor);
                conexao.AbrirConexao();
                MySqlDataReader registro = comando.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["forma_id"]);
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
