namespace COSMOS
{
    partial class frmGerVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerVendedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnEditarGrid = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dtgVendedores = new System.Windows.Forms.DataGridView();
            this.IDVEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPLEMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CADUSU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATANASC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATACAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFiltroUsuario = new System.Windows.Forms.GroupBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.pnlFilUsu = new System.Windows.Forms.Panel();
            this.rbUsuInativo = new System.Windows.Forms.RadioButton();
            this.rbUsuAtivo = new System.Windows.Forms.RadioButton();
            this.rbUsuTodos = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedores)).BeginInit();
            this.grpFiltroUsuario.SuspendLayout();
            this.pnlFilUsu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtgVendedores);
            this.panel1.Controls.Add(this.grpFiltroUsuario);
            this.panel1.Controls.Add(this.pnlFilUsu);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 574);
            this.panel1.TabIndex = 2;
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
            // dtgVendedores
            // 
            this.dtgVendedores.AllowUserToAddRows = false;
            this.dtgVendedores.AllowUserToDeleteRows = false;
            this.dtgVendedores.AllowUserToOrderColumns = true;
            this.dtgVendedores.AllowUserToResizeColumns = false;
            this.dtgVendedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVEN,
            this.NOME,
            this.APELIDO,
            this.ENDERECO,
            this.NRO,
            this.COMPLEMENTO,
            this.CADUSU,
            this.CEP,
            this.BAIRRO,
            this.CIDADE,
            this.UF,
            this.FONE,
            this.CEL,
            this.CPF,
            this.RG,
            this.DATANASC,
            this.DATACAD,
            this.ATIVO});
            this.dtgVendedores.Location = new System.Drawing.Point(3, 87);
            this.dtgVendedores.Name = "dtgVendedores";
            this.dtgVendedores.ReadOnly = true;
            this.dtgVendedores.RowHeadersWidth = 12;
            this.dtgVendedores.Size = new System.Drawing.Size(995, 441);
            this.dtgVendedores.TabIndex = 10;
            // 
            // IDVEN
            // 
            this.IDVEN.DataPropertyName = "IDVEN";
            this.IDVEN.HeaderText = "COD";
            this.IDVEN.Name = "IDVEN";
            this.IDVEN.ReadOnly = true;
            this.IDVEN.Width = 40;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "NOME";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 250;
            // 
            // APELIDO
            // 
            this.APELIDO.DataPropertyName = "APELIDO";
            this.APELIDO.HeaderText = "APELIDO";
            this.APELIDO.Name = "APELIDO";
            this.APELIDO.ReadOnly = true;
            // 
            // ENDERECO
            // 
            this.ENDERECO.DataPropertyName = "ENDERECO";
            this.ENDERECO.HeaderText = "ENDEREÇO";
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.ReadOnly = true;
            this.ENDERECO.Width = 250;
            // 
            // NRO
            // 
            this.NRO.DataPropertyName = "NRO";
            this.NRO.HeaderText = "NRO";
            this.NRO.Name = "NRO";
            this.NRO.ReadOnly = true;
            this.NRO.Width = 60;
            // 
            // COMPLEMENTO
            // 
            this.COMPLEMENTO.DataPropertyName = "COMPLEMENTO";
            this.COMPLEMENTO.HeaderText = "COMPLEMENTO";
            this.COMPLEMENTO.Name = "COMPLEMENTO";
            this.COMPLEMENTO.ReadOnly = true;
            this.COMPLEMENTO.Width = 200;
            // 
            // CADUSU
            // 
            this.CADUSU.DataPropertyName = "CADUSU";
            this.CADUSU.HeaderText = "CADUSU";
            this.CADUSU.Name = "CADUSU";
            this.CADUSU.ReadOnly = true;
            this.CADUSU.Visible = false;
            // 
            // CEP
            // 
            this.CEP.DataPropertyName = "CEP";
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            this.CEP.Width = 80;
            // 
            // BAIRRO
            // 
            this.BAIRRO.DataPropertyName = "BAIRRO";
            this.BAIRRO.HeaderText = "BAIRRO";
            this.BAIRRO.Name = "BAIRRO";
            this.BAIRRO.ReadOnly = true;
            this.BAIRRO.Width = 150;
            // 
            // CIDADE
            // 
            this.CIDADE.DataPropertyName = "CIDADE";
            this.CIDADE.HeaderText = "CIDADE";
            this.CIDADE.Name = "CIDADE";
            this.CIDADE.ReadOnly = true;
            // 
            // UF
            // 
            this.UF.DataPropertyName = "UF";
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            this.UF.Width = 40;
            // 
            // FONE
            // 
            this.FONE.DataPropertyName = "FONE";
            this.FONE.HeaderText = "FONE";
            this.FONE.Name = "FONE";
            this.FONE.ReadOnly = true;
            // 
            // CEL
            // 
            this.CEL.DataPropertyName = "CEL";
            this.CEL.HeaderText = "CEL";
            this.CEL.Name = "CEL";
            this.CEL.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // RG
            // 
            this.RG.DataPropertyName = "RG";
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            // 
            // DATANASC
            // 
            this.DATANASC.DataPropertyName = "DATANASC";
            this.DATANASC.HeaderText = "DATANASC";
            this.DATANASC.Name = "DATANASC";
            this.DATANASC.ReadOnly = true;
            // 
            // DATACAD
            // 
            this.DATACAD.DataPropertyName = "DATACAD";
            this.DATACAD.HeaderText = "DATACAD";
            this.DATACAD.Name = "DATACAD";
            this.DATACAD.ReadOnly = true;
            // 
            // ATIVO
            // 
            this.ATIVO.DataPropertyName = "ATIVO";
            this.ATIVO.HeaderText = "ATIVO";
            this.ATIVO.Name = "ATIVO";
            this.ATIVO.ReadOnly = true;
            this.ATIVO.Visible = false;
            this.ATIVO.Width = 50;
            // 
            // grpFiltroUsuario
            // 
            this.grpFiltroUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiltroUsuario.Controls.Add(this.lblVendedor);
            this.grpFiltroUsuario.Controls.Add(this.lblCodigo);
            this.grpFiltroUsuario.Controls.Add(this.txtVendedor);
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
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(333, 22);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(83, 17);
            this.lblVendedor.TabIndex = 14;
            this.lblVendedor.Text = "Vendedor:";
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
            // txtVendedor
            // 
            this.txtVendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendedor.Location = new System.Drawing.Point(422, 19);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(191, 23);
            this.txtVendedor.TabIndex = 12;
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
            // frmGerVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 582);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerVendedores";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Vendedores -Cosmos - Sistema para controle de cosméticos - New E" +
    "ra Info";
            this.Load += new System.EventHandler(this.frmGerVendedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVendedores)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgVendedores;
        private System.Windows.Forms.GroupBox grpFiltroUsuario;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Panel pnlFilUsu;
        private System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.RadioButton rbUsuInativo;
        public System.Windows.Forms.RadioButton rbUsuAtivo;
        public System.Windows.Forms.RadioButton rbUsuTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPLEMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CADUSU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn FONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATANASC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATACAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATIVO;
    }
}