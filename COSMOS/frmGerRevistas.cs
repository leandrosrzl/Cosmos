using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSMOS
{
    public partial class frmGerRevistas : Form
    {
        clRevistas revistas;
        clProdutos produtos;
        frmIncRevistas novaRevista;
        int idusu;

        public frmGerRevistas(int idUsu)
        {
            InitializeComponent();
            idusu = idUsu;
        }

        public void pvListarRevistasAtivas()
        {
            revistas = new clRevistas();
            dtgRevistas.DataSource = revistas.listarRevistasAtivas();
        }

        private void pvListarProdutosPorRevista()
        {
            produtos = new clProdutos();
            //MessageBox.Show(linhaClicada.ToString());
            dtgProdutosPorRevista.DataSource = produtos.listarProdutosComFiltro(0, "", "", Convert.ToInt32(dtgRevistas.CurrentRow.Cells["ID_REV"].Value));
        }

        private void pvListarTodasRevistas()
        {
            revistas = new clRevistas();
            dtgRevistas.DataSource = revistas.listarTodasRevistas();
        }

        private void pvListarRevistasInativas()
        {
            revistas = new clRevistas();
            dtgRevistas.DataSource = revistas.listarRevistasInativas();
        }

        private void pvExcluirRevistas()
        {
            revistas = new clRevistas();
            revistas.excluirRevista(Convert.ToInt32(dtgRevistas.CurrentRow.Cells["ID_REV"].Value));
        }

        private void pvListarRevistasComFiltro(string ativo)
        {
            if (txtCodigo.Text == "")
            {
                revistas = new clRevistas();
                dtgRevistas.DataSource = revistas.listarRevistasComFiltro(0, txtRevista.Text, ativo);
            }
            else
            {
                revistas = new clRevistas();
                dtgRevistas.DataSource = revistas.listarRevistasComFiltro(Convert.ToInt32(txtCodigo.Text), txtRevista.Text, ativo);
            }
        }

        private void frmGerRevistas_Load(object sender, EventArgs e)
        {
            pvListarRevistasAtivas();
            txtCodigo.Text = null;
            txtRevista.Text = null;
        }

        private void rbUsuAtivo_CheckedChanged(object sender, EventArgs e)
        {
            pvListarRevistasAtivas();
        }

        private void rbUsuTodos_CheckedChanged(object sender, EventArgs e)
        {
            pvListarTodasRevistas();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            novaRevista = new frmIncRevistas(this, "INCLUIR", 0, idusu);
            novaRevista.Show();
        }

        private void btnEditarGrid_Click(object sender, EventArgs e)
        {
            if (dtgRevistas.Rows.Count > 0)
            {
                novaRevista = new frmIncRevistas(this, "EDITAR", Convert.ToInt32(dtgRevistas.CurrentRow.Cells["ID_REV"].Value), Convert.ToInt32(idusu));
                novaRevista.Show();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dtgRevistas.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir essa revista? Essa ação é irreversível!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pvExcluirRevistas();
                    MessageBox.Show("Revista excluída com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rbUsuAtivo.Checked = true;
                    pvListarRevistasAtivas();
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbUsuInativo_CheckedChanged(object sender, EventArgs e)
        {
            pvListarRevistasInativas();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtCodigo.Text = null;
            txtRevista.Text = null;
            rbUsuAtivo.Checked = true;
            pvListarRevistasAtivas();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text == "" & txtRevista.Text == "")||(txtCodigo.Text == null & txtRevista.Text == null))
            {
                pvListarRevistasAtivas();
                rbUsuAtivo.Checked = true;
            }
            else
            {
                if (rbUsuAtivo.Checked == true)
                {
                    pvListarRevistasComFiltro("S");
                }
                else if (rbUsuInativo.Checked == true)
                {
                    pvListarRevistasComFiltro("N");
                }
                else
                {
                    pvListarRevistasComFiltro("");
                }
            }
        } // Fim btnFiltrar_Click

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            tbcRevistas.SelectedTab = tbpRevistas;
            lblRevistaSelecionada.Visible = false;
        }

        private void tbcRevistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcRevistas.SelectedTab == tbpProdutosVinculados)
            {
                pvListarProdutosPorRevista();
                lblRevistaSelecionada.Text = "Revista selecionada: " + dtgRevistas.CurrentRow.Cells["REVISTA"].Value.ToString();
                lblRevistaSelecionada.Visible = true;
            }
            else
            {
                lblRevistaSelecionada.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtgProdutosPorRevista.SelectedRows.Count.ToString());
        }

        private void btnExcluirTodos_Click(object sender, EventArgs e)
        {
            if(dtgProdutosPorRevista.Rows.Count > 0)
            {
                int i;
                if(MessageBox.Show("Deseja realmente excluir esses " + dtgProdutosPorRevista.Rows.Count.ToString() + " produtos?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (i = 0; i < dtgRevistas.Rows.Count; i++)
                    {
                        dtgProdutosPorRevista.Rows[i].Cells["PATIVO"].Value = "N";
                        produtos = new clProdutos();
                        produtos.excluirProdutos(Convert.ToInt32(dtgProdutosPorRevista.Rows[i].Cells["ID_PRO"].Value));
                    }
                    MessageBox.Show(i + " produtos excluídos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Não há registro para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dtgProdutosPorRevista.Rows.Count > 0)
            {
                int i;
                if (MessageBox.Show("Deseja realmente reativar esses " + dtgProdutosPorRevista.Rows.Count.ToString() + " produtos?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (i = 0; i < dtgRevistas.Rows.Count; i++)
                    {
                        dtgProdutosPorRevista.Rows[i].Cells["PATIVO"].Value = "S";
                        produtos = new clProdutos();
                        produtos.reativarProdutos(Convert.ToInt32(dtgProdutosPorRevista.Rows[i].Cells["ID_PRO"].Value));
                    }
                    MessageBox.Show(i + " produtos reativados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Não há registro para reativar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
