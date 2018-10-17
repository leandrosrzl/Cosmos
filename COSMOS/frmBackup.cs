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

namespace COSMOS
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int verificaPasta(string path) //verifica se a pasta de destino existe no computador ou dispositivo
        {
            try
            {
                if (Directory.Exists(path) == true)
                {
                    //MessageBox.Show("Deu certo, movendo backup", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Directory.CreateDirectory(path);
                }
                pgbBackup.Increment(10);
                return 1;
            }
            catch (Exception eta)
            {
                throw new Exception("Erro ao criar ou verificar a existência do diretório de destino. Tente novamente ou, se o problema persistir, entre em contato com nosso suporte.\n" + eta.Message);
            }
        }

        int procuraBanco(string path) //procura o banco dentro do diretório recebido
        {
            string nomeBanco = "COSMDB.FDB"; //Nome do banco de dados
            pgbBackup.Increment(10);

            if (File.Exists(path + "\\" + nomeBanco) == true)
            {
                pgbBackup.Increment(10);
                return 1;
            }
            else
            {
                pgbBackup.Increment(10);
                return 0;
            }
        }

        void iniciaBackup()
        {
            if (verificaPasta(txtCaminhoBackup.Text) == 1)
            {
                pgbBackup.Visible = true;
                pgbBackup.Increment(10);
                if (procuraBanco(Application.StartupPath) == 1)
                {
                    try
                    {
                        pgbBackup.Increment(10);
                        string nomeBanco = "\\COSMDB.FDB";
                        pgbBackup.Increment(10);
                        string pathOrigem = Application.StartupPath + nomeBanco;
                        pgbBackup.Increment(10);
                        string pathDestino = txtCaminhoBackup.Text + nomeBanco;
                        pgbBackup.Increment(10);
                        if (File.Exists(pathDestino) == true)
                        {
                            File.Delete(pathDestino);
                            pgbBackup.Increment(10);
                            File.Copy(pathOrigem, pathDestino);
                            pgbBackup.Increment(10);
                        }
                        else
                        {
                            File.Copy(pathOrigem, pathDestino);
                            pgbBackup.Increment(20);
                        }
                        MessageBox.Show("Arquivos copiados com sucesso. Verificar dentro do seu dispositivo no caminho\n" + pathDestino + ".", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ecb)
                    {
                        throw new Exception("Erro ao fazer backup, se o problema persistir, comunique o administrador do sistema.\n" + ecb.Message);
                    }
                }
            }
        }

        private void btnLupa_Click(object sender, EventArgs e)
        {
            if (fbdProcuraBackup.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoBackup.Text = fbdProcuraBackup.SelectedPath;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtCaminhoBackup.TextLength > 0)
            {
                iniciaBackup();
            }
            else
            {
                MessageBox.Show("Especifique o caminho para fazer o backup. Em caso de dúvidas, entre em contato com nosso suporte técnico. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {
            pgbBackup.Visible = false;
        }
    }
}
