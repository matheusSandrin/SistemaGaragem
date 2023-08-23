using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoGaragem.Utilidade;
using GestaoGaragem.Modelo;
using GestaoGaragem.Negocio;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace GestaoGaragem.Validacao
{
    public class validacao_Usuario
    {
        private Utilidade_Conexao conexao;
        public validacao_Usuario(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        public void SalvarUsuario(modelo_Usuario usuario)
        {
            if (usuario.User_usuario.Trim().Length == 0)
            {
                MessageBox.Show("O nome do usuário é obrigatório", "Validação usuário", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (usuario.User_password.Trim().Length == 0)
            {
                MessageBox.Show("O password é obrigatório", "Validação Password", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
            negocio_Usuario.SalvarUsuario(usuario);
        }

        public void EditarUsuario(modelo_Usuario usuario)
        {
            if (usuario.User_id <= 0)
            {
                MessageBox.Show("O código do acesso é obrigatório", "Validação", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (usuario.User_usuario.Trim().Length == 0)
            {
                MessageBox.Show("O nome do usuário é obrigatório", "Validação usuário", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (usuario.User_password.Trim().Length == 0)
            {
                MessageBox.Show("O password é obrigatório", "Validação Password", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
            negocio_Usuario.EditarUsuario(usuario);
        }

        public void ExcluirUsuario(int codigo)
        {
            negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
            negocio_Usuario.ExcluirUsuario(codigo);
        }

        public DataTable ListarUsuario(String valor)
        {
            negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
            return negocio_Usuario.ListarUsuario(valor);
        }
        public modelo_Usuario CarregarUsuario(int codigo)
        {
            negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
            return negocio_Usuario.CarregarUsuario(codigo);
        }
        public int VerificaUsuario(String valor)
        {
            negocio_Usuario negocio_Usuario = new negocio_Usuario(conexao);
            return negocio_Usuario.VerificaUsuario(valor);
        }
    }
}
