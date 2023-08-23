using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoGaragem.Utilidade;
using GestaoGaragem.Modelo;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace GestaoGaragem.Negocio
{
    public class negocio_Usuario
    {
        private Utilidade_Conexao conexao;
        MySqlCommand comando = null;

        public negocio_Usuario(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        public void SalvarUsuario(modelo_Usuario mod_usuario)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "INSERT INTO usuarios (user_usuario, user_password) VALUES (@user_usuario, @user_password); SELECT @@IDENTITY";
                cmd.Parameters.AddWithValue("user_usuario", mod_usuario.User_usuario);
                cmd.Parameters.AddWithValue("user_password", mod_usuario.User_password);
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
        public void EditarUsuario(modelo_Usuario usuario)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "UPDATE usuarios SET user_usuario = @user_usuario, user_password = @user_password WHERE user_id = @user_id";
                cmd.Parameters.AddWithValue("@user_usuario", usuario.User_usuario);
                cmd.Parameters.AddWithValue("@user_password", usuario.User_password);
                cmd.Parameters.AddWithValue("@user_id", usuario.User_id);
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
        public void ExcluirUsuario(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "DELETE FROM usuarios WHERE user_id = @user_id";
                cmd.Parameters.AddWithValue("@user_id", codigo);
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
        public DataTable ListarUsuario(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM usuarios WHERE user_usuario like '%" + valor + "%'", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
             catch(Exception ex)
            {
                throw ex;
            }
        }
        public modelo_Usuario CarregarUsuario(int codigo)
        {
            try
            {
                conexao.AbrirConexao();
                modelo_Usuario usuario = new modelo_Usuario();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.Conexao;
                cmd.CommandText = "SELECT * FROM usuarios WHERE user_id = @user_id;";
                cmd.Parameters.AddWithValue("@user_id", codigo);
                MySqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    usuario.User_id = Convert.ToInt32(registro["user_id"]);
                    usuario.User_usuario = Convert.ToString(registro["user_usuario"]);
                    usuario.User_password = Convert.ToString(registro["user_password"]);
                }
                return usuario;
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
        public int VerificaUsuario(String valor)
        {
            try
            {
                int r = 0;
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao.Conexao;
                comando.CommandText = "SELECT * FROM usuarios WHERE user_usuario = @user_usuario;";
                comando.Parameters.AddWithValue("@user_usuario", valor);
                conexao.AbrirConexao();
                MySqlDataReader registro = comando.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    r = Convert.ToInt32(registro["user_id"]);
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
