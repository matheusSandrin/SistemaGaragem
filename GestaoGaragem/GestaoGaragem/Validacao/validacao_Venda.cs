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
    public class validacao_Venda
    {
        private Utilidade_Conexao conexao;
        public validacao_Venda(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }
        public void SalvarVenda(modelo_Venda venda)
        {

            if (venda.Venda_valor == 0)
            {
                MessageBox.Show("O Valor do veículo é obrigatório", "Validação Venda", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            negocio_Venda negocio_venda = new negocio_Venda(conexao);
            negocio_venda.SalvarVenda(venda);
        }
        public void ValidarEditarVenda(modelo_Venda venda)
        {
            if (venda.Venda_valor == 0)
            {
                MessageBox.Show("O Valor do veículo é obrigatório", "Validação Venda", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                negocio_Venda negocio_venda = new negocio_Venda(conexao);
                negocio_venda.EditarVenda(venda);
            }
        }
        public DataTable ListarVenda(String valor)
        {
            negocio_Venda negocio_venda = new negocio_Venda(conexao);
            return negocio_venda.ListarVenda(valor);
        }

        public modelo_Venda CarregarVenda(int codigo)
        {
            negocio_Venda negocio_venda = new negocio_Venda(conexao);
            return negocio_venda.CarregarVenda(codigo);
        }
        public void ExcluirVenda(int codigo)
        {
            negocio_Venda negocio_venda = new negocio_Venda(conexao);
            negocio_venda.ExcluirVenda(codigo);
        }

        public int VerificaVenda(String valor)
        {
            negocio_Venda negocio_venda = new negocio_Venda(conexao);
            return negocio_venda.VerificaVenda(valor);
        }

    }
}
