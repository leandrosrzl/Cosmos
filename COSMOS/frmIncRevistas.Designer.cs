namespace COSMOS
{
    partial class frmIncRevistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncRevistas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbComissao = new System.Windows.Forms.GroupBox();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.gpbCpf = new System.Windows.Forms.GroupBox();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.gpbEdicao = new System.Windows.Forms.GroupBox();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.gpbNomeVen = new System.Windows.Forms.GroupBox();
            this.txtRevista = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxDesatVen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDREV = new System.Windows.Forms.TextBox();
            this.gpbDesatPor = new System.Windows.Forms.GroupBox();
            this.lblDataDesat = new System.Windows.Forms.Label();
            this.lblUsuDesat = new System.Windows.Forms.Label();
            this.gpbCadPor = new System.Windows.Forms.GroupBox();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.lblUsuCad = new System.Windows.Forms.Label();
            this.gpbObservacoes = new System.Windows.Forms.GroupBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.pnlGeral = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvarManutVen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpbComissao.SuspendLayout();
            this.gpbCpf.SuspendLayout();
            this.gpbEdicao.SuspendLayout();
            this.gpbNomeVen.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gpbDesatPor.SuspendLayout();
            this.gpbCadPor.SuspendLayout();
            this.gpbObservacoes.SuspendLayout();
            this.pnlGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gpbComissao);
            this.groupBox1.Controls.Add(this.gpbCpf);
            this.groupBox1.Controls.Add(this.gpbEdicao);
            this.groupBox1.Controls.Add(this.gpbNomeVen);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.groupBox1.Location = new System.Drawing.Point(4, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 132);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados cadastrais";
            // 
            // gpbComissao
            // 
            this.gpbComissao.Controls.Add(this.txtComissao);
            this.gpbComissao.Location = new System.Drawing.Point(488, 68);
            this.gpbComissao.Name = "gpbComissao";
            this.gpbComissao.Size = new System.Drawing.Size(110, 49);
            this.gpbComissao.TabIndex = 29;
            this.gpbComissao.TabStop = false;
            this.gpbComissao.Text = "Comissão";
            // 
            // txtComissao
            // 
            this.txtComissao.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.txtComissao.Location = new System.Drawing.Point(6, 15);
            this.txtComissao.MaxLength = 2;
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(98, 26);
            this.txtComissao.TabIndex = 19;
            this.txtComissao.Text = "0";
            // 
            // gpbCpf
            // 
            this.gpbCpf.Controls.Add(this.dtpValidade);
            this.gpbCpf.Location = new System.Drawing.Point(296, 68);
            this.gpbCpf.Name = "gpbCpf";
            this.gpbCpf.Size = new System.Drawing.Size(156, 49);
            this.gpbCpf.TabIndex = 2;
            this.gpbCpf.TabStop = false;
            this.gpbCpf.Text = "*Validade";
            // 
            // dtpValidade
            // 
            this.dtpValidade.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidade.Location = new System.Drawing.Point(6, 15);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(143, 26);
            this.dtpValidade.TabIndex = 1;
            // 
            // gpbEdicao
            // 
            this.gpbEdicao.Controls.Add(this.txtEdicao);
            this.gpbEdicao.Location = new System.Drawing.Point(6, 68);
            this.gpbEdicao.Name = "gpbEdicao";
            this.gpbEdicao.Size = new System.Drawing.Size(255, 49);
            this.gpbEdicao.TabIndex = 1;
            this.gpbEdicao.TabStop = false;
            this.gpbEdicao.Text = "*Edição";
            // 
            // txtEdicao
            // 
            this.txtEdicao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEdicao.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.txtEdicao.Location = new System.Drawing.Point(6, 15);
            this.txtEdicao.MaxLength = 30;
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(243, 26);
            this.txtEdicao.TabIndex = 5;
            // 
            // gpbNomeVen
            // 
            this.gpbNomeVen.Controls.Add(this.txtRevista);
            this.gpbNomeVen.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.gpbNomeVen.Location = new System.Drawing.Point(6, 15);
            this.gpbNomeVen.Name = "gpbNomeVen";
            this.gpbNomeVen.Size = new System.Drawing.Size(684, 49);
            this.gpbNomeVen.TabIndex = 0;
            this.gpbNomeVen.TabStop = false;
            this.gpbNomeVen.Text = "*Revista";
            // 
            // txtRevista
            // 
            this.txtRevista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRevista.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.txtRevista.Location = new System.Drawing.Point(6, 15);
            this.txtRevista.MaxLength = 100;
            this.txtRevista.Name = "txtRevista";
            this.txtRevista.Size = new System.Drawing.Size(672, 26);
            this.txtRevista.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxDesatVen);
            this.panel2.Font = new System.Drawing.Font("Bookman Old Style", 10F);
            this.panel2.Location = new System.Drawing.Point(604, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 57);
            this.panel2.TabIndex = 28;
            // 
            // cbxDesatVen
            // 
            this.cbxDesatVen.AutoSize = true;
            this.cbxDesatVen.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbxDesatVen.Location = new System.Drawing.Point(4, 13);
            this.cbxDesatVen.Name = "cbxDesatVen";
            this.cbxDesatVen.Size = new System.Drawing.Size(78, 37);
            this.cbxDesatVen.TabIndex = 0;
            this.cbxDesatVen.Text = "Desativar";
            this.cbxDesatVen.UseVisualStyleBackColor = true;
            this.cbxDesatVen.CheckedChanged += new System.EventHandler(this.cbxDesatVen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Código:";
            // 
            // txtIDREV
            // 
            this.txtIDREV.Location = new System.Drawing.Point(323, 5);
            this.txtIDREV.Name = "txtIDREV";
            this.txtIDREV.ReadOnly = true;
            this.txtIDREV.Size = new System.Drawing.Size(133, 26);
            this.txtIDREV.TabIndex = 58;
            // 
            // gpbDesatPor
            // 
            this.gpbDesatPor.Controls.Add(this.lblDataDesat);
            this.gpbDesatPor.Controls.Add(this.lblUsuDesat);
            this.gpbDesatPor.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.gpbDesatPor.Location = new System.Drawing.Point(4, 561);
            this.gpbDesatPor.Name = "gpbDesatPor";
            this.gpbDesatPor.Size = new System.Drawing.Size(319, 37);
            this.gpbDesatPor.TabIndex = 62;
            this.gpbDesatPor.TabStop = false;
            this.gpbDesatPor.Text = "Desativado por:";
            this.gpbDesatPor.Visible = false;
            // 
            // lblDataDesat
            // 
            this.lblDataDesat.AutoSize = true;
            this.lblDataDesat.Location = new System.Drawing.Point(180, 16);
            this.lblDataDesat.Name = "lblDataDesat";
            this.lblDataDesat.Size = new System.Drawing.Size(51, 16);
            this.lblDataDesat.TabIndex = 2;
            this.lblDataDesat.Text = "label12";
            // 
            // lblUsuDesat
            // 
            this.lblUsuDesat.AutoSize = true;
            this.lblUsuDesat.Location = new System.Drawing.Point(6, 16);
            this.lblUsuDesat.Name = "lblUsuDesat";
            this.lblUsuDesat.Size = new System.Drawing.Size(51, 16);
            this.lblUsuDesat.TabIndex = 1;
            this.lblUsuDesat.Text = "label12";
            // 
            // gpbCadPor
            // 
            this.gpbCadPor.Controls.Add(this.lblDataCad);
            this.gpbCadPor.Controls.Add(this.lblUsuCad);
            this.gpbCadPor.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.gpbCadPor.Location = new System.Drawing.Point(381, 561);
            this.gpbCadPor.Name = "gpbCadPor";
            this.gpbCadPor.Size = new System.Drawing.Size(319, 37);
            this.gpbCadPor.TabIndex = 63;
            this.gpbCadPor.TabStop = false;
            this.gpbCadPor.Text = "Cadastrado por:";
            this.gpbCadPor.Visible = false;
            // 
            // lblDataCad
            // 
            this.lblDataCad.AutoSize = true;
            this.lblDataCad.Location = new System.Drawing.Point(170, 16);
            this.lblDataCad.Name = "lblDataCad";
            this.lblDataCad.Size = new System.Drawing.Size(51, 16);
            this.lblDataCad.TabIndex = 2;
            this.lblDataCad.Text = "label12";
            // 
            // lblUsuCad
            // 
            this.lblUsuCad.AutoSize = true;
            this.lblUsuCad.Location = new System.Drawing.Point(6, 16);
            this.lblUsuCad.Name = "lblUsuCad";
            this.lblUsuCad.Size = new System.Drawing.Size(51, 16);
            this.lblUsuCad.TabIndex = 1;
            this.lblUsuCad.Text = "label13";
            // 
            // gpbObservacoes
            // 
            this.gpbObservacoes.Controls.Add(this.txtObservacao);
            this.gpbObservacoes.Font = new System.Drawing.Font("Bookman Old Style", 9F);
            this.gpbObservacoes.Location = new System.Drawing.Point(4, 218);
            this.gpbObservacoes.Name = "gpbObservacoes";
            this.gpbObservacoes.Size = new System.Drawing.Size(696, 337);
            this.gpbObservacoes.TabIndex = 15;
            this.gpbObservacoes.TabStop = false;
            this.gpbObservacoes.Text = "Observações";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.txtObservacao.Location = new System.Drawing.Point(6, 14);
            this.txtObservacao.MaxLength = 512;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(684, 316);
            this.txtObservacao.TabIndex = 0;
            // 
            // pnlGeral
            // 
            this.pnlGeral.Controls.Add(this.gpbObservacoes);
            this.pnlGeral.Controls.Add(this.gpbCadPor);
            this.pnlGeral.Controls.Add(this.gpbDesatPor);
            this.pnlGeral.Controls.Add(this.txtIDREV);
            this.pnlGeral.Controls.Add(this.label1);
            this.pnlGeral.Controls.Add(this.groupBox1);
            this.pnlGeral.Enabled = false;
            this.pnlGeral.Font = new System.Drawing.Font("Bookman Old Style", 12F);
            this.pnlGeral.Location = new System.Drawing.Point(0, 0);
            this.pnlGeral.Name = "pnlGeral";
            this.pnlGeral.Size = new System.Drawing.Size(704, 602);
            this.pnlGeral.TabIndex = 68;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.Image = global::COSMOS.Properties.Resources.editar;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(145, 608);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(130, 31);
            this.btnAlterar.TabIndex = 64;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnIncluir.Image = global::COSMOS.Properties.Resources.editar;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(286, 608);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(130, 31);
            this.btnIncluir.TabIndex = 65;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Image = global::COSMOS.Properties.Resources.sair_fw;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(568, 608);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(130, 31);
            this.btnVoltar.TabIndex = 67;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvarManutVen
            // 
            this.btnSalvarManutVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvarManutVen.Image = global::COSMOS.Properties.Resources.save;
            this.btnSalvarManutVen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarManutVen.Location = new System.Drawing.Point(4, 608);
            this.btnSalvarManutVen.Name = "btnSalvarManutVen";
            this.btnSalvarManutVen.Size = new System.Drawing.Size(130, 31);
            this.btnSalvarManutVen.TabIndex = 63;
            this.btnSalvarManutVen.Text = "&Salvar";
            this.btnSalvarManutVen.UseVisualStyleBackColor = true;
            this.btnSalvarManutVen.Visible = false;
            this.btnSalvarManutVen.Click += new System.EventHandler(this.btnSalvarManutVen_Click);
            // 
            // frmIncRevistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 648);
            this.Controls.Add(this.pnlGeral);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvarManutVen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmIncRevistas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Revistas - Cosmos - New Era Info";
            this.Load += new System.EventHandler(this.frmIncRevistas_Load);
            this.groupBox1.ResumeLayout(false);
            this.gpbComissao.ResumeLayout(false);
            this.gpbComissao.PerformLayout();
            this.gpbCpf.ResumeLayout(false);
            this.gpbEdicao.ResumeLayout(false);
            this.gpbEdicao.PerformLayout();
            this.gpbNomeVen.ResumeLayout(false);
            this.gpbNomeVen.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gpbDesatPor.ResumeLayout(false);
            this.gpbDesatPor.PerformLayout();
            this.gpbCadPor.ResumeLayout(false);
            this.gpbCadPor.PerformLayout();
            this.gpbObservacoes.ResumeLayout(false);
            this.gpbObservacoes.PerformLayout();
            this.pnlGeral.ResumeLayout(false);
            this.pnlGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvarManutVen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbCpf;
        private System.Windows.Forms.GroupBox gpbEdicao;
        private System.Windows.Forms.TextBox txtEdicao;
        private System.Windows.Forms.GroupBox gpbNomeVen;
        private System.Windows.Forms.TextBox txtRevista;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbxDesatVen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDREV;
        private System.Windows.Forms.GroupBox gpbDesatPor;
        private System.Windows.Forms.Label lblDataDesat;
        private System.Windows.Forms.Label lblUsuDesat;
        private System.Windows.Forms.GroupBox gpbCadPor;
        private System.Windows.Forms.Label lblDataCad;
        private System.Windows.Forms.Label lblUsuCad;
        private System.Windows.Forms.GroupBox gpbObservacoes;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Panel pnlGeral;
        private System.Windows.Forms.GroupBox gpbComissao;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.DateTimePicker dtpValidade;
    }
}