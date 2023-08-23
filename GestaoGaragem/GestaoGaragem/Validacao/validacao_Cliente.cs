using GestaoGaragem.Modelo;
using GestaoGaragem.Negocio;
using GestaoGaragem.Utilidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoGaragem.Validacao
{
    public class validacao_Cliente
    {
        private Utilidade_Conexao conexao;
        public validacao_Cliente(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        public void SalvarCliente(modelo_Cliente cliente)
        {
            
            if (cliente.Cli_nome.Trim().Length == 0)
            {
                MessageBox.Show("O Nome do cliente é obrigatório", "Validação Cliente", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (cliente.Cli_foneCelular.Trim().Length == 0)
            {
                MessageBox.Show("O Celular do cliente é obrigatório", "Validação Cliente", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            negocio_cliente.SalvarCliente(cliente);
        }

        public void EditarCliente(modelo_Cliente cliente)
        {
            if (cliente.Cli_id <= 0)
            {
                MessageBox.Show("O código do acesso é obrigatório", "Validação", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (cliente.Cli_nome.Trim().Length == 0)
            {
                MessageBox.Show("O Nome do cliente é obrigatório", "Validação Cliente", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (cliente.Cli_foneCelular.Trim().Length == 0)
            {
                MessageBox.Show("O Celular do cliente é obrigatório", "Validação Cliente", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            negocio_cliente.EditarCliente(cliente);
        }

        public void ExcluirCliente(int codigo)
        {
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            negocio_cliente.ExcluirCliente(codigo);
        }

        public DataTable ListarCliente(String valor)
        {
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            return negocio_cliente.ListarCliente(valor);
        }
        public modelo_Cliente CarregarCliente(int codigo)
        {
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            return negocio_cliente.CarregarCliente(codigo);
        }
        public int VerificaCliente(String valor)
        {
            negocio_Cliente negocio_cliente = new negocio_Cliente(conexao);
            return negocio_cliente.VerificaCliente(valor);
        }
    }
}
