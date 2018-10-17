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
    public partial class frmAlterarSenha : Form
    {
        clUsuarios novoUsuario;
        int idusu;
        string nomeusu, senha;

        public frmAlterarSenha(int id_usu, string nome_usu, string senha_)
        {
            InitializeComponent();
            idusu = id_usu;
            nomeusu = nome_usu;
            senha = senha_;
        }

        private void pvAlterar()
        {
            novoUsuario = new clUsuarios();
            if (txtNovaSenha.Text == txtConfirmaNovaSenha.Text & txtAtual.Text == senha)
            {
                if (MessageBox.Show("Tem certeza de que deseja alterar a senha do usuário " + nomeusu + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        novoUsuario.alterarSenha(idusu, txtNovaSenha.Text);
                        MessageBox.Show("Senha alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    catch (Exception Err)
                    {
                        MessageBox.Show(Err.Message + " Erro no form Erro ao alterar a senha do usuario. Se o problema persistir, entre em contato com o Administrador do Sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Senha atual inválida ou novas senhas com valores diferentes. \nVerifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmAlterarSenha_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = nomeusu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pvAlterar();
        }

        private void txtNovaSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtConfirmaNovaSenha.Select();
                txtConfirmaNovaSenha.SelectAll();
            }
        }

        private void txtAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNovaSenha.Select();
                txtNovaSenha.SelectAll();
            }
        }

        private void txtConfirmaNovaSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pvAlterar();
            }
        }
    }
}
