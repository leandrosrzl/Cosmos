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
    public partial class frmIncVenda : Form
    {
        clVendas vendas;
        clProdutos produtos;
        clRevistas revistas;
        public DataTable dadosTabela, dadosTabelaRev;
        frmGerProdutos gerProdutos;
        string vendedor, produto, revista, edicao, referencia, nroPed, tpAcesso, tpPesquisa, 
            vPesquisa = "", tpVar;
        int idven, qtdItensPedido = 0, ultimaLinha = 1, linhaClicada = -1, idrev, idvda, idusu, codigo;
        public int idintpro;
        double vunit, valorTotal, totalPedido = 0, vcomissao, vcomissaoitem, vcomissaototal;

        public frmIncVenda(int id_usu, string lTpAcesso, int id_vda)
        {
            InitializeComponent();
            idusu = id_usu;
            tpAcesso = lTpAcesso;
            idvda = id_vda;
        }

        private void pvAtualizarCabecalho(string tpSalva)
        {
            vendas = new clVendas();
            totalPedido = 0;
            vcomissaototal = 0;
            for (int i = 0; i < dtgitensPedidoa.Rows.Count; i++)
            {
                totalPedido += Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["VALORTOTALA"].Value);
                vcomissaototal += Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["VLRCOMISSAO"].Value);
                txtStatus.Text = tpSalva;
                lblTotalPedido.Text = string.Format("{0:N}", totalPedido).ToString();
                lblComissao.Text = string.Format("{0:N}", vcomissaototal).ToString();
            }
            vendas.atualizarCabecalho(idvda, Convert.ToDouble(lblTotalPedido.Text), Convert.ToDouble(lblComissao.Text), Convert.ToInt32(lblQTotalItens.Text), tpSalva);
        }

        private void pvListarProdutos()
        {
            dadosTabela = new DataTable();
            dadosTabela = vendas.listarItensVendas(idvda);
            pvInserirProdutoGridCarregado();
        }

        private void pvExcluirProdutoPedido()
        {
            try
            {
                vendas = new clVendas();
                vendas.excluirItemPedido(Convert.ToInt32(dtgitensPedidoa.CurrentRow.Cells["COD"].Value), idvda);
                vcomissaototal -= Convert.ToDouble(dtgitensPedidoa.CurrentRow.Cells["VLRCOMISSAO"].Value);
                lblComissao.Text = string.Format("{0:N}", vcomissaototal).ToString();
                dtgitensPedidoa.Rows.Remove(dtgitensPedidoa.CurrentRow);
            }
            catch (Exception eae)
            {
                MessageBox.Show("Erro ao excluir produto. Se o problema persistir, comunique o administrador do sistema.\n" + eae.Message);
            }
        }

        private void pvListarGeneratorIDVDA()
        {
            vendas = new clVendas();
            dadosTabela = new DataTable();
            dadosTabela = vendas.lerGeneratorIDVDA();
            idvda = Convert.ToInt32(dadosTabela.Rows[0]["GEN_ID"]);
            //MessageBox.Show(idvda.ToString());
        }

        private void pvListarGeneratorNROVDA()
        {
            vendas = new clVendas();
            dadosTabela = vendas.lerGeneratorNROVDA();
            nroPed = dadosTabela.Rows[0]["GEN_ID"].ToString();
            //MessageBox.Show(nroPed);
            txtNroPed.Text = nroPed;
        }

        private void pvSalvarCabecalho(string TpSalva)
        {
            try
            {
                vendas = new clVendas();
                pvListarGeneratorIDVDA();
                pvListarGeneratorNROVDA();
                vendas.salvarPedido(idvda, idusu, idven, nroPed, dtpPagto.Value, dtpPrevEntr.Value, DateTime.Now, TpSalva, 0, 0, Convert.ToInt32(lblQTotalItens.Text));
            }
            catch (Exception esc)
            {
                throw new Exception("Erro ao salvar o cabeçalho no form de pedidos. Se o problema persistir, comunique o administrador do sistema. \n" + esc.Message);
            }
        }

        private int pvProcuraProduto(int idpro)
        {
            int sit = 0;
            for (int i = 0; i < dtgitensPedidoa.Rows.Count; i++)
            {
                if (dtgitensPedidoa.Rows[i].Cells["COD"].Value.ToString() == txtCodigo.Text)
                {
                    //MessageBox.Show("Produto já lançado.");
                    sit = 1;
                    break;
                }
                else
                {
                    //MessageBox.Show("Não tem ai");
                    sit = 0;
                }
            }

            return sit;
        }

        private void pvPercorreGrid(string TpSalva)
        {
            int totalLinha = dtgitensPedidoa.Rows.Count;
            for (int i = 0; i < totalLinha; i++)
            {
                //dtgitensPedidoa.Rows.Add("ITEM", "COD", "REF", "PRODUTOA", "ID_REV", "REVISTAA", "EDICAOA", "VUNITA", "QTD", "VALORTOTALA", "COMISSAO", "VLRCOMISSAO); // Colunas do grid

                pvAtualizarCabecalho(TpSalva);

                if (tpAcesso == "INSERIR")
                {
                    pvSalvarItens(idvda,                                                                                           //id do cabeçalho de venda
                    Convert.ToInt32(dtgitensPedidoa.Rows[i].Cells["COD"].Value),         //id do produto
                    Convert.ToInt32(dtgitensPedidoa.Rows[i].Cells["ID_REV"].Value),         //id da revista do produto
                    Convert.ToInt32(dtgitensPedidoa.Rows[i].Cells["ITEM"].Value),           //numero do item inserido no grid
                    dtgitensPedidoa.Rows[i].Cells["REF"].Value.ToString(),                           //referencia do produto
                    dtgitensPedidoa.Rows[i].Cells["PRODUTOA"].Value.ToString(),                //nome do produto
                    Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["VUNITA"].Value),        //Valor unitário do produto
                    Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["QTD"].Value),           //quantidade do produto
                    Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["VALORTOTALA"].Value),    //Valor total do produto
                    dtgitensPedidoa.Rows[i].Cells["REVISTAA"].Value.ToString(),                  //nome da revista
                    dtgitensPedidoa.Rows[i].Cells["EDICAOA"].Value.ToString(),                   //edicao da revista
                    Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["COMISSAO"].Value),    //Porcentagem comissao do produto
                    Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["VLRCOMISSAO"].Value),    //Valor comissao do produto
                    TpSalva);
                }
                else
                {
                    if (dtgitensPedidoa.Rows[i].Cells["tpProduto"].Value.ToString() == "ATUALIZAR")
                    {
                        pvAtualizarItens(idvda,
                        Convert.ToInt32(dtgitensPedidoa.Rows[i].Cells["COD"].Value),         //id do produto
                        Convert.ToInt32(dtgitensPedidoa.Rows[i].Cells["ITEM"].Value),           //numero do item inserido no grid
                        Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["VUNITA"].Value),        //Valor unitário do produto
                        Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["QTD"].Value),           //quantidade do produto
                        Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["VALORTOTALA"].Value),    //Valor total do produto
                        Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["COMISSAO"].Value),    //Porcentagem comissao do produto
                        Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["VLRCOMISSAO"].Value));    //Valor comissao do produto
                    }
                    else
                    {
                        pvSalvarItens(idvda,                                                                                           //id do cabeçalho de venda
                        Convert.ToInt32(dtgitensPedidoa.Rows[i].Cells["COD"].Value),         //id do produto
                        Convert.ToInt32(dtgitensPedidoa.Rows[i].Cells["ID_REV"].Value),         //id da revista do produto
                        Convert.ToInt32(dtgitensPedidoa.Rows[i].Cells["ITEM"].Value),           //numero do item inserido no grid
                        dtgitensPedidoa.Rows[i].Cells["REF"].Value.ToString(),                           //referencia do produto
                        dtgitensPedidoa.Rows[i].Cells["PRODUTOA"].Value.ToString(),                //nome do produto
                        Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["VUNITA"].Value),        //Valor unitário do produto
                        Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["QTD"].Value),           //quantidade do produto
                        Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["VALORTOTALA"].Value),    //Valor total do produto
                        dtgitensPedidoa.Rows[i].Cells["REVISTAA"].Value.ToString(),                  //nome da revista
                        dtgitensPedidoa.Rows[i].Cells["EDICAOA"].Value.ToString(),                   //edicao da revista
                        Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["COMISSAO"].Value),    //Porcentagem comissao do produto
                        Convert.ToDouble(dtgitensPedidoa.Rows[i].Cells["VLRCOMISSAO"].Value),    //Valor comissao do produto
                        TpSalva);
                    }
                }
            }
            if (TpSalva == "FECHADO")
            {
                MessageBox.Show("Pedido fechado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pedido pausado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void pvAtualizarItens(int idvda, int id_pro, int item, double vunit, double qtd, double vtotal, double comissao, double vlrcomissao)
        {
            vendas = new clVendas();
            vendas.atualizarItensPedido(idvda, id_pro, item, vunit, qtd, vtotal, comissao, vlrcomissao);
        }

        private void pvSalvarItens(int idvda, int id_pro, int id_rev, int item, string referencia, string produto, double vunit, double qtd, double vtotal, string revista, string edicao, double comissao, double vlrcomissao, string TpSalva)
        {
            try
            {
                vendas = new clVendas();
                vendas.salvarItensPedido(idvda, id_pro, id_rev, item, referencia, produto, vunit, qtd, vtotal, revista, edicao, comissao, vlrcomissao);
            }
            catch (Exception eiip)
            {
                throw new Exception("Erro no form de inclusão de pedidos no método de salvar itens. Se o problema persistir, entre em contato com o Administrador do sistema. \n" + eiip.Message);
            }
        }

        private void pvBuscaVendedor()
        {
            vendas = new clVendas();

            try
            {
                int codigo = Convert.ToInt32(txtVendedor.Text);
                dadosTabela = vendas.buscarVendedor("",codigo);
            }
            catch (Exception)
            {
                dadosTabela = vendas.buscarVendedor(txtVendedor.Text, 0);
            }
            if (dadosTabela.Rows.Count > 0)
            {
                idven = Convert.ToInt32(dadosTabela.Rows[0]["IDVEN"]);
                vendedor = dadosTabela.Rows[0]["APELIDO"].ToString();
                txtVendedor.Text = vendedor;
                gpbPedido.Enabled = true;
                gpbDadosGerais.Enabled = false;
            }
            else
            {
                MessageBox.Show("Não foi encontrado vendedor com esse nome/código.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pvListarCabecalho()
        {
            vendas = new clVendas();
            dadosTabela = new DataTable();
            dadosTabela = vendas.listarVendasComFiltro(idvda);
            try
            {
                txtNroPed.Text = dadosTabela.Rows[0]["NROVDA"].ToString();
                txtStatus.Text = dadosTabela.Rows[0]["STATUS"].ToString();
                txtVendedor.Text = dadosTabela.Rows[0]["APELIDO"].ToString();
                dtpPagto.Value = Convert.ToDateTime(dadosTabela.Rows[0]["DATAPAGTO"].ToString());
                dtpEmissao.Value = Convert.ToDateTime(dadosTabela.Rows[0]["EMISSAO"].ToString());
                dtpPrevEntr.Value = Convert.ToDateTime(dadosTabela.Rows[0]["DATAENTR"].ToString());
                lblTotalPedido.Text = dadosTabela.Rows[0]["VTOTAL"].ToString();
                lblComissao.Text = dadosTabela.Rows[0]["COMISSAO"].ToString();
                lblQTotalItens.Text = dadosTabela.Rows[0]["TTL_ITENS"].ToString();
                gpbDadosGerais.Enabled = false;
                gpbPedido.Enabled = true;
                vcomissaototal = Convert.ToDouble(lblComissao.Text);
                qtdItensPedido = Convert.ToInt32(lblQTotalItens.Text);
                totalPedido = Convert.ToDouble(lblTotalPedido.Text);
            }
            catch (Exception abc)
            {
                
                throw new Exception(abc.Message);
            }
        }

        private void pvVerificaCodRef(int idIntProCodRef)
        {
            codigo = idIntProCodRef;
            dadosTabela = new DataTable();
            try
            {//Tenta converter o conteúdo do textbox para inteiro. Se der certo, é código ou referencia por numero
                codigo = Convert.ToInt32(txtCodigo.Text);
                if (idIntProCodRef == 0)
                {
                    dadosTabela = produtos.listarProdutosVendas(codigo.ToString(), codigo);
                }
                else
                {
                    dadosTabela = produtos.listarProdutosVendas("", codigo);
                }
                tpPesquisa = "COD";
            }
            catch (Exception)
            {//Se for letra, vai direto para referencia
                dadosTabela = produtos.listarProdutosVendas(txtCodigo.Text, 0);
                tpPesquisa = "REF";
            }
        }

        private void pvBuscarProdutos()
        {
            produtos = new clProdutos();
            vendas = new clVendas();
            //dadosTabela = new DataTable();

            pvVerificaCodRef(0);
            idintpro = Convert.ToInt32(dadosTabela.Rows.Count);
            if (dadosTabela.Rows.Count > 0)
            {
                if (dadosTabela.Rows.Count > 1)
                {//Se tiver mais do que um produto no resultado, abre o form de produtos para selecionar qual quer usar. 
                    if(tpPesquisa == "COD")
                    {//Se o cod for numero, vai buscar por numero
                        vPesquisa = codigo.ToString();
                        tpVar = "COD";
                    }
                    else
                    {//se for ref, vai buscar por letra
                        vPesquisa = txtCodigo.Text;
                        tpVar = "REF";
                    }

                    gerProdutos = new frmGerProdutos(this,idusu, vPesquisa, tpVar);
                    gerProdutos.ShowDialog();

                    if (idintpro > 0)
                    {
                        txtCodigo.Text = idintpro.ToString();

                        pvVerificaCodRef(idintpro);
                    }

                    //MessageBox.Show(idintpro.ToString());
                }
                
                //Preenche os campos com o resultado do dadosTabela sendo ele apenas com um registro no select 
                if(idintpro > 0)
                {
                    idintpro = Convert.ToInt32(dadosTabela.Rows[0]["ID_PRO"]);
                    txtCodigo.Text = dadosTabela.Rows[0]["ID_PRO"].ToString();
                    /*if (pvProcuraProduto(idintpro) == 0)
                    {*/
                        //if (Convert.ToDouble(dadosTabela.Rows[0]["PROMOCAO"]) > 0)
                        //{
                        //    txtVUnit.Text = dadosTabela.Rows[0]["PROMOCAO"].ToString();
                        //}
                        //else
                        //{
                        //    txtVUnit.Text = dadosTabela.Rows[0]["PRECO"].ToString();
                        //}

                    if (Convert.ToDouble(dadosTabela.Rows[0]["PROMOCAO"]) > 0)
                    {
                        if (MessageBox.Show("Deseja colocar o preço normal " + dadosTabela.Rows[0]["PRECO"].ToString() + " (Sim)\nou o preço de promoção " + dadosTabela.Rows[0]["PROMOCAO"].ToString() + " (Não)?", "Atenção",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                        {
                            txtVUnit.Text = dadosTabela.Rows[0]["PROMOCAO"].ToString();
                        }
                        else
                        {
                            txtVUnit.Text = dadosTabela.Rows[0]["PRECO"].ToString();
                        }
                    }
                    else
                    {
                        txtVUnit.Text = dadosTabela.Rows[0]["PRECO"].ToString();
                    }

                    txtProduto.Text = produto = dadosTabela.Rows[0]["PRODUTO"].ToString();
                    idrev = Convert.ToInt32(dadosTabela.Rows[0]["ID_REV"].ToString());
                    revista = dadosTabela.Rows[0]["REVISTA"].ToString();
                    edicao = dadosTabela.Rows[0]["EDICAO"].ToString();
                    referencia = dadosTabela.Rows[0]["REF"].ToString();
                    vunit = Convert.ToDouble(txtVUnit.Text);
                    txtQtd.Focus();
                    txtComissaoItem.Text = dadosTabela.Rows[0]["COMISSAO"].ToString();

                    if (dadosTabela.Rows[0]["COMISSAO"].ToString() == Convert.ToString(0))
                    {
                        revistas = new clRevistas();
                        dadosTabelaRev = revistas.consultarComissao(idrev);
                        vcomissao = Convert.ToDouble(dadosTabelaRev.Rows[0]["COMISSAO"]);
                    }
                    else
                    {
                        vcomissao = Convert.ToDouble(dadosTabela.Rows[0]["COMISSAO"]);
                        if(vcomissao == 30)
                        {
                            txtComissaoItem.Enabled = true;
                        }
                    }
                    /*}
                    else
                    {
                        MessageBox.Show("Atenção, produto já lançado anteriormente. \nVerifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigo.Clear();
                    }*/
                    //MessageBox.Show(vcomissao.ToString());
                }
                else
                {
                    //if (idintpro > 0)
                    //{
                    //    MessageBox.Show("Atenção, produto já lançado anteriormente. \nVerifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                    //else
                    //{
                        MessageBox.Show("Operação desfeita pelo usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
            }
            else
            {
                MessageBox.Show("Não foi encontrado produto com esse código.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtVendedor.Text != "")
                {
                    pvBuscaVendedor();
                }
                else
                {
                    MessageBox.Show("Selecione o vendedor");
                }
            }
        }

        private void btnAlterarPedido_Click(object sender, EventArgs e)
        {
            gpbPedido.Enabled = false;
            gpbDadosGerais.Enabled = true;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtCodigo.TextLength > 0)
                {
                    pvBuscarProdutos();
                }
                else
                {
                    MessageBox.Show("Selecione o produto");
                }
            }
        }

        private void pvLimparCampos()
        {
            txtProduto.Text = "";
            txtQtd.Text = "";
            txtVTotal.Text = "0";
            txtVUnit.Text = "";
            txtCodigo.Text = "";
            txtComissaoItem.Text = "";
            txtComissaoItem.Enabled = false;
            txtCodigo.Focus();
        }

        private void pvInserirProdutoGrid()
        {
            //dtgitensPedidoa.Rows.Add("ITEM", "COD", "REF", "PRODUTOA", "ID_REV", "REVISTAA", "EDICAOA", "VUNITA", "QTD", "VALORTOTALA", "COMISSAO", "VLRCOMISSAO); // Colunas do grid
            if (dadosTabela.Rows[0]["ENCARTE"].ToString() == "S")
            {
                vcomissaoitem = 0;
            }
            else
            {
                vcomissao = Convert.ToDouble(txtComissaoItem.Text);
                vcomissaoitem = ((valorTotal * vcomissao) / 100);
                vcomissaototal += vcomissaoitem;
            }
            dtgitensPedidoa.Rows.Add(ultimaLinha, txtCodigo.Text, referencia, txtProduto.Text, idrev, revista, edicao, txtVUnit.Text, txtQtd.Text, txtVTotal.Text, vcomissao, vcomissaoitem, "INSERIR");
            ultimaLinha++;
            //string.Format("{0:N}", 43239,11)); // saída = 43.239,11
            //lblComissao.Text = vcomissaototal.ToString();
            lblComissao.Text = string.Format("{0:N}", vcomissaototal).ToString();
        }

        private void pvInserirProdutoGridCarregado()
        {
            //dtgitensPedidoa.Rows.Add("ITEM", "COD", "REF", "PRODUTOA", "ID_REV", "REVISTAA", "EDICAOA", "VUNITA", "QTD", "VALORTOTALA", "COMISSAO", "VLRCOMISSAO); // Colunas do grid
            for (int i = 0; i < dadosTabela.Rows.Count; i++)
            {
                try
                {
                    string tpProduto = "ATUALIZAR";
                    dtgitensPedidoa.Rows.Add(dadosTabela.Rows[i]["ITEM"], dadosTabela.Rows[i]["ID_PRO"],dadosTabela.Rows[i]["REF"],dadosTabela.Rows[i]["PRODUTO"], dadosTabela.Rows[i]["ID_REV"],dadosTabela.Rows[i]["REVISTA"],
                        dadosTabela.Rows[i]["EDICAO"], dadosTabela.Rows[i]["VUNIT"], dadosTabela.Rows[i]["QTD"], dadosTabela.Rows[i]["VTOTAL"], dadosTabela.Rows[i]["COMISSAO"], dadosTabela.Rows[i]["VLRCOMISSAO"], tpProduto);
                    ultimaLinha++;
                }
                catch (Exception aew)
                {
                    
                    throw new Exception(aew.Message);
                }
            }
        }

        private void pvPreparaPreenchimento()
        {
            txtVTotal.Text = Convert.ToString(Convert.ToDouble(txtVUnit.Text) * Convert.ToDouble(txtQtd.Text));
            valorTotal = Convert.ToDouble(txtVTotal.Text);
            //string.Format("{0:N}", 43239,11)); // saída = 43.239,11
            //lblTotalPedido.Text = Convert.ToString(Convert.ToDouble(lblTotalPedido.Text) + Convert.ToDouble(txtVTotal.Text));
            lblTotalPedido.Text = string.Format("{0:N}", (Convert.ToDouble(lblTotalPedido.Text) + Convert.ToDouble(txtVTotal.Text))).ToString();
            totalPedido = Convert.ToDouble(lblTotalPedido.Text);
            qtdItensPedido += 1;
            lblQTotalItens.Text = qtdItensPedido.ToString();
            pvInserirProdutoGrid();
            pvLimparCampos();
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtQtd.TextLength > 0)
                {
                    pvPreparaPreenchimento();
                }
                else
                {
                    MessageBox.Show("Digite a quantidade do produto", "Digite a quantidade", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtVUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtQtd.TextLength > 0)
                {
                    pvPreparaPreenchimento();
                }
                else
                {
                    MessageBox.Show("Digite o valor unitário do produto", "Digite o valor unitário", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void frmIncVenda_Load(object sender, EventArgs e)
        {
            lblQTotalItens.Text = lblComissao.Text = lblTotalPedido.Text = totalPedido.ToString();
            if (tpAcesso == "INSERIR")
            {
                btnContinuarDepois.Visible = true;
            }
            else
            {
                pvListarCabecalho();
                pvListarProdutos();//listar produtos
                if (txtStatus.Text == "ABERTO")
                {
                    btnContinuarDepois.Visible = true;
                }
                else
                {
                    btnContinuarDepois.Visible = false;
                }
            }
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            if(dtgitensPedidoa.Rows.Count > 0)
            {
                if(MessageBox.Show("Deseja realmente excluir o item " + dtgitensPedidoa.CurrentRow.Cells["PRODUTOA"].Value.ToString() + " do pedido?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (tpAcesso == "ALTERAR")
                    {
                        pvExcluirProdutoPedido();
                    }
                    else
                    {
                        vcomissaototal -= Convert.ToDouble(dtgitensPedidoa.CurrentRow.Cells["VLRCOMISSAO"].Value);
                        totalPedido -= Convert.ToDouble(dtgitensPedidoa.CurrentRow.Cells["VALORTOTALA"].Value);

                        lblComissao.Text = string.Format("{0:N}", vcomissaototal).ToString();
                        lblTotalPedido.Text = string.Format("{0:N}", totalPedido).ToString();

                        dtgitensPedidoa.Rows.Remove(dtgitensPedidoa.CurrentRow);
                    }
                    MessageBox.Show("Produto removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Não há item para ser removido", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAlterarItem_Click(object sender, EventArgs e)
        {
            if (dtgitensPedidoa.Rows.Count > 0)
            {
                txtCodigo.Text = dtgitensPedidoa.CurrentRow.Cells["COD"].Value.ToString();
                txtProduto.Text = dtgitensPedidoa.CurrentRow.Cells["PRODUTOA"].Value.ToString();
                txtVUnit.Text = dtgitensPedidoa.CurrentRow.Cells["VUNITA"].Value.ToString();
                txtQtd.Text = dtgitensPedidoa.CurrentRow.Cells["QTD"].Value.ToString();
                txtVTotal.Text = dtgitensPedidoa.CurrentRow.Cells["VALORTOTALA"].Value.ToString();
                txtComissaoItem.Text = dtgitensPedidoa.CurrentRow.Cells["COMISSAO"].Value.ToString();
                if(Convert.ToDouble(txtComissaoItem.Text) > 30)
                {
                    txtComissaoItem.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Não há item para ser alterado", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtgitensPedidoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaClicada = dtgitensPedidoa.CurrentRow.Index;
            //MessageBox.Show(linhaClicada.ToString());
        }

        private void btnFecharVenda_Click(object sender, EventArgs e)
        {
            if(dtgitensPedidoa.Rows.Count > 0)
            {
                if (tpAcesso == "INSERIR")
                {
                    pvSalvarCabecalho("FECHADO");
                    pvPercorreGrid("FECHADO");
                }
                else
                {
                    pvPercorreGrid("FECHADO");
                }
            }
            else
            {
                MessageBox.Show("Não há itens para ser fechado.\nUtilize a opção \"Continuar Depois\"", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnContinuarDepois_Click(object sender, EventArgs e)
        {
            //pvListarGeneratorNROVDA();
            //MessageBox.Show(txtNroPed.Text);
            pvSalvarCabecalho("ABERTO");
            pvPercorreGrid("ABERTO");
        }

        private void btnCadPro_Click(object sender, EventArgs e)
        {
            gerProdutos = new frmGerProdutos(null, idusu, "", "");
            gerProdutos.ShowDialog();
        }
    }
}
