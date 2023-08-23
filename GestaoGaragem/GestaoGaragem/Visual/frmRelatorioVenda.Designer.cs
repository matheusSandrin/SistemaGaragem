namespace GestaoGaragem.Visual
{
    partial class frmRelatorioVenda
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
            this.cmbGerarArquivo = new MetroFramework.Controls.MetroComboBox();
            this.dvgVenda = new System.Windows.Forms.DataGridView();
            this.btnGerar = new MetroFramework.Controls.MetroButton();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.txtPesquisaVenda = new MetroFramework.Controls.MetroTextBox();
            this.dtPickerInicial = new System.Windows.Forms.DateTimePicker();
            this.dtPickerFinal = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(19, 83);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(95, 22);
            this.bunifuCustomLabel1.TabIndex = 31;
            this.bunifuCustomLabel1.Text = "Pesquisar";
            // 
            // cmbGerarArquivo
            // 
            this.cmbGerarArquivo.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.cmbGerarArquivo.FormattingEnabled = true;
            this.cmbGerarArquivo.ItemHeight = 29;
            this.cmbGerarArquivo.Location = new System.Drawing.Point(23, 455);
            this.cmbGerarArquivo.Name = "cmbGerarArquivo";
            this.cmbGerarArquivo.Size = new System.Drawing.Size(121, 35);
            this.cmbGerarArquivo.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cmbGerarArquivo.TabIndex = 30;
            this.cmbGerarArquivo.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dvgVenda
            // 
            this.dvgVenda.AllowUserToAddRows = false;
            this.dvgVenda.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVenda.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dvgVenda.Location = new System.Drawing.Point(22, 128);
            this.dvgVenda.Margin = new System.Windows.Forms.Padding(2);
            this.dvgVenda.Name = "dvgVenda";
            this.dvgVenda.RowHeadersVisible = false;
            this.dvgVenda.RowTemplate.Height = 28;
            this.dvgVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgVenda.Size = new System.Drawing.Size(819, 322);
            this.dvgVenda.TabIndex = 29;
            this.dvgVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgVenda_CellDoubleClick);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(167, 455);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(100, 25);
            this.btnGerar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnGerar.TabIndex = 27;
            this.btnGerar.Text = "Gerar ";
            this.btnGerar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(741, 455);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 25);
            this.btnVoltar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnVoltar.TabIndex = 28;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(572, 83);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 25);
            this.btnPesquisar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnPesquisar.TabIndex = 26;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisaVenda
            // 
            this.txtPesquisaVenda.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPesquisaVenda.Location = new System.Drawing.Point(122, 83);
            this.txtPesquisaVenda.Name = "txtPesquisaVenda";
            this.txtPesquisaVenda.Size = new System.Drawing.Size(424, 25);
            this.txtPesquisaVenda.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtPesquisaVenda.TabIndex = 25;
            this.txtPesquisaVenda.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dtPickerInicial
            // 
            this.dtPickerInicial.Location = new System.Drawing.Point(412, 32);
            this.dtPickerInicial.Name = "dtPickerInicial";
            this.dtPickerInicial.Size = new System.Drawing.Size(211, 20);
            this.dtPickerInicial.TabIndex = 32;
            // 
            // dtPickerFinal
            // 
            this.dtPickerFinal.Location = new System.Drawing.Point(629, 32);
            this.dtPickerFinal.Name = "dtPickerFinal";
            this.dtPickerFinal.Size = new System.Drawing.Size(212, 20);
            this.dtPickerFinal.TabIndex = 33;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(741, 83);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 25);
            this.btnConsultar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnConsultar.TabIndex = 34;
            this.btnConsultar.Text = "Vendas por Data";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmRelatorioVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtPickerFinal);
            this.Controls.Add(this.dtPickerInicial);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.cmbGerarArquivo);
            this.Controls.Add(this.dvgVenda);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisaVenda);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioVenda";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Relatorio Venda";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.frmRelatorioVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private MetroFramework.Controls.MetroComboBox cmbGerarArquivo;
        private System.Windows.Forms.DataGridView dvgVenda;
        private MetroFramework.Controls.MetroButton btnGerar;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroTextBox txtPesquisaVenda;
        private System.Windows.Forms.DateTimePicker dtPickerInicial;
        private System.Windows.Forms.DateTimePicker dtPickerFinal;
        private MetroFramework.Controls.MetroButton btnConsultar;
    }
}