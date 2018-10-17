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
    public partial class frmIncVendedor : Form
    {
        frmGerVendedores gerVendedores;
        string lTpAcesso, ativo="S";
        clVendedores vendedores;
        int idven, idusu, desatusu=0;
        DateTime dataDesat=Convert.ToDateTime("01/01/2001");
        DataTable dadosTabela;

        public frmIncVendedor(frmGerVendedores gerVen, string tpAcesso, int codven, int idUsu)
        {
            gerVendedores = gerVen;
            InitializeComponent();
            lTpAcesso = tpAcesso;
            idven = codven;
            idusu = idUsu;
        }

        private void pvSalvar()
        {
            try
            {
                pvLerGenerator();
                vendedores = new clVendedores();
                vendedores.salvarVendedor(idven, txtNome.Text, txtApelido.Text, txtENDERECO.Text, txtNRO.Text, txtCOMP.Text, txtBAIRRO.Text, mTxtTELEFONE.Text, mTxtTELEFONE2.Text,
                    mTxtCPF.Text, mTxtRG.Text, dtpNascimento.Value, DateTime.Now, mTxtCEP.Text, txtCIDADE.Text, mTxtUF.Text,Convert.ToInt32(idusu), txtObservacao.Text);
                MessageBox.Show("Vendedor cadastrado com sucesso!","Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro no botão salvar do vendedor. Se o problema persistir, entre em contato com o administrador do sistema. " + erro);
            }
        }

        private void pvLerGenerator()
        {
            vendedores = new clVendedores();
            dtgTeste.DataSource = vendedores.lerGenerator();
            idven = Convert.ToInt32(dtgTeste.Rows[0].Cells["GEN_ID"].Value.ToString());
            //MessageBox.Show(idven.ToString());
        }

        private void pvListarVendedorComFiltro()
        {
            vendedores = new clVendedores();
            dadosTabela = vendedores.listarVendedoresComFiltroInc(idven);
        }

        private void pvPreencherCampos()
        {
            pvListarVendedorComFiltro();
            txtIDVEN.Text      = dadosTabela.Rows[0]["IDVEN"].ToString();
            txtNome.Text        = dadosTabela.Rows[0]["NOME"].ToString();
            txtApelido.Text     = dadosTabela.Rows[0]["APELIDO"].ToString();
            mTxtCPF.Text      = dadosTabela.Rows[0]["CPF"].ToString();
            mTxtRG.Text        = dadosTabela.Rows[0]["RG"].ToString();
            dtpNascimento.Value = Convert.ToDateTime(dadosTabela.Rows[0]["DATANASC"]);
            txtENDERECO.Text = dadosTabela.Rows[0]["ENDERECO"].ToString();
            txtNRO.Text = dadosTabela.Rows[0]["NRO"].ToString();
            txtCOMP.Text = dadosTabela.Rows[0]["COMPLEMENTO"].ToString();
            txtBAIRRO.Text = dadosTabela.Rows[0]["BAIRRO"].ToString();
            mTxtCEP.Text = dadosTabela.Rows[0]["CEP"].ToString();
            txtCIDADE.Text = dadosTabela.Rows[0]["CIDADE"].ToString();
            mTxtUF.Text = dadosTabela.Rows[0]["UF"].ToString();
            mTxtTELEFONE.Text = dadosTabela.Rows[0]["FONE"].ToString();
            mTxtTELEFONE2.Text = dadosTabela.Rows[0]["CEL"].ToString();
            txtObservacao.Text = dadosTabela.Rows[0]["OBS"].ToString();
            lblDataCad.Text = Convert.ToDateTime(dadosTabela.Rows[0]["DATACAD"].ToString()).ToShortDateString();
            lblUsuCad.Text = dadosTabela.Rows[0]["NOME_USU"].ToString();
            if (dadosTabela.Rows[0]["ATIVO"].ToString() == "S")
                cbxDesatVen.Checked = false;
            else
                cbxDesatVen.Checked = true;
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
        }

        private void pvAtualizar()
        {
            try
            {
                vendedores = new clVendedores();
                vendedores.atualizarVendedor(Convert.ToInt32(txtIDVEN.Text), txtNome.Text, txtApelido.Text, txtENDERECO.Text, txtNRO.Text, 
                        txtCOMP.Text, txtBAIRRO.Text, mTxtTELEFONE.Text, mTxtTELEFONE2.Text,
                        mTxtCPF.Text, mTxtRG.Text, dtpNascimento.Value, DateTime.Now,  mTxtCEP.Text, txtCIDADE.Text,
                        mTxtUF.Text,1, txtObservacao.Text, ativo);
                MessageBox.Show("Vendedor atualizado com sucesso!","Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro no botão atualizar do vendedor. Se o problema persistir, entre em contato com o administrador do sistema. " + erro);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            lTpAcesso = "INCLUIR";
            pvLimparCampos();
            pnlGeral.Enabled = true;
            btnSalvarManutVen.Visible = true;
            btnIncluir.Visible = false;
            txtNome.Focus();
        }

        private void pvInicializarVendedores()
        {
            pvLimparCampos();

            if (lTpAcesso == "INCLUIR")
            {
                btnAlterar.Enabled = false;
                btnAlterar.Visible = false;
                cbxDesatVen.Visible = false;
                cbxDesatVen.Enabled = false;
            }
            else
            {
                btnIncluir.Enabled = false;
                btnIncluir.Visible = false;
                pvPreencherCampos();
            }
            dtpNascimento.Value = DateTime.Now;
        }

        private void frmIncVendedor_Load(object sender, EventArgs e)
        {
            pvInicializarVendedores();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            //pvLerGenerator();
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            pnlGeral.Enabled = true;
            btnSalvarManutVen.Visible = true;
            btnAlterar.Visible = false;
        }

        private void pvLimparCampos()
        {
            txtIDVEN.Clear();
            txtNome.Clear();
            txtApelido.Clear();
            mTxtCEP.Clear();
            mTxtCPF.Clear();
            mTxtRG.Clear();
            mTxtTELEFONE.Clear();
            mTxtTELEFONE2.Clear();
            mTxtUF.Clear();
            txtENDERECO.Clear();
            txtNRO.Clear();
            dtpNascimento.Value = DateTime.Today;
            txtCOMP.Clear();
            txtBAIRRO.Clear();
            cbxDesatVen.Checked = false;
            txtCIDADE.Clear();
            txtObservacao.Clear();
            gpbDesatPor.Visible = false;
            gpbCadPor.Visible = false;
        }

        private void btnSalvarManutFor_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(mTxtUF.TextLength.ToString());
            if (txtNome.Text == "" || txtApelido.Text == "")
            {
                MessageBox.Show("Preencha corretamente os campos com o caracter '*'.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (dtpNascimento.Value >= DateTime.Now)
                {
                    MessageBox.Show("Data de nascimento inválida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (mTxtUF.TextLength == 2)
                    {
                        if (lTpAcesso == "INCLUIR")
                        {
                            pvSalvar();
                            btnAlterar.Visible = false;
                        }
                        else
                        {
                            pvAtualizar();
                            btnAlterar.Visible = true;
                            btnAlterar.Enabled = true;
                        }
                        gerVendedores.pvListarVendedoresAtivos();
                        pvInicializarVendedores();
                    }
                    else
                    {
                        MessageBox.Show("Preencha a UF corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            pnlGeral.Enabled = false;
            btnSalvarManutVen.Visible = false;
            btnIncluir.Visible = true;
            btnIncluir.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Text = "LEANDRO SANTIAGO ROSA ";
            txtApelido.Text = "LEANDRO";
            mTxtCPF.Text = "41181782813";
            mTxtRG.Text = "438484939";
            dtpNascimento.Value = Convert.ToDateTime("02/05/1994");
            txtENDERECO.Text = "RUA DOS BANQUEIROS";
            txtNRO.Text = "144";
            txtCOMP.Text = "BL 6A APTO 634";
            txtBAIRRO.Text = "PARQUE DOS BANCARIOS";
            mTxtCEP.Text = "03918050";
            txtCIDADE.Text = "SÃO PAULO";
            mTxtTELEFONE.Text = "1123011568";
            mTxtTELEFONE2.Text = "11954969388";
            txtObservacao.Text = "Vendedor sem restrição";
        }

        private void cbxDesatVen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDesatVen.Checked == true) //Estou desativando
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
    }
}
