using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGaragem.Modelo
{
    public class modelo_FormaPagto
    {

        private int forma_id;
        private string forma_descricao;

        public modelo_FormaPagto()
        {
            this.Forma_id = 0;
            this.Forma_descricao = "";
        }

        public int Forma_id { get => forma_id; set => forma_id = value; }
        public string Forma_descricao { get => forma_descricao; set => forma_descricao = value; }
    }
}
