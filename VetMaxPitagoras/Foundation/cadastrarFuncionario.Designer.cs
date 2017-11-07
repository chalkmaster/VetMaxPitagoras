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
            this.grpCadFuncionario = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNomeDono = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbRaça = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEspecialidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitulacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataCadFuncionario = new System.Windows.Forms.DataGridView();
            this.gridCadastroFuncionario.SuspendLayout();
            this.grpCadFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCadFuncionario)).BeginInit();
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
            this.gridCadastroFuncionario.Controls.Add(this.grpCadFuncionario, 1, 0);
            this.gridCadastroFuncionario.Location = new System.Drawing.Point(-90, -38);
            this.gridCadastroFuncionario.Name = "gridCadastroFuncionario";
            this.gridCadastroFuncionario.RowCount = 1;
            this.gridCadastroFuncionario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridCadastroFuncionario.Size = new System.Drawing.Size(980, 647);
            this.gridCadastroFuncionario.TabIndex = 13;
            // 
            // grpCadFuncionario
            // 
            this.grpCadFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpCadFuncionario.BackColor = System.Drawing.SystemColors.Control;
            this.grpCadFuncionario.Controls.Add(this.dataCadFuncionario);
            this.grpCadFuncionario.Controls.Add(this.txtTitulacao);
            this.grpCadFuncionario.Controls.Add(this.label5);
            this.grpCadFuncionario.Controls.Add(this.txtEspecialidade);
            this.grpCadFuncionario.Controls.Add(this.label4);
            this.grpCadFuncionario.Controls.Add(this.txtEndereco);
            this.grpCadFuncionario.Controls.Add(this.label3);
            this.grpCadFuncionario.Controls.Add(this.txtDepartamento);
            this.grpCadFuncionario.Controls.Add(this.label1);
            this.grpCadFuncionario.Controls.Add(this.txtEmail);
            this.grpCadFuncionario.Controls.Add(this.label2);
            this.grpCadFuncionario.Controls.Add(this.mtbTelefone);
            this.grpCadFuncionario.Controls.Add(this.dtpDataNascimento);
            this.grpCadFuncionario.Controls.Add(this.txtNome);
            this.grpCadFuncionario.Controls.Add(this.lbNomeDono);
            this.grpCadFuncionario.Controls.Add(this.btnCadastrar);
            this.grpCadFuncionario.Controls.Add(this.lbTipo);
            this.grpCadFuncionario.Controls.Add(this.lbNome);
            this.grpCadFuncionario.Controls.Add(this.lbRaça);
            this.grpCadFuncionario.Controls.Add(this.txtCargo);
            this.grpCadFuncionario.Location = new System.Drawing.Point(331, 50);
            this.grpCadFuncionario.Name = "grpCadFuncionario";
            this.grpCadFuncionario.Size = new System.Drawing.Size(356, 547);
            this.grpCadFuncionario.TabIndex = 11;
            this.grpCadFuncionario.TabStop = false;
            this.grpCadFuncionario.Text = "Cadastro de Funcionários Administrativos da Clínica";
            this.grpCadFuncionario.Enter += new System.EventHandler(this.grpCadFuncionario_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(127, 113);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 20);
            this.txtEmail.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email:";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(127, 139);
            this.mtbTelefone.Mask = "(99)9999-9999";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(209, 20);
            this.mtbTelefone.TabIndex = 16;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(129, 88);
            this.dtpDataNascimento.MaxDate = new System.DateTime(9000, 12, 31, 0, 0, 0, 0);
            this.dtpDataNascimento.MinDate = new System.DateTime(1850, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(209, 20);
            this.dtpDataNascimento.TabIndex = 13;
            this.dtpDataNascimento.Value = new System.DateTime(2017, 10, 17, 0, 0, 0, 0);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(129, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(209, 20);
            this.txtNome.TabIndex = 5;
            // 
            // lbNomeDono
            // 
            this.lbNomeDono.AutoSize = true;
            this.lbNomeDono.Location = new System.Drawing.Point(16, 88);
            this.lbNomeDono.Name = "lbNomeDono";
            this.lbNomeDono.Size = new System.Drawing.Size(107, 13);
            this.lbNomeDono.TabIndex = 4;
            this.lbNomeDono.Text = "Data de Nascimento:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(265, 273);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(14, 139);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(52, 13);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "Telefone:";
//            this.lbTipo.Click += new System.EventHandler(this.lbTipo_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(16, 38);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // lbRaça
            // 
            this.lbRaça.AutoSize = true;
            this.lbRaça.Location = new System.Drawing.Point(18, 66);
            this.lbRaça.Name = "lbRaça";
            this.lbRaça.Size = new System.Drawing.Size(38, 13);
            this.lbRaça.TabIndex = 1;
            this.lbRaça.Text = "Cargo:";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(129, 59);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(209, 20);
            this.txtCargo.TabIndex = 6;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(130, 168);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(209, 20);
            this.txtDepartamento.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Departamento:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(130, 194);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(209, 20);
            this.txtEndereco.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Endereço:";
            // 
            // txtEspecialidade
            // 
            this.txtEspecialidade.Location = new System.Drawing.Point(130, 220);
            this.txtEspecialidade.Name = "txtEspecialidade";
            this.txtEspecialidade.Size = new System.Drawing.Size(209, 20);
            this.txtEspecialidade.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Especialidade:";
            // 
            // txtTitulacao
            // 
            this.txtTitulacao.Location = new System.Drawing.Point(131, 247);
            this.txtTitulacao.Name = "txtTitulacao";
            this.txtTitulacao.Size = new System.Drawing.Size(209, 20);
            this.txtTitulacao.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Titulação:";
            // 
            // dataCadFuncionario
            // 
            this.dataCadFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCadFuncionario.Location = new System.Drawing.Point(19, 307);
            this.dataCadFuncionario.Name = "dataCadFuncionario";
            this.dataCadFuncionario.Size = new System.Drawing.Size(320, 150);
            this.dataCadFuncionario.TabIndex = 29;
            // 
            // frmcadastrarfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 571);
            this.Controls.Add(this.gridCadastroFuncionario);
            this.Name = "frmcadastrarfuncionario";
            this.Text = "Cadastrar Funcionários Administrativos da Clínica";
            this.Load += new System.EventHandler(this.frmcadastrarfuncionario_Load);
            this.gridCadastroFuncionario.ResumeLayout(false);
            this.grpCadFuncionario.ResumeLayout(false);
            this.grpCadFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCadFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gridCadastroFuncionario;
        private System.Windows.Forms.GroupBox grpCadFuncionario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNomeDono;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbRaça;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtTitulacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEspecialidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataCadFuncionario;
    }
}