﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoGaragem.Modelo
{
    public class modelo_Cliente
    {

        private int cli_id;
        private string cli_cpf;
        private string cli_nome;
        private DateTime cli_dataCadastro;
        private string cli_cep;
        private string cli_endereco;
        private int cli_numero;
        private string cli_complemento;
        private string cli_bairro;
        private string cli_cidade;
        private string cli_estado;
        private string cli_email;
        private string cli_foneCelular;
        private string cli_observacao;

        public modelo_Cliente()
        {
            this.Cli_id = 0;
            this.Cli_cpf = "";
            this.Cli_nome = "";
            this.Cli_dataCadastro = DateTime.Now;
            this.Cli_cep = "";
            this.cli_endereco = "";
            this.Cli_numero = 0;
            this.Cli_complemento = "";
            this.Cli_bairro = "";
            this.Cli_cidade = "";
            this.Cli_estado = "";
            this.Cli_email = "";
            this.Cli_foneCelular = "";
            this.Cli_observacao = "";
        }

        public int Cli_id { get => cli_id; set => cli_id = value; }
        public string Cli_cpf { get => cli_cpf; set => cli_cpf = value; }
        public string Cli_nome { get => cli_nome; set => cli_nome = value; }
        public DateTime Cli_dataCadastro { get => cli_dataCadastro; set => cli_dataCadastro = value; }
        public string Cli_cep { get => cli_cep; set => cli_cep = value; }
        public string Cli_endereco { get => cli_endereco; set => cli_endereco = value; }
        public int Cli_numero { get => cli_numero; set => cli_numero = value; }
        public string Cli_complemento { get => cli_complemento; set => cli_complemento = value; }
        public string Cli_bairro { get => cli_bairro; set => cli_bairro = value; }
        public string Cli_cidade { get => cli_cidade; set => cli_cidade = value; }
        public string Cli_estado { get => cli_estado; set => cli_estado = value; }
        public string Cli_email { get => cli_email; set => cli_email = value; }
        public string Cli_foneCelular { get => cli_foneCelular; set => cli_foneCelular = value; }
        public string Cli_observacao { get => cli_observacao; set => cli_observacao = value; }
    }
}
