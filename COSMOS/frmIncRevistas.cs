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
    public partial class frmIncRevistas : Form
    {
        string lTpAcesso, ativo="S";
        clRevistas revistas;
        int idrev;
        int idusu, desatusu=0;
        frmGerRevistas gerRevistas;
        DateTime dataDesat=Convert.ToDateTime("01/01/2001");
        DataTable dadosTabela;

        public frmIncRevistas(frmGerRevistas frmGerRev, string tpAcesso, int codrev, int idUsu)
        {
            gerRevistas = frmGerRev;
            InitializeComponent();
            lTpAcesso = tpAcesso;
            idrev = codrev;
            idusu = idUsu;
        }

        private void pvLerGenerator()
        {
            revistas = new clRevistas();
            dadosTabela = new DataTable();
            dadosTabela = revistas.lerGenerator();
            idrev = Convert.ToInt32(dadosTabela.Rows[0]["GEN_ID"].ToString());
        }

        private void pvSalvar()
        {
            revistas = new clRevistas();
            pvLerGenerator();
            //MessageBox.Show("IDVEN: "+idven.ToString());
            revistas.salvarRevistas(idrev, txtRevista.Text, txtEdicao.Text, dtpValidade.Value, DateTime.Now, Convert.ToDouble(txtComissao.Text), txtObservacao.Text, Convert.ToInt32(idusu));
            MessageBox.Show("Revista cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gerRevistas.pvListarRevistasAtivas();
        }

        private void pvPreencherCampos()
        {
            txtIDREV.Text = dadosTabela.Rows[0]["ID_REV"].ToString();
            txtRevista.Text = dadosTabela.Rows[0]["REVISTA"].ToString();
            txtEdicao.Text = dadosTabela.Rows[0]["EDICAO"].ToString();
            dtpValidade.Value = Convert.ToDateTime(dadosTabela.Rows[0]["VALIDADE"]);
            txtComissao.Text = dadosTabela.Rows[0]["COMISSAO"].ToString();
            lblDataCad.Text = Convert.ToDateTime(dadosTabela.Rows[0]["DATACAD"].ToString()).ToShortDateString();
            lblUsuCad.Text = dadosTabela.Rows[0]["NOME_USU"].ToString();
            txtObservacao.Text = dadosTabela.Rows[0]["OBS"].ToString();
            if (dadosTabela.Rows[0]["ATIVO"].ToString() == "S")
            {
                cbxDesatVen.Checked = false;
            }
            else
            {
                cbxDesatVen.Checked = true;
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
        }

        private void pvLerRevistaComFiltro()
        {
            revistas = new clRevistas();
            dadosTabela = new DataTable();
            dadosTabela = revistas.listarRevistasComFiltroInc(idrev);
            pvPreencherCampos();
        }

        private void pvAtualizar()
        {
            revistas = new clRevistas();
            try
            {
                revistas.editarRevistas(Convert.ToInt32(txtIDREV.Text), txtRevista.Text, txtEdicao.Text, dtpValidade.Value, Convert.ToDouble(txtComissao.Text), txtObservacao.Text, 
                    desatusu, dataDesat, ativo.ToString());
                MessageBox.Show("Revista alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gerRevistas.pvListarRevistasAtivas();
            }
            catch (Exception eer)
            {
                throw new Exception("Erro no formulario de inclusao de revistas. Se o problema persistir comunique o administrador do sistema. Erro original: \n" + eer);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            lTpAcesso = "INCLUIR";
            pvInicializarRevistas();
            pnlGeral.Enabled = true;
            btnSalvarManutVen.Visible = true;
            btnIncluir.Visible = false;
            btnAlterar.Visible = false;
            txtRevista.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            pnlGeral.Enabled = true;
            btnSalvarManutVen.Visible = true;
            btnAlterar.Visible = false;
            btnIncluir.Visible = false;
            txtRevista.Focus();
        }

        private void btnSalvarManutVen_Click(object sender, EventArgs e)
        {
            if (txtEdicao.Text == "" || txtRevista.Text == "")
            {
                MessageBox.Show("Preencha os campos com '*'.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dtpValidade.Value > DateTime.Today)
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
                    pvInicializarRevistas();
                }
                else
                {
                    MessageBox.Show("A data de vencimento não pode ser menor que a data de hoje.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            pnlGeral.Enabled = false;
            btnSalvarManutVen.Visible = false;
            btnIncluir.Visible = true;
            btnIncluir.Enabled = true;
        }

        private void pvLimparCampos()
        {
            txtRevista.Clear();
            txtIDREV.Clear();
            txtObservacao.Clear();
            txtEdicao.Clear();
            txtComissao.Text = "0";
            dtpValidade.Value = DateTime.Today;
            cbxDesatVen.Checked = false;
            gpbCadPor.Visible = false;
            gpbDesatPor.Visible = false;
        }

        private void pvInicializarRevistas()
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
                pvLerRevistaComFiltro();
            }
        }

        private void frmIncRevistas_Load(object sender, EventArgs e)
        {
            pvInicializarRevistas();
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
