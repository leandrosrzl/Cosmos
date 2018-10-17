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
    public partial class frmGerVendas : Form
    {
        frmIncVenda novoPedido;
        clVendas vendas;
        DataTable dadosTabela;

        int idusu;

        public frmGerVendas(int id_usu)
        {
            InitializeComponent();
            idusu = id_usu;
        }
        private void pvExcluirPedido()
        {
            vendas = new clVendas();
            if (tbcRevistas.SelectedTab == tbpPedidos)
            {
                vendas.atualizarStatusPedido(Convert.ToInt32(dtgPedidos.CurrentRow.Cells["IDVDA"].Value), "CANCELADO");
                dtgPedidos.DataSource = pvListarPedidos(0, "ABERTO");
            }
            else
            {
                vendas.atualizarStatusPedido(Convert.ToInt32(dtgPagar.CurrentRow.Cells["PAGARIDVDA"].Value), "CANCELADO");
                dtgPagar.DataSource = pvListarPedidos(0, "FECHADO");
            }
            MessageBox.Show("Pedido cancelado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }

        private DataTable pvListarPedidos(int idvda, string status)
        {
            dadosTabela = new DataTable();
            vendas = new clVendas();
            dadosTabela = vendas.listarVendas(idvda, status);
            return dadosTabela;
        }

        private void pvListarPedidosComFiltro()
        {
            vendas = new clVendas();
            if (tbcRevistas.SelectedTab == tbpPedidos)
            {
                dtgPedidos.DataSource = vendas.listarVendasComFiltroGrid(mTxtNroVda.Text, txtRevista.Text, txtEdicao.Text, txtVendedor.Text, "ABERTO");
            }
            else if (tbcRevistas.SelectedTab ==tbpCancelados)
            {
                dtgCancelados.DataSource = vendas.listarVendasComFiltroGrid(mTxtNroVda.Text, txtRevista.Text, txtEdicao.Text, txtVendedor.Text, "CANCELADO");
            }
            else if (tbcRevistas.SelectedTab == tbpPagar)
            {
                dtgPagar.DataSource = vendas.listarVendasComFiltroGrid(mTxtNroVda.Text, txtRevista.Text, txtEdicao.Text, txtVendedor.Text, "FECHADO");
            }
            else
            {
                dtgJaPagos.DataSource = vendas.listarVendasComFiltroGrid(mTxtNroVda.Text, txtRevista.Text, txtEdicao.Text, txtVendedor.Text, "PAGO");
            }
        }

        private void btnJPVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            novoPedido = new frmIncVenda(idusu, "INSERIR",0);
            novoPedido.ShowDialog();
        }

        private void frmGerVendas_Load(object sender, EventArgs e)
        {
            //pvListarVendasAtivas();
            dtgPedidos.DataSource = pvListarPedidos(0, "ABERTO");
        }

        private void btnAlterarPed_Click(object sender, EventArgs e)
        {
            if (dtgPedidos.Rows.Count > 0)
            {
                novoPedido = new frmIncVenda(idusu, "ALTERAR", Convert.ToInt32(dtgPedidos.CurrentRow.Cells["IDVDA"].Value));
                novoPedido.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não há pedido para ser alterado", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (mTxtNroVda.TextLength == 0 && txtEdicao.TextLength == 0 && txtRevista.TextLength == 0 && txtVendedor.TextLength == 0)
            {
                pvListarPedidos(0,"ABERTO");
            }
            else
            {
                pvListarPedidosComFiltro();
            }
        }

        private void tbcRevistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcRevistas.SelectedTab == tbpPedidos) //PEDIDOS ABERTOS
            {
                dtgPedidos.DataSource = pvListarPedidos(0, "ABERTO");
            }
            else if (tbcRevistas.SelectedTab == tbpCancelados) //PEDIDOS CANCELADOS
            {
                dtgCancelados.DataSource = pvListarPedidos(0, "CANCELADO");
            }
            else if (tbcRevistas.SelectedTab == tbpPagar) //PEDIDOS A PAGAR
            {
                dtgPagar.DataSource = pvListarPedidos(0, "FECHADO");
            }
            else //PEDIDOS PAGOS
            {
                dtgJaPagos.DataSource = pvListarPedidos(0, "PAGO");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dtgPedidos.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente cancelar esse pedido? Essa ação é irreversível!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pvExcluirPedido();
                }
            }
            else
            {
                MessageBox.Show("Não há pedido para ser excluído", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConsultarPedido_Click(object sender, EventArgs e)
        {
            if (dtgPagar.Rows.Count > 0)
            {
                frmRelPedidos relPedidos = new frmRelPedidos(Convert.ToInt32(dtgPagar.CurrentRow.Cells["pagarIDVDA"].Value),
                    Convert.ToInt32(dtgPagar.CurrentRow.Cells["PAGARIDVEN"].Value), idusu);
                relPedidos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não há pedido para ser consultado", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mTxtNroVda.Clear();
            txtEdicao.Clear();
            txtRevista.Clear();
            txtVendedor.Clear();
        }

        private void btnCanAlterarPed_Click(object sender, EventArgs e)
        {
            if (dtgCancelados.Rows.Count > 0)
            {
                novoPedido = new frmIncVenda(idusu, "ALTERAR", Convert.ToInt32(dtgCancelados.CurrentRow.Cells["CIDVDA"].Value));
                novoPedido.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não há pedido para ser alterado", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCanNovoPed_Click(object sender, EventArgs e)
        {
            novoPedido = new frmIncVenda(idusu, "INSERIR", 0);
            novoPedido.ShowDialog();
        }

        private void btnPCancelar_Click(object sender, EventArgs e)
        {
            if (dtgPagar.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente cancelar esse pedido? Essa ação é irreversível!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    pvExcluirPedido();
                }
            }
            else
            {
                MessageBox.Show("Não há pedido para ser cancelado", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dtgPagar.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente pagar esse pedido? Essa ação é irreversível!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    vendas =  new clVendas();
                    vendas.atualizarStatusPedido(Convert.ToInt32(dtgPagar.CurrentRow.Cells["PAGARIDVDA"].Value), "PAGO");
                    dtgPagar.DataSource = pvListarPedidos(0, "FECHADO");
                    MessageBox.Show("Pedido pago com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Não há pedido para ser pago", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnJaPagosConsultarPagto_Click(object sender, EventArgs e)
        {
            if (dtgJaPagos.Rows.Count > 0)
            {
                frmRelPedidos relPedidos = new frmRelPedidos(Convert.ToInt32(dtgJaPagos.CurrentRow.Cells["JPIDVDA"].Value),
                    Convert.ToInt32(dtgJaPagos.CurrentRow.Cells["JPIDVEN"].Value), idusu);
                relPedidos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não há pedido para ser consultado", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPAlterar_Click(object sender, EventArgs e)
        {
            if (dtgPagar.Rows.Count > 0)
            {
                novoPedido = new frmIncVenda(idusu, "ALTERAR", Convert.ToInt32(dtgPagar.CurrentRow.Cells["PAGARIDVDA"].Value));
                novoPedido.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não há pedido para ser alterado", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}