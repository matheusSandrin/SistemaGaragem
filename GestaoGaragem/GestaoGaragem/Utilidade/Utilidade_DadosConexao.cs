using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGaragem.Utilidade
{
    public class Utilidade_DadosConexao
    {
        //Variável global de conexão
        public static String servidor = "localhost";
        public static String banco = "gestaogaragem";
        public static String usuario = "root";
        public static String senha = "123456";

        //método stringconexão que realiza a conexão com o db;

        public static String StringConexao
        {
            get
            {
                return @"Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
            }
        }

    }
}
