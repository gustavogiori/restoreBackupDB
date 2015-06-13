using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoreBackupDB.OperacoesForm
{
    public partial class frmOperacoes : Form
    {
        public frmOperacoes()
        {
            InitializeComponent();
        }

        private void btnLocalBackup_Click(object sender, EventArgs e)
        {
            RegraNegocio.clsUtil util = new RegraNegocio.clsUtil();
            txtCaminhoBackup.Text = util.salvarArquivo(".bak", "Restauração de base", "Arquivo Backup|*.bak*|Todos Arquivos|*.*", cmbDatabase.Text);
        }

        private void frmOperacoes_Load(object sender, EventArgs e)
        {
            RegraNegocio.clsConfiguracao config = new RegraNegocio.clsConfiguracao();
            config.listarBases(cmbDatabase);
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            RegraNegocio.clsConfiguracao config = new RegraNegocio.clsConfiguracao();
            RegraNegocio.clsUtil util = new RegraNegocio.clsUtil();
            List<Control> lst = new List<Control>();
            lst.Add(txtCaminhoBackup);
            lst.Add(cmbDatabase);

            if (util.verificarNulo(errorProvider1, lst) != true)
            {
                frmOperacoes frm = new frmOperacoes();
                config.realizarBackUp(progress, cmbDatabase, txtCaminhoBackup.Text, label4, frm);
            }

            else
            {

            }
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            RegraNegocio.clsUtil util = new RegraNegocio.clsUtil();

            string arquivo = "";
            arquivo = util.abrirDialigoArquivo("Arquivo Backup|*.bak| Todos arquivos|*.*", "Restauração");
            txtArquivo.Text = arquivo;

            DirectoryInfo info = new DirectoryInfo(arquivo);
            string arquivoPatch = info.Name.Remove(info.Name.Length-4);

            txtNomeBase.Text = arquivoPatch;

        }

        private void btnExecutarRestauracap_Click(object sender, EventArgs e)
        {
            try
            {

                RegraNegocio.clsUtil util = new RegraNegocio.clsUtil();
                List<Control> lst = new List<Control>();
                lst.Add(txtArquivo);
                lst.Add(txtNomeBase);

                if (util.verificarNulo(errorProvider1, lst))
                {

                }
                else
                {
                    frmOperacoes frm = new frmOperacoes();
                    RegraNegocio.clsConfiguracao config = new RegraNegocio.clsConfiguracao();
                    config.realizarRestauracao(progress, txtNomeBase, txtArquivo.Text, label4, frm, checkAcertaUsuario, checkVersao);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegraNegocio.clsUtil util = new RegraNegocio.clsUtil();
            List<Control> lst = new List<Control>();

            lst.Add(txtArquivo);
            lst.Add(txtCaminhoBackup);
            lst.Add(txtNomeBase);
            lst.Add(cmbDatabase);
            if (util.verificarNulo(errorProvider1, lst))
            {
                MessageBox.Show("Ainda há");
            }

            else
            {
                MessageBox.Show("não mais");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmOperacoes frm = new frmOperacoes();
            RegraNegocio.clsConfiguracao config = new RegraNegocio.clsConfiguracao();

            config.verificarVersao();
        }

        private void cmbDatabase_Click(object sender, EventArgs e)
        {
            RegraNegocio.clsConfiguracao config = new RegraNegocio.clsConfiguracao();

            config.listarBases(cmbDatabase);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            RegraNegocio.clsConfiguracao cls = new RegraNegocio.clsConfiguracao();
            cls.AcertaUsuario2008(txtNomeBase.Text);
        }
    }
}
