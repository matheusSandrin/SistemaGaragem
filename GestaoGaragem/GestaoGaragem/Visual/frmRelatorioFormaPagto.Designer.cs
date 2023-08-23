namespace GestaoGaragem.Visual
{
    partial class frmRelatorioFormaPagto
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPesquisaFormaPagto = new MetroFramework.Controls.MetroTextBox();
            this.dvgFormaPagto = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.btnGerar = new MetroFramework.Controls.MetroButton();
            this.cmbGerarArquivo = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFormaPagto)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(18, 83);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(95, 22);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Pesquisar";
            // 
            // txtPesquisaFormaPagto
            // 
            this.txtPesquisaFormaPagto.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPesquisaFormaPagto.Location = new System.Drawing.Point(121, 83);
            this.txtPesquisaFormaPagto.Name = "txtPesquisaFormaPagto";
            this.txtPesquisaFormaPagto.Size = new System.Drawing.Size(424, 25);
            this.txtPesquisaFormaPagto.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtPesquisaFormaPagto.TabIndex = 11;
            this.txtPesquisaFormaPagto.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dvgFormaPagto
            // 
            this.dvgFormaPagto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgFormaPagto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFormaPagto.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dvgFormaPagto.Location = new System.Drawing.Point(22, 122);
            this.dvgFormaPagto.Margin = new System.Windows.Forms.Padding(2);
            this.dvgFormaPagto.Name = "dvgFormaPagto";
            this.dvgFormaPagto.RowHeadersVisible = false;
            this.dvgFormaPagto.RowTemplate.Height = 28;
            this.dvgFormaPagto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgFormaPagto.Size = new System.Drawing.Size(819, 322);
            this.dvgFormaPagto.TabIndex = 13;
            this.dvgFormaPagto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgFormaPagto_CellDoubleClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(741, 83);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 25);
            this.btnPesquisar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(741, 452);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 25);
            this.btnVoltar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(163, 452);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(100, 25);
            this.btnGerar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnGerar.TabIndex = 16;
            this.btnGerar.Text = "Gerar ";
            this.btnGerar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // cmbGerarArquivo
            // 
            this.cmbGerarArquivo.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.cmbGerarArquivo.FormattingEnabled = true;
            this.cmbGerarArquivo.ItemHeight = 29;
            this.cmbGerarArquivo.Location = new System.Drawing.Point(23, 449);
            this.cmbGerarArquivo.Name = "cmbGerarArquivo";
            this.cmbGerarArquivo.Size = new System.Drawing.Size(121, 35);
            this.cmbGerarArquivo.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cmbGerarArquivo.TabIndex = 17;
            this.cmbGerarArquivo.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmRelatorioFormaPagto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.cmbGerarArquivo);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dvgFormaPagto);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtPesquisaFormaPagto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioFormaPagto";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Relatório Forma Pagamento";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.frmRelatorioFormaPagto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgFormaPagto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private MetroFramework.Controls.MetroTextBox txtPesquisaFormaPagto;
        private System.Windows.Forms.DataGridView dvgFormaPagto;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroButton btnGerar;
        private MetroFramework.Controls.MetroComboBox cmbGerarArquivo;
    }
}