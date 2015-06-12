namespace RestoreBackupDB.OperacoesForm
{
    partial class frmOperacoes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperacoes));
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaminhoBackup = new System.Windows.Forms.TextBox();
            this.btnLocalBackup = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkAcertaUsuario = new System.Windows.Forms.CheckBox();
            this.checkVersao = new System.Windows.Forms.CheckBox();
            this.btnExecutarRestauracap = new System.Windows.Forms.Button();
            this.lblNomeBase = new System.Windows.Forms.Label();
            this.txtNomeBase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bases Backup";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabase.FormattingEnabled = true;
            this.cmbDatabase.Location = new System.Drawing.Point(123, 28);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(160, 21);
            this.cmbDatabase.TabIndex = 15;
            this.cmbDatabase.Click += new System.EventHandler(this.cmbDatabase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Local Backup";
            // 
            // txtCaminhoBackup
            // 
            this.txtCaminhoBackup.Location = new System.Drawing.Point(123, 71);
            this.txtCaminhoBackup.Name = "txtCaminhoBackup";
            this.txtCaminhoBackup.Size = new System.Drawing.Size(160, 20);
            this.txtCaminhoBackup.TabIndex = 17;
            // 
            // btnLocalBackup
            // 
            this.btnLocalBackup.Location = new System.Drawing.Point(305, 71);
            this.btnLocalBackup.Name = "btnLocalBackup";
            this.btnLocalBackup.Size = new System.Drawing.Size(27, 23);
            this.btnLocalBackup.TabIndex = 18;
            this.btnLocalBackup.Text = "...";
            this.btnLocalBackup.UseVisualStyleBackColor = true;
            this.btnLocalBackup.Click += new System.EventHandler(this.btnLocalBackup_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(133, 116);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(110, 23);
            this.btnExecutar.TabIndex = 20;
            this.btnExecutar.Text = "Executar backup";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDatabase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnExecutar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLocalBackup);
            this.groupBox1.Controls.Add(this.txtCaminhoBackup);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 159);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkAcertaUsuario);
            this.groupBox2.Controls.Add(this.checkVersao);
            this.groupBox2.Controls.Add(this.btnExecutarRestauracap);
            this.groupBox2.Controls.Add(this.lblNomeBase);
            this.groupBox2.Controls.Add(this.txtNomeBase);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtArquivo);
            this.groupBox2.Controls.Add(this.btnArquivo);
            this.groupBox2.Location = new System.Drawing.Point(388, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 159);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restauração";
            // 
            // checkAcertaUsuario
            // 
            this.checkAcertaUsuario.AutoSize = true;
            this.checkAcertaUsuario.Location = new System.Drawing.Point(353, 47);
            this.checkAcertaUsuario.Name = "checkAcertaUsuario";
            this.checkAcertaUsuario.Size = new System.Drawing.Size(139, 17);
            this.checkAcertaUsuario.TabIndex = 27;
            this.checkAcertaUsuario.Text = "Executar Acerta usuário";
            this.checkAcertaUsuario.UseVisualStyleBackColor = true;
            // 
            // checkVersao
            // 
            this.checkVersao.AutoSize = true;
            this.checkVersao.Location = new System.Drawing.Point(353, 24);
            this.checkVersao.Name = "checkVersao";
            this.checkVersao.Size = new System.Drawing.Size(74, 17);
            this.checkVersao.TabIndex = 26;
            this.checkVersao.Text = "Versão 12";
            this.checkVersao.UseVisualStyleBackColor = true;
            // 
            // btnExecutarRestauracap
            // 
            this.btnExecutarRestauracap.Location = new System.Drawing.Point(128, 116);
            this.btnExecutarRestauracap.Name = "btnExecutarRestauracap";
            this.btnExecutarRestauracap.Size = new System.Drawing.Size(151, 23);
            this.btnExecutarRestauracap.TabIndex = 21;
            this.btnExecutarRestauracap.Text = "Executar Restauracação";
            this.btnExecutarRestauracap.UseVisualStyleBackColor = true;
            this.btnExecutarRestauracap.Click += new System.EventHandler(this.btnExecutarRestauracap_Click);
            // 
            // lblNomeBase
            // 
            this.lblNomeBase.AutoSize = true;
            this.lblNomeBase.Location = new System.Drawing.Point(12, 74);
            this.lblNomeBase.Name = "lblNomeBase";
            this.lblNomeBase.Size = new System.Drawing.Size(76, 13);
            this.lblNomeBase.TabIndex = 24;
            this.lblNomeBase.Text = "Nome da base";
            // 
            // txtNomeBase
            // 
            this.txtNomeBase.Location = new System.Drawing.Point(128, 71);
            this.txtNomeBase.Name = "txtNomeBase";
            this.txtNomeBase.Size = new System.Drawing.Size(160, 20);
            this.txtNomeBase.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Base a ser restaurada";
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(128, 25);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(160, 20);
            this.txtArquivo.TabIndex = 22;
            // 
            // btnArquivo
            // 
            this.btnArquivo.Location = new System.Drawing.Point(310, 25);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(27, 23);
            this.btnArquivo.TabIndex = 23;
            this.btnArquivo.Text = "...";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 23;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(1, 239);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(748, 23);
            this.progress.TabIndex = 24;
            // 
            // frmOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 315);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOperacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOperacoes";
            this.Load += new System.EventHandler(this.frmOperacoes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaminhoBackup;
        private System.Windows.Forms.Button btnLocalBackup;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExecutarRestauracap;
        private System.Windows.Forms.Label lblNomeBase;
        private System.Windows.Forms.TextBox txtNomeBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.CheckBox checkVersao;
        private System.Windows.Forms.CheckBox checkAcertaUsuario;
    }
}