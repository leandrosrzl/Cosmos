using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;

namespace COSMOS
{
    class clVendedores
    {
        DataTable dadosTabela = new DataTable();
        FbCommand comandoSql = new FbCommand();
        StringBuilder sql = new StringBuilder();

        //método de salvar os vendedores
        public void salvarVendedor(
            int IDVEN, string NOME, string APELIDO, string ENDERECO, string NRO, string COMPLEMENTO, string BAIRRO, string FONE, string CEL, string CPF, string RG, DateTime DATANASC, 
            DateTime DATACAD, string CEP, string CIDADE, string UF, int USUCAD, string OBS)
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("INSERT INTO VENDEDORES (");
                    sql.Append("IDVEN,");
                    sql.Append("NOME,");
                    sql.Append("APELIDO,");
                    sql.Append("ENDERECO,");
                    sql.Append("NRO,");
                    sql.Append("COMPLEMENTO,");
                    sql.Append("BAIRRO,");
                    sql.Append("FONE,");
                    sql.Append("CEL,");
                    sql.Append("CPF,");
                    sql.Append("RG,");
                    sql.Append("DATANASC,");
                    sql.Append("DATACAD,");
                    sql.Append("ATIVO,");
                    sql.Append("CEP,");
                    sql.Append("CIDADE,");
                    sql.Append("UF,");
                    sql.Append("CADUSU,");
                    sql.Append("OBS)");

                    sql.Append("VALUES");
                    sql.Append("(@IDVEN,");
                    sql.Append("@NOME,");
                    sql.Append("@APELIDO,");
                    sql.Append("@ENDERECO,");
                    sql.Append("@NRO,");
                    sql.Append("@COMPLEMENTO,");
                    sql.Append("@BAIRRO,");
                    sql.Append("@FONE,");
                    sql.Append("@CEL,");
                    sql.Append("@CPF,");
                    sql.Append("@RG,");
                    sql.Append("@DATANASC,");
                    sql.Append("@DATACAD,");
                    sql.Append("'S',");
                    sql.Append("@CEP,");
                    sql.Append("@CIDADE,");
                    sql.Append("@UF,");
                    sql.Append("@CADUSU,");
                    sql.Append("@OBS)");

                    comandoSql.Parameters.Add(new FbParameter("@IDVEN", IDVEN));
                    comandoSql.Parameters.Add(new FbParameter("@NOME", NOME));
                    comandoSql.Parameters.Add(new FbParameter("@APELIDO", APELIDO));
                    comandoSql.Parameters.Add(new FbParameter("@ENDERECO", ENDERECO));
                    comandoSql.Parameters.Add(new FbParameter("@NRO", NRO));
                    comandoSql.Parameters.Add(new FbParameter("@COMPLEMENTO", COMPLEMENTO));
                    comandoSql.Parameters.Add(new FbParameter("@BAIRRO", BAIRRO));
                    comandoSql.Parameters.Add(new FbParameter("@FONE", FONE));
                    comandoSql.Parameters.Add(new FbParameter("@CEL", CEL));
                    comandoSql.Parameters.Add(new FbParameter("@CPF", CPF));
                    comandoSql.Parameters.Add(new FbParameter("@RG", RG));
                    comandoSql.Parameters.Add(new FbParameter("@DATANASC", DATANASC));
                    comandoSql.Parameters.Add(new FbParameter("@DATACAD", DATACAD));
                    comandoSql.Parameters.Add(new FbParameter("@CEP", CEP));
                    comandoSql.Parameters.Add(new FbParameter("@CIDADE", CIDADE));
                    comandoSql.Parameters.Add(new FbParameter("@UF", UF));
                    comandoSql.Parameters.Add(new FbParameter("@CADUSU", USUCAD));
                    comandoSql.Parameters.Add(new FbParameter("@OBS", OBS));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception esv)
            {
                throw new Exception("Erro no método salvar da classe de vendedores. Se o problema persistir, comunique o administrador do sistema. " + esv.Message);
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

                    sql.Append("SELECT GEN_ID(GEN_VEN_IDVEN,1) FROM RDB$DATABASE");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elg)
            {
                throw new Exception("Erro ao ler generator. Se o problema persistir, contate o administrador do sistema. \nErro original: "+elg.Message);
            }
        }

        public DataTable listarVendedoresAtivos()
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT IDVEN, NOME, APELIDO, ENDERECO, NRO, COMPLEMENTO, CEP, BAIRRO, CIDADE, UF, FONE, CEL, CPF, RG, DATANASC, CADUSU, DATACAD, ATIVO ");
                    sql.Append("FROM VENDEDORES ");
                    sql.Append("WHERE ATIVO = 'S'");
                    sql.Append("ORDER BY IDVEN ASC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elva)
            {
                throw new Exception("Erro ao listar vendedores ativos na classe vendedores. Se o problema persistir, contate o administrador do sistema. \nErro original: "+elva.Message);
            }
        }

        public DataTable listarVendedoresInativos()
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT IDVEN, NOME, APELIDO, ENDERECO, NRO, COMPLEMENTO, CEP, BAIRRO, CIDADE, UF, FONE, CEL, CPF, RG, DATANASC, CADUSU, DATACAD, ATIVO ");
                    sql.Append("FROM VENDEDORES ");
                    sql.Append("WHERE ATIVO = 'N'");
                    sql.Append("ORDER BY IDVEN ASC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elvi)
            {
                throw new Exception("Erro ao listar vendedores inativos na classe vendedores. Se o problema persistir, contate o administrador do sistema. \nErro original: " + elvi.Message);
            }
        }

        public DataTable listarTodosVendedores()
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT IDVEN, NOME, APELIDO, ENDERECO, NRO, COMPLEMENTO, CEP, BAIRRO, CIDADE, UF, FONE, CEL, CPF, RG, DATANASC, CADUSU, DATACAD, ATIVO ");
                    sql.Append("FROM VENDEDORES ");
                    sql.Append("ORDER BY IDVEN ASC");

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception eltv)
            {
                throw new Exception("Erro ao listar vendedores ativos na classe vendedores. Se o problema persistir, contate o administrador do sistema. \nErro original: " + eltv.Message);
            }
        }

        public DataTable listarVendedoresComFiltro(int idven, string nome, string ativo)
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT IDVEN, NOME, APELIDO, ENDERECO, NRO, COMPLEMENTO, CEP, BAIRRO, CIDADE, UF, FONE, CEL, CPF, RG, DATANASC, CADUSU, DATACAD, OBS, ATIVO ");
                    sql.Append("FROM VENDEDORES ");
                    sql.Append("WHERE ( ");
                    if (idven != 0)
                    {
                        sql.Append(" IDVEN = @IDVEN  ");
                    }
                    if (idven != 0 && nome != "")
                    {
                        sql.Append(" OR ");
                    }
                    if (nome != "")
                    {
                        sql.Append(" NOME CONTAINING (@NOME) ");
                    }
                    if (ativo != "")
                    {
                        sql.Append(" AND ATIVO = @ATIVO ");
                    }
                    sql.Append(") ORDER BY IDVEN ASC");

                    //MessageBox.Show(nome);

                    if (idven != 0)
                    {
                        comandoSql.Parameters.Add(new FbParameter("@IDVEN", idven));
                    }

                    if (nome != "")
                    {
                        comandoSql.Parameters.Add(new FbParameter("@NOME", nome));
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
            catch (Exception elvf)
            {
                throw new Exception("Erro ao listar vendedores ativos na classe vendedores. Se o problema persistir, contate o administrador do sistema. \nErro original: " + elvf.Message);
            }
        }

        public DataTable listarVendedoresComFiltroInc(int idven)
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("SELECT V.IDVEN, V.NOME, V.APELIDO, V.ENDERECO, V.NRO, V.COMPLEMENTO, V.CEP, V.BAIRRO, V.CIDADE, V.UF, V.FONE, V.CEL, ");
                    sql.Append("V.CPF, V.RG, V.DATANASC, V.CADUSU, U.NOME_USU, V.DATACAD, V.OBS, V.ATIVO, V.DESATUSU, V.DESATDATA ");
                    sql.Append("FROM VENDEDORES V ");
                    sql.Append(" INNER JOIN USUARIOS U ");
                    sql.Append(" ON V.CADUSU = U.ID_USU ");
                    sql.Append("WHERE (IDVEN = @IDVEN) ");
                    sql.Append("ORDER BY IDVEN ASC");

                    comandoSql.Parameters.Add(new FbParameter("@IDVEN", idven));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    dadosTabela.Load(comandoSql.ExecuteReader());
                    return dadosTabela;
                }
            }
            catch (Exception elvf)
            {
                throw new Exception("Erro ao listar vendedores ativos na classe vendedores. Se o problema persistir, contate o administrador do sistema. \nErro original: " + elvf.Message);
            }
        }

        public void excluirVendedor(int idven)
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("UPDATE VENDEDORES SET ");
                    sql.Append("ATIVO = 'N' ");
                    sql.Append("WHERE IDVEN = @IDVEN ");

                    comandoSql.Parameters.Add(new FbParameter("@IDVEN", idven));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception eef)
            {
                throw new Exception("Erro ao excluir vendedores na classe vendedores. Se o problema persistir, contate o administrador do sistema. \nErro original: " + eef.Message);
            }
        }

        public void atualizarVendedor(int IDVEN, string NOME, string APELIDO, string ENDERECO, string NRO, string COMPLEMENTO, string BAIRRO, string FONE, string CEL, string CPF, string RG, 
            DateTime DATANASC, DateTime DATACAD, string CEP, string CIDADE, string UF, int USUCAD, string OBS, string ATIVO)
        {
            try
            {
                using (FbConnection conexao = new FbConnection(clConexao.stringConexao))
                {
                    conexao.Open();

                    sql = new StringBuilder();

                    sql.Append("UPDATE VENDEDORES SET ");
                    sql.Append("NOME = @NOME,");
                    sql.Append("APELIDO = @APELIDO,");
                    sql.Append("ENDERECO = @ENDERECO,");
                    sql.Append("NRO = @NRO,");
                    sql.Append("COMPLEMENTO = @COMPLEMENTO,");
                    sql.Append("BAIRRO = @BAIRRO,");
                    sql.Append("FONE = @FONE,");
                    sql.Append("CEL = @CEL,");
                    sql.Append("CPF = @CPF,");
                    sql.Append("RG = @RG,");
                    sql.Append("DATANASC = @DATANASC,");
                    sql.Append("DATACAD = @DATACAD,");
                    sql.Append("ATIVO = @ATIVO,");
                    sql.Append("CEP = @CEP,");
                    sql.Append("CIDADE = @CIDADE,");
                    sql.Append("UF = @UF,");
                    sql.Append("CADUSU = @CADUSU,");
                    sql.Append("OBS = @OBS ");
                    sql.Append("WHERE IDVEN = @IDVEN");

                    comandoSql.Parameters.Add(new FbParameter("@IDVEN", IDVEN));
                    comandoSql.Parameters.Add(new FbParameter("@NOME", NOME));
                    comandoSql.Parameters.Add(new FbParameter("@APELIDO", APELIDO));
                    comandoSql.Parameters.Add(new FbParameter("@ENDERECO", ENDERECO));
                    comandoSql.Parameters.Add(new FbParameter("@NRO", NRO));
                    comandoSql.Parameters.Add(new FbParameter("@COMPLEMENTO", COMPLEMENTO));
                    comandoSql.Parameters.Add(new FbParameter("@BAIRRO", BAIRRO));
                    comandoSql.Parameters.Add(new FbParameter("@FONE", FONE));
                    comandoSql.Parameters.Add(new FbParameter("@CEL", CEL));
                    comandoSql.Parameters.Add(new FbParameter("@CPF", CPF));
                    comandoSql.Parameters.Add(new FbParameter("@RG", RG));
                    comandoSql.Parameters.Add(new FbParameter("@DATANASC", DATANASC));
                    comandoSql.Parameters.Add(new FbParameter("@DATACAD", DATACAD));
                    comandoSql.Parameters.Add(new FbParameter("@CEP", CEP));
                    comandoSql.Parameters.Add(new FbParameter("@CIDADE", CIDADE));
                    comandoSql.Parameters.Add(new FbParameter("@UF", UF));
                    comandoSql.Parameters.Add(new FbParameter("@CADUSU", USUCAD));
                    comandoSql.Parameters.Add(new FbParameter("@OBS", OBS));
                    comandoSql.Parameters.Add(new FbParameter("@ATIVO", ATIVO));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = conexao;
                    comandoSql.ExecuteNonQuery();
                }
            }
            catch (Exception eav)
            {
                throw new Exception("Erro no método atualizar da classe de vendedores. Se o problema persistir, comunique o administrador do sistema. " + eav.Message);
            }
        }

    } //FIM DA CLASS VENDEDORES
} //FIM DO NAMESPACE COSMOS
