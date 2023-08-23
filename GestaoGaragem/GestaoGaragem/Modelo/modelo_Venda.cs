using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGaragem.Modelo
{
    public class modelo_Venda
    {
        private int venda_id;
        private DateTime venda_data;
        private decimal venda_valor;
        private int veiculo_id;
        private int cliente_id;
        private string veic_modelo;
        private string cli_nome;

        public modelo_Venda()
        {
            this.Venda_id = 0;
            this.Venda_data = DateTime.Now;
            this.Venda_valor = 0;
            this.Cliente_id = 0;
            this.Veiculo_id = 0;
            this.Veic_modelo = "";
            this.Cli_nome = "";
        }

        public int Venda_id { get => venda_id; set => venda_id = value; }
        public DateTime Venda_data { get => venda_data; set => venda_data = value; }
        public decimal Venda_valor { get => venda_valor; set => venda_valor = value; }
        public int Veiculo_id { get => veiculo_id; set => veiculo_id = value; }
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }
        public string Veic_modelo { get => veic_modelo; set => veic_modelo = value; }
        public string Cli_nome { get => cli_nome; set => cli_nome = value; }
    }
}
