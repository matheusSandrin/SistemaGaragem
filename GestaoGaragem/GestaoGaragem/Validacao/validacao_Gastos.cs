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
    public class validacao_Gastos
    {
        private Utilidade_Conexao conexao;
        public validacao_Gastos(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }
        public void SalvarGastos(modelo_Gastos gastos)
        {

            if (gastos.Gastos_valor == 0)
            {
                MessageBox.Show("O Valor do gasto é obrigatório", "Validação Gasto", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            negocio_Gastos negocio_gastos = new negocio_Gastos(conexao);
            negocio_gastos.SalvarGastos(gastos);
        }
        public void ValidarEditarGastos(modelo_Gastos gastos)
        {
            if (gastos.Gastos_valor == 0)
            {
                MessageBox.Show("O Valor do gasto é obrigatório", "Validação Gasto", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                negocio_Gastos negocio_gastos = new negocio_Gastos(conexao);
                negocio_gastos.EditarGastos(gastos);
            }
        }
        public void ExcluirGastos(int codigo)
        {
            negocio_Gastos negocio_gastos = new negocio_Gastos(conexao);
            negocio_gastos.ExcluirGastos(codigo);
        }
        public DataTable ListarGastos(String valor)
        {
            negocio_Gastos negocio_gastos = new negocio_Gastos(conexao);
            return negocio_gastos.ListarGastos(valor);
        }

        public modelo_Gastos CarregarGastos(int codigo)
        {
            negocio_Gastos negocio_gastos = new negocio_Gastos(conexao);
            return negocio_gastos.CarregarGastos(codigo);
        }

        public int VerificaGastos(String valor)
        {
            negocio_Gastos negocio_gastos = new negocio_Gastos(conexao);
            return negocio_gastos.VerificaGastos(valor);
        }
    }
}
