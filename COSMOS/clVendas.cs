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
    class clVendas
    {
        DataTable dadosTabela = new DataTable();
        FbCommand comandoSql = new FbCommand();
        FbConnection conexao = new FbConnection();
        StringBuilder sql = new StringBuilder();

        public DataTable buscarVendedor(string vendedor, int codigo)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT IDVEN, APELIDO FROM VENDEDORES ");
                    sql.Append(" WHERE ATIVO = 'S' AND ");
                    sql.Append(" IDVEN > 0 AND ( ");
                    if (vendedor != "")
                    {
                        sql.Append(" APELIDO CONTAINING @APELIDO ");
                    }
                    if (vendedor != "" && codigo > 0)
                    {
                        sql.Append(" OR ");
                    }
                    if (codigo > 0)
                    {
                        sql.Append(" IDVEN = @IDVEN ");
                    }
                    sql.Append(" ) ");

                    comandoSql.Parameters.Add(new FbParameter("@APELIDO", vendedor));
                    comandoSql.Parameters.Add(new FbParameter("@IDVEN", codigo));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elv)
            {
                throw new Exception("Erro ao procurar o vendedor na classe de vendas. Se o problema persistir, entre em contato com o administrador do sistema. \n"+elv.Message);
            }
        } //fim DataTable buscarVendedor

        public DataTable lerGeneratorIDVDA()
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT GEN_ID(GEN_VENDAS_IDVDA,1) FROM RDB$DATABASE");

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
        } // fim DataTable lerGeneratorIDVDA

        public DataTable lerGeneratorNROVDA()
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT GEN_ID(GEN_VENDAS_NROVDA,1) FROM RDB$DATABASE");

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
        } // fim DataTable lerGeneratorNROVDA

        public void salvarPedido(int idvda, int id_usu, int idven, string nrovda, DateTime datapagto, DateTime dataentr, DateTime emissao, string status, double vtotal, double comissao, int ttl_itens)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append(" INSERT INTO VENDAS (IDVDA, ID_USU, IDVEN, NROVDA, DATAPAGTO, DATAENTR, EMISSAO, STATUS, VTOTAL, COMISSAO, TTL_ITENS) ");
                    sql.Append(" VALUES (@IDVDA, @ID_USU, @IDVEN, @NROVDA, @DATAPAGTO, @DATAENTR, @EMISSAO, @STATUS, @VTOTAL, @COMISSAO, @TTL_ITENS) ");

                    comandoSql.Parameters.Add(new FbParameter("@IDVDA", idvda));
                    comandoSql.Parameters.Add(new FbParameter("@ID_USU", id_usu));
                    comandoSql.Parameters.Add(new FbParameter("@IDVEN", idven));
                    comandoSql.Parameters.Add(new FbParameter("@NROVDA", nrovda));
                    comandoSql.Parameters.Add(new FbParameter("@DATAPAGTO", datapagto));
                    comandoSql.Parameters.Add(new FbParameter("@DATAENTR", dataentr));
                    comandoSql.Parameters.Add(new FbParameter("@EMISSAO", emissao));
                    comandoSql.Parameters.Add(new FbParameter("@STATUS", status));
                    comandoSql.Parameters.Add(new FbParameter("@VTOTAL", vtotal));
                    comandoSql.Parameters.Add(new FbParameter("@COMISSAO", comissao));
                    comandoSql.Parameters.Add(new FbParameter("@TTL_ITENS", ttl_itens));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception eip)
            {
                throw new Exception("Erro ao inserir o cabeçalho do pedido. Se o problema persistir, comunique o adminstrador do sistema.\n" + eip.Message);
            }
        } // Fim do void salvarPedido

        public void salvarItensPedido(int idvda, int id_pro, int id_rev, int item, string referencia, string produto, double vunit, double qtd, double vtotal, string revista, string edicao, double comissao, double vlrcomissao)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append(" INSERT INTO ITENS_VENDA (IDVDA, ID_PRO, ID_REV, ITEM, REF, PRODUTO, VUNIT, QTD, VTOTAL, REVISTA, EDICAO, COMISSAO, VLRCOMISSAO) ");
                    sql.Append(" VALUES(@IDVDA, @ID_PRO, @ID_REV, @ITEM, @REF, @PRODUTO, @VUNIT, @QTD, @VTOTAL, @REVISTA, @EDICAO, @COMISSAO, @VLRCOMISSAO) ");

                    comandoSql.Parameters.Add(new FbParameter("@IDVDA", idvda));
                    comandoSql.Parameters.Add(new FbParameter("@ID_PRO", id_pro));
                    comandoSql.Parameters.Add(new FbParameter("@ID_REV", id_rev));
                    comandoSql.Parameters.Add(new FbParameter("@ITEM", item));
                    comandoSql.Parameters.Add(new FbParameter("@REF", referencia));
                    comandoSql.Parameters.Add(new FbParameter("@PRODUTO", produto));
                    comandoSql.Parameters.Add(new FbParameter("@VUNIT", vunit));
                    comandoSql.Parameters.Add(new FbParameter("@QTD", qtd));
                    comandoSql.Parameters.Add(new FbParameter("@VTOTAL", vtotal));
                    comandoSql.Parameters.Add(new FbParameter("@REVISTA", revista));
                    comandoSql.Parameters.Add(new FbParameter("@EDICAO", edicao));
                    comandoSql.Parameters.Add(new FbParameter("@COMISSAO", comissao));
                    comandoSql.Parameters.Add(new FbParameter("@VLRCOMISSAO", vlrcomissao));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception eiip)
            {
                throw new Exception("Erro ao inserir os itens do pedido. Se o problema persistir, comunique o adminstrador do sistema.\n" + eiip.Message);
            }
        }//Fim do void salvarItensPedido

        public DataTable listarVendasComFiltro(int idvda)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT VD.IDVDA, VD.NROVDA, VE.APELIDO, ");
                    sql.Append(" (SELECT COUNT (IDVDA) FROM ITENS_VENDA IV WHERE IV.IDVDA = @IDVDA) AS \"ITENS\", ");
                    sql.Append(" VD.VTOTAL, VD.EMISSAO, VD.DATAENTR, VD.DATAPAGTO, VD.STATUS, VD.COMISSAO, VD.TTL_ITENS ");
                    sql.Append(" FROM VENDAS VD ");
                    sql.Append(" INNER JOIN VENDEDORES VE ");
                    sql.Append(" ON VD.IDVEN = VE.IDVEN ");
                    sql.Append(" WHERE VD.IDVDA = @IDVDA ");

                    comandoSql.Parameters.Add(new FbParameter("@IDVDA", idvda));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elva)
            {
                throw new Exception("Erro ao listar o pedido com filtro. Se o problema persistir, comunique o adminstrador do sistema.\n" + elva.Message);
            }
        }//Fim DataTable listarVendasComFiltro

        public void excluirItemPedido(int idpro, int idvda)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("DELETE FROM ITENS_VENDA ");
                    sql.Append(" WHERE ID_PRO = @IDPRO AND IDVDA = @IDVDA ");

                    comandoSql.Parameters.Add(new FbParameter("@IDPRO", idpro));
                    comandoSql.Parameters.Add(new FbParameter("@IDVDA", idvda));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception eeip)
            {
                throw new Exception("Erro ao excluir o item do pedido. Se o problema persistir, comunique o adminstrador do sistema.\n" + eeip.Message);
            }
        }//FIM DATATABLE EXCLUIRITEMPEDIDO

        public DataTable listarItensVendas(int idvda)
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();
                    dadosTabela = new DataTable();

                    sql.Append("SELECT ITEM, ID_PRO, REF, PRODUTO, ID_REV, REVISTA, EDICAO, VUNIT, QTD, VTOTAL, COMISSAO, VLRCOMISSAO ");
                    sql.Append(" FROM ITENS_VENDA WHERE IDVDA = @IDVDA ");
                    sql.Append(" ORDER BY ITEM ASC ");

                    comandoSql.Parameters.Add(new FbParameter("@IDVDA", idvda));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elpp)
            {
                throw new Exception("Erro no método listar produtos do pedido da classe de Vendas. Se o problema persistir, comunique o administrador do sistema. " + elpp.Message);
            }
        }//Fim DataTable listarItensVendas

        public void atualizarCabecalho(int idvda, double vtotal, double comissao, int ttl_itens, string status)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append("UPDATE VENDAS SET VTOTAL = @VTOTAL, COMISSAO = @COMISSAO, TTL_ITENS = @TTL_ITENS, STATUS = @STATUS WHERE IDVDA = @IDVDA ");

                    comandoSql.Parameters.Add(new FbParameter("@IDVDA", idvda));
                    comandoSql.Parameters.Add(new FbParameter("@COMISSAO", comissao));
                    comandoSql.Parameters.Add(new FbParameter("@VTOTAL", vtotal));
                    comandoSql.Parameters.Add(new FbParameter("@TTL_ITENS", ttl_itens));
                    comandoSql.Parameters.Add(new FbParameter("@STATUS", status));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception eacp)
            {
                throw new Exception("Erro no método atualizar cabeçalho do pedido na classe de Vendas. Se o problema persistir, comunique o administrador do sistema. " + eacp.Message);
            }
        }//Fim do void atualizarCabecalho

        public void atualizarItensPedido(int idvda, int id_pro, int item, double vunit, double qtd, double vtotal, double comissao, double vlrcomissao)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("UPDATE ITENS_VENDA SET ITEM=@ITEM, ");
                    sql.Append("VUNIT=@VUNIT, ");
                    sql.Append("QTD=@QTD, ");
                    sql.Append("VTOTAL=@VTOTAL, ");
                    sql.Append("COMISSAO=@COMISSAO, ");
                    sql.Append("VLRCOMISSAO=@VLRCOMISSAO ");
                    sql.Append("WHERE IDVDA = @IDVDA  AND ID_PRO = @ID_PRO AND ITEM = @ITEM ");

                    comandoSql.Parameters.Add(new FbParameter("@IDVDA", idvda));
                    comandoSql.Parameters.Add(new FbParameter("@ID_PRO", id_pro));
                    comandoSql.Parameters.Add(new FbParameter("@ITEM", item));
                    comandoSql.Parameters.Add(new FbParameter("@VUNIT", vunit));
                    comandoSql.Parameters.Add(new FbParameter("@QTD", qtd));
                    comandoSql.Parameters.Add(new FbParameter("@VTOTAL", vtotal));
                    comandoSql.Parameters.Add(new FbParameter("@COMISSAO", comissao));
                    comandoSql.Parameters.Add(new FbParameter("@VLRCOMISSAO", vlrcomissao));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception eiip)
            {
                throw new Exception("Erro ao inserir os itens do pedido. Se o problema persistir, comunique o adminstrador do sistema.\n" + eiip.Message);
            }
        }//Fim do void salvarItensPedido

        public DataTable listarVendas(int idvda, string status)
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();
                    dadosTabela = new DataTable();

                    sql.Append(" SELECT IDVDA, NROVDA, VD.IDVEN, VE.APELIDO, TTL_ITENS, VTOTAL, EMISSAO, DATAENTR, DATAPAGTO, STATUS, VD.COMISSAO ");
                    sql.Append(" FROM VENDAS VD ");
                    sql.Append(" INNER JOIN VENDEDORES VE ");
                    sql.Append(" ON VD.IDVEN = VE.IDVEN ");
                    sql.Append(" WHERE STATUS = @STATUS ");
                    sql.Append(" OR IDVDA = @IDVDA ");
                    sql.Append(" ORDER BY 1 ASC ");

                    comandoSql.Parameters.Add(new FbParameter("@IDVDA", idvda));
                    comandoSql.Parameters.Add(new FbParameter("@STATUS", status));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elpp)
            {
                throw new Exception("Erro no método listar produtos do pedido da classe de Vendas. Se o problema persistir, comunique o administrador do sistema. " + elpp.Message);
            }
        }//Fim DataTable listarVendas

        public void atualizarStatusPedido(int idvda, string status)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql.Append(" UPDATE VENDAS SET STATUS = @STATUS WHERE IDVDA = @IDVDA ");

                    comandoSql.Parameters.Add(new FbParameter("@IDVDA", idvda));
                    comandoSql.Parameters.Add(new FbParameter("@STATUS", status));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception eep)
            {
                throw new Exception("Erro no método excluir do pedido da classe de Vendas. Se o problema persistir, comunique o administrador do sistema. " + eep.Message);
            }
        } //Fim void excluirPedido

        public DataTable listarVendasComFiltroGrid(string nrovda, string revista, string edicao, string vendedor, string status)
        {
            try
            {
                using (conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT VD.IDVDA, VD.NROVDA, VE.APELIDO, ");
                    sql.Append(" VD.VTOTAL, VD.EMISSAO, VD.DATAENTR, VD.DATAPAGTO, VD.STATUS, VD.COMISSAO, VD.TTL_ITENS ");
                    sql.Append(" FROM VENDAS VD ");
                    sql.Append(" INNER JOIN VENDEDORES VE ");
                    sql.Append(" ON VD.IDVEN = VE.IDVEN ");
                    sql.Append(" INNER JOIN ITENS_VENDA IV ");
                    sql.Append(" ON IV.IDVDA = VD.IDVDA ");
                    sql.Append(" WHERE (");
                    sql.Append(" STATUS = @STATUS ");

                    if (nrovda != "" || revista != "" || edicao != "" || vendedor != "")
                    {
                        sql.Append(" AND ");
                    }
                    if (nrovda != "")
                    {
                        sql.Append(" NROVDA = @NROVDA ");
                    }
                    if (nrovda != "" && revista != "")
                    {
                        sql.Append(" OR ");
                    }
                    if (revista != "")
                    {
                        sql.Append(" IV.REVISTA CONTAINING @REVISTA ");
                    }
                    if (revista != "" && edicao != "")
                    {
                        sql.Append(" OR ");
                    }
                    if (edicao != "")
                    {
                        sql.Append(" IV.EDICAO CONTAINING @EDICAO ");
                    }
                    if (edicao != "" && vendedor != "")
                    {
                        sql.Append(" OR ");
                    }
                    if (vendedor != "")
                    {
                        sql.Append(" APELIDO CONTAINING @VENDEDOR ");
                    }
                    sql.Append(" )");
                    sql.Append(" GROUP BY 1,2,3,4,5,6,7,8,9,10 ");
                    sql.Append(" ORDER BY 1 ");

                    comandoSql.Parameters.Add(new FbParameter("@STATUS", status));
                    if (nrovda != "")
                    {
                        comandoSql.Parameters.Add(new FbParameter("@NROVDA", nrovda));
                    }
                    if (revista != "")
                    {
                        comandoSql.Parameters.Add(new FbParameter("@REVISTA", revista));
                    }
                    if (edicao != "")
                    {
                        comandoSql.Parameters.Add(new FbParameter("@EDICAO", edicao));
                    }
                    if (vendedor != "")
                    {
                        comandoSql.Parameters.Add(new FbParameter("@VENDEDOR", vendedor));
                    }

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elva)
            {
                throw new Exception("Erro ao listar o pedido com filtro. Se o problema persistir, comunique o adminstrador do sistema.\n" + elva.Message);
            }
        }//Fim DataTable listarVendasComFiltro
    }
}
