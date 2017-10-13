namespace VetMaxPitagoras.Foundation
{
    partial class userForm
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.tabelaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.lbConfirmarSenha = new System.Windows.Forms.Label();
            this.tabelaLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCadastrar.Location = new System.Drawing.Point(579, 322);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(80, 3, 3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.UseWaitCursor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNome.Location = new System.Drawing.Point(502, 236);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(151, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeUsuario.Location = new System.Drawing.Point(386, 236);
            this.lbNomeUsuario.Margin = new System.Windows.Forms.Padding(3);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(110, 20);
            this.lbNomeUsuario.TabIndex = 2;
            this.lbNomeUsuario.Text = "Nome de Usuário :";
            // 
            // lbSenha
            // 
            this.lbSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(386, 265);
            this.lbSenha.Margin = new System.Windows.Forms.Padding(3);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(110, 20);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha :";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSenha.Location = new System.Drawing.Point(502, 265);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(151, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // tabelaLayout
            // 
            this.tabelaLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabelaLayout.ColumnCount = 2;
            this.tabelaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabelaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabelaLayout.Controls.Add(this.txtNome, 1, 1);
            this.tabelaLayout.Controls.Add(this.txtSenha, 1, 2);
            this.tabelaLayout.Controls.Add(this.lbSenha, 0, 2);
            this.tabelaLayout.Controls.Add(this.lbNomeUsuario, 0, 1);
            this.tabelaLayout.Controls.Add(this.btnCadastrar, 1, 4);
            this.tabelaLayout.Controls.Add(this.txtConfSenha, 1, 3);
            this.tabelaLayout.Controls.Add(this.lbConfirmarSenha, 0, 3);
            this.tabelaLayout.Location = new System.Drawing.Point(0, 0);
            this.tabelaLayout.Margin = new System.Windows.Forms.Padding(0);
            this.tabelaLayout.Name = "tabelaLayout";
            this.tabelaLayout.RowCount = 6;
            this.tabelaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tabelaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tabelaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tabelaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tabelaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tabelaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tabelaLayout.Size = new System.Drawing.Size(999, 580);
            this.tabelaLayout.TabIndex = 6;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(502, 293);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(151, 20);
            this.txtConfSenha.TabIndex = 6;
            this.txtConfSenha.UseSystemPasswordChar = true;
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbConfirmarSenha.Location = new System.Drawing.Point(389, 298);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(107, 13);
            this.lbConfirmarSenha.TabIndex = 7;
            this.lbConfirmarSenha.Text = "Confirmar Senha :";
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 580);
            this.Controls.Add(this.tabelaLayout);
            this.Name = "userForm";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.userForm_Load);
            this.tabelaLayout.ResumeLayout(false);
            this.tabelaLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Label lbConfirmarSenha;
        private System.Windows.Forms.TableLayoutPanel tabelaLayout;
    }
}