using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGaragem.Modelo
{
    public class modelo_Usuario
    {

        private int user_id;
        private string user_usuario;
        private string user_password;

        public modelo_Usuario()
        {
            this.User_id = 0;
            this.User_usuario = "";
            this.User_password = "";
        }

        public int User_id { get => user_id; set => user_id = value; }
        public string User_usuario { get => user_usuario; set => user_usuario = value; }
        public string User_password { get => user_password; set => user_password = value; }
    }
}
