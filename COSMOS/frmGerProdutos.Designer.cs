namespace COSMOS
{
    partial class frmGerProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerProdutos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgT = new System.Windows.Forms.DataGridView();
            this.dtgProdutos = new System.Windows.Forms.DataGridView();
            this.ID_PRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROMOCAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REVISTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMISSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATACAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnEditarGrid = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.grpFiltroUsuario = new System.Windows.Forms.GroupBox();
            this.cmbRevistas = new System.Windows.Forms.ComboBox();
            this.lblRevista = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.pnlFilUsu = new System.Windows.Forms.Panel();
            this.rbUsuInativo = new System.Windows.Forms.RadioButton();
            this.rbUsuAtivo = new System.Windows.Forms.RadioButton();
            this.rbUsuTodos = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
            this.panel2.SuspendLayout();
            this.grpFiltroUsuario.SuspendLayout();
            this.pnlFilUsu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtgT);
            this.panel1.Controls.Add(this.dtgProdutos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grpFiltroUsuario);
            this.panel1.Controls.Add(this.pnlFilUsu);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 574);
            this.panel1.TabIndex = 3;
            // 
            // dtgT
            // 
            this.dtgT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgT.Location = new System.Drawing.Point(593, 59);
            this.dtgT.Name = "dtgT";
            this.dtgT.Size = new System.Drawing.Size(240, 150);
            this.dtgT.TabIndex = 4;
            this.dtgT.Visible = false;
            // 
            // dtgProdutos
            // 
            this.dtgProdutos.AllowUserToAddRows = false;
            this.dtgProdutos.AllowUserToDeleteRows = false;
            this.dtgProdutos.AllowUserToOrderColumns = true;
            this.dtgProdutos.AllowUserToResizeColumns = false;
            this.dtgProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRO,
            this.REF,
            this.PRODUTO,
            this.PRECO,
            this.PROMOCAO,
            this.REVISTA,
            this.EDICAO,
            this.VALIDADE,
            this.COMISSAO,
            this.OBS,
            this.DATACAD,
            this.ATIVO});
            this.dtgProdutos.Location = new System.Drawing.Point(3, 87);
            this.dtgProdutos.Name = "dtgProdutos";
            this.dtgProdutos.ReadOnly = true;
            this.dtgProdutos.RowHeadersWidth = 12;
            this.dtgProdutos.Size = new System.Drawing.Size(995, 441);
            this.dtgProdutos.TabIndex = 19;
            this.dtgProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProdutos_CellClick);
            this.dtgProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgProdutos_KeyDown);
            // 
            // ID_PRO
            // 
            this.ID_PRO.DataPropertyName = "ID_PRO";
            this.ID_PRO.HeaderText = "COD";
            this.ID_PRO.Name = "ID_PRO";
            this.ID_PRO.ReadOnly = true;
            this.ID_PRO.Width = 50;
            // 
            // REF
            // 
            this.REF.DataPropertyName = "REF";
            this.REF.HeaderText = "REF";
            this.REF.Name = "REF";
            this.REF.ReadOnly = true;
            // 
            // PRODUTO
            // 
            this.PRODUTO.DataPropertyName = "PRODUTO";
            this.PRODUTO.HeaderText = "PRODUTO";
            this.PRODUTO.Name = "PRODUTO";
            this.PRODUTO.ReadOnly = true;
            this.PRODUTO.Width = 250;
            // 
            // PRECO
            // 
            this.PRECO.DataPropertyName = "PRECO";
            dataGridViewCellStyle1.Format = "N2";
            this.PRECO.DefaultCellStyle = dataGridViewCellStyle1;
            this.PRECO.HeaderText = "PREÇO";
            this.PRECO.Name = "PRECO";
            this.PRECO.ReadOnly = true;
            this.PRECO.Width = 60;
            // 
            // PROMOCAO
            // 
            this.PROMOCAO.DataPropertyName = "PROMOCAO";
            dataGridViewCellStyle2.Format = "N2";
            this.PROMOCAO.DefaultCellStyle = dataGridViewCellStyle2;
            this.PROMOCAO.HeaderText = "PROMO";
            this.PROMOCAO.Name = "PROMOCAO";
            this.PROMOCAO.ReadOnly = true;
            this.PROMOCAO.Width = 60;
            // 
            // REVISTA
            // 
            this.REVISTA.DataPropertyName = "REVISTA";
            this.REVISTA.HeaderText = "REVISTA";
            this.REVISTA.Name = "REVISTA";
            this.REVISTA.ReadOnly = true;
            this.REVISTA.Width = 150;
            // 
            // EDICAO
            // 
            this.EDICAO.DataPropertyName = "EDICAO";
            this.EDICAO.HeaderText = "EDIÇÃO";
            this.EDICAO.Name = "EDICAO";
            this.EDICAO.ReadOnly = true;
            this.EDICAO.Width = 150;
            // 
            // VALIDADE
            // 
            this.VALIDADE.DataPropertyName = "VALIDADE";
            this.VALIDADE.HeaderText = "VALIDADE";
            this.VALIDADE.Name = "VALIDADE";
            this.VALIDADE.ReadOnly = true;
            this.VALIDADE.Width = 80;
            // 
            // COMISSAO
            // 
            this.COMISSAO.DataPropertyName = "COMISSAO";
            this.COMISSAO.HeaderText = "COM";
            this.COMISSAO.Name = "COMISSAO";
            this.COMISSAO.ReadOnly = true;
            this.COMISSAO.Width = 50;
            // 
            // OBS
            // 
            this.OBS.DataPropertyName = "OBS";
            this.OBS.HeaderText = "OBS";
            this.OBS.Name = "OBS";
            this.OBS.ReadOnly = true;
            this.OBS.Width = 800;
            // 
            // DATACAD
            // 
            this.DATACAD.DataPropertyName = "DATACAD";
            this.DATACAD.HeaderText = "DATACAD";
            this.DATACAD.Name = "DATACAD";
            this.DATACAD.ReadOnly = true;
            this.DATACAD.Width = 80;
            // 
            // ATIVO
            // 
            this.ATIVO.DataPropertyName = "ATIVO";
            this.ATIVO.HeaderText = "ATIVO";
            this.ATIVO.Name = "ATIVO";
            this.ATIVO.ReadOnly = true;
            this.ATIVO.Width = 40;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnDesfazer);
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.btnEditarGrid);
            this.panel2.Controls.Add(this.btnVoltar);
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnIncluir);
            this.panel2.Location = new System.Drawing.Point(3, 534);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 37);
            this.panel2.TabIndex = 11;
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDesfazer.Image = global::COSMOS.Properties.Resources.desfazer_fw;
            this.btnDesfazer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesfazer.Location = new System.Drawing.Point(561, 3);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(130, 31);
            this.btnDesfazer.TabIndex = 6;
            this.btnDesfazer.Text = "&Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Visible = false;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.Image = global::COSMOS.Properties.Resources.confirma;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(700, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(130, 31);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnEditarGrid
            // 
            this.btnEditarGrid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditarGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditarGrid.Image = global::COSMOS.Properties.Resources.editar;
            this.btnEditarGrid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarGrid.Location = new System.Drawing.Point(422, 3);
            this.btnEditarGrid.Name = "btnEditarGrid";
            this.btnEditarGrid.Size = new System.Drawing.Size(130, 31);
            this.btnEditarGrid.TabIndex = 4;
            this.btnEditarGrid.Text = "&Editar";
            this.btnEditarGrid.UseVisualStyleBackColor = true;
            this.btnEditarGrid.Click += new System.EventHandler(this.btnEditarGrid_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Image = global::COSMOS.Properties.Resources.sair_fw;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(862, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(130, 31);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.Image = global::COSMOS.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(139, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(130, 31);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnIncluir.Image = global::COSMOS.Properties.Resources.editar;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(3, 3);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(130, 31);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // grpFiltroUsuario
            // 
            this.grpFiltroUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiltroUsuario.Controls.Add(this.cmbRevistas);
            this.grpFiltroUsuario.Controls.Add(this.lblRevista);
            this.grpFiltroUsuario.Controls.Add(this.lblProduto);
            this.grpFiltroUsuario.Controls.Add(this.lblCodigo);
            this.grpFiltroUsuario.Controls.Add(this.txtProduto);
            this.grpFiltroUsuario.Controls.Add(this.txtCodigo);
            this.grpFiltroUsuario.Controls.Add(this.btnLimpar);
            this.grpFiltroUsuario.Controls.Add(this.btnFiltrar);
            this.grpFiltroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grpFiltroUsuario.Location = new System.Drawing.Point(3, 3);
            this.grpFiltroUsuario.Name = "grpFiltroUsuario";
            this.grpFiltroUsuario.Size = new System.Drawing.Size(995, 52);
            this.grpFiltroUsuario.TabIndex = 3;
            this.grpFiltroUsuario.TabStop = false;
            this.grpFiltroUsuario.Text = "Filtrar por:";
            // 
            // cmbRevistas
            // 
            this.cmbRevistas.FormattingEnabled = true;
            this.cmbRevistas.Location = new System.Drawing.Point(612, 19);
            this.cmbRevistas.Name = "cmbRevistas";
            this.cmbRevistas.Size = new System.Drawing.Size(164, 24);
            this.cmbRevistas.TabIndex = 65;
            this.cmbRevistas.SelectedIndexChanged += new System.EventHandler(this.cmbRevistas_SelectedIndexChanged);
            // 
            // lblRevista
            // 
            this.lblRevista.AutoSize = true;
            this.lblRevista.Location = new System.Drawing.Point(539, 22);
            this.lblRevista.Name = "lblRevista";
            this.lblRevista.Size = new System.Drawing.Size(67, 17);
            this.lblRevista.TabIndex = 16;
            this.lblRevista.Text = "Revista:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(241, 22);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(70, 17);
            this.lblProduto.TabIndex = 14;
            this.lblProduto.Text = "Produto:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 17);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "Código:";
            // 
            // txtProduto
            // 
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Location = new System.Drawing.Point(317, 19);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(204, 23);
            this.txtProduto.TabIndex = 12;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(75, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(148, 23);
            this.txtCodigo.TabIndex = 11;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Image = global::COSMOS.Properties.Resources.Pequeno_Eraser_icon_icons_com_55918_fw;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(898, 15);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 30);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.Image = global::COSMOS.Properties.Resources.lupa_fw;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(798, 15);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(88, 30);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // pnlFilUsu
            // 
            this.pnlFilUsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilUsu.Controls.Add(this.rbUsuInativo);
            this.pnlFilUsu.Controls.Add(this.rbUsuAtivo);
            this.pnlFilUsu.Controls.Add(this.rbUsuTodos);
            this.pnlFilUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFilUsu.Location = new System.Drawing.Point(799, 59);
            this.pnlFilUsu.Name = "pnlFilUsu";
            this.pnlFilUsu.Size = new System.Drawing.Size(186, 22);
            this.pnlFilUsu.TabIndex = 1;
            // 
            // rbUsuInativo
            // 
            this.rbUsuInativo.AutoSize = true;
            this.rbUsuInativo.Location = new System.Drawing.Point(127, 2);
            this.rbUsuInativo.Name = "rbUsuInativo";
            this.rbUsuInativo.Size = new System.Drawing.Size(62, 17);
            this.rbUsuInativo.TabIndex = 2;
            this.rbUsuInativo.Text = "Inativos";
            this.rbUsuInativo.UseVisualStyleBackColor = true;
            this.rbUsuInativo.CheckedChanged += new System.EventHandler(this.rbUsuInativo_CheckedChanged);
            // 
            // rbUsuAtivo
            // 
            this.rbUsuAtivo.AutoSize = true;
            this.rbUsuAtivo.Checked = true;
            this.rbUsuAtivo.Location = new System.Drawing.Point(66, 2);
            this.rbUsuAtivo.Name = "rbUsuAtivo";
            this.rbUsuAtivo.Size = new System.Drawing.Size(54, 17);
            this.rbUsuAtivo.TabIndex = 1;
            this.rbUsuAtivo.TabStop = true;
            this.rbUsuAtivo.Text = "Ativos";
            this.rbUsuAtivo.UseVisualStyleBackColor = true;
            this.rbUsuAtivo.CheckedChanged += new System.EventHandler(this.rbUsuAtivo_CheckedChanged);
            // 
            // rbUsuTodos
            // 
            this.rbUsuTodos.AutoSize = true;
            this.rbUsuTodos.Location = new System.Drawing.Point(4, 2);
            this.rbUsuTodos.Name = "rbUsuTodos";
            this.rbUsuTodos.Size = new System.Drawing.Size(55, 17);
            this.rbUsuTodos.TabIndex = 0;
            this.rbUsuTodos.Text = "Todos";
            this.rbUsuTodos.UseVisualStyleBackColor = true;
            this.rbUsuTodos.CheckedChanged += new System.EventHandler(this.rbUsuTodos_CheckedChanged);
            // 
            // frmGerProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 582);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerProdutos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Produtos -Cosmos - Sistema para controle de cosméticos - New Era" +
    " Info";
            this.Load += new System.EventHandler(this.frmGerProdutos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.grpFiltroUsuario.ResumeLayout(false);
            this.grpFiltroUsuario.PerformLayout();
            this.pnlFilUsu.ResumeLayout(false);
            this.pnlFilUsu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnEditarGrid;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox grpFiltroUsuario;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Panel pnlFilUsu;
        public System.Windows.Forms.RadioButton rbUsuInativo;
        public System.Windows.Forms.RadioButton rbUsuAtivo;
        public System.Windows.Forms.RadioButton rbUsuTodos;
        private System.Windows.Forms.Label lblRevista;
        private System.Windows.Forms.ComboBox cmbRevistas;
        private System.Windows.Forms.DataGridView dtgProdutos;
        private System.Windows.Forms.DataGridView dtgT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROMOCAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn REVISTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMISSAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATACAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATIVO;

    }
}