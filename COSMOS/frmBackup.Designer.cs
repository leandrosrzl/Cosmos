namespace COSMOS
{
    partial class frmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtCaminhoBackup = new System.Windows.Forms.TextBox();
            this.lblCaminhoBackup = new System.Windows.Forms.Label();
            this.btnLupa = new System.Windows.Forms.Button();
            this.pgbBackup = new System.Windows.Forms.ProgressBar();
            this.fbdProcuraBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pgbBackup);
            this.panel1.Controls.Add(this.btnLupa);
            this.panel1.Controls.Add(this.lblCaminhoBackup);
            this.panel1.Controls.Add(this.txtCaminhoBackup);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 476);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(9, 231);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(620, 199);
            this.textBox1.TabIndex = 99;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmar.Image = global::COSMOS.Properties.Resources.confirma;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(9, 436);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(130, 31);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Image = global::COSMOS.Properties.Resources.sair_fw;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(499, 436);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(130, 31);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtCaminhoBackup
            // 
            this.txtCaminhoBackup.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoBackup.Location = new System.Drawing.Point(9, 47);
            this.txtCaminhoBackup.Name = "txtCaminhoBackup";
            this.txtCaminhoBackup.Size = new System.Drawing.Size(571, 32);
            this.txtCaminhoBackup.TabIndex = 1;
            // 
            // lblCaminhoBackup
            // 
            this.lblCaminhoBackup.AutoSize = true;
            this.lblCaminhoBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCaminhoBackup.Location = new System.Drawing.Point(9, 27);
            this.lblCaminhoBackup.Name = "lblCaminhoBackup";
            this.lblCaminhoBackup.Size = new System.Drawing.Size(165, 17);
            this.lblCaminhoBackup.TabIndex = 9;
            this.lblCaminhoBackup.Text = "Caminho para backup";
            // 
            // btnLupa
            // 
            this.btnLupa.Image = global::COSMOS.Properties.Resources.lupa_fw;
            this.btnLupa.Location = new System.Drawing.Point(586, 47);
            this.btnLupa.Name = "btnLupa";
            this.btnLupa.Size = new System.Drawing.Size(43, 32);
            this.btnLupa.TabIndex = 0;
            this.btnLupa.UseVisualStyleBackColor = true;
            this.btnLupa.Click += new System.EventHandler(this.btnLupa_Click);
            // 
            // pgbBackup
            // 
            this.pgbBackup.Location = new System.Drawing.Point(9, 132);
            this.pgbBackup.Name = "pgbBackup";
            this.pgbBackup.Size = new System.Drawing.Size(620, 33);
            this.pgbBackup.TabIndex = 11;
            // 
            // fbdProcuraBackup
            // 
            this.fbdProcuraBackup.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 482);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup de banco de dados - COSMOS - Sistema para controle de cosméticos - New Era" +
    " Info";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtCaminhoBackup;
        private System.Windows.Forms.ProgressBar pgbBackup;
        private System.Windows.Forms.Button btnLupa;
        private System.Windows.Forms.Label lblCaminhoBackup;
        private System.Windows.Forms.FolderBrowserDialog fbdProcuraBackup;
    }
}