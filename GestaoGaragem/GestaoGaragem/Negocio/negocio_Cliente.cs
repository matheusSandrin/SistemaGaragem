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
    public class negocio_Cliente
    {
        private Utilidade_Conexao conexao;
        MySqlCommand comando = null;
        public negocio_Cliente(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }
        public void SalvarCliente(modelo_Cliente modelo_cliente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO cliente (cli_dataCadastro, cli_cpf, cli_nome,cli_cep, cli_endereco, cli_numero, cli_complemento, cli_bairro, cli_cidade, cli_estado, cli_email, cli_foneCelular, cli_observacao) " +
                    "VALUES ( @cli_dataCadastro, @cli_cpf, @cli_nome, @cli_cep, @cli_endereco, @cli_numero, @cli_complemento, @cli_bairro, @cli_cidade, @cli_estado, @cli_email, @cli_foneCelular, @cli_observacao); SELECT @@IDENTITY";
                cmd.Parameters.AddWithValue("cli_dataCadastro", modelo_cliente.Cli_dataCadastro);
                cmd.Parameters.AddWithValue("cli_cpf", modelo_cliente.Cli_cpf);
                cmd.Parameters.AddWithValue("cli_nome", modelo_cliente.Cli_nome);
                cmd.Parameters.AddWithValue("cli_cep", modelo_cliente.Cli_cep);
                cmd.Parameters.AddWithValue("cli_endereco", modelo_cliente.Cli_endereco);
                cmd.Parameters.AddWithValue("cli_numero", modelo_cliente.Cli_numero);
                cmd.Parameters.AddWithValue("cli_complemento", modelo_cliente.Cli_complemento);
                cmd.Parameters.AddWithValue("cli_bairro", modelo_cliente.Cli_bairro);
                cmd.Parameters.AddWithValue("cli_cidade", modelo_cliente.Cli_cidade);
                cmd.Parameters.AddWithValue("cli_estado", modelo_cliente.Cli_estado);
                cmd.Parameters.AddWithValue("cli_email", modelo_cliente.Cli_email);
                cmd.Parameters.AddWithValue("cli_foneCelular", modelo_cliente.Cli_foneCelular);
                cmd.Parameters.AddWithValue("cli_observacao", modelo_cliente.Cli_observacao);
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
        public void EditarCliente(modelo_Cliente modelo_cliente)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE cliente SET cli_cpf = @cli_cpf, cli_nome = @cli_nome, cli_dataCadastro = @cli_dataCadastro, cli_cep = @cli_cep," +
                    "cli_endereco = @cli_endereco, cli_numero = @cli_numero, cli_complemento = @cli_complemento, cli_bairro = @cli_bairro," +
                    "cli_cidade = @cli_cidade, cli_estado = @cli_estado, cli_email = @cli_email, cli_foneCelular = @cli_foneCelular," +
                    "cli_observacao = @cli_observacao WHERE cli_id = @cli_id";
                cmd.Parameters.AddWithValue("cli_cpf", modelo_cliente.Cli_cpf);
                cmd.Parameters.AddWithValue("cli_nome", modelo_cliente.Cli_nome);
                cmd.Parameters.AddWithValue("cli_dataCadastro", modelo_cliente.Cli_dataCadastro);
                cmd.Parameters.AddWithValue("cli_cep", modelo_cliente.Cli_cep);
                cmd.Parameters.AddWithValue("cli_endereco", modelo_cliente.Cli_endereco);
                cmd.Parameters.AddWithValue("cli_numero", modelo_cliente.Cli_numero);
                cmd.Parameters.AddWithValue("cli_complemento", modelo_cliente.Cli_complemento);
                cmd.Parameters.AddWithValue("cli_bairro", modelo_cliente.Cli_bairro);
                cmd.Parameters.AddWithValue("cli_cidade", modelo_cliente.Cli_cidade);
                cmd.Parameters.AddWithValue("cli_estado", modelo_cliente.Cli_estado);
                cmd.Parameters.AddWithValue("cli_email", modelo_cliente.Cli_email);
                cmd.Parameters.AddWithValue("cli_foneCelular", modelo_cliente.Cli_foneCelular);
                cmd.Parameters.AddWithValue("cli_observacao", modelo_cliente.Cli_observacao);
                cmd.Parameters.AddWithValue("cli_id", modelo_cliente.Cli_id);
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
        public void ExcluirCliente(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM cliente WHERE cli_id = @cli_id";
                cmd.Parameters.AddWithValue("@cli_id", codigo);
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
        public DataTable ListarCliente(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM cliente WHERE cli_nome like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public modelo_Cliente CarregarCliente(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Cliente modelo_cliente = new modelo_Cliente();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM cliente WHERE cli_id = @cli_id;";
                cmd.Parameters.AddWithValue("@cli_id", codigo);
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo_cliente.Cli_id = Convert.ToInt32(registro["cli_id"]);
                    modelo_cliente.Cli_cpf = Convert.ToString(registro["cli_cpf"]);
                    modelo_cliente.Cli_nome = Convert.ToString(registro["cli_nome"]);
                    modelo_cliente.Cli_dataCadastro = Convert.ToDateTime(registro["cli_dataCadastro"]);
                    modelo_cliente.Cli_cep = Convert.ToString(registro["cli_cep"]);
                    modelo_cliente.Cli_endereco = Convert.ToString(registro["cli_endereco"]);
                    modelo_cliente.Cli_numero = Convert.ToInt32(registro["cli_numero"]);
                    modelo_cliente.Cli_complemento = Convert.ToString(registro["cli_complemento"]);
                    modelo_cliente.Cli_bairro = Convert.ToString(registro["cli_bairro"]);
                    modelo_cliente.Cli_cidade = Convert.ToString(registro["cli_cidade"]);
                    modelo_cliente.Cli_estado = Convert.ToString(registro["cli_estado"]);
                    modelo_cliente.Cli_email = Convert.ToString(registro["cli_email"]);
                    modelo_cliente.Cli_foneCelular = Convert.ToString(registro["cli_foneCelular"]);
                    modelo_cliente.Cli_observacao = Convert.ToString(registro["cli_observacao"]);
                }
                return modelo_cliente;
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
        public int VerificaCliente(String valor)
        {
            try
            {
                int r = 0;
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM cliente WHERE cli_cpf = @cli_cpf;";
                cmd.Parameters.AddWithValue("@cli_cpf", valor);
                conexao.AbrirConexao();
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["cli_id"]);
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
