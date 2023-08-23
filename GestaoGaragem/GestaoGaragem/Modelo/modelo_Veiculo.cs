using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGaragem.Modelo
{
    public class modelo_Veiculo
    {
        private int veic_id;
        private string veic_modelo;
        private string veic_marca;
        private int veic_ano;
        private decimal veic_km;
        private string veic_placa;
        private decimal veic_precopago;
        private decimal veic_precovenda;
        private DateTime veic_datacompra;
        private bool veic_disponivel;

        public modelo_Veiculo()
        {
            this.Veic_id = 0;
            this.Veic_modelo = "";
            this.Veic_marca = "";
            this.Veic_ano = 0;
            this.Veic_placa = "";
            this.Veic_km = 0;
            this.Veic_precopago = 0;
            this.Veic_precovenda = 0;
            this.Veic_datacompra = DateTime.Now;
            this.Veic_disponivel = true;
        }

        public int Veic_id { get => veic_id; set => veic_id = value; }
        public string Veic_modelo { get => veic_modelo; set => veic_modelo = value; }
        public int Veic_ano { get => veic_ano; set => veic_ano = value; }
        public string Veic_placa { get => veic_placa; set => veic_placa = value; }
        public decimal Veic_precopago { get => veic_precopago; set => veic_precopago = value; }
        public DateTime Veic_datacompra { get => veic_datacompra; set => veic_datacompra = value; }
        public string Veic_marca { get => veic_marca; set => veic_marca = value; }
        public decimal Veic_km { get => veic_km; set => veic_km = value; }
        public decimal Veic_precovenda { get => veic_precovenda; set => veic_precovenda = value; }
        public bool Veic_disponivel { get => veic_disponivel; set => veic_disponivel = value; }
    }
}
