using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSMOS
{
    public partial class frmPrincipal : Form
    {
        public string[] vetor;

        frmIncVenda incVendas;

        public frmPrincipal(string[] v)
        {
            InitializeComponent();

            vetor = v;
            /*
             * vetor[0] = idusu
             * vetor[1] = nome usu
             * vetor[2] = computador logado
             * vetor[3] = senha
             */
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = this.BackColor;
                    
                    break;
                }
            }

            if (vetor[0] == Convert.ToString(1))
            {
                testeToolStripMenuItem.Visible = true;
            }

            tsslUsuario.Text = "USUÁRIO: "+vetor[1].ToString(); //preenche com o usuario logado no toolstrip
            tsslComputador.Text = "COMPUTADOR: "+vetor[2].ToString(); //preenche com o computador logado no toolstrip
            tsslDataHora.Text = "DATA/HORA: "+DateTime.Now.ToString(); //preenche com a data e hora no toolstrip
            
            tmrHora.Enabled = true;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerRevistas revistas = new frmGerRevistas(Convert.ToInt32(vetor[0]));
            revistas.MdiParent = this;
            revistas.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerProdutos produtos = new frmGerProdutos(incVendas,Convert.ToInt32(vetor[0]), "","");
            produtos.MdiParent = this;
            produtos.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerVendedores vendedores = new frmGerVendedores(Convert.ToInt32(vetor[0]));
            vendedores.MdiParent = this;
            vendedores.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerVendas vendas = new frmGerVendas(Convert.ToInt32(vetor[0]));
            vendas.MdiParent = this;
            vendas.Show();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            tsslDataHora.Text = DateTime.Now.ToString();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            frmAlterarSenha alterarSenha = new frmAlterarSenha(Convert.ToInt32(vetor[0].ToString()), vetor[1].ToString(), vetor[3].ToString());
            //alterarSenha.MdiParent = this;
            alterarSenha.ShowDialog();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fmr = new Form1();
            fmr.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 sobre = new AboutBox1();
            sobre.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackup backup = new frmBackup();
            backup.ShowDialog();
        }
    }
}
