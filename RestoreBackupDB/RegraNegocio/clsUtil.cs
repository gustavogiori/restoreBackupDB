using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
namespace RestoreBackupDB.RegraNegocio
{
    public class clsUtil
    {

        public void controleErrorProviderTela(ErrorProvider erro,bool remover,Control controle)
        {
            if (remover == true)
            {
                erro.SetError(controle, "");
            }

            else
            {
                erro.SetError(controle, "Valor deve ser preenchido!");
            }
        }

        public bool verificarNulo (ErrorProvider erro , List<Control> controles)
        {
            bool possuiValorNulo = false;
            int cout = 0;
           
            foreach (Control controle in controles)
            {
                if (controle is TextBox)
                {
                    if (controle.Text == string.Empty)
                    {
                        cout++;
                        controleErrorProviderTela(erro, false, controle);
                    }

                    else
                    {
                      //  cout--;
                        controleErrorProviderTela(erro, true, controle);
                    }
                }

                if (controle is ComboBox)
                {
                    if (controle.Text==string.Empty)
                    {
                        controleErrorProviderTela(erro, false, controle);
                        cout++;
                    }

                    else
                    {
                        controleErrorProviderTela(erro, true, controle);
                       //cout--;
                    }
                }
            }

            if (cout > 0)
            {
                possuiValorNulo = true;
            }
            else
            {
                possuiValorNulo = false;
            }
            return possuiValorNulo;
        }
        public void mensagemErro(string texto)
        {
            MessageBox.Show(texto, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void mensagemSucesso(string texto)
        {
            MessageBox.Show(texto, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void mensagemAlerta(string texto)
        {
            MessageBox.Show(texto, "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        public void mensagemAviso(string texto)
        {
            MessageBox.Show(texto, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public string salvarArquivo(string extensaoPadrao,string titulo,string filtro,string nomeArquivo)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            string retorno ="";
            dialogo.AddExtension = true;
            dialogo.DefaultExt = extensaoPadrao;
            dialogo.Title = titulo;
            dialogo.Filter = filtro;
            dialogo.FileName = nomeArquivo ;
            dialogo.CheckPathExists = true;
          DialogResult result=  dialogo.ShowDialog();
            
            retorno = dialogo.FileName;
            
            if (result==DialogResult.Cancel)
            {
                retorno = "";
            }

            return retorno;
        }

        public string abrirDialigoArquivo(string filtro,string titulo)
        {
            string retorno = "";
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Filter = filtro;
            dialogo.Title = titulo;
            dialogo.ShowDialog();

            retorno = dialogo.FileName;

            if (retorno == string.Empty)
            {
                mensagemAviso("Processo cancelado!");
            }

            return retorno;
        }

        public string localDiretorio(FolderBrowserDialog dialogo )
        {
            string caminho = "";
            dialogo.ShowDialog();
            caminho = dialogo.SelectedPath;

            return caminho;
        }

        public string salvarDiretorio(SaveFileDialog dialogo, string filter, string titulo)
        {
            string name = "";

            dialogo.Filter = filter;
            dialogo.Title = titulo;
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
               

                if (name == string.Empty)
                {
                    mensagemAviso("Processo cancelado!");
                    return null;
                }

                else
                {
                    dialogo.FileName = name;
                }
            }
            return name;
        }
    }
}
