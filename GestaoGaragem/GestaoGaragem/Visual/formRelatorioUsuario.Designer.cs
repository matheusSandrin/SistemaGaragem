namespace GestaoGaragem.Visual
{
    partial class formRelatorioUsuario
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
            this.txtPesquisaUsuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.dvgUsuario = new System.Windows.Forms.DataGridView();
            this.cmbGerarArquivo = new MetroFramework.Controls.MetroComboBox();
            this.btnGerar = new MetroFramework.Controls.MetroButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisaUsuario
            // 
            this.txtPesquisaUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPesquisaUsuario.Location = new System.Drawing.Point(115, 87);
            this.txtPesquisaUsuario.Name = "txtPesquisaUsuario";
            this.txtPesquisaUsuario.Size = new System.Drawing.Size(424, 25);
            this.txtPesquisaUsuario.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtPesquisaUsuario.TabIndex = 3;
            this.txtPesquisaUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(210, 239);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Pesquisar";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(734, 87);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 25);
            this.btnPesquisar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(734, 459);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 25);
            this.btnVoltar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dvgUsuario
            // 
            this.dvgUsuario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuario.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dvgUsuario.Location = new System.Drawing.Point(16, 131);
            this.dvgUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dvgUsuario.Name = "dvgUsuario";
            this.dvgUsuario.RowHeadersVisible = false;
            this.dvgUsuario.RowTemplate.Height = 28;
            this.dvgUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgUsuario.Size = new System.Drawing.Size(819, 322);
            this.dvgUsuario.TabIndex = 8;
            this.dvgUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUsuario_CellDoubleClick);
            // 
            // cmbGerarArquivo
            // 
            this.cmbGerarArquivo.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.cmbGerarArquivo.FormattingEnabled = true;
            this.cmbGerarArquivo.ItemHeight = 29;
            this.cmbGerarArquivo.Location = new System.Drawing.Point(16, 459);
            this.cmbGerarArquivo.Name = "cmbGerarArquivo";
            this.cmbGerarArquivo.Size = new System.Drawing.Size(121, 35);
            this.cmbGerarArquivo.Style = MetroFramework.MetroColorStyle.Yellow;
            this.cmbGerarArquivo.TabIndex = 9;
            this.cmbGerarArquivo.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(160, 459);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(100, 25);
            this.btnGerar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btnGerar.TabIndex = 7;
            this.btnGerar.Text = "Gerar ";
            this.btnGerar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 87);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(95, 22);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "Pesquisar";
            // 
            // formRelatorioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.cmbGerarArquivo);
            this.Controls.Add(this.dvgUsuario);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisaUsuario);
            this.Controls.Add(this.metroLabel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formRelatorioUsuario";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Formulário de Usuário";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.formRelatorioUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtPesquisaUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private System.Windows.Forms.DataGridView dvgUsuario;
        private MetroFramework.Controls.MetroComboBox cmbGerarArquivo;
        private MetroFramework.Controls.MetroButton btnGerar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}