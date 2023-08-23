namespace GestaoGaragem.Visual
{
    partial class frmRelatorioCliente
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
            this.dvgCliente = new System.Windows.Forms.DataGridView();
            this.btnGerar = new MetroFramework.Controls.MetroButton();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.txtPesquisaCliente = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(18, 86);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(95, 22);
            this.bunifuCustomLabel1.TabIndex = 17;
            this.bunifuCustomLabel1.Text = "Pesquisar";
            // 
            // cmbGerarArquivo
            // 
            this.cmbGerarArquivo.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.cmbGerarArquivo.FormattingEnabled = true;
            this.cmbGerarArquivo.ItemHeight = 29;
            this.cmbGerarArquivo.Location = new System.Drawing.Point(22, 458);
            this.cmbGerarArquivo.Name = "cmbGerarArquivo";
            this.cmbGerarArquivo.Size = new System.Drawing.Size(121, 35);
            this.cmbGerarArquivo.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cmbGerarArquivo.TabIndex = 16;
            this.cmbGerarArquivo.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // dvgCliente
            // 
            this.dvgCliente.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCliente.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dvgCliente.Location = new System.Drawing.Point(21, 131);
            this.dvgCliente.Margin = new System.Windows.Forms.Padding(2);
            this.dvgCliente.Name = "dvgCliente";
            this.dvgCliente.RowHeadersVisible = false;
            this.dvgCliente.RowTemplate.Height = 28;
            this.dvgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCliente.Size = new System.Drawing.Size(819, 322);
            this.dvgCliente.TabIndex = 15;
            this.dvgCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCliente_CellDoubleClick);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(166, 458);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(100, 25);
            this.btnGerar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnGerar.TabIndex = 13;
            this.btnGerar.Text = "Gerar ";
            this.btnGerar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(740, 458);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 25);
            this.btnVoltar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(740, 86);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 25);
            this.btnPesquisar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisaCliente
            // 
            this.txtPesquisaCliente.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPesquisaCliente.Location = new System.Drawing.Point(121, 86);
            this.txtPesquisaCliente.Name = "txtPesquisaCliente";
            this.txtPesquisaCliente.Size = new System.Drawing.Size(424, 25);
            this.txtPesquisaCliente.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtPesquisaCliente.TabIndex = 11;
            this.txtPesquisaCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // frmRelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.cmbGerarArquivo);
            this.Controls.Add(this.dvgCliente);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisaCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioCliente";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Relatório Cliente";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.frmRelatorioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private MetroFramework.Controls.MetroComboBox cmbGerarArquivo;
        private System.Windows.Forms.DataGridView dvgCliente;
        private MetroFramework.Controls.MetroButton btnGerar;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroTextBox txtPesquisaCliente;
    }
}