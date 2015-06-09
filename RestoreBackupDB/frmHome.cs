using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoreBackupDB
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            RegraNegocio.clsConfiguracao config = new RegraNegocio.clsConfiguracao();
            config.listarServer(cbServer);
        }

        private void cbAutenticacao_CheckedChanged(object sender, EventArgs e)
        {
            RegraNegocio.clsConfiguracao config = new RegraNegocio.clsConfiguracao();
            config.validarTextBoxEnable(cbAutenticacao, txtLogin, txtSenha);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            RegraNegocio.clsUtil util = new RegraNegocio.clsUtil();
            RegraNegocio.clsConfiguracao config = new RegraNegocio.clsConfiguracao();
            List<Control> lst = new List<Control>();
            lst.Add(txtLogin);
            lst.Add(txtSenha);

            if (cbAutenticacao.Checked == false)
            {
                if (util.verificarNulo(errorProvider1, lst))
                {

                }

                else
                {
                    errorProvider1.Clear();
                    
                    if (config.conectarServidor(cbServer, cbAutenticacao, txtLogin, txtSenha))
                    {
                        OperacoesForm.frmOperacoes frm = new OperacoesForm.frmOperacoes();
                        frm.ShowDialog();
                    }
                }
            }
            else
            {
                errorProvider1.Clear();
                if (config.conectarServidor(cbServer, cbAutenticacao, txtLogin, txtSenha))
                {
                    OperacoesForm.frmOperacoes frm = new OperacoesForm.frmOperacoes();
                    frm.ShowDialog();
                }
            }
        }
    }
}
