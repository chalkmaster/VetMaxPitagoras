namespace VetMaxPitagoras.Foundation
{
    partial class frmcadastrarfuncionario
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
            this.gridCadastroFuncionario = new System.Windows.Forms.TableLayoutPanel();
            this.grupoCadAnimal = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lbRaça = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbNomeDono = new System.Windows.Forms.Label();
            this.telefoneDono = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gridCadastroFuncionario.SuspendLayout();
            this.grupoCadAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCadastroFuncionario
            // 
            this.gridCadastroFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridCadastroFuncionario.BackColor = System.Drawing.SystemColors.Control;
            this.gridCadastroFuncionario.ColumnCount = 3;
            this.gridCadastroFuncionario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gridCadastroFuncionario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.44898F));
            this.gridCadastroFuncionario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.28572F));
            this.gridCadastroFuncionario.Controls.Add(this.grupoCadAnimal, 1, 0);
            this.gridCadastroFuncionario.Location = new System.Drawing.Point(-90, -38);
            this.gridCadastroFuncionario.Name = "gridCadastroFuncionario";
            this.gridCadastroFuncionario.RowCount = 1;
            this.gridCadastroFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridCadastroFuncionario.Size = new System.Drawing.Size(980, 647);
            this.gridCadastroFuncionario.TabIndex = 13;
            // 
            // grupoCadAnimal
            // 
            this.grupoCadAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grupoCadAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.grupoCadAnimal.Controls.Add(this.txtEmail);
            this.grupoCadAnimal.Controls.Add(this.label2);
            this.grupoCadAnimal.Controls.Add(this.label1);
            this.grupoCadAnimal.Controls.Add(this.mtbCelular);
            this.grupoCadAnimal.Controls.Add(this.mtbTelefone);
            this.grupoCadAnimal.Controls.Add(this.rdbFeminino);
            this.grupoCadAnimal.Controls.Add(this.rdbMasculino);
            this.grupoCadAnimal.Controls.Add(this.dtpDataNascimento);
            this.grupoCadAnimal.Controls.Add(this.txtNome);
            this.grupoCadAnimal.Controls.Add(this.telefoneDono);
            this.grupoCadAnimal.Controls.Add(this.lbNomeDono);
            this.grupoCadAnimal.Controls.Add(this.btnCadastrar);
            this.grupoCadAnimal.Controls.Add(this.lbTipo);
            this.grupoCadAnimal.Controls.Add(this.lbNome);
            this.grupoCadAnimal.Controls.Add(this.lbRaça);
            this.grupoCadAnimal.Controls.Add(this.txtCpf);
            this.grupoCadAnimal.Location = new System.Drawing.Point(331, 153);
            this.grupoCadAnimal.Name = "grupoCadAnimal";
            this.grupoCadAnimal.Size = new System.Drawing.Size(356, 341);
            this.grupoCadAnimal.TabIndex = 11;
            this.grupoCadAnimal.TabStop = false;
            this.grupoCadAnimal.Text = "Cadastro de Funcionários Administrativos da Clínica";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(263, 298);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(129, 77);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(209, 20);
            this.txtCpf.TabIndex = 6;
            // 
            // lbRaça
            // 
            this.lbRaça.AutoSize = true;
            this.lbRaça.Location = new System.Drawing.Point(18, 84);
            this.lbRaça.Name = "lbRaça";
            this.lbRaça.Size = new System.Drawing.Size(30, 13);
            this.lbRaça.TabIndex = 1;
            this.lbRaça.Text = "CPF:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(16, 44);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(16, 223);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(52, 13);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "Telefone:";
            this.lbTipo.Click += new System.EventHandler(this.lbTipo_Click);
            // 
            // lbNomeDono
            // 
            this.lbNomeDono.AutoSize = true;
            this.lbNomeDono.Location = new System.Drawing.Point(16, 121);
            this.lbNomeDono.Name = "lbNomeDono";
            this.lbNomeDono.Size = new System.Drawing.Size(107, 13);
            this.lbNomeDono.TabIndex = 4;
            this.lbNomeDono.Text = "Data de Nascimento:";
            // 
            // telefoneDono
            // 
            this.telefoneDono.AutoSize = true;
            this.telefoneDono.Location = new System.Drawing.Point(16, 157);
            this.telefoneDono.Name = "telefoneDono";
            this.telefoneDono.Size = new System.Drawing.Size(34, 13);
            this.telefoneDono.TabIndex = 12;
            this.telefoneDono.Text = "Sexo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(129, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(209, 20);
            this.txtNome.TabIndex = 5;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(129, 121);
            this.dtpDataNascimento.MaxDate = new System.DateTime(9000, 12, 31, 0, 0, 0, 0);
            this.dtpDataNascimento.MinDate = new System.DateTime(1850, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(209, 20);
            this.dtpDataNascimento.TabIndex = 13;
            this.dtpDataNascimento.Value = new System.DateTime(2017, 10, 17, 0, 0, 0, 0);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(129, 153);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 14;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(253, 153);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 15;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(129, 223);
            this.mtbTelefone.Mask = "(99)9999-9999";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(209, 20);
            this.mtbTelefone.TabIndex = 16;
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(129, 261);
            this.mtbCelular.Mask = "(99)99999-9999";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(209, 20);
            this.mtbCelular.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Celular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 186);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // frmcadastrarfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 571);
            this.Controls.Add(this.gridCadastroFuncionario);
            this.Name = "frmcadastrarfuncionario";
            this.Text = "Cadastrar Funcionários Administrativos da Clínica";
            this.gridCadastroFuncionario.ResumeLayout(false);
            this.grupoCadAnimal.ResumeLayout(false);
            this.grupoCadAnimal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gridCadastroFuncionario;
        private System.Windows.Forms.GroupBox grupoCadAnimal;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label telefoneDono;
        private System.Windows.Forms.Label lbNomeDono;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbRaça;
        private System.Windows.Forms.TextBox txtCpf;
    }
}