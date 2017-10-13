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
<<<<<<< HEAD
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbConfirmarSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtConSenha = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCadastrar.Location = new System.Drawing.Point(579, 363);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(80, 3, 3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar ";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.UseWaitCursor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNome.Location = new System.Drawing.Point(499, 197);
            this.txtNome.Margin = new System.Windows.Forms.Padding(0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbNomeUsuario.Location = new System.Drawing.Point(402, 199);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(94, 16);
            this.lbNomeUsuario.TabIndex = 2;
            this.lbNomeUsuario.Text = "Nome de Usuário :";
            // 
            // lbSenha
            // 
            this.lbSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbSenha.Location = new System.Drawing.Point(402, 257);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(94, 20);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha ";
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbConfirmarSenha.AutoSize = true;
            this.lbConfirmarSenha.Location = new System.Drawing.Point(399, 314);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(97, 13);
            this.lbConfirmarSenha.TabIndex = 4;
            this.lbConfirmarSenha.Text = "Confirmar a Senha ";
            this.lbConfirmarSenha.Click += new System.EventHandler(this.lbConfirmarSenha_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSenha.Location = new System.Drawing.Point(499, 257);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(0);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(155, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtNome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSenha, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbSenha, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbConfirmarSenha, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbNomeUsuario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastrar, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtConSenha, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0894F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.43252F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.462888F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.462892F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.462888F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0894F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(999, 580);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtConSenha
            // 
            this.txtConSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConSenha.Location = new System.Drawing.Point(499, 311);
            this.txtConSenha.Margin = new System.Windows.Forms.Padding(0);
            this.txtConSenha.Name = "txtConSenha";
            this.txtConSenha.Size = new System.Drawing.Size(154, 20);
            this.txtConSenha.TabIndex = 7;
=======
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
>>>>>>> 62eb702127e498d2d8fb6c38a44be5ec44c24d9e
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(996, 580);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "userForm";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.userForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
=======
            this.ClientSize = new System.Drawing.Size(549, 279);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "userForm";
            this.Text = "newUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> 62eb702127e498d2d8fb6c38a44be5ec44c24d9e

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbConfirmarSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtConSenha;
=======
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
>>>>>>> 62eb702127e498d2d8fb6c38a44be5ec44c24d9e
    }
}