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
    public class validacao_Veiculo
    {
        private Utilidade_Conexao conexao;
        public validacao_Veiculo(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        public void SalvarVeiculo(modelo_Veiculo veiculo)
        {

            if (veiculo.Veic_modelo.Trim().Length == 0)
            {
                MessageBox.Show("O Modelo do veículo é obrigatório", "Validação Veículo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (veiculo.Veic_marca.Trim().Length == 0)
            {
                MessageBox.Show("A Marca do veículo é obrigatório", "Validação Veículo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (veiculo.Veic_precopago == 0)
            {
                MessageBox.Show("O Preço do veículo é obrigatório", "Validação Veículo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            negocio_Veiculo negocio_veiculo = new negocio_Veiculo(conexao);
            negocio_veiculo.SalvarVeiculo(veiculo);
        }

        public void ValidarEditarVeiculo(modelo_Veiculo veiculo)
        {
            if (veiculo.Veic_id <= 0)
            {
                MessageBox.Show("O código do acesso é obrigatório", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (veiculo.Veic_modelo.Trim().Length == 0)
            {
                MessageBox.Show("O Modelo do veículo é obrigatório", "Validação Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (veiculo.Veic_marca.Trim().Length == 0)
            {
                MessageBox.Show("A Marca do veículo é obrigatório", "Validação Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (veiculo.Veic_precopago == 0)
            {
                MessageBox.Show("O Preço do veículo é obrigatório", "Validação Veículo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                negocio_Veiculo negocio_veiculo = new negocio_Veiculo(conexao);
                negocio_veiculo.EditarVeiculo(veiculo);
            }
        }

        public void ExcluirVeiculo(int codigo)
        {
            negocio_Veiculo negocio_veiculo = new negocio_Veiculo(conexao);
            negocio_veiculo.ExcluirVeiculo(codigo);
        }

        public DataTable ListarVeiculo(String valor)
        {
            negocio_Veiculo negocio_veiculo = new negocio_Veiculo(conexao);
            return negocio_veiculo.ListarVeiculo(valor);
        }
        public modelo_Veiculo CarregarVeiculo(int codigo)
        {
            negocio_Veiculo negocio_veiculo = new negocio_Veiculo(conexao);
            return negocio_veiculo.CarregarVeiculo(codigo);
        }
        public int VerificaVeiculo(String valor)
        {
            negocio_Veiculo negocio_veiculo = new negocio_Veiculo(conexao);
            return negocio_veiculo.VerificaVeiculo(valor);
        }
    }
}
