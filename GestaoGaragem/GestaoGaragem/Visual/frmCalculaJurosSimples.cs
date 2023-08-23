using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySqlX.XDevAPI.Relational;

namespace GestaoGaragem.Visual
{
    public partial class frmCalculaJurosSimples : MetroForm
    {
        /*
        * FORMULAR PARA CALCULAR JUROS SIMPLES.
        * M = P.(1+(I.N))
        * M = MONTANTE => RESULTADO ESPERANDO
        * P = VALOR PRESENTE (PRINCIPAL, BASE PARA O CALCULO)
        * I = TAXA
        * N = PERIODO
        */
        public frmCalculaJurosSimples()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            this.txtValorParcela.Text = "";
            this.txtTaxaJuros.Text = "";
            this.txtDiasAtraso.Text = "";
            this.txtValorPagar.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double M;
            double P = Convert.ToDouble(txtValorParcela.Text);
            double I = Convert.ToDouble(txtTaxaJuros.Text) / 100;
            double N = Convert.ToDouble(txtDiasAtraso.Text);
            //Formula para calcular juros simples;
            M = P * (1 + (I * (N / 30)));
            //Montras o valor calcula no txtbox;
            txtValorPagar.Text = M.ToString("C");
        }

        private void txtValorParcela_Leave(object sender, EventArgs e)
        {
            if (txtValorParcela.Text.Contains(",") == false)
            {
                txtValorParcela.Text += ",00";
            }
            else
            {
                if (txtValorParcela.Text.IndexOf(",") == txtValorParcela.Text.Length - 1)
                {
                    txtValorParcela.Text += "00";
                }
            }
        }

        private void txtValorParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorParcela.Text.Contains("."))
                {
                    e.KeyChar = '.';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValorParcela_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtValorPagar_Leave(object sender, EventArgs e)
        {
            if (txtValorPagar.Text.Contains(",") == false)
            {
                txtValorPagar.Text += ",00";
            }
            else
            {
                if (txtValorPagar.Text.IndexOf(",") == txtValorPagar.Text.Length - 1)
                {
                    txtValorPagar.Text += "00";
                }
            }
        }

        private void txtValorPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPagar.Text.Contains("."))
                {
                    e.KeyChar = ',';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtValorPagar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtTaxaJuros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtDiasAtraso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
