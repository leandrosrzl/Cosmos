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
    class clRevistas
    {
        DataTable dadosTabela = new DataTable(); 
        FbCommand comandoSql = new FbCommand();
        FbConnection conexao = new FbConnection();
        StringBuilder sql = new StringBuilder();

        public void salvarRevistas(int id_rev, string revista, string edicao, DateTime validade, DateTime datacad, double comissao, string obs, int cadusu)
        {
            try
            {
                using (FbConnection conexao= new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("INSERT ");
                    sql.Append("INTO ");
                    sql.Append("REVISTAS (");

                    sql.Append("ID_REV,  ");
                    sql.Append("REVISTA,  ");
                    sql.Append("EDICAO,  ");
                    sql.Append("VALIDADE,  ");
                    sql.Append("DATACAD,  ");
                    sql.Append("COMISSAO,  ");
                    sql.Append("OBS,  ");
                    sql.Append("CADUSU,  "); 
                    sql.Append("ATIVO) ");

                    sql.Append("VALUES ");

                    //sql.Append("(99,'ASDFV', '132//13241', '19.09.2016', '19.06.2016', 0, '', 1, 'S')");

                    sql.Append("(@ID_REV, ");
                    sql.Append("@REVISTA, ");
                    sql.Append("@EDICAO, ");
                    sql.Append("@VALIDADE, ");
                    sql.Append("@DATACAD, ");
                    sql.Append("@COMISSAO, ");
                    sql.Append("@OBS, ");
                    sql.Append("@CADUSU, ");
                    sql.Append("'S')");

                    comandoSql.Parameters.Add(new FbParameter("@ID_REV", id_rev));
                    comandoSql.Parameters.Add(new FbParameter("@REVISTA", revista));
                    comandoSql.Parameters.Add(new FbParameter("@EDICAO", edicao));
                    comandoSql.Parameters.Add(new FbParameter("@VALIDADE", validade));
                    comandoSql.Parameters.Add(new FbParameter("@DATACAD", datacad));
                    comandoSql.Parameters.Add(new FbParameter("@COMISSAO", comissao));
                    comandoSql.Parameters.Add(new FbParameter("@OBS", obs));
                    comandoSql.Parameters.Add(new FbParameter("@CADUSU", cadusu));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception esr)
            {
                throw new Exception("Erro no método salvar da classe de revistas. Se o problema persistir, comunique o administrador do sistema. " + esr);
            }
        }

        public DataTable listarRevistasAtivas()
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT ID_REV,  REVISTA,  EDICAO,  VALIDADE,  DATACAD,  COMISSAO,  OBS, ATIVO ");
                    sql.Append("FROM REVISTAS ");
                    sql.Append("WHERE ATIVO = 'S' ");
                    sql.Append("AND VALIDADE >= CURRENT_DATE ");
                    sql.Append("AND ID_REV >= 1 ");
                    sql.Append("ORDER BY ID_REV ASC ");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elra)
            {
                throw new Exception("Erro no método listar da classe de revistas. Se o problema persistir, comunique o administrador do sistema. " + elra.Message);
            }
        }

        public DataTable listarRevistasInativas()
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT ID_REV,  REVISTA,  EDICAO,  VALIDADE,  DATACAD,  COMISSAO,  OBS, ATIVO ");
                    sql.Append("FROM REVISTAS ");
                    sql.Append("WHERE ATIVO = 'N' ");
                    sql.Append("AND ID_REV >= 1 ");
                    sql.Append("ORDER BY ID_REV ASC ");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elri)
            {
                throw new Exception("Erro no método listar da classe de revistas. Se o problema persistir, comunique o administrador do sistema. " + elri.Message);
            }
        }

        public DataTable listarTodasRevistas()
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT ID_REV,  REVISTA,  EDICAO,  VALIDADE,  DATACAD,  COMISSAO,  OBS, ATIVO ");
                    sql.Append(" FROM REVISTAS ");
                    sql.Append("WHERE ID_REV >= 1 ");
                    sql.Append("ORDER BY ID_REV ASC ");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception eltr)
            {
                throw new Exception("Erro no método listar da classe de revistas. Se o problema persistir, comunique o administrador do sistema. " + eltr.Message);
            }
        }

        public DataTable listarRevistasComFiltro(int idrev, string revista, string ativo)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT ID_REV,  REVISTA,  EDICAO,  VALIDADE,  DATACAD,  COMISSAO,  OBS, ATIVO ");
                    sql.Append("FROM REVISTAS ");
                    sql.Append(" WHERE ( ");
                    if (idrev != 0)
                    {
                        sql.Append("ID_REV = @IDREV  ");
                    }
                    if (idrev != 0 && revista != "")
                    {
                        sql.Append(" OR ");
                    }
                    if (revista != "")
                    {
                        sql.Append(" REVISTA CONTAINING (@REVISTA) ");
                    }
                    if (ativo != "")
                    {
                        sql.Append(" AND ATIVO = @ATIVO ");
                        if(ativo == "S")
                        {
                            sql.Append("AND VALIDADE >= CURRENT_DATE ");
                        }
                    }

                    sql.Append(") ORDER BY ID_REV ASC ");



                    if (idrev != 0)
                    {
                        comandoSql.Parameters.Add(new FbParameter("@IDREV", idrev));
                    }

                    if (revista != "")
                    {
                        comandoSql.Parameters.Add(new FbParameter("@REVISTA", revista));
                    }

                    if (ativo != "")
                    {
                        comandoSql.Parameters.Add(new FbParameter("@ATIVO", ativo));
                    }

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elrc)
            {
                throw new Exception("Erro no método listar com filtro da classe de revistas. Se o problema persistir, comunique o administrador do sistema. " + elrc.Message);
            }
        }

        public DataTable listarRevistasComFiltroInc(int idrev)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT R.ID_REV,  R.REVISTA,  R.EDICAO,  R.VALIDADE,  R.DATACAD,  R.COMISSAO,  R.OBS,  R.ATIVO, R.CADUSU, U.NOME_USU, ");
                    sql.Append(" R.DESATUSU, R.DESATDATA  ");
                    sql.Append("FROM REVISTAS R ");
                    sql.Append(" INNER JOIN USUARIOS U ");
                    sql.Append(" ON R.CADUSU = U.ID_USU ");
                    sql.Append("WHERE R.ID_REV = @IDREV ");
                    sql.Append("ORDER BY R.ID_REV ASC ");

                    comandoSql.Parameters.Add(new FbParameter("@IDREV", idrev));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elrc)
            {
                throw new Exception("Erro no método listar com filtro da classe de revistas. Se o problema persistir, comunique o administrador do sistema. " + elrc.Message);
            }
        }

        public DataTable lerGenerator()
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT GEN_ID(GEN_REV_IDREV,1) FROM RDB$DATABASE");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elg)
            {
                throw new Exception("Erro ao ler generator. Se o problema persistir, contate o administrador do sistema. \nErro original: " + elg.Message);
            }
        }

        public void excluirRevista(int idrev)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("UPDATE REVISTAS ");
                    sql.Append("SET ATIVO = 'N' ");
                    sql.Append("WHERE ID_REV = @IDREV ");

                    comandoSql.Parameters.Add(new FbParameter("@IDREV", idrev));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception eir)
            {
                throw new Exception("Erro ao excluir revistas na classe revistas. Se o problema persistir, contate o administrador do sistema. \nErro original: " + eir.Message);
            }
        }

        public void editarRevistas(int id_rev, string revista, string edicao, DateTime validade, double comissao, string obs, int desatusu, DateTime desatdata, string ativo)
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("UPDATE REVISTAS SET ");
                    sql.Append("REVISTA=@REVISTA,");
                    sql.Append("EDICAO=@EDICAO,");
                    sql.Append("VALIDADE=@VALIDADE,");
                    sql.Append("COMISSAO=@COMISSAO,");
                    sql.Append("OBS=@OBS,");
                    if (desatusu == 0)
                    {
                        sql.Append("DESATUSU=null,");
                        sql.Append("DESATDATA=null,");
                    }
                    else
                    {
                        sql.Append("DESATUSU=@DESATUSU,");
                        sql.Append("DESATDATA=@DESATDATA,");
                    }
                    sql.Append("ATIVO=@ATIVO ");
                    sql.Append("WHERE ID_REV=@IDREV");


                    comandoSql.Parameters.Add(new FbParameter("@IDREV", id_rev));
                    comandoSql.Parameters.Add(new FbParameter("@REVISTA", revista));
                    comandoSql.Parameters.Add(new FbParameter("@EDICAO", edicao));
                    comandoSql.Parameters.Add(new FbParameter("@VALIDADE", validade));
                    comandoSql.Parameters.Add(new FbParameter("@COMISSAO", comissao));
                    comandoSql.Parameters.Add(new FbParameter("@OBS", obs));
                    if (desatusu == 0)
                    {
                        //absolutamente nada
                    }
                    else
                    {
                        comandoSql.Parameters.Add(new FbParameter("@DESATUSU", desatusu));
                        comandoSql.Parameters.Add(new FbParameter("@DESATDATA", desatdata));
                    }
                    comandoSql.Parameters.Add(new FbParameter("@ATIVO", ativo));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception ear)
            {
                throw new Exception("Erro no método atualizar da classe de revistas. Se o problema persistir, comunique o administrador do sistema. " + ear.Message);
            }
        }

        public DataTable consultarComissao(int idrev)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("SELECT COMISSAO FROM REVISTAS ");
                    sql.Append(" WHERE ID_REV = @IDREV ");

                    comandoSql.Parameters.Add(new FbParameter("@IDREV", idrev));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elc)
            {
                throw new Exception("Erro ao consultar a comissão na classe de revistas. Se o problema persistir, entre em contato com o Administrador do sistema.\n" + elc.Message);
            }
        }
    }
}
