using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoGaragem.Modelo
{
    public class modelo_Gastos
    {

        private int gastos_id;
        private DateTime gastos_data;
        private decimal gastos_valor;
        private string gastos_descricao;

        public modelo_Gastos()
        {
            this.Gastos_id = 0;
            this.Gastos_valor = 0;
            this.Gastos_data = DateTime.Now;
            this.Gastos_descricao = "";
        }


        public int Gastos_id { get => gastos_id; set => gastos_id = value; }
        public DateTime Gastos_data { get => gastos_data; set => gastos_data = value; }
        public decimal Gastos_valor { get => gastos_valor; set => gastos_valor = value; }
        public string Gastos_descricao { get => gastos_descricao; set => gastos_descricao = value; }
    }
}
