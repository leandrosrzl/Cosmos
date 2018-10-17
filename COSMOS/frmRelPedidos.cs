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
    public partial class frmRelPedidos : Form
    {
        clVendas vendas;
        clVendedores vendedores;
        DataTable dadosTabela;

        int idvda, idven, idusu;

        public frmRelPedidos(int id_vda, int id_ven, int id_usu)
        {
            InitializeComponent();
            idvda = id_vda;
            idven = id_ven;
            idusu = id_usu;
        }

        private void pvListarVendasComFiltro()
        {
            vendas = new clVendas();
            dadosTabela = new DataTable();
            dadosTabela = vendas.listarVendasComFiltro(idvda);
        }

        private void pvListarItensVendas()
        {
            vendas = new clVendas();
            dadosTabela = new DataTable();
            dadosTabela = vendas.listarItensVendas(idvda);
        }

        private void pvListarVendedores()
        {
            vendedores = new clVendedores();
            dadosTabela = new DataTable();
            dadosTabela = vendedores.listarVendedoresComFiltroInc(idven);
        }

        private void frmRelPedidos_Load(object sender, EventArgs e)
        {
            pvListarVendasComFiltro(); //Carrega o DataBinding de VENDAS
            VENDASBindingSource.DataSource = dadosTabela;
            pvListarItensVendas(); //Carrega o DataBinding de ITENS
            ITENS_VENDABindingSource.DataSource = dadosTabela;
            pvListarVendedores(); //Carrega o DataBinding de VENDEDORES
            VENDEDORESBindingSource.DataSource = dadosTabela;
            this.rpvViewerPedidos.RefreshReport();
        }
    }
}
