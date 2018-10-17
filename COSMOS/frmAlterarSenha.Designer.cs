namespace COSMOS
{
    partial class frmAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarSenha));
            this.txtConfirmaNovaSenha = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConfirmaNova = new System.Windows.Forms.Label();
            this.lblNova = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAtual = new System.Windows.Forms.TextBox();
            this.lblAtual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConfirmaNovaSenha
            // 
            this.txtConfirmaNovaSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConfirmaNovaSenha.Location = new System.Drawing.Point(140, 117);
            this.txtConfirmaNovaSenha.Name = "txtConfirmaNovaSenha";
            this.txtConfirmaNovaSenha.PasswordChar = '*';
            this.txtConfirmaNovaSenha.Size = new System.Drawing.Size(211, 23);
            this.txtConfirmaNovaSenha.TabIndex = 3;
            this.txtConfirmaNovaSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmaNovaSenha_KeyPress);
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNovaSenha.Location = new System.Drawing.Point(140, 82);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(211, 23);
            this.txtNovaSenha.TabIndex = 2;
            this.txtNovaSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNovaSenha_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(209, 11);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 16);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "label2";
            // 
            // lblConfirmaNova
            // 
            this.lblConfirmaNova.AutoSize = true;
            this.lblConfirmaNova.Location = new System.Drawing.Point(12, 120);
            this.lblConfirmaNova.Name = "lblConfirmaNova";
            this.lblConfirmaNova.Size = new System.Drawing.Size(122, 16);
            this.lblConfirmaNova.TabIndex = 9;
            this.lblConfirmaNova.Text = "Confirma nova:";
            // 
            // lblNova
            // 
            this.lblNova.AutoSize = true;
            this.lblNova.Location = new System.Drawing.Point(82, 85);
            this.lblNova.Name = "lblNova";
            this.lblNova.Size = new System.Drawing.Size(52, 16);
            this.lblNova.TabIndex = 10;
            this.lblNova.Text = "Nova:";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(14, 11);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(200, 16);
            this.lblTexto.TabIndex = 6;
            this.lblTexto.Text = "Alterar senha do usuário:";
            // 
            // button2
            // 
            this.button2.Image = global::COSMOS.Properties.Resources.confirma;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(192, 174);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Confirmar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::COSMOS.Properties.Resources.desfazer_fw;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Desfazer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAtual
            // 
            this.txtAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAtual.Location = new System.Drawing.Point(140, 44);
            this.txtAtual.Name = "txtAtual";
            this.txtAtual.PasswordChar = '*';
            this.txtAtual.Size = new System.Drawing.Size(211, 23);
            this.txtAtual.TabIndex = 1;
            this.txtAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtual_KeyPress);
            // 
            // lblAtual
            // 
            this.lblAtual.AutoSize = true;
            this.lblAtual.Location = new System.Drawing.Point(80, 47);
            this.lblAtual.Name = "lblAtual";
            this.lblAtual.Size = new System.Drawing.Size(54, 16);
            this.lblAtual.TabIndex = 15;
            this.lblAtual.Text = "Atual:";
            // 
            // frmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 216);
            this.Controls.Add(this.txtAtual);
            this.Controls.Add(this.lblAtual);
            this.Controls.Add(this.txtConfirmaNovaSenha);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblConfirmaNova);
            this.Controls.Add(this.lblNova);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Usuários - Cosmos - New Era Info";
            this.Load += new System.EventHandler(this.frmAlterarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConfirmaNovaSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfirmaNova;
        private System.Windows.Forms.Label lblNova;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAtual;
        private System.Windows.Forms.Label lblAtual;
    }
}