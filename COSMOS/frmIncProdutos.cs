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
    public partial class frmIncProdutos : Form
    {
        frmGerProdutos vGerProd;
        string lTpAcesso, ativo = "S", encarte = "N";
        clProdutos produtos;
        int idpro;
        int idrev, index, linhaCmb;
        int idusu, desatusu = 0;
        DateTime dataDesat = Convert.ToDateTime("01/01/2001");
        DataTable dadosTabela, dadosTabelac;

        public frmIncProdutos(frmGerProdutos gerProd, string tpAcesso, int codpro, int idUsu)
        {
            InitializeComponent();
            lTpAcesso = tpAcesso;
            idpro = codpro;
            idusu = idUsu;
            vGerProd = gerProd;
        }

        private void pvLerGenerator()
        {
            produtos = new clProdutos();
            dadosTabela = new DataTable();
            dadosTabela = produtos.lerGenerator();
            idpro = Convert.ToInt32(dadosTabela.Rows[0]["GEN_ID"].ToString());
        }

        private void pvPreencherCombo()
        {
            produtos = new clProdutos();
            dadosTabelac = new DataTable();
            //dadosTabela = produtos.listarRevistas();
            dtgT.DataSource = dadosTabelac = produtos.listarRevistas();

            //try
            //{
            //    for (int i = 0; i < dadosTabela.Rows.Count; i++)
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

            cmbRevistas.DataSource = dadosTabelac;
            cmbRevistas.DisplayMember = dadosTabelac.Columns["REVISTA"].ToString();
            //cmbRevistas.ValueMember = dadosTabela.Columns["ID_REV"].ToString();

        }

        private void pvPreencherCampos()
        {
            txtIdPro.Text = dadosTabela.Rows[0]["ID_PRO"].ToString();
            txtRef.Text = dadosTabela.Rows[0]["REF"].ToString();
            txtProduto.Text = dadosTabela.Rows[0]["PRODUTO"].ToString();
            txtPreco.Text = dadosTabela.Rows[0]["PRECO"].ToString();
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                cmbRevistas.SelectedIndex = linhaCmb;
                dtgT.Rows[linhaCmb].Selected = true;
            }
            catch (Exception era)
            {

                throw new Exception(era.Message);
            }
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            txtPromocao.Text = dadosTabela.Rows[0]["PROMOCAO"].ToString();
            txtComissao.Text = dadosTabela.Rows[0]["COMISSAO"].ToString();
            lblDataCad.Text = Convert.ToDateTime(dadosTabela.Rows[0]["DATACAD"].ToString()).ToShortDateString();
            lblUsuCad.Text = dadosTabela.Rows[0]["NOME_USU"].ToString();
            txtObservacao.Text = dadosTabela.Rows[0]["OBS"].ToString();
            if (dadosTabela.Rows[0]["ATIVO"].ToString() == "S")
            {
                cbxDesatPro.Checked = false;
            }
            else
            {
                cbxDesatPro.Checked = true;
            }
            if (dadosTabela.Rows[0]["DESATUSU"].ToString() == null | dadosTabela.Rows[0]["DESATUSU"].ToString() == "")
            {
                gpbDesatPor.Visible = false;
            }
            else
            {
                lblUsuDesat.Text = dadosTabela.Rows[0]["DESATUSU"].ToString();
                lblUsuDesat.Visible = true;
                lblDataDesat.Text = Convert.ToDateTime(dadosTabela.Rows[0]["DESATDATA"].ToString()).ToShortDateString();
                lblDataDesat.Visible = true;
                gpbDesatPor.Visible = true;
            }
            gpbCadPor.Visible = true;
            if (dadosTabela.Rows[0]["ENCARTE"].ToString() == "S")
                rbnSim.Checked = true;
            else
                rbnNao.Checked = true;
        }

        private void pvLerProdutoComFiltro()
        {
            produtos = new clProdutos();
            dadosTabela = new DataTable();
            dadosTabela = produtos.listarProdutosComFiltroInc(idpro);
            pvBuscaId();
            pvPreencherCampos();
        }

        private void pvAtualizar()
        {
            produtos = new clProdutos();
            if (rbnNao.Checked == true)
                encarte = "N";
            else
                encarte = "S";
            try
            {
                produtos.editarProdutos(Convert.ToInt32(txtIdPro.Text), idrev, txtRef.Text, txtProduto.Text, Convert.ToDouble(txtPreco.Text), Convert.ToDouble(txtPromocao.Text), Convert.ToDouble(txtComissao.Text), txtObservacao.Text,
                    desatusu, dataDesat, ativo.ToString(), encarte);
                MessageBox.Show("Produto alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vGerProd.pvListarProdutosAtivos();
            }
            catch (Exception eer)
            {
                throw new Exception("Erro no formulario de inclusao de produto. Se o problema persistir comunique o administrador do sistema. Erro original: \n" + eer);
            }
        }

        private void pvSalvar()
        {
            if (rbnNao.Checked == true)
                encarte = "N";
            else
                encarte = "S";
            produtos = new clProdutos();
            pvLerGenerator();
            //MessageBox.Show("IDVEN: "+idven.ToString());
            produtos.salvarProdutos(idpro, idrev, txtRef.Text, txtProduto.Text, Convert.ToDouble(txtPreco.Text), Convert.ToDouble(txtPromocao.Text), DateTime.Now, Convert.ToDouble(txtComissao.Text), txtObservacao.Text, Convert.ToInt32(idusu), encarte);
            MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            vGerProd.pvListarProdutosAtivos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarManutVen_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text == "" || txtRef.Text == "")
            {
                MessageBox.Show("Preencha os campos com '*'.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (lTpAcesso == "INCLUIR")
                {
                    pvSalvar();
                    //this.Close();
                }
                else
                {
                    pvAtualizar();
                    //this.Close();
                }
            }
            pvInicializar();
            pnlGeral.Enabled = false;
            btnSalvarManutVen.Visible = false;
            btnIncluir.Visible = true;
            btnIncluir.Enabled = true;
         }

        private void pvFor()
        {
            MessageBox.Show(cmbRevistas.Items.Count.ToString());
            for (int i = 0; i < cmbRevistas.Items.Count; i++)
            {
                MessageBox.Show(cmbRevistas.Items[i].ToString()+"\n"+cmbRevistas.ValueMember.ToString());
            }
        }

        public void pvBuscaId()
        {
            int i;
            for (i = 0; i < dtgT.Rows.Count; i++)
            {
                //MessageBox.Show("dtgT " + dtgT.Rows[i].Cells["REVISTA"].Value.ToString());
                //MessageBox.Show("\ndadosTabela " + dadosTabelac.Rows[0]["REVISTA"].ToString());
                if (dtgT.Rows[i].Cells["REVISTA"].Value.ToString() == dadosTabela.Rows[0]["REVISTA"].ToString())
                {
                    //MessageBox.Show("Oi, achei!");
                    linhaCmb = i;
                    //MessageBox.Show("Olha só o i: " + i.ToString());
                    break;
                }
                else
                {
                    //MessageBox.Show("Test");
                }
            }
        }

        private void pvLimparCampos()
        {
            txtIdPro.Clear();
            txtProduto.Clear();
            txtRef.Clear();
            txtPreco.Text = "0";
            txtPromocao.Text = "0";
            txtComissao.Text = "0";
            txtObservacao.Clear();
            cbxDesatPro.Checked = false;
            gpbCadPor.Visible = false;
            gpbDesatPor.Visible = false;
            btnSalvarManutVen.Visible = false;
        }

        private void pvInicializar()
        {
            pvLimparCampos();
            pvPreencherCombo();
            //pvFor();
            if (lTpAcesso == "INCLUIR")
            {
                pvLimparCampos();
                btnAlterar.Enabled = false;
                btnAlterar.Visible = false;
                cbxDesatPro.Visible = false;
                cbxDesatPro.Enabled = false;
            }
            else
            {
                btnIncluir.Enabled = true;
                btnIncluir.Visible = true;
                btnAlterar.Visible = true;
                pvLerProdutoComFiltro();
            }
        }

        private void frmIncProdutos_Load(object sender, EventArgs e)
        {
            pvInicializar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            lTpAcesso = "INCLUIR";
            pvInicializar();
            pnlGeral.Enabled = true;
            btnSalvarManutVen.Visible = true;
            btnIncluir.Visible = false;
            btnAlterar.Visible = false;
            txtProduto.Focus();
        }

        private void cbxDesatPro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDesatPro.Checked == true) //Estou desativando
            {
                desatusu = idusu;
                dataDesat = DateTime.Now;
                lblDataDesat.Text = dataDesat.ToShortDateString();
                lblUsuDesat.Text = desatusu.ToString();
                gpbDesatPor.Visible = true;
                ativo = "N";
            }
            else //estou reativando
            {
                desatusu = 0;
                dataDesat = Convert.ToDateTime("01/01/2001");
                lblDataDesat.Text = "";
                lblUsuDesat.Text = "";
                gpbDesatPor.Visible = false;
                ativo = "S";
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            pnlGeral.Enabled = true;
            btnSalvarManutVen.Visible = true;
            btnAlterar.Visible = false;
            btnIncluir.Visible = false;
            txtProduto.Focus();
        }

        private void cmbRevistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = dtgT.TabIndex = cmbRevistas.SelectedIndex;
            idrev = Convert.ToInt32(dtgT.Rows[index].Cells["ID_REV"].Value);
            //MessageBox.Show(idrev.ToString());
        }
    }
}
