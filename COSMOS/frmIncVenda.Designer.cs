namespace COSMOS
{
    partial class frmIncVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbPedido = new System.Windows.Forms.GroupBox();
            this.txtVUnit = new System.Windows.Forms.MaskedTextBox();
            this.txtVTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblVUnit = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.gpbResumo = new System.Windows.Forms.GroupBox();
            this.lblQTotalItens = new System.Windows.Forms.Label();
            this.btnCadPro = new System.Windows.Forms.Button();
            this.gpbComissao = new System.Windows.Forms.GroupBox();
            this.lblComissao = new System.Windows.Forms.Label();
            this.lblTotalItens = new System.Windows.Forms.Label();
            this.gpbTotalDoPedido = new System.Windows.Forms.GroupBox();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.gpbItens = new System.Windows.Forms.GroupBox();
            this.dtgitensPedidoa = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produtoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_REV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revistaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edicaoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VUnita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlrComissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIgual = new System.Windows.Forms.Label();
            this.lblVTotal = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.gpbBotoes = new System.Windows.Forms.GroupBox();
            this.btnAlterarPedido = new System.Windows.Forms.Button();
            this.btnAlterarItem = new System.Windows.Forms.Button();
            this.btnContinuarDepois = new System.Windows.Forms.Button();
            this.btnFecharVenda = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.gpbDadosGerais = new System.Windows.Forms.GroupBox();
            this.lblEmissao = new System.Windows.Forms.Label();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtNroPed = new System.Windows.Forms.MaskedTextBox();
            this.lblPedNro = new System.Windows.Forms.Label();
            this.dtpPrevEntr = new System.Windows.Forms.DateTimePicker();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.lblPagto = new System.Windows.Forms.Label();
            this.dtpPagto = new System.Windows.Forms.DateTimePicker();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtComissaoItem = new System.Windows.Forms.MaskedTextBox();
            this.lblComissaoItem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpbPedido.SuspendLayout();
            this.gpbResumo.SuspendLayout();
            this.gpbComissao.SuspendLayout();
            this.gpbTotalDoPedido.SuspendLayout();
            this.gpbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgitensPedidoa)).BeginInit();
            this.gpbBotoes.SuspendLayout();
            this.gpbDadosGerais.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.gpbPedido);
            this.panel1.Controls.Add(this.gpbDadosGerais);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 682);
            this.panel1.TabIndex = 5;
            // 
            // gpbPedido
            // 
            this.gpbPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbPedido.Controls.Add(this.txtComissaoItem);
            this.gpbPedido.Controls.Add(this.lblComissaoItem);
            this.gpbPedido.Controls.Add(this.txtVUnit);
            this.gpbPedido.Controls.Add(this.txtVTotal);
            this.gpbPedido.Controls.Add(this.lblVUnit);
            this.gpbPedido.Controls.Add(this.lblX);
            this.gpbPedido.Controls.Add(this.lblQtd);
            this.gpbPedido.Controls.Add(this.txtQtd);
            this.gpbPedido.Controls.Add(this.gpbResumo);
            this.gpbPedido.Controls.Add(this.gpbItens);
            this.gpbPedido.Controls.Add(this.lblIgual);
            this.gpbPedido.Controls.Add(this.lblVTotal);
            this.gpbPedido.Controls.Add(this.lblCod);
            this.gpbPedido.Controls.Add(this.txtCodigo);
            this.gpbPedido.Controls.Add(this.lblProduto);
            this.gpbPedido.Controls.Add(this.txtProduto);
            this.gpbPedido.Controls.Add(this.gpbBotoes);
            this.gpbPedido.Enabled = false;
            this.gpbPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gpbPedido.Location = new System.Drawing.Point(3, 91);
            this.gpbPedido.Name = "gpbPedido";
            this.gpbPedido.Size = new System.Drawing.Size(994, 588);
            this.gpbPedido.TabIndex = 15;
            this.gpbPedido.TabStop = false;
            this.gpbPedido.Text = "Pedido:";
            // 
            // txtVUnit
            // 
            this.txtVUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtVUnit.Location = new System.Drawing.Point(513, 44);
            this.txtVUnit.Name = "txtVUnit";
            this.txtVUnit.Size = new System.Drawing.Size(77, 23);
            this.txtVUnit.TabIndex = 24;
            this.txtVUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVUnit_KeyPress);
            // 
            // txtVTotal
            // 
            this.txtVTotal.Enabled = false;
            this.txtVTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtVTotal.Location = new System.Drawing.Point(620, 44);
            this.txtVTotal.Name = "txtVTotal";
            this.txtVTotal.Size = new System.Drawing.Size(109, 23);
            this.txtVTotal.TabIndex = 12;
            this.txtVTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVUnit
            // 
            this.lblVUnit.AutoSize = true;
            this.lblVUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblVUnit.Location = new System.Drawing.Point(510, 24);
            this.lblVUnit.Name = "lblVUnit";
            this.lblVUnit.Size = new System.Drawing.Size(60, 15);
            this.lblVUnit.TabIndex = 23;
            this.lblVUnit.Text = "V.Unitário";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblX.Location = new System.Drawing.Point(489, 47);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 17);
            this.lblX.TabIndex = 21;
            this.lblX.Text = "X";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblQtd.Location = new System.Drawing.Point(439, 24);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(26, 15);
            this.lblQtd.TabIndex = 20;
            this.lblQtd.Text = "Qtd";
            // 
            // txtQtd
            // 
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtQtd.Location = new System.Drawing.Point(432, 44);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(50, 23);
            this.txtQtd.TabIndex = 19;
            this.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            // 
            // gpbResumo
            // 
            this.gpbResumo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbResumo.Controls.Add(this.lblQTotalItens);
            this.gpbResumo.Controls.Add(this.btnCadPro);
            this.gpbResumo.Controls.Add(this.gpbComissao);
            this.gpbResumo.Controls.Add(this.lblTotalItens);
            this.gpbResumo.Controls.Add(this.gpbTotalDoPedido);
            this.gpbResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gpbResumo.Location = new System.Drawing.Point(735, 67);
            this.gpbResumo.Name = "gpbResumo";
            this.gpbResumo.Size = new System.Drawing.Size(254, 515);
            this.gpbResumo.TabIndex = 18;
            this.gpbResumo.TabStop = false;
            this.gpbResumo.Text = "Resumo";
            // 
            // lblQTotalItens
            // 
            this.lblQTotalItens.AutoSize = true;
            this.lblQTotalItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblQTotalItens.Location = new System.Drawing.Point(64, 25);
            this.lblQTotalItens.Name = "lblQTotalItens";
            this.lblQTotalItens.Size = new System.Drawing.Size(13, 13);
            this.lblQTotalItens.TabIndex = 23;
            this.lblQTotalItens.Text = "0";
            // 
            // btnCadPro
            // 
            this.btnCadPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadPro.Location = new System.Drawing.Point(106, 470);
            this.btnCadPro.Name = "btnCadPro";
            this.btnCadPro.Size = new System.Drawing.Size(140, 36);
            this.btnCadPro.TabIndex = 3;
            this.btnCadPro.Text = "&Gerenciar Produtos";
            this.btnCadPro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadPro.UseVisualStyleBackColor = true;
            this.btnCadPro.Click += new System.EventHandler(this.btnCadPro_Click);
            // 
            // gpbComissao
            // 
            this.gpbComissao.Controls.Add(this.lblComissao);
            this.gpbComissao.Location = new System.Drawing.Point(6, 152);
            this.gpbComissao.Name = "gpbComissao";
            this.gpbComissao.Size = new System.Drawing.Size(242, 48);
            this.gpbComissao.TabIndex = 22;
            this.gpbComissao.TabStop = false;
            this.gpbComissao.Text = "Total de comissão";
            // 
            // lblComissao
            // 
            this.lblComissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblComissao.Location = new System.Drawing.Point(6, 14);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(230, 30);
            this.lblComissao.TabIndex = 21;
            this.lblComissao.Text = "5,00";
            this.lblComissao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalItens
            // 
            this.lblTotalItens.AutoSize = true;
            this.lblTotalItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblTotalItens.Location = new System.Drawing.Point(6, 25);
            this.lblTotalItens.Name = "lblTotalItens";
            this.lblTotalItens.Size = new System.Drawing.Size(63, 13);
            this.lblTotalItens.TabIndex = 20;
            this.lblTotalItens.Text = "Total Itens: ";
            // 
            // gpbTotalDoPedido
            // 
            this.gpbTotalDoPedido.Controls.Add(this.lblTotalPedido);
            this.gpbTotalDoPedido.Location = new System.Drawing.Point(6, 84);
            this.gpbTotalDoPedido.Name = "gpbTotalDoPedido";
            this.gpbTotalDoPedido.Size = new System.Drawing.Size(242, 48);
            this.gpbTotalDoPedido.TabIndex = 19;
            this.gpbTotalDoPedido.TabStop = false;
            this.gpbTotalDoPedido.Text = "Total do pedido";
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTotalPedido.Location = new System.Drawing.Point(6, 14);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(230, 30);
            this.lblTotalPedido.TabIndex = 21;
            this.lblTotalPedido.Text = "5,00";
            this.lblTotalPedido.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gpbItens
            // 
            this.gpbItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbItens.Controls.Add(this.dtgitensPedidoa);
            this.gpbItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.gpbItens.Location = new System.Drawing.Point(6, 67);
            this.gpbItens.Name = "gpbItens";
            this.gpbItens.Size = new System.Drawing.Size(723, 456);
            this.gpbItens.TabIndex = 16;
            this.gpbItens.TabStop = false;
            this.gpbItens.Text = "Itens";
            // 
            // dtgitensPedidoa
            // 
            this.dtgitensPedidoa.AllowUserToAddRows = false;
            this.dtgitensPedidoa.AllowUserToDeleteRows = false;
            this.dtgitensPedidoa.AllowUserToOrderColumns = true;
            this.dtgitensPedidoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgitensPedidoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgitensPedidoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Cod,
            this.Ref,
            this.Produtoa,
            this.ID_REV,
            this.Revistaa,
            this.Edicaoa,
            this.VUnita,
            this.Qtd,
            this.ValorTotala,
            this.Comissao,
            this.VlrComissao,
            this.tpProduto});
            this.dtgitensPedidoa.Location = new System.Drawing.Point(6, 15);
            this.dtgitensPedidoa.Name = "dtgitensPedidoa";
            this.dtgitensPedidoa.ReadOnly = true;
            this.dtgitensPedidoa.RowHeadersVisible = false;
            this.dtgitensPedidoa.Size = new System.Drawing.Size(711, 435);
            this.dtgitensPedidoa.TabIndex = 0;
            this.dtgitensPedidoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgitensPedidoa_CellClick);
            // 
            // Item
            // 
            this.Item.DataPropertyName = "ITEM";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 45;
            // 
            // Cod
            // 
            this.Cod.DataPropertyName = "ID_PRO";
            this.Cod.HeaderText = "Cod";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            this.Cod.Width = 50;
            // 
            // Ref
            // 
            this.Ref.DataPropertyName = "REF";
            this.Ref.HeaderText = "Ref";
            this.Ref.Name = "Ref";
            this.Ref.ReadOnly = true;
            // 
            // Produtoa
            // 
            this.Produtoa.DataPropertyName = "PRODUTO";
            this.Produtoa.HeaderText = "Produto";
            this.Produtoa.Name = "Produtoa";
            this.Produtoa.ReadOnly = true;
            this.Produtoa.Width = 250;
            // 
            // ID_REV
            // 
            this.ID_REV.DataPropertyName = "ID_REV";
            this.ID_REV.HeaderText = "ID_REV";
            this.ID_REV.Name = "ID_REV";
            this.ID_REV.ReadOnly = true;
            this.ID_REV.Visible = false;
            // 
            // Revistaa
            // 
            this.Revistaa.DataPropertyName = "REVISTA";
            this.Revistaa.HeaderText = "Revista";
            this.Revistaa.Name = "Revistaa";
            this.Revistaa.ReadOnly = true;
            this.Revistaa.Width = 150;
            // 
            // Edicaoa
            // 
            this.Edicaoa.DataPropertyName = "EDICAO";
            this.Edicaoa.HeaderText = "Edicao";
            this.Edicaoa.Name = "Edicaoa";
            this.Edicaoa.ReadOnly = true;
            // 
            // VUnita
            // 
            this.VUnita.DataPropertyName = "VUNIT";
            dataGridViewCellStyle1.Format = "N2";
            this.VUnita.DefaultCellStyle = dataGridViewCellStyle1;
            this.VUnita.HeaderText = "VUnit";
            this.VUnita.Name = "VUnita";
            this.VUnita.ReadOnly = true;
            // 
            // Qtd
            // 
            this.Qtd.DataPropertyName = "QTD";
            this.Qtd.HeaderText = "Qtd";
            this.Qtd.Name = "Qtd";
            this.Qtd.ReadOnly = true;
            this.Qtd.Width = 45;
            // 
            // ValorTotala
            // 
            this.ValorTotala.DataPropertyName = "VTOTAL";
            dataGridViewCellStyle2.Format = "N2";
            this.ValorTotala.DefaultCellStyle = dataGridViewCellStyle2;
            this.ValorTotala.HeaderText = "Valor Total";
            this.ValorTotala.Name = "ValorTotala";
            this.ValorTotala.ReadOnly = true;
            // 
            // Comissao
            // 
            this.Comissao.DataPropertyName = "COMISSAO";
            this.Comissao.HeaderText = "Comissao";
            this.Comissao.Name = "Comissao";
            this.Comissao.ReadOnly = true;
            this.Comissao.Width = 55;
            // 
            // VlrComissao
            // 
            this.VlrComissao.DataPropertyName = "VLRCOMISSAO";
            dataGridViewCellStyle3.Format = "N2";
            this.VlrComissao.DefaultCellStyle = dataGridViewCellStyle3;
            this.VlrComissao.HeaderText = "Vlr Comissão";
            this.VlrComissao.Name = "VlrComissao";
            this.VlrComissao.ReadOnly = true;
            // 
            // tpProduto
            // 
            this.tpProduto.HeaderText = "tpProduto";
            this.tpProduto.Name = "tpProduto";
            this.tpProduto.ReadOnly = true;
            this.tpProduto.Visible = false;
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblIgual.Location = new System.Drawing.Point(596, 44);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(19, 20);
            this.lblIgual.TabIndex = 14;
            this.lblIgual.Text = "=";
            // 
            // lblVTotal
            // 
            this.lblVTotal.AutoSize = true;
            this.lblVTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblVTotal.Location = new System.Drawing.Point(617, 24);
            this.lblVTotal.Name = "lblVTotal";
            this.lblVTotal.Size = new System.Drawing.Size(44, 15);
            this.lblVTotal.TabIndex = 13;
            this.lblVTotal.Text = "V.Total";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCod.Location = new System.Drawing.Point(3, 24);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(46, 15);
            this.lblCod.TabIndex = 9;
            this.lblCod.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtCodigo.Location = new System.Drawing.Point(6, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(91, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblProduto.Location = new System.Drawing.Point(100, 24);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(50, 15);
            this.lblProduto.TabIndex = 7;
            this.lblProduto.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtProduto.Location = new System.Drawing.Point(103, 44);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(323, 23);
            this.txtProduto.TabIndex = 6;
            // 
            // gpbBotoes
            // 
            this.gpbBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBotoes.Controls.Add(this.btnAlterarPedido);
            this.gpbBotoes.Controls.Add(this.btnAlterarItem);
            this.gpbBotoes.Controls.Add(this.btnContinuarDepois);
            this.gpbBotoes.Controls.Add(this.btnFecharVenda);
            this.gpbBotoes.Controls.Add(this.btnExcluirItem);
            this.gpbBotoes.Location = new System.Drawing.Point(6, 520);
            this.gpbBotoes.Name = "gpbBotoes";
            this.gpbBotoes.Size = new System.Drawing.Size(723, 62);
            this.gpbBotoes.TabIndex = 17;
            this.gpbBotoes.TabStop = false;
            // 
            // btnAlterarPedido
            // 
            this.btnAlterarPedido.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAlterarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAlterarPedido.Image = global::COSMOS.Properties.Resources.editar;
            this.btnAlterarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarPedido.Location = new System.Drawing.Point(272, 17);
            this.btnAlterarPedido.Name = "btnAlterarPedido";
            this.btnAlterarPedido.Size = new System.Drawing.Size(125, 36);
            this.btnAlterarPedido.TabIndex = 4;
            this.btnAlterarPedido.Text = "&Alterar Pedido";
            this.btnAlterarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarPedido.UseVisualStyleBackColor = true;
            this.btnAlterarPedido.Click += new System.EventHandler(this.btnAlterarPedido_Click);
            // 
            // btnAlterarItem
            // 
            this.btnAlterarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAlterarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAlterarItem.Image = global::COSMOS.Properties.Resources.editar;
            this.btnAlterarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarItem.Location = new System.Drawing.Point(127, 17);
            this.btnAlterarItem.Name = "btnAlterarItem";
            this.btnAlterarItem.Size = new System.Drawing.Size(111, 36);
            this.btnAlterarItem.TabIndex = 3;
            this.btnAlterarItem.Text = "A&lterar Item";
            this.btnAlterarItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarItem.UseVisualStyleBackColor = true;
            this.btnAlterarItem.Click += new System.EventHandler(this.btnAlterarItem_Click);
            // 
            // btnContinuarDepois
            // 
            this.btnContinuarDepois.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinuarDepois.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnContinuarDepois.Image = global::COSMOS.Properties.Resources.pause_player_icone_5157_48___pequeno;
            this.btnContinuarDepois.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinuarDepois.Location = new System.Drawing.Point(430, 17);
            this.btnContinuarDepois.Name = "btnContinuarDepois";
            this.btnContinuarDepois.Size = new System.Drawing.Size(149, 36);
            this.btnContinuarDepois.TabIndex = 2;
            this.btnContinuarDepois.Text = "&Continuar Depois";
            this.btnContinuarDepois.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContinuarDepois.UseVisualStyleBackColor = true;
            this.btnContinuarDepois.Click += new System.EventHandler(this.btnContinuarDepois_Click);
            // 
            // btnFecharVenda
            // 
            this.btnFecharVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnFecharVenda.Image = global::COSMOS.Properties.Resources.confirma;
            this.btnFecharVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharVenda.Location = new System.Drawing.Point(585, 17);
            this.btnFecharVenda.Name = "btnFecharVenda";
            this.btnFecharVenda.Size = new System.Drawing.Size(129, 36);
            this.btnFecharVenda.TabIndex = 1;
            this.btnFecharVenda.Text = "&Fechar Pedido";
            this.btnFecharVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFecharVenda.UseVisualStyleBackColor = true;
            this.btnFecharVenda.Click += new System.EventHandler(this.btnFecharVenda_Click);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnExcluirItem.Image = global::COSMOS.Properties.Resources.excluir;
            this.btnExcluirItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirItem.Location = new System.Drawing.Point(9, 17);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(112, 36);
            this.btnExcluirItem.TabIndex = 0;
            this.btnExcluirItem.Text = "&Retirar Item";
            this.btnExcluirItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // gpbDadosGerais
            // 
            this.gpbDadosGerais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbDadosGerais.Controls.Add(this.lblEmissao);
            this.gpbDadosGerais.Controls.Add(this.dtpEmissao);
            this.gpbDadosGerais.Controls.Add(this.lblStatus);
            this.gpbDadosGerais.Controls.Add(this.txtStatus);
            this.gpbDadosGerais.Controls.Add(this.txtNroPed);
            this.gpbDadosGerais.Controls.Add(this.lblPedNro);
            this.gpbDadosGerais.Controls.Add(this.dtpPrevEntr);
            this.gpbDadosGerais.Controls.Add(this.lblEntrega);
            this.gpbDadosGerais.Controls.Add(this.lblPagto);
            this.gpbDadosGerais.Controls.Add(this.dtpPagto);
            this.gpbDadosGerais.Controls.Add(this.lblCodigo);
            this.gpbDadosGerais.Controls.Add(this.txtVendedor);
            this.gpbDadosGerais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gpbDadosGerais.Location = new System.Drawing.Point(3, 3);
            this.gpbDadosGerais.Name = "gpbDadosGerais";
            this.gpbDadosGerais.Size = new System.Drawing.Size(994, 88);
            this.gpbDadosGerais.TabIndex = 14;
            this.gpbDadosGerais.TabStop = false;
            this.gpbDadosGerais.Text = "Dados Gerais:";
            // 
            // lblEmissao
            // 
            this.lblEmissao.AutoSize = true;
            this.lblEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEmissao.Location = new System.Drawing.Point(776, 23);
            this.lblEmissao.Name = "lblEmissao";
            this.lblEmissao.Size = new System.Drawing.Size(58, 15);
            this.lblEmissao.TabIndex = 13;
            this.lblEmissao.Text = "Emissão:";
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmissao.Location = new System.Drawing.Point(846, 20);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(142, 23);
            this.dtpEmissao.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStatus.Location = new System.Drawing.Point(218, 23);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 15);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtStatus.Location = new System.Drawing.Point(268, 20);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(144, 23);
            this.txtStatus.TabIndex = 11;
            // 
            // txtNroPed
            // 
            this.txtNroPed.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtNroPed.Enabled = false;
            this.txtNroPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtNroPed.Location = new System.Drawing.Point(95, 20);
            this.txtNroPed.Mask = "000\\.000";
            this.txtNroPed.Name = "txtNroPed";
            this.txtNroPed.PromptChar = ' ';
            this.txtNroPed.Size = new System.Drawing.Size(71, 23);
            this.txtNroPed.TabIndex = 9;
            this.txtNroPed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNroPed.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblPedNro
            // 
            this.lblPedNro.AutoSize = true;
            this.lblPedNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPedNro.Location = new System.Drawing.Point(40, 23);
            this.lblPedNro.Name = "lblPedNro";
            this.lblPedNro.Size = new System.Drawing.Size(49, 15);
            this.lblPedNro.TabIndex = 8;
            this.lblPedNro.Text = "Pedido:";
            // 
            // dtpPrevEntr
            // 
            this.dtpPrevEntr.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.dtpPrevEntr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrevEntr.Location = new System.Drawing.Point(846, 52);
            this.dtpPrevEntr.Name = "dtpPrevEntr";
            this.dtpPrevEntr.Size = new System.Drawing.Size(142, 23);
            this.dtpPrevEntr.TabIndex = 7;
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEntrega.Location = new System.Drawing.Point(754, 55);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(80, 15);
            this.lblEntrega.TabIndex = 6;
            this.lblEntrega.Text = "Prev. Entrega";
            // 
            // lblPagto
            // 
            this.lblPagto.AutoSize = true;
            this.lblPagto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPagto.Location = new System.Drawing.Point(481, 55);
            this.lblPagto.Name = "lblPagto";
            this.lblPagto.Size = new System.Drawing.Size(69, 15);
            this.lblPagto.TabIndex = 4;
            this.lblPagto.Text = "Prev. Pagto";
            // 
            // dtpPagto
            // 
            this.dtpPagto.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.dtpPagto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPagto.Location = new System.Drawing.Point(558, 52);
            this.dtpPagto.Name = "dtpPagto";
            this.dtpPagto.Size = new System.Drawing.Size(142, 23);
            this.dtpPagto.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCodigo.Location = new System.Drawing.Point(28, 55);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 15);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Vendedor:";
            // 
            // txtVendedor
            // 
            this.txtVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtVendedor.Location = new System.Drawing.Point(95, 52);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(317, 23);
            this.txtVendedor.TabIndex = 2;
            this.txtVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVendedor_KeyPress);
            // 
            // txtComissaoItem
            // 
            this.txtComissaoItem.Enabled = false;
            this.txtComissaoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtComissaoItem.Location = new System.Drawing.Point(735, 44);
            this.txtComissaoItem.Name = "txtComissaoItem";
            this.txtComissaoItem.Size = new System.Drawing.Size(109, 23);
            this.txtComissaoItem.TabIndex = 25;
            this.txtComissaoItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtComissaoItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            // 
            // lblComissaoItem
            // 
            this.lblComissaoItem.AutoSize = true;
            this.lblComissaoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblComissaoItem.Location = new System.Drawing.Point(732, 24);
            this.lblComissaoItem.Name = "lblComissaoItem";
            this.lblComissaoItem.Size = new System.Drawing.Size(62, 15);
            this.lblComissaoItem.TabIndex = 26;
            this.lblComissaoItem.Text = "Comissão";
            // 
            // frmIncVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 690);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIncVenda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Pedidos - Cosmos - Sistema para controle de cosméticos - New Era In" +
    "fo";
            this.Load += new System.EventHandler(this.frmIncVenda_Load);
            this.panel1.ResumeLayout(false);
            this.gpbPedido.ResumeLayout(false);
            this.gpbPedido.PerformLayout();
            this.gpbResumo.ResumeLayout(false);
            this.gpbResumo.PerformLayout();
            this.gpbComissao.ResumeLayout(false);
            this.gpbTotalDoPedido.ResumeLayout(false);
            this.gpbItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgitensPedidoa)).EndInit();
            this.gpbBotoes.ResumeLayout(false);
            this.gpbDadosGerais.ResumeLayout(false);
            this.gpbDadosGerais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbDadosGerais;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.GroupBox gpbPedido;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.DateTimePicker dtpPrevEntr;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.Label lblPagto;
        private System.Windows.Forms.DateTimePicker dtpPagto;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblVTotal;
        private System.Windows.Forms.GroupBox gpbItens;
        private System.Windows.Forms.GroupBox gpbResumo;
        private System.Windows.Forms.GroupBox gpbBotoes;
        private System.Windows.Forms.Label lblTotalItens;
        private System.Windows.Forms.GroupBox gpbTotalDoPedido;
        private System.Windows.Forms.GroupBox gpbComissao;
        private System.Windows.Forms.Label lblComissao;
        private System.Windows.Forms.Label lblTotalPedido;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnContinuarDepois;
        private System.Windows.Forms.Button btnFecharVenda;
        private System.Windows.Forms.Button btnCadPro;
        private System.Windows.Forms.Label lblQTotalItens;
        private System.Windows.Forms.Button btnAlterarItem;
        private System.Windows.Forms.Button btnAlterarPedido;
        private System.Windows.Forms.Label lblVUnit;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.MaskedTextBox txtVTotal;
        private System.Windows.Forms.MaskedTextBox txtVUnit;
        private System.Windows.Forms.DataGridView dtgitensPedidoa;
        private System.Windows.Forms.Label lblPedNro;
        private System.Windows.Forms.MaskedTextBox txtNroPed;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblEmissao;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produtoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_REV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revistaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edicaoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn VUnita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlrComissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpProduto;
        private System.Windows.Forms.MaskedTextBox txtComissaoItem;
        private System.Windows.Forms.Label lblComissaoItem;
    }
}