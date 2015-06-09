using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Data;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Diagnostics;
using System.IO;
namespace RestoreBackupDB.RegraNegocio
{
  public class clsConfiguracao
  {
    public static Server srv;
    ProgressBar progressBar1 = new ProgressBar();
    Label lblProgress = new Label();
    clsUtil util = new clsUtil();
    Form frm = new Form();
    public void ProgressEventHandler(object sender, PercentCompleteEventArgs e)
    {
      Application.DoEvents();
      progressBar1.Value = e.Percent;
      lblProgress.Text = string.Format("{0} % do processo concluído", e.Percent.ToString());
      lblProgress.Update();
      
    }

    public void executarAcertaUsuario(string baseExecutar)
    {

      Database db = new Database(srv, baseExecutar);

      string parte1 = @"IF NOT EXISTS(SELECT * FROM MASTER.DBO.SYSLOGINS WHERE NAME = 'rm')
   CREATE LOGIN rm WITH PASSWORD = 'rm',CHECK_POLICY=OFF,DEFAULT_LANGUAGE = us_english";


      string parte2 = @"
 SP_DROPUSER SYSDBA;
 EXEC SP_CHANGEDBOWNER sa;
 

                                                  ";

      string parte3 = @"
EXEC SP_CHANGEDBOWNER rm
";

      string parte4 = @"IF NOT EXISTS(SELECT * FROM MASTER.DBO.SYSLOGINS WHERE NAME = 'sysdba')
   CREATE LOGIN sysdba WITH PASSWORD = 'masterkey',CHECK_POLICY=OFF,DEFAULT_LANGUAGE = us_english ";
      string parte5 = "sp_adduser sysdba,sysdba";

      string parte6 = @"GRANT SELECT ON GPARAMS TO sysdba;
GRANT SELECT , UPDATE ON GUSUARIO TO sysdba;
GRANT SELECT ON GPERMIS  TO sysdba;
GRANT SELECT ON GACESSO  TO sysdba;
GRANT SELECT ON GSISTEMA  TO sysdba;
GRANT SELECT ON GCOLIGADA  TO sysdba;
GRANT SELECT ON GUSRPERFIL TO sysdba;
GRANT SELECT ON GSERVICO TO sysdba;
GRANT SELECT ON GPARAMETROSSISTEMA TO sysdba;
GRANT SELECT,INSERT ON GDATALOG TO sysdba;
";
      db.ExecuteWithResults(parte1);
      db.ExecuteWithResults(parte2);
      db.ExecuteWithResults(parte3);
      db.ExecuteWithResults(parte4);
      db.ExecuteWithResults(parte5);
      db.ExecuteWithResults(parte6);
    }

    public void realizarRestauracao(ProgressBar process, TextBox txtBase, string arquivo, Label lbl, Form frm)
    {
      //
      this.progressBar1 = process;
      lblProgress = lbl;
      this.frm = frm;
      try
      {

        if (srv != null)
        {



          if (arquivo != string.Empty)
          {
            Database db = new Database(srv, txtBase.Text);

            Restore re_db = new Restore();


            db.Create();


            re_db.Action = RestoreActionType.Database;
            re_db.Database = txtBase.Text; //cmbDatabase.SelectedItem.ToString();
            BackupDeviceItem bk_item = new BackupDeviceItem(arquivo, DeviceType.File);
            re_db.Devices.Add(bk_item);
            re_db.ReplaceDatabase = true;

            this.progressBar1.Value = 0;
            this.progressBar1.Maximum = 100;
            //this.progressBar1.Value = 10;

            re_db.PercentCompleteNotification = 10;
            re_db.ReplaceDatabase = true;
            re_db.PercentComplete += new PercentCompleteEventHandler(ProgressEventHandler);

            re_db.SqlRestore(srv);

            executarAcertaUsuario(txtBase.Text);
            progressBar1.Value = 0;
            util.mensagemSucesso("Base " + txtBase.Text + " restaurada com sucesso!");
            lblProgress.Text = "";
          }
        }
        else
        {
          MessageBox.Show("A connection to a SQL server was not established.", "Not Connected to Server", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    public void realizarBackUp(ProgressBar progress, ComboBox cmbDatabase, string arquivo, Label lbl, Form frm)
    {
      this.frm = frm;
      lblProgress = lbl;
      clsUtil util = new clsUtil();
      this.progressBar1 = progress;
      Database db = new Database(srv, cmbDatabase.SelectedItem.ToString());
      Backup db_bk = new Backup();
      db_bk.Action = BackupActionType.Database;
      db_bk.Database = cmbDatabase.SelectedItem.ToString();
      //  Directory.CreateDirectory(@"C:\d");
      DataSet consultaRetornarCaminhoPadrao = db.ExecuteWithResults(@"EXEC  master.dbo.xp_instance_regread  
 N'HKEY_LOCAL_MACHINE', N'Software\Microsoft\MSSQLServer\MSSQLServer',N'BackupDirectory'
 ");

      string caminhoPadrao = consultaRetornarCaminhoPadrao.Tables[0].Rows[0]["Data"].ToString();
      FileInfo propriedadesArquivo = new FileInfo(arquivo);
      string caminhoOrigem = string.Format(caminhoPadrao + "\\" + propriedadesArquivo.Name);
      BackupDeviceItem bkitem = new BackupDeviceItem(caminhoOrigem, DeviceType.File);
      db_bk.Devices.Add(bkitem);


      this.progressBar1.Value = 0;
      this.progressBar1.Maximum = 100;
      this.progressBar1.Value = 10;

      db_bk.PercentCompleteNotification = 10;
      db_bk.PercentComplete += new PercentCompleteEventHandler(ProgressEventHandler);

      db_bk.SqlBackup(srv);

      string caminhoDestino = arquivo;

      copiarBackupCaminhoUsuario(caminhoDestino, caminhoOrigem);
      util.mensagemSucesso("Backup realizado com sucesso!");
      progressBar1.Value = 0;
      lblProgress.Text = "";
    }

    public void copiarBackupCaminhoUsuario(string caminhoUsuario, string caminhoPadrao)
        {
          try
          {

            if (File.Exists(caminhoUsuario))
            {
              File.Delete(caminhoUsuario);
            }
            File.Move(caminhoPadrao, caminhoUsuario);
          }

          catch (Exception ex)
          {
            throw new ArgumentException(ex.Message);
          }
        }

    public void listarBases(ComboBox cbBases)
    {
      foreach (Database db in srv.Databases)
      {
        //cmbdatabse in which all database realted to server willl be loaded
        cbBases.Items.Add(db.Name);
      }
    }

    public void testarConexao(ServerConnection srvcon)
    {
      try
      {
        srvcon.Connect();
      }

      catch (Exception ex)
      {
        srvcon.Disconnect();
        throw new ArgumentException("Erro ao conectar ao servidor verifique os dados informados e tente novamente !");
      }

    }

    public bool conectarServidor(ComboBox cbServer, CheckBox checkAutenticacao, TextBox txtLogin, TextBox txtSenha)
    {
      bool conectou = false;

      try
      {
        if (cbServer.Text != null && cbServer.Text != "")
        {
          ServerConnection srvcon = new ServerConnection(cbServer.Text);



          if (checkAutenticacao.Checked == true)
          {
            testarConexao(srvcon);
            // srvcon.ServerInstance =cmbsrv_name.SelectedText ;

            //  srvcon.LoginSecure = false;
            srvcon.ConnectionString = "Data Source=" + cbServer.Text + " ;Integrated Security=True";
            srv = new Server(srvcon);
            string teste = srv.Status.ToString();

          }

          else
          {

            srvcon.LoginSecure = false;
            srvcon.Login = txtLogin.Text;
            srvcon.Password = txtSenha.Text;
            testarConexao(srvcon);
            srv = new Server(srvcon);
          }

          conectou = true;
          util.mensagemSucesso("Conectado com sucesso!");
        }
        else if (cbServer.Text == string.Empty)
        {
          util.mensagemAlerta("Favor selecionar o servidor o digitar o nome do servidor!");
          conectou = false;
        }
      }
      catch (Exception ex)
      {
        util.mensagemErro(ex.Message);
        conectou = false;
      }
      return conectou;
    }

    public void validarTextBoxEnable(CheckBox cbAutenticacao, TextBox txtLogin, TextBox txtSenha)
    {
      if (cbAutenticacao.Checked)
      {
        txtLogin.Enabled = false;
        txtSenha.Enabled = false;
      }

      else
      {
        txtLogin.Enabled = true;
        txtSenha.Enabled = true;
      }

    }
    public void listarServer(ComboBox cbServer)
    {
      DataTable dt = SmoApplication.EnumAvailableSqlServers(true);
      if (dt.Rows.Count > 0)
      {
        // Loop through each server in the DataTable
        foreach (DataRow dr in dt.Rows)
        {
          cbServer.Items.Add(dr["Name"]);
        }
      }
    }
  }
}
