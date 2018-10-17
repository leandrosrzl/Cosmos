using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using FirebirdSql.Data.FirebirdClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSMOS
{
    public partial class frmGerProdutos : Form
    {
        clProdutos produtos;
        frmIncProdutos novoProduto;
        frmIncVenda incVendas;
        DataTable dadosTabela;
        int idusu, index, idrev;
        string codref, tpVar;

        public frmGerProdutos(frmIncVenda frmVenda,int idUsu, string cod_ref, string tp_Var)
        {
            InitializeComponent();
            incVendas = frmVenda;
            idusu = idUsu;
            codref = cod_ref; //se for "", é pelo gerenciador de produto, se for diferente, é pesquisa dentro das vendas pelo valor ref/cod
            tp_Var = tpVar; //Se for REF é string, se for COD é int.
        }

        private void pvExcluirProdutos()
        {
            produtos = new clProdutos();
            produtos.excluirProdutos(Convert.ToInt32(dtgProdutos.CurrentRow.Cells["ID_PRO"].Value));
        }

        public void pvListarProdutosAtivos()
        {
            produtos = new clProdutos();
            dtgProdutos.DataSource = produtos.listarProdutosAtivos();
        }

        private void pvListarProdutosComFiltro(string ativo)
        {
            if (txtCodigo.Text == "")
            {
                produtos = new clProdutos();
                dtgProdutos.DataSource = produtos.listarProdutosComFiltro(0, txtProduto.Text, ativo, idrev);
            }
            else
            {
                produtos = new clProdutos();
                dtgProdutos.DataSource = produtos.listarProdutosComFiltro(Convert.ToInt32(txtCodigo.Text), txtProduto.Text, ativo, idrev);
            }
        }

        private void pvPreencherCombo()
        {
            produtos = new clProdutos();
            dadosTabela = new DataTable();
            dtgT.DataSource = dadosTabela = produtos.listarRevistas();

            cmbRevistas.DataSource = dadosTabela;
            cmbRevistas.DisplayMember = dadosTabela.Columns["REVISTA"].ToString();

            //try
            //{
            //    for (int i = 1; i < dadosTabela.Rows.Count; i++)
            //    {
            //        cmbRevistas.Items.Add(dadosTabela.Rows[i]["REVISTA"]);
            //        cmbRevistas.ValueMember = dadosTabela.Rows[i]["ID_REV"].ToString();
            //        cmbRevistas.DisplayMember = dadosTabela.Rows[i]["REVISTA"].ToString();
            //    }
            //}
            //catch (Exception erroGRP)
            //{

            //    MessageBox.Show(erroGRP.Message);
            //}

            cmbRevistas.DataSource = dadosTabela;
            cmbRevistas.DisplayMember = "REVISTA";
            cmbRevistas.ValueMember = "ID_REV";

            

            cmbRevistas.SelectedIndex = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = null;
            cmbRevistas.SelectedIndex = 0;
            txtProduto.Text = null;
            rbUsuAtivo.Checked = true;
            pvListarProdutosAtivos();
        }

        private void frmGerProdutos_Load(object sender, EventArgs e)
        {
            if (incVendas != null)
            {
                btnConfirmar.Visible = true;
                btnIncluir.Visible = false;
                btnEditarGrid.Visible = false;
                btnExcluir.Visible = false;
                btnVoltar.Visible = false;
                btnDesfazer.Visible = true;
            }
            if (codref == "")
            {
                pvPreencherCombo();
                pvListarProdutosAtivos();
            }
            else
            {
                txtCodigo.Text = codref;
                pvListarProdutosComFiltro("S");
                //dtgProdutos.Focus();
                dtgProdutos.Select();
            }
        }

        private void rbUsuAtivo_CheckedChanged(object sender, EventArgs e)
        {
            pvListarProdutosAtivos();
        }

        private void rbUsuTodos_CheckedChanged(object sender, EventArgs e)
        {
            produtos = new clProdutos();
            dtgProdutos.DataSource = produtos.listarTodosProdutos();
        }

        private void rbUsuInativo_CheckedChanged(object sender, EventArgs e)
        {
            produtos = new clProdutos();
            dtgProdutos.DataSource = produtos.listarProdutosInativos();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            novoProduto = new frmIncProdutos(this, "INCLUIR", 0, idusu);
            novoProduto.Show();
        }

        private void btnEditarGrid_Click(object sender, EventArgs e)
        {
            if (dtgProdutos.Rows.Count > 0)
            {
                novoProduto = new frmIncProdutos(this, "EDITAR", Convert.ToInt32(dtgProdutos.CurrentRow.Cells["ID_PRO"].Value), Convert.ToInt32(idusu));
                novoProduto.Show();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dtgProdutos.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir esse produto? Essa ação é irreversível!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pvExcluirProdutos();
                    MessageBox.Show("Produto excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rbUsuAtivo.Checked = true;
                    pvListarProdutosAtivos();
                }
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text == "" & txtProduto.Text == "" & cmbRevistas.Text == " SELECIONE") || (txtCodigo.Text == null & txtProduto.Text == null))
            {
                pvListarProdutosAtivos();
                rbUsuAtivo.Checked = true;
            }
            else
            {
                if (rbUsuAtivo.Checked == true)
                {
                    pvListarProdutosComFiltro("S");
                }
                else if (rbUsuInativo.Checked == true)
                {
                    pvListarProdutosComFiltro("N");
                }
                else
                {
                    pvListarProdutosComFiltro("");
                }
            }
        }

        private void dtgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //linhaClicada = Convert.ToInt32(dtgProdutos.CurrentRow.Cells["ID_PRO"].Value);
        }

        private void cmbRevistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = dtgT.TabIndex = cmbRevistas.SelectedIndex;
            idrev = Convert.ToInt32(dtgT.Rows[index].Cells["ID_REV"].Value);
        }

        private void pvFecharForm(string tpAcesso)
        {
            if (tpAcesso == "CONFIRMAR")
            {
                incVendas.idintpro = Convert.ToInt32(dtgProdutos.CurrentRow.Cells["ID_PRO"].Value);
                //MessageBox.Show(incVendas.idintpro.ToString());
                this.Close();
            }
            else
            {
                incVendas.idintpro = 0;
                this.Close();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            pvFecharForm("CONFIRMAR");
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            pvFecharForm("DESFAZER");
        }

        private void dtgProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pvFecharForm("CONFIRMAR");
            }
            else if (e.KeyCode == Keys.Escape)
            {
                pvFecharForm("DESFAZER");
            }
        }
    }
}
