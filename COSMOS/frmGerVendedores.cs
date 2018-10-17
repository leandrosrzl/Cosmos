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
    public partial class frmGerVendedores : Form
    {
        public frmGerVendedores(int idUsu )
        {
            InitializeComponent();
            idusu = idUsu;
        }

        frmIncVendedor incluirVendedor;
        clVendedores vendedores;
        int idusu;

        public void pvListarVendedoresAtivos()
        {
            vendedores = new clVendedores();
            dtgVendedores.DataSource = vendedores.listarVendedoresAtivos();
        }

        public void pvListarVendedoresInativos()
        {
            vendedores = new clVendedores();
            dtgVendedores.DataSource = vendedores.listarVendedoresInativos();
        }

        public void pvListarTodosVendedores()
        {
            vendedores = new clVendedores();
            dtgVendedores.DataSource = vendedores.listarTodosVendedores();
        }

        private void pvListarVendedoresComFiltro(string ativo)
        {
            if (txtCodigo.Text == "")
            {
                vendedores = new clVendedores();
                dtgVendedores.DataSource = vendedores.listarVendedoresComFiltro(0, txtVendedor.Text, ativo);
            }
            else
            {
                vendedores = new clVendedores();
                dtgVendedores.DataSource = vendedores.listarVendedoresComFiltro(Convert.ToInt32(txtCodigo.Text), txtVendedor.Text, ativo);
            }
        }

        private void pvExcluirVendedor()
        {
            vendedores = new clVendedores();
            vendedores.excluirVendedor(Convert.ToInt32(dtgVendedores.CurrentRow.Cells["IDVEN"].Value));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dtgVendedores.CurrentRow.Cells["ATIVO"].Value.ToString() == "S")
            {
                if (MessageBox.Show("Deseja realmente excluir esse vendedor? Essa ação é irreversível!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dtgVendedores.Rows.Count > 0)
                    {
                        pvExcluirVendedor();
                        MessageBox.Show("Vendedor excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pvListarVendedoresAtivos();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro selecionado para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não é possível excluir um vendedor inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            incluirVendedor = new frmIncVendedor(this, "INCLUIR",0, Convert.ToInt32(idusu));
            incluirVendedor.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGerVendedores_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtVendedor.Text = "";
            pvListarVendedoresAtivos();
        }

        private void rbUsuTodos_CheckedChanged(object sender, EventArgs e)
        {
            pvListarTodosVendedores();
        }

        private void rbUsuAtivo_CheckedChanged(object sender, EventArgs e)
        {
            pvListarVendedoresAtivos();
        }

        private void rbUsuInativo_CheckedChanged(object sender, EventArgs e)
        {
            pvListarVendedoresInativos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtVendedor.Text = "";
            rbUsuAtivo.Checked = true;
            pvListarVendedoresAtivos();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text == "" & txtVendedor.Text == "")||txtCodigo.Text == null & txtVendedor.Text == null)
            {
                pvListarVendedoresAtivos();
                rbUsuAtivo.Checked = true;
            }
            else
            {
                if (rbUsuAtivo.Checked == true)
                {
                    pvListarVendedoresComFiltro("S");
                }
                else if (rbUsuInativo.Checked == true)
                {
                    pvListarVendedoresComFiltro("N");
                }
                else
                {
                    pvListarVendedoresComFiltro("");
                }
            }
        }

        private void btnEditarGrid_Click(object sender, EventArgs e)
        {
            if (dtgVendedores.Rows.Count > 0)
            {
                //pvEditarVendedor();
                incluirVendedor = new frmIncVendedor(this, "EDITAR", Convert.ToInt32(dtgVendedores.CurrentRow.Cells["IDVEN"].Value), Convert.ToInt32(idusu));
                incluirVendedor.Show();
            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
