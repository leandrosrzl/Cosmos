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
    class clProdutos
    {

        DataTable dadosTabela = new DataTable();
        FbCommand comandoSql = new FbCommand();
        FbConnection conexao = new FbConnection();
        StringBuilder sql = new StringBuilder();

        public void salvarProdutos(int IDPRO, int IDREV, string REF, string PRODUTO, double PRECO, double PROMOCAO, DateTime DATACAD, double COMISSAO, string OBS, int CADUSU, string ENCARTE)
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("INSERT ");
                    sql.Append("INTO ");
                    sql.Append("PRODUTOS (");

                    sql.Append("ID_PRO,  "); //1
                    sql.Append("ID_REV,  "); //2
                    sql.Append("REF,  "); //2
                    sql.Append("PRODUTO,  "); //4
                    sql.Append("PRECO,  ");//5
                    sql.Append("PROMOCAO,  ");//6
                    sql.Append("DATACAD,  ");//7
                    sql.Append("COMISSAO,  ");//8
                    sql.Append("OBS,  ");//9
                    sql.Append("CADUSU,  ");//10
                    sql.Append("ATIVO, ");//11
                    sql.Append("ENCARTE) ");//12

                    sql.Append("VALUES ");

                    //sql.Append("(99,'ASDFV', '132//13241', '19.09.2016', '19.06.2016', 0, '', 1, 'S')");

                    sql.Append("(@ID_PRO, ");
                    sql.Append("@ID_REV, ");
                    sql.Append("@REF, ");
                    sql.Append("@PRODUTO, ");
                    sql.Append("@PRECO, ");
                    sql.Append("@PROMOCAO, ");
                    sql.Append("@DATACAD, ");
                    sql.Append("@COMISSAO, ");
                    sql.Append("@OBS, ");
                    sql.Append("@CADUSU, ");
                    sql.Append("'S', ");
                    sql.Append("@ENCARTE)");

                    comandoSql.Parameters.Add(new FbParameter("@ID_PRO", IDPRO));
                    comandoSql.Parameters.Add(new FbParameter("@ID_REV", IDREV));
                    comandoSql.Parameters.Add(new FbParameter("@REF", REF));
                    comandoSql.Parameters.Add(new FbParameter("@PRODUTO", PRODUTO));
                    comandoSql.Parameters.Add(new FbParameter("@PRECO", PRECO));
                    comandoSql.Parameters.Add(new FbParameter("@PROMOCAO", PROMOCAO));
                    comandoSql.Parameters.Add(new FbParameter("@DATACAD", DATACAD));
                    comandoSql.Parameters.Add(new FbParameter("@COMISSAO", COMISSAO));
                    comandoSql.Parameters.Add(new FbParameter("@OBS", OBS));
                    comandoSql.Parameters.Add(new FbParameter("@CADUSU", CADUSU));
                    comandoSql.Parameters.Add(new FbParameter("@ENCARTE", ENCARTE));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception esp)
            {
                throw new Exception("Erro no método salvar da classe de Produtos. Se o problema persistir, comunique o administrador do sistema. " + esp);
            }
        }

        public DataTable listarProdutosAtivos()
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    dadosTabela = new DataTable();
                    sql = new StringBuilder();

                    sql.Append("SELECT P.ID_PRO, P.REF,  P.PRODUTO,  P.PRECO,  P.PROMOCAO,  R.REVISTA, R.EDICAO, R.VALIDADE, P.DATACAD,  P.COMISSAO,  P.OBS, P.ATIVO, P.ENCARTE ");
                    sql.Append("FROM PRODUTOS P ");
                    sql.Append(" INNER JOIN REVISTAS R ");
                    sql.Append(" ON P.ID_REV = R.ID_REV ");
                    sql.Append("WHERE P.ATIVO = 'S' ");
                    sql.Append(" AND R.VALIDADE >=  CURRENT_DATE ");
                    sql.Append(" AND R.ATIVO = 'S' ");
                    sql.Append(" AND P.ID_PRO >= 1 ");
                    sql.Append("ORDER BY P.ID_PRO ASC ");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elpa)
            {
                throw new Exception("Erro no método listar da classe de Produtos. Se o problema persistir, comunique o administrador do sistema. " + elpa.Message);
            }
        }

        public DataTable listarProdutosVendas(string referencia, int codigo)
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    dadosTabela = new DataTable();
                    sql = new StringBuilder();
                    comandoSql = new FbCommand();

                    sql.Append("SELECT P.ID_PRO, P.REF,  P.PRODUTO,  P.PRECO,  P.PROMOCAO, P.ID_REV, R.REVISTA, R.EDICAO, P.COMISSAO, P.ENCARTE ");
                    sql.Append(" FROM PRODUTOS P ");
                    sql.Append(" INNER JOIN REVISTAS R ");
                    sql.Append(" ON P.ID_REV = R.ID_REV ");
                    sql.Append(" WHERE P.ATIVO = 'S' ");
                    sql.Append(" AND R.VALIDADE >=  CURRENT_DATE ");
                    sql.Append(" AND P.ID_PRO >= 1 AND (");
                    if (referencia != "")
                    {
                        sql.Append(" P.REF CONTAINING @REF ");
                    }
                    if (referencia != "" && codigo > 0)
                    {
                        sql.Append(" OR ");
                    }
                    if (codigo > 0)
                    {
                        sql.Append(" P.ID_PRO = @COD ");
                    }
                    sql.Append(") ORDER BY P.ID_PRO ASC ");

                    if (referencia != "")
                    {
                        comandoSql.Parameters.Add(new FbParameter("@REF", referencia));
                    }
                    if (codigo > 0)
                    {
                        comandoSql.Parameters.Add(new FbParameter("@COD", codigo));
                    }

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elpa)
            {
                throw new Exception("Erro no método listar da classe de Produtos. Se o problema persistir, comunique o administrador do sistema. " + elpa.Message);
            }
        }

        public DataTable listarProdutosInativos()
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    dadosTabela = new DataTable();
                    sql = new StringBuilder();

                    sql.Append("SELECT P.ID_PRO, P.REF,  P.PRODUTO,  P.PRECO,  P.PROMOCAO,  R.REVISTA, R.EDICAO, R.VALIDADE, P.DATACAD,  P.COMISSAO,  P.OBS, P.ATIVO, P.ENCARTE ");
                    sql.Append("FROM PRODUTOS P ");
                    sql.Append(" INNER JOIN REVISTAS R ");
                    sql.Append(" ON P.ID_REV = R.ID_REV ");
                    sql.Append("WHERE (P.ATIVO = 'N' ");
                    sql.Append(" AND P.ID_PRO >= 1 )");
                    sql.Append(" AND R.VALIDADE <  CURRENT_DATE ");
                    sql.Append("ORDER BY P.ID_PRO ASC ");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elpi)
            {
                throw new Exception("Erro no método listar da classe de Produtos. Se o problema persistir, comunique o administrador do sistema. " + elpi.Message);
            }
        }

        public DataTable listarTodosProdutos()
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    dadosTabela = new DataTable();
                    sql = new StringBuilder();

                    sql.Append("SELECT P.ID_PRO, P.REF,  P.PRODUTO,  P.PRECO,  P.PROMOCAO,  R.REVISTA, R.EDICAO, R.VALIDADE, P.DATACAD,  P.COMISSAO,  P.OBS, P.ATIVO, P.ENCARTE ");
                    sql.Append("FROM PRODUTOS P ");
                    sql.Append(" INNER JOIN REVISTAS R ");
                    sql.Append(" ON P.ID_REV = R.ID_REV ");
                    sql.Append(" WHERE P.ID_PRO >= 1 ");
                    sql.Append("ORDER BY P.ID_PRO ASC ");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception eltp)
            {
                throw new Exception("Erro no método listar da classe de Produtos. Se o problema persistir, comunique o administrador do sistema. " + eltp.Message);
            }
        }

        public DataTable listarProdutosComFiltro(int idpro, string produto, string ativo, int revista)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    dadosTabela = new DataTable();
                    sql = new StringBuilder();

                    sql.Append("SELECT P.ID_PRO, P.ID_REV,  P.REF,  P.PRODUTO,  P.PRECO,  P.PROMOCAO,  R.REVISTA, R.EDICAO, R.VALIDADE, P.DATACAD,  P.COMISSAO,  P.OBS, P.ATIVO, P.ENCARTE ");
                    sql.Append("FROM PRODUTOS P ");
                    sql.Append(" INNER JOIN REVISTAS R ");
                    sql.Append(" ON P.ID_REV = R.ID_REV ");
                    sql.Append(" WHERE ( ");
                    if (idpro != 0)
                    {
                        sql.Append(" (ID_PRO = @IDPRO  ");
                        sql.Append(" OR P.REF CONTAINING @IDPRO) ");
                    }
                    if (idpro != 0 && produto != "")
                    {
                        sql.Append(" AND ");
                    }
                    if (produto != "")
                    {
                        sql.Append(" P.PRODUTO CONTAINING (@PRODUTO) ");
                    }
                    if ((produto != "" & ativo != "") || (ativo != "" & idpro != 0))
                    {
                        sql.Append(" AND ");
                    }
                    if (ativo != "")
                    {
                        sql.Append("  P.ATIVO = @ATIVO ");
                    }
                    if (ativo != "" & revista != 0)
                    {
                        sql.Append(" AND ");
                    }
                    if (revista != 0)
                    {
                        sql.Append(" P.ID_REV = @REVISTA ");
                    }

                    sql.Append(") ORDER BY ID_PRO ASC ");



                    if (idpro != 0)
                    {
                        comandoSql.Parameters.Add(new FbParameter("@IDPRO", idpro));
                    }

                    if (produto != "")
                    {
                        comandoSql.Parameters.Add(new FbParameter("@PRODUTO", produto));
                    }

                    if (ativo != "")
                    {
                        comandoSql.Parameters.Add(new FbParameter("@ATIVO", ativo));
                    }

                    if (revista != 0)
                    {
                        comandoSql.Parameters.Add(new FbParameter("@REVISTA", revista));
                    }

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elpc)
            {
                throw new Exception("Erro no método listar com filtro da classe de Produtos. Se o problema persistir, comunique o administrador do sistema. " + elpc.Message);
            }
        }

        public DataTable listarProdutosComFiltroInc(int idpro)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    dadosTabela = new DataTable();
                    sql = new StringBuilder();

                    sql.Append("SELECT P.ID_PRO, P.ID_REV,  P.REF, P.PRODUTO,  P.PRECO,  P.PROMOCAO,  R.REVISTA, P.DATACAD,  P.COMISSAO,  P.OBS,  P.ATIVO, P.CADUSU, U.NOME_USU, ");
                    sql.Append(" P.DESATUSU, P.DESATDATA  , P.ENCARTE ");
                    sql.Append("FROM PRODUTOS P ");
                    sql.Append(" INNER JOIN USUARIOS U ");
                    sql.Append(" ON P.CADUSU = U.ID_USU ");
                    sql.Append(" INNER JOIN REVISTAS R ");
                    sql.Append(" ON P.ID_REV = R.ID_REV ");
                    sql.Append("WHERE P.ID_PRO = @IDPRO ");
                    sql.Append("ORDER BY P.ID_REV ASC ");

                    comandoSql.Parameters.Add(new FbParameter("@IDPRO", idpro));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elpc)
            {
                throw new Exception("Erro no método listar com filtro da classe de Produtos. Se o problema persistir, comunique o administrador do sistema. " + elpc.Message);
            }
        }

        public DataTable lerGenerator()
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    dadosTabela = new DataTable();
                    sql = new StringBuilder();

                    sql.Append("SELECT GEN_ID(GEN_PRO_IDPRO,1) FROM RDB$DATABASE");

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

        public void excluirProdutos(int idpro)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("UPDATE PRODUTOS ");
                    sql.Append("SET ATIVO = 'N' ");
                    sql.Append("WHERE ID_PRO = @IDPRO ");

                    comandoSql.Parameters.Add(new FbParameter("@IDPRO", idpro));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception eip)
            {
                throw new Exception("Erro ao excluir Produtos na classe Produtos. Se o problema persistir, contate o administrador do sistema. \nErro original: " + eip.Message);
            }
        }

        public void reativarProdutos(int idpro)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("UPDATE PRODUTOS ");
                    sql.Append("SET ATIVO = 'S' ");
                    sql.Append("WHERE ID_PRO = @IDPRO ");

                    comandoSql.Parameters.Add(new FbParameter("@IDPRO", idpro));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception eip)
            {
                throw new Exception("Erro ao excluir Produtos na classe Produtos. Se o problema persistir, contate o administrador do sistema. \nErro original: " + eip.Message);
            }
        }

        public void editarProdutos(int IDPRO, int IDREV, string REF, string PRODUTO, double PRECO, double PROMOCAO, double COMISSAO, string OBS, int desatusu, DateTime desatdata, string ativo, string ENCARTE)
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("UPDATE PRODUTOS SET ");
                    sql.Append("ID_REV=@IDREV,");
                    sql.Append("REF=@REF,");
                    sql.Append("PRODUTO=@PRODUTO,");
                    sql.Append("PRECO=@PRECO,");
                    sql.Append("PROMOCAO=@PROMOCAO,");
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
                    sql.Append("ATIVO=@ATIVO, ");
                    sql.Append("ENCARTE=@ENCARTE ");

                    sql.Append("WHERE ID_PRO=@IDPRO");

                    comandoSql.Parameters.Add(new FbParameter("@IDPRO", IDPRO));
                    comandoSql.Parameters.Add(new FbParameter("@IDREV", IDREV));
                    comandoSql.Parameters.Add(new FbParameter("@REF", REF));
                    comandoSql.Parameters.Add(new FbParameter("@PRODUTO", PRODUTO));
                    comandoSql.Parameters.Add(new FbParameter("@PRECO", PRECO));
                    comandoSql.Parameters.Add(new FbParameter("@PROMOCAO", PROMOCAO));
                    comandoSql.Parameters.Add(new FbParameter("@COMISSAO", COMISSAO));
                    comandoSql.Parameters.Add(new FbParameter("@OBS", OBS));
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
                    comandoSql.Parameters.Add(new FbParameter("@ENCARTE", ENCARTE));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception eap)
            {
                throw new Exception("Erro no método atualizar da classe de Produtos. Se o problema persistir, comunique o administrador do sistema. " + eap.Message);
            }
        }

        public DataTable listarRevistas()
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    dadosTabela = new DataTable();
                    sql.Append("SELECT ID_REV, REVISTA FROM REVISTAS WHERE ATIVO = 'S' AND VALIDADE >= CURRENT_DATE ORDER BY REVISTA ASC ");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elr)
            {

                throw new Exception("Erro no método listar revistas da classe de Produtos. Se o problema persistir, comunique o administrador do sistema. " + elr.Message);
            }
        }

    } //fim da classe clProdutos
} //fim do namespace COSMOS
