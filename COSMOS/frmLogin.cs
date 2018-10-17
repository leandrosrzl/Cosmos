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
using FirebirdSql.Data.FirebirdClient;

namespace COSMOS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        FbConnection sqlConn = null;
        FbDataReader leitorSql;
        private string _Sql = string.Empty;
        string[] v = new string[4];

        private void pvLogar(string strUsu, string strPass)
        {
            sqlConn = new FbConnection(clConexao.stringConexao);

            try
            {
                _Sql = "SELECT ID_USU, NOME_USU FROM USUARIOS WHERE NOME_USU = @NOME AND SENHA = @SENHA";

                FbCommand comandoSql = new FbCommand(_Sql, sqlConn);

                comandoSql.Parameters.Add("@NOME", strUsu);
                comandoSql.Parameters.Add("@SENHA", strPass);

                sqlConn.Open();
                leitorSql = comandoSql.ExecuteReader();
                if (leitorSql.Read())
                {
                    v[0] = leitorSql["ID_USU"].ToString();
                    v[1] = leitorSql["NOME_USU"].ToString();
                    v[2] = System.Windows.Forms.SystemInformation.ComputerName.ToString();
                    v[3] = txtSenha.Text;

                    frmPrincipal principal = new frmPrincipal(v);
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos. \n", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro no método de conexão. Comunique o administrador do sistema.\nErro original: " + erro.Message, "Erro conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pvPreLogar()
        {
            if (txtUsuario.Text != "" && txtSenha.Text != "")
            {
                pvLogar(txtUsuario.Text, txtSenha.Text);
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro ao conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            pvPreLogar();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pvPreLogar();
            }
        }
    }
}
