namespace COSMOS
{
    partial class frmGerRevistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerRevistas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRevistaSelecionada = new System.Windows.Forms.Label();
            this.grpFiltroUsuario = new System.Windows.Forms.GroupBox();
            this.lblRevista = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtRevista = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.pnlFilUsu = new System.Windows.Forms.Panel();
            this.rbUsuInativo = new System.Windows.Forms.RadioButton();
            this.rbUsuAtivo = new System.Windows.Forms.RadioButton();
            this.rbUsuTodos = new System.Windows.Forms.RadioButton();
            this.tbcRevistas = new System.Windows.Forms.TabControl();
            this.tbpRevistas = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnEditarGrid = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dtgRevistas = new System.Windows.Forms.DataGridView();
            this.ID_REV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REVISTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMISSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATACAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpProdutosVinculados = new System.Windows.Forms.TabPage();
            this.dtgProdutosPorRevista = new System.Windows.Forms.DataGridView();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PATIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROMOCAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDREV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReativar = new System.Windows.Forms.Button();
            this.btnExcluirTodos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpFiltroUsuario.SuspendLayout();
            this.pnlFilUsu.SuspendLayout();
            this.tbcRevistas.SuspendLayout();
            this.tbpRevistas.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRevistas)).BeginInit();
            this.tbpProdutosVinculados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutosPorRevista)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblRevistaSelecionada);
            this.panel1.Controls.Add(this.grpFiltroUsuario);
            this.panel1.Controls.Add(this.pnlFilUsu);
            this.panel1.Controls.Add(this.tbcRevistas);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 574);
            this.panel1.TabIndex = 3;
            // 
            // lblRevistaSelecionada
            // 
            this.lblRevistaSelecionada.AutoSize = true;
            this.lblRevistaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblRevistaSelecionada.Location = new System.Drawing.Point(305, 63);
            this.lblRevistaSelecionada.Name = "lblRevistaSelecionada";
            this.lblRevistaSelecionada.Size = new System.Drawing.Size(159, 17);
            this.lblRevistaSelecionada.TabIndex = 15;
            this.lblRevistaSelecionada.Text = "Revista selecionada:";
            this.lblRevistaSelecionada.Visible = false;
            // 
            // grpFiltroUsuario
            // 
            this.grpFiltroUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiltroUsuario.Controls.Add(this.lblRevista);
            this.grpFiltroUsuario.Controls.Add(this.lblCodigo);
            this.grpFiltroUsuario.Controls.Add(this.txtRevista);
            this.grpFiltroUsuario.Controls.Add(this.txtCodigo);
            this.grpFiltroUsuario.Controls.Add(this.btnLimpar);
            this.grpFiltroUsuario.Controls.Add(this.btnFiltrar);
            this.grpFiltroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.grpFiltroUsuario.Location = new System.Drawing.Point(3, 3);
            this.grpFiltroUsuario.Name = "grpFiltroUsuario";
            this.grpFiltroUsuario.Size = new System.Drawing.Size(994, 52);
            this.grpFiltroUsuario.TabIndex = 13;
            this.grpFiltroUsuario.TabStop = false;
            this.grpFiltroUsuario.Text = "Filtrar por:";
            // 
            // lblRevista
            // 
            this.lblRevista.AutoSize = true;
            this.lblRevista.Location = new System.Drawing.Point(349, 22);
            this.lblRevista.Name = "lblRevista";
            this.lblRevista.Size = new System.Drawing.Size(67, 17);
            this.lblRevista.TabIndex = 14;
            this.lblRevista.Text = "Revista:";
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
            // txtRevista
            // 
            this.txtRevista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRevista.Location = new System.Drawing.Point(422, 19);
            this.txtRevista.Name = "txtRevista";
            this.txtRevista.Size = new System.Drawing.Size(191, 23);
            this.txtRevista.TabIndex = 12;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(75, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(191, 23);
            this.txtCodigo.TabIndex = 11;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Image = global::COSMOS.Properties.Resources.Pequeno_Eraser_icon_icons_com_55918_fw;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(899, 15);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 30);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.Image = global::COSMOS.Properties.Resources.lupa_fw;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(799, 15);
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
            this.pnlFilUsu.Size = new System.Drawing.Size(191, 22);
            this.pnlFilUsu.TabIndex = 12;
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
            // tbcRevistas
            // 
            this.tbcRevistas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcRevistas.Controls.Add(this.tbpRevistas);
            this.tbcRevistas.Controls.Add(this.tbpProdutosVinculados);
            this.tbcRevistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tbcRevistas.Location = new System.Drawing.Point(4, 62);
            this.tbcRevistas.Name = "tbcRevistas";
            this.tbcRevistas.SelectedIndex = 0;
            this.tbcRevistas.Size = new System.Drawing.Size(994, 509);
            this.tbcRevistas.TabIndex = 0;
            this.tbcRevistas.SelectedIndexChanged += new System.EventHandler(this.tbcRevistas_SelectedIndexChanged);
            // 
            // tbpRevistas
            // 
            this.tbpRevistas.BackColor = System.Drawing.SystemColors.Control;
            this.tbpRevistas.Controls.Add(this.panel2);
            this.tbpRevistas.Controls.Add(this.dtgRevistas);
            this.tbpRevistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpRevistas.Location = new System.Drawing.Point(4, 25);
            this.tbpRevistas.Name = "tbpRevistas";
            this.tbpRevistas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRevistas.Size = new System.Drawing.Size(986, 480);
            this.tbpRevistas.TabIndex = 0;
            this.tbpRevistas.Text = "Revistas";
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
            this.panel2.Location = new System.Drawing.Point(3, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 37);
            this.panel2.TabIndex = 15;
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDesfazer.Image = global::COSMOS.Properties.Resources.desfazer_fw;
            this.btnDesfazer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesfazer.Location = new System.Drawing.Point(556, 3);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(130, 31);
            this.btnDesfazer.TabIndex = 6;
            this.btnDesfazer.Text = "&Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.Image = global::COSMOS.Properties.Resources.confirma;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(695, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(130, 31);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            // 
            // btnEditarGrid
            // 
            this.btnEditarGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditarGrid.Image = global::COSMOS.Properties.Resources.editar;
            this.btnEditarGrid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarGrid.Location = new System.Drawing.Point(417, 3);
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
            this.btnVoltar.Location = new System.Drawing.Point(847, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(130, 31);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
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
            // dtgRevistas
            // 
            this.dtgRevistas.AllowUserToAddRows = false;
            this.dtgRevistas.AllowUserToDeleteRows = false;
            this.dtgRevistas.AllowUserToOrderColumns = true;
            this.dtgRevistas.AllowUserToResizeColumns = false;
            this.dtgRevistas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgRevistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_REV,
            this.REVISTA,
            this.EDICAO,
            this.VALIDADE,
            this.COMISSAO,
            this.DATACAD,
            this.OBS,
            this.ATIVO});
            this.dtgRevistas.Location = new System.Drawing.Point(3, 4);
            this.dtgRevistas.Name = "dtgRevistas";
            this.dtgRevistas.RowHeadersWidth = 12;
            this.dtgRevistas.Size = new System.Drawing.Size(980, 430);
            this.dtgRevistas.TabIndex = 14;
            // 
            // ID_REV
            // 
            this.ID_REV.DataPropertyName = "ID_REV";
            this.ID_REV.HeaderText = "COD";
            this.ID_REV.Name = "ID_REV";
            this.ID_REV.ReadOnly = true;
            this.ID_REV.Width = 50;
            // 
            // REVISTA
            // 
            this.REVISTA.DataPropertyName = "REVISTA";
            this.REVISTA.HeaderText = "REVISTA";
            this.REVISTA.Name = "REVISTA";
            this.REVISTA.ReadOnly = true;
            this.REVISTA.Width = 300;
            // 
            // EDICAO
            // 
            this.EDICAO.DataPropertyName = "EDICAO";
            this.EDICAO.HeaderText = "EDICAO";
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
            // 
            // COMISSAO
            // 
            this.COMISSAO.DataPropertyName = "COMISSAO";
            this.COMISSAO.HeaderText = "COMISSAO";
            this.COMISSAO.Name = "COMISSAO";
            // 
            // DATACAD
            // 
            this.DATACAD.DataPropertyName = "DATACAD";
            this.DATACAD.HeaderText = "DATACAD";
            this.DATACAD.Name = "DATACAD";
            this.DATACAD.ReadOnly = true;
            // 
            // OBS
            // 
            this.OBS.DataPropertyName = "OBS";
            this.OBS.HeaderText = "OBS";
            this.OBS.Name = "OBS";
            this.OBS.Width = 500;
            // 
            // ATIVO
            // 
            this.ATIVO.DataPropertyName = "ATIVO";
            this.ATIVO.HeaderText = "ATIVO";
            this.ATIVO.Name = "ATIVO";
            this.ATIVO.Visible = false;
            // 
            // tbpProdutosVinculados
            // 
            this.tbpProdutosVinculados.Controls.Add(this.dtgProdutosPorRevista);
            this.tbpProdutosVinculados.Controls.Add(this.panel3);
            this.tbpProdutosVinculados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbpProdutosVinculados.Location = new System.Drawing.Point(4, 25);
            this.tbpProdutosVinculados.Name = "tbpProdutosVinculados";
            this.tbpProdutosVinculados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProdutosVinculados.Size = new System.Drawing.Size(986, 480);
            this.tbpProdutosVinculados.TabIndex = 1;
            this.tbpProdutosVinculados.Text = "Produtos Vinculados";
            this.tbpProdutosVinculados.UseVisualStyleBackColor = true;
            // 
            // dtgProdutosPorRevista
            // 
            this.dtgProdutosPorRevista.AllowUserToAddRows = false;
            this.dtgProdutosPorRevista.AllowUserToDeleteRows = false;
            this.dtgProdutosPorRevista.AllowUserToOrderColumns = true;
            this.dtgProdutosPorRevista.AllowUserToResizeColumns = false;
            this.dtgProdutosPorRevista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProdutosPorRevista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sel,
            this.PATIVO,
            this.ID_PRO,
            this.REF,
            this.PRODUTO,
            this.PRECO,
            this.PROMOCAO,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.IDREV});
            this.dtgProdutosPorRevista.Location = new System.Drawing.Point(3, 4);
            this.dtgProdutosPorRevista.Name = "dtgProdutosPorRevista";
            this.dtgProdutosPorRevista.RowHeadersWidth = 12;
            this.dtgProdutosPorRevista.Size = new System.Drawing.Size(980, 538);
            this.dtgProdutosPorRevista.TabIndex = 18;
            // 
            // Sel
            // 
            this.Sel.HeaderText = "SEL";
            this.Sel.Name = "Sel";
            this.Sel.Visible = false;
            this.Sel.Width = 30;
            // 
            // PATIVO
            // 
            this.PATIVO.DataPropertyName = "ATIVO";
            this.PATIVO.HeaderText = "ATIVO";
            this.PATIVO.Name = "PATIVO";
            this.PATIVO.Width = 40;
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
            this.PRECO.HeaderText = "PREÇO";
            this.PRECO.Name = "PRECO";
            this.PRECO.ReadOnly = true;
            this.PRECO.Width = 60;
            // 
            // PROMOCAO
            // 
            this.PROMOCAO.DataPropertyName = "PROMOCAO";
            this.PROMOCAO.HeaderText = "PROMO";
            this.PROMOCAO.Name = "PROMOCAO";
            this.PROMOCAO.ReadOnly = true;
            this.PROMOCAO.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "REVISTA";
            this.dataGridViewTextBoxColumn1.HeaderText = "REVISTA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EDICAO";
            this.dataGridViewTextBoxColumn2.HeaderText = "EDIÇÃO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VALIDADE";
            this.dataGridViewTextBoxColumn3.HeaderText = "VALIDADE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "COMISSAO";
            this.dataGridViewTextBoxColumn4.HeaderText = "COM";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OBS";
            this.dataGridViewTextBoxColumn5.HeaderText = "OBS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DATACAD";
            this.dataGridViewTextBoxColumn6.HeaderText = "DATACAD";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // IDREV
            // 
            this.IDREV.DataPropertyName = "ID_REV";
            this.IDREV.HeaderText = "ID_REVabc";
            this.IDREV.Name = "IDREV";
            this.IDREV.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnReativar);
            this.panel3.Controls.Add(this.btnExcluirTodos);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btnVoltar2);
            this.panel3.Location = new System.Drawing.Point(3, 548);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 37);
            this.panel3.TabIndex = 17;
            // 
            // btnReativar
            // 
            this.btnReativar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnReativar.Image = global::COSMOS.Properties.Resources.editar;
            this.btnReativar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReativar.Location = new System.Drawing.Point(630, 3);
            this.btnReativar.Name = "btnReativar";
            this.btnReativar.Size = new System.Drawing.Size(150, 31);
            this.btnReativar.TabIndex = 8;
            this.btnReativar.Text = "&Reativar Todos";
            this.btnReativar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReativar.UseVisualStyleBackColor = true;
            this.btnReativar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExcluirTodos
            // 
            this.btnExcluirTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcluirTodos.Image = global::COSMOS.Properties.Resources.excluir;
            this.btnExcluirTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirTodos.Location = new System.Drawing.Point(3, 3);
            this.btnExcluirTodos.Name = "btnExcluirTodos";
            this.btnExcluirTodos.Size = new System.Drawing.Size(130, 31);
            this.btnExcluirTodos.TabIndex = 7;
            this.btnExcluirTodos.Text = "Excluir &Todos";
            this.btnExcluirTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirTodos.UseVisualStyleBackColor = true;
            this.btnExcluirTodos.Click += new System.EventHandler(this.btnExcluirTodos_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button3.Image = global::COSMOS.Properties.Resources.editar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(417, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "&Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnVoltar2.Image = global::COSMOS.Properties.Resources.sair_fw;
            this.btnVoltar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar2.Location = new System.Drawing.Point(847, 3);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(130, 31);
            this.btnVoltar2.TabIndex = 3;
            this.btnVoltar2.Text = "&Voltar";
            this.btnVoltar2.UseVisualStyleBackColor = true;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // frmGerRevistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 582);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerRevistas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Revistas -Cosmos - Sistema para controle de cosméticos - New Era" +
    " Info";
            this.Load += new System.EventHandler(this.frmGerRevistas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpFiltroUsuario.ResumeLayout(false);
            this.grpFiltroUsuario.PerformLayout();
            this.pnlFilUsu.ResumeLayout(false);
            this.pnlFilUsu.PerformLayout();
            this.tbcRevistas.ResumeLayout(false);
            this.tbpRevistas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRevistas)).EndInit();
            this.tbpProdutosVinculados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutosPorRevista)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbcRevistas;
        private System.Windows.Forms.TabPage tbpRevistas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnEditarGrid;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView dtgRevistas;
        private System.Windows.Forms.GroupBox grpFiltroUsuario;
        private System.Windows.Forms.Label lblRevista;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtRevista;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Panel pnlFilUsu;
        public System.Windows.Forms.RadioButton rbUsuInativo;
        public System.Windows.Forms.RadioButton rbUsuAtivo;
        public System.Windows.Forms.RadioButton rbUsuTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_REV;
        private System.Windows.Forms.DataGridViewTextBoxColumn REVISTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMISSAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATACAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATIVO;
        private System.Windows.Forms.TabPage tbpProdutosVinculados;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.DataGridView dtgProdutosPorRevista;
        private System.Windows.Forms.Label lblRevistaSelecionada;
        private System.Windows.Forms.Button btnExcluirTodos;
        private System.Windows.Forms.Button btnReativar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn REF;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROMOCAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDREV;

    }
}