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
    public class validacao_FormaPagto
    {
        private Utilidade_Conexao conexao;
        public validacao_FormaPagto(Utilidade_Conexao cx)
        {
            this.conexao = cx;
        }

        public void SalvarFormaPagto(modelo_FormaPagto modelo_formapagto)
        {
            if (modelo_formapagto.Forma_descricao.Trim().Length == 0)
            {
                MessageBox.Show("O nome da descrição é obrigatório", "Validação Forma Pagto", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            negocio_FormaPagto negocio_formapagto = new negocio_FormaPagto(conexao);
            negocio_formapagto.SalvarFormaPagto(modelo_formapagto);
        }

        public void EditarFormaPagto(modelo_FormaPagto modelo_formapagto)
        {
            if (modelo_formapagto.Forma_id <= 0)
            {
                MessageBox.Show("O código Forma de Pagto é obrigatório", "Validação Forma Pagto", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (modelo_formapagto.Forma_descricao.Trim().Length == 0)
            {
                MessageBox.Show("O nome da descrição é obrigatório", "Validação Forma Pagto", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            negocio_FormaPagto negocio_formapagto = new negocio_FormaPagto(conexao);
            negocio_formapagto.EditarFormPagto(modelo_formapagto);
        }

        public void ExcluirFormaPagto(int codigo)
        {
            negocio_FormaPagto negocio_formapagto = new negocio_FormaPagto(conexao);
            negocio_formapagto.ExcluirFromaPagto(codigo);
        }

        public DataTable ListarFormaPagto(String valor)
        {
            negocio_FormaPagto negocio_formapagto = new negocio_FormaPagto(conexao);
            return negocio_formapagto.ListarFromaPagto(valor);
        }
        public modelo_FormaPagto CarregarFormaPagto(int codigo)
        {
            negocio_FormaPagto negocio_formapagto = new negocio_FormaPagto(conexao);
            return negocio_formapagto.CarregarFormaPagto(codigo);
        }
        public int VerificaFormaPagto(String valor)
        {
            negocio_FormaPagto negocio_formapagto = new negocio_FormaPagto(conexao);
            return negocio_formapagto.VerificaFormaPagto(valor);
        }
    }
}

