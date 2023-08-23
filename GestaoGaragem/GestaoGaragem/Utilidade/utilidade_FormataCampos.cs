using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.Lib;


namespace GestaoGaragem.Utilidade
{
    public class utilidade_FormataCampos
    {
        public enum Campos
        {
            CEP = 1,
            CPF = 2,
            CNPJ = 3,
            TELEFONE = 4,
            DATA = 5
        }

        /// <summary>
        /// Metodo preenchimento de mascara do texbox;
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="txtTexto"></param>
        public void Maskara(Campos valor, TextBox txtTexto)
        {
            switch (valor)
            {
                // Colocar Mascara no CEP
                // 00.000-000
                case Campos.CEP:
                    txtTexto.MaxLength = 10;
                    if(txtTexto is System.Windows.Forms.TextBox) {
                        System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)txtTexto;
                        if (txtTexto.Text.Length == 2)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    }
                    break;

                // Colocar Mascara no CPF
                // 000.000.000-00
                case Campos.CPF:
                    txtTexto.MaxLength = 14;
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 7)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;

                // Colocar Mascara no CNPJ
                // 00.000.000/0001-00
                case Campos.CNPJ:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;

                // Colocar Mascara no TELEFONE
                // (00) 0.0000-0000
                case Campos.TELEFONE:
                    txtTexto.MaxLength = 16;
                    if (txtTexto.Text.Length == 0)
                    {
                        txtTexto.Text = txtTexto.Text + "(";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ")";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    if (txtTexto.Text.Length == 4)
                    {
                        txtTexto.Text = txtTexto.Text + " ";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    if (txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;


                // Colocar Mascara no DATA
                // 00/00/0000
                case Campos.DATA:
                    txtTexto.MaxLength = 10;
                    if (txtTexto.Text.Length == 2)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 5)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
            }
        }
    }
}
