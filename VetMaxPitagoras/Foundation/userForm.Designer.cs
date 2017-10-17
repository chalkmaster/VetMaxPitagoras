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
            this.cadastroUsuario = new System.Windows.Forms.GroupBox();
            this.lbConfirmarSenha = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cadastroUsuario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroUsuario
            // 
            this.cadastroUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cadastroUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.cadastroUsuario.Controls.Add(this.lbConfirmarSenha);
            this.cadastroUsuario.Controls.Add(this.lbSenha);
            this.cadastroUsuario.Controls.Add(this.txtSenha);
            this.cadastroUsuario.Controls.Add(this.lbNomeUsuario);
            this.cadastroUsuario.Controls.Add(this.txtNome);
            this.cadastroUsuario.Controls.Add(this.btnCadastrar);
            this.cadastroUsuario.Controls.Add(this.txtConfSenha);
            this.cadastroUsuario.Location = new System.Drawing.Point(335, 151);
            this.cadastroUsuario.Name = "cadastroUsuario";
            this.cadastroUsuario.Size = new System.Drawing.Size(326, 278);
            this.cadastroUsuario.TabIndex = 9;
            this.cadastroUsuario.TabStop = false;
            this.cadastroUsuario.Text = "Cadastro de Usuário";
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbConfirmarSenha.Location = new System.Drawing.Point(6, 121);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(107, 13);
            this.lbConfirmarSenha.TabIndex = 7;
            this.lbConfirmarSenha.Text = "Confirmar Senha :";
            // 
            // lbSenha
            // 
            this.lbSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(6, 74);
            this.lbSenha.Margin = new System.Windows.Forms.Padding(3);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(110, 20);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha :";
            this.lbSenha.Click += new System.EventHandler(this.lbSenha_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSenha.Location = new System.Drawing.Point(145, 118);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(151, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeUsuario.Location = new System.Drawing.Point(6, 30);
            this.lbNomeUsuario.Margin = new System.Windows.Forms.Padding(3);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(110, 20);
            this.lbNomeUsuario.TabIndex = 2;
            this.lbNomeUsuario.Text = "Nome de Usuário :";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNome.Location = new System.Drawing.Point(145, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(151, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCadastrar.Location = new System.Drawing.Point(221, 161);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(80, 3, 3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.UseWaitCursor = true;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(145, 73);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.Size = new System.Drawing.Size(151, 20);
            this.txtConfSenha.TabIndex = 6;
            this.txtConfSenha.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.cadastroUsuario, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 580);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 580);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "userForm";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.userForm_Load);
            this.cadastroUsuario.ResumeLayout(false);
            this.cadastroUsuario.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cadastroUsuario;
        private System.Windows.Forms.Label lbConfirmarSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}