namespace GestaoGaragem.Visual
{
    partial class frmCalculaJurosSimples
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtValorParcela = new MetroFramework.Controls.MetroTextBox();
            this.txtTaxaJuros = new MetroFramework.Controls.MetroTextBox();
            this.txtDiasAtraso = new MetroFramework.Controls.MetroTextBox();
            this.txtValorPagar = new MetroFramework.Controls.MetroTextBox();
            this.btnLimparCampos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCalcular = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVoltar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(133, 25);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Valor da Parcela";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 125);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(157, 25);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Taxa de Juros (A.M)";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(23, 166);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(121, 25);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Dias de Atraso";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(23, 208);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 25);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Valor a Pagar";
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtValorParcela.Location = new System.Drawing.Point(231, 80);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.Size = new System.Drawing.Size(196, 23);
            this.txtValorParcela.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtValorParcela.TabIndex = 1;
            this.txtValorParcela.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorParcela.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorParcela_KeyDown);
            this.txtValorParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorParcela_KeyPress);
            this.txtValorParcela.Leave += new System.EventHandler(this.txtValorParcela_Leave);
            // 
            // txtTaxaJuros
            // 
            this.txtTaxaJuros.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTaxaJuros.Location = new System.Drawing.Point(231, 125);
            this.txtTaxaJuros.Name = "txtTaxaJuros";
            this.txtTaxaJuros.Size = new System.Drawing.Size(196, 23);
            this.txtTaxaJuros.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtTaxaJuros.TabIndex = 2;
            this.txtTaxaJuros.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTaxaJuros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaxaJuros_KeyDown);
            // 
            // txtDiasAtraso
            // 
            this.txtDiasAtraso.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDiasAtraso.Location = new System.Drawing.Point(231, 166);
            this.txtDiasAtraso.Name = "txtDiasAtraso";
            this.txtDiasAtraso.Size = new System.Drawing.Size(196, 23);
            this.txtDiasAtraso.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtDiasAtraso.TabIndex = 3;
            this.txtDiasAtraso.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiasAtraso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiasAtraso_KeyDown);
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Enabled = false;
            this.txtValorPagar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtValorPagar.Location = new System.Drawing.Point(231, 208);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(196, 23);
            this.txtValorPagar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtValorPagar.TabIndex = 4;
            this.txtValorPagar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorPagar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorPagar_KeyDown);
            this.txtValorPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPagar_KeyPress);
            this.txtValorPagar.Leave += new System.EventHandler(this.txtValorPagar_Leave);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Active = false;
            this.btnLimparCampos.Activecolor = System.Drawing.Color.Silver;
            this.btnLimparCampos.BackColor = System.Drawing.Color.Silver;
            this.btnLimparCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimparCampos.BorderRadius = 0;
            this.btnLimparCampos.ButtonText = "Limpar";
            this.btnLimparCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparCampos.DisabledColor = System.Drawing.Color.Gray;
            this.btnLimparCampos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLimparCampos.Iconimage = global::GestaoGaragem.Properties.Resources.icons8_restituição_2_36;
            this.btnLimparCampos.Iconimage_right = null;
            this.btnLimparCampos.Iconimage_right_Selected = null;
            this.btnLimparCampos.Iconimage_Selected = null;
            this.btnLimparCampos.IconMarginLeft = 0;
            this.btnLimparCampos.IconMarginRight = 0;
            this.btnLimparCampos.IconRightVisible = true;
            this.btnLimparCampos.IconRightZoom = 0D;
            this.btnLimparCampos.IconVisible = true;
            this.btnLimparCampos.IconZoom = 90D;
            this.btnLimparCampos.IsTab = false;
            this.btnLimparCampos.Location = new System.Drawing.Point(23, 286);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Normalcolor = System.Drawing.Color.Silver;
            this.btnLimparCampos.OnHovercolor = System.Drawing.Color.Silver;
            this.btnLimparCampos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLimparCampos.selected = false;
            this.btnLimparCampos.Size = new System.Drawing.Size(111, 41);
            this.btnLimparCampos.TabIndex = 11;
            this.btnLimparCampos.Text = "Limpar";
            this.btnLimparCampos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCampos.Textcolor = System.Drawing.Color.White;
            this.btnLimparCampos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Active = false;
            this.btnCalcular.Activecolor = System.Drawing.Color.Silver;
            this.btnCalcular.BackColor = System.Drawing.Color.Silver;
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcular.BorderRadius = 0;
            this.btnCalcular.ButtonText = "Calcular";
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.DisabledColor = System.Drawing.Color.Gray;
            this.btnCalcular.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalcular.Iconimage = global::GestaoGaragem.Properties.Resources.icons8_verificar_36;
            this.btnCalcular.Iconimage_right = null;
            this.btnCalcular.Iconimage_right_Selected = null;
            this.btnCalcular.Iconimage_Selected = null;
            this.btnCalcular.IconMarginLeft = 0;
            this.btnCalcular.IconMarginRight = 0;
            this.btnCalcular.IconRightVisible = true;
            this.btnCalcular.IconRightZoom = 0D;
            this.btnCalcular.IconVisible = true;
            this.btnCalcular.IconZoom = 90D;
            this.btnCalcular.IsTab = false;
            this.btnCalcular.Location = new System.Drawing.Point(172, 286);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Normalcolor = System.Drawing.Color.Silver;
            this.btnCalcular.OnHovercolor = System.Drawing.Color.Silver;
            this.btnCalcular.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalcular.selected = false;
            this.btnCalcular.Size = new System.Drawing.Size(111, 41);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Textcolor = System.Drawing.Color.White;
            this.btnCalcular.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Active = false;
            this.btnVoltar.Activecolor = System.Drawing.Color.Silver;
            this.btnVoltar.BackColor = System.Drawing.Color.Silver;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.BorderRadius = 0;
            this.btnVoltar.ButtonText = "Voltar";
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.DisabledColor = System.Drawing.Color.Gray;
            this.btnVoltar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVoltar.Iconimage = global::GestaoGaragem.Properties.Resources.icons8_duplo_para_a_esquerda_32;
            this.btnVoltar.Iconimage_right = null;
            this.btnVoltar.Iconimage_right_Selected = null;
            this.btnVoltar.Iconimage_Selected = null;
            this.btnVoltar.IconMarginLeft = 0;
            this.btnVoltar.IconMarginRight = 0;
            this.btnVoltar.IconRightVisible = true;
            this.btnVoltar.IconRightZoom = 0D;
            this.btnVoltar.IconVisible = true;
            this.btnVoltar.IconZoom = 90D;
            this.btnVoltar.IsTab = false;
            this.btnVoltar.Location = new System.Drawing.Point(316, 286);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Normalcolor = System.Drawing.Color.Silver;
            this.btnVoltar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnVoltar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVoltar.selected = false;
            this.btnVoltar.Size = new System.Drawing.Size(111, 41);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Textcolor = System.Drawing.Color.White;
            this.btnVoltar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmCalculaJurosSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.txtDiasAtraso);
            this.Controls.Add(this.txtTaxaJuros);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnVoltar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculaJurosSimples";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Calcula Juros Simples";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnVoltar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalcular;
        private Bunifu.Framework.UI.BunifuFlatButton btnLimparCampos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtValorParcela;
        private MetroFramework.Controls.MetroTextBox txtTaxaJuros;
        private MetroFramework.Controls.MetroTextBox txtDiasAtraso;
        private MetroFramework.Controls.MetroTextBox txtValorPagar;
    }
}