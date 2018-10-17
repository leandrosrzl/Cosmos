using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FirebirdSql.Data.FirebirdClient;

namespace COSMOS
{
    class clUsuarios
    {
        DataTable dadosTabela = new DataTable();
        FbCommand comandoSql = new FbCommand();
        FbConnection conexao = new FbConnection();
        StringBuilder sql = new StringBuilder();

        public void alterarSenha(int idusu, string senha)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE USUARIOS ");
                    sql.Append(" SET SENHA = @SENHA ");
                    sql.Append(" WHERE ID_USU = @IDUSU ");

                    comandoSql.Parameters.Add(new FbParameter("@IDUSU", idusu));
                    comandoSql.Parameters.Add(new FbParameter("@SENHA", senha));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception eas)
            {

                throw new Exception("Erro no método mudar senha da classe de Usuários. Se o problema persistir, comunique o administrador do sistema. " + eas);
            }
        }
    }
}
