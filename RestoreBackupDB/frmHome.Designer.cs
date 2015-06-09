namespace RestoreBackupDB
{
    partial class frmHome
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
      this.cbServer = new System.Windows.Forms.ComboBox();
      this.lblServer = new System.Windows.Forms.Label();
      this.txtLogin = new System.Windows.Forms.TextBox();
      this.txtSenha = new System.Windows.Forms.TextBox();
      this.cbAutenticacao = new System.Windows.Forms.CheckBox();
      this.lblLogin = new System.Windows.Forms.Label();
      this.lblSenha = new System.Windows.Forms.Label();
      this.btnConectar = new System.Windows.Forms.Button();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // cbServer
      // 
      this.cbServer.FormattingEnabled = true;
      this.cbServer.Location = new System.Drawing.Point(102, 24);
      this.cbServer.Name = "cbServer";
      this.cbServer.Size = new System.Drawing.Size(147, 21);
      this.cbServer.TabIndex = 0;
      // 
      // lblServer
      // 
      this.lblServer.AutoSize = true;
      this.lblServer.Location = new System.Drawing.Point(41, 27);
      this.lblServer.Name = "lblServer";
      this.lblServer.Size = new System.Drawing.Size(46, 13);
      this.lblServer.TabIndex = 1;
      this.lblServer.Text = "Servidor";
      // 
      // txtLogin
      // 
      this.txtLogin.Location = new System.Drawing.Point(102, 109);
      this.txtLogin.Name = "txtLogin";
      this.txtLogin.Size = new System.Drawing.Size(147, 20);
      this.txtLogin.TabIndex = 3;
      // 
      // txtSenha
      // 
      this.txtSenha.Location = new System.Drawing.Point(102, 149);
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.PasswordChar = '*';
      this.txtSenha.Size = new System.Drawing.Size(147, 20);
      this.txtSenha.TabIndex = 4;
      // 
      // cbAutenticacao
      // 
      this.cbAutenticacao.AutoSize = true;
      this.cbAutenticacao.Location = new System.Drawing.Point(102, 67);
      this.cbAutenticacao.Name = "cbAutenticacao";
      this.cbAutenticacao.Size = new System.Drawing.Size(151, 17);
      this.cbAutenticacao.TabIndex = 5;
      this.cbAutenticacao.Text = "Autenticação do Windows";
      this.cbAutenticacao.UseVisualStyleBackColor = true;
      this.cbAutenticacao.CheckedChanged += new System.EventHandler(this.cbAutenticacao_CheckedChanged);
      // 
      // lblLogin
      // 
      this.lblLogin.AutoSize = true;
      this.lblLogin.Location = new System.Drawing.Point(41, 112);
      this.lblLogin.Name = "lblLogin";
      this.lblLogin.Size = new System.Drawing.Size(33, 13);
      this.lblLogin.TabIndex = 6;
      this.lblLogin.Text = "Login";
      // 
      // lblSenha
      // 
      this.lblSenha.AutoSize = true;
      this.lblSenha.Location = new System.Drawing.Point(41, 152);
      this.lblSenha.Name = "lblSenha";
      this.lblSenha.Size = new System.Drawing.Size(38, 13);
      this.lblSenha.TabIndex = 7;
      this.lblSenha.Text = "Senha";
      // 
      // btnConectar
      // 
      this.btnConectar.Location = new System.Drawing.Point(132, 195);
      this.btnConectar.Name = "btnConectar";
      this.btnConectar.Size = new System.Drawing.Size(75, 23);
      this.btnConectar.TabIndex = 8;
      this.btnConectar.Text = "Conectar";
      this.btnConectar.UseVisualStyleBackColor = true;
      this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // frmHome
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(324, 261);
      this.Controls.Add(this.btnConectar);
      this.Controls.Add(this.lblSenha);
      this.Controls.Add(this.lblLogin);
      this.Controls.Add(this.cbAutenticacao);
      this.Controls.Add(this.txtSenha);
      this.Controls.Add(this.txtLogin);
      this.Controls.Add(this.lblServer);
      this.Controls.Add(this.cbServer);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmHome";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Home";
      this.Load += new System.EventHandler(this.frmHome_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox cbAutenticacao;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

