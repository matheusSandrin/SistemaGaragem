using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGaragem.Utilidade
{
    public class Utilidade_Conexao
    {
        
            //variavel privada da classe conexão;
            private String _stringConexao;
            private MySqlConnection _conexao;

            public Utilidade_Conexao(String dadosConexao)
            {
                this._conexao = new MySqlConnection();
                this.StringConexao = dadosConexao;
                this._conexao.ConnectionString = dadosConexao;
            }

            public String StringConexao
            {
                get => this._stringConexao;
                set => this._stringConexao = value;
            }

            public MySqlConnection Conexao
            {
                get => this._conexao;
                set => this._conexao = value;   
            }

            public void AbrirConexao()
            {
                this._conexao.Open();
            }

            public void FecharConexao()
            {
                this._conexao.Close();
            }
        }
    }

