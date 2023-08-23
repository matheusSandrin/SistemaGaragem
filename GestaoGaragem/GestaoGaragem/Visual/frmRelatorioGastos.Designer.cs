namespace GestaoGaragem.Visual
{
    partial class frmRelatorioGastos
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
            this.dvgGastos = new System.Windows.Forms.DataGridView();
            this.btnGerar = new MetroFramework.Controls.MetroButton();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.txtPesquisaVeiculo = new MetroFramework.Controls.MetroTextBox();
            this.btnConsultar = new MetroFramework.Controls.MetroButton();
            this.dtPickerFinal = new System.Windows.Forms.DateTimePicker();
            this.dtPickerInicial = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(19, 73);
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
            this.cmbGerarArquivo.Location = new System.Drawing.Point(23, 445);
            this.cmbGerarArquivo.Name = "cmbGerarArquivo";
            this.cmbGerarArquivo.Size = new System.Drawing.Size(121, 35);
            this.cmbGerarArquivo.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cmbGerarArquivo.TabIndex = 30;
            this.cmbGerarArquivo.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dvgGastos
            // 
            this.dvgGastos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgGastos.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dvgGastos.Location = new System.Drawing.Point(22, 118);
            this.dvgGastos.Margin = new System.Windows.Forms.Padding(2);
            this.dvgGastos.Name = "dvgGastos";
            this.dvgGastos.RowHeadersVisible = false;
            this.dvgGastos.RowTemplate.Height = 28;
            this.dvgGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgGastos.Size = new System.Drawing.Size(819, 322);
            this.dvgGastos.TabIndex = 29;
            this.dvgGastos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgGastos_CellDoubleClick);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(167, 445);
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
            this.btnVoltar.Location = new System.Drawing.Point(741, 445);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 25);
            this.btnVoltar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnVoltar.TabIndex = 28;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(579, 73);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 25);
            this.btnPesquisar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnPesquisar.TabIndex = 26;
            this.btnPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisaVeiculo
            // 
            this.txtPesquisaVeiculo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPesquisaVeiculo.Location = new System.Drawing.Point(122, 73);
            this.txtPesquisaVeiculo.Name = "txtPesquisaVeiculo";
            this.txtPesquisaVeiculo.Size = new System.Drawing.Size(424, 25);
            this.txtPesquisaVeiculo.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtPesquisaVeiculo.TabIndex = 25;
            this.txtPesquisaVeiculo.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(741, 73);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 25);
            this.btnConsultar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnConsultar.TabIndex = 40;
            this.btnConsultar.Text = "Gastos por Data";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtPickerFinal
            // 
            this.dtPickerFinal.Location = new System.Drawing.Point(629, 19);
            this.dtPickerFinal.Name = "dtPickerFinal";
            this.dtPickerFinal.Size = new System.Drawing.Size(212, 20);
            this.dtPickerFinal.TabIndex = 39;
            // 
            // dtPickerInicial
            // 
            this.dtPickerInicial.Location = new System.Drawing.Point(412, 19);
            this.dtPickerInicial.Name = "dtPickerInicial";
            this.dtPickerInicial.Size = new System.Drawing.Size(211, 20);
            this.dtPickerInicial.TabIndex = 38;
            // 
            // frmRelatorioGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtPickerFinal);
            this.Controls.Add(this.dtPickerInicial);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.cmbGerarArquivo);
            this.Controls.Add(this.dvgGastos);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisaVeiculo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioGastos";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Relatório Gastos";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.frmRelatorioGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private MetroFramework.Controls.MetroComboBox cmbGerarArquivo;
        private System.Windows.Forms.DataGridView dvgGastos;
        private MetroFramework.Controls.MetroButton btnGerar;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroTextBox txtPesquisaVeiculo;
        private MetroFramework.Controls.MetroButton btnConsultar;
        private System.Windows.Forms.DateTimePicker dtPickerFinal;
        private System.Windows.Forms.DateTimePicker dtPickerInicial;
    }
}