namespace VetMaxPitagoras
{
    partial class frmCartaoVacina
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataN = new System.Windows.Forms.Label();
            this.lblProprietario = new System.Windows.Forms.Label();
            this.lblCoreMarcas = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtCorMarca = new System.Windows.Forms.TextBox();
            this.txtDatadeNascimento = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.lblResidencia = new System.Windows.Forms.Label();
            this.txtProprietario = new System.Windows.Forms.TextBox();
            this.txtResidencia = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.gbDadosA = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.gbDadosP = new System.Windows.Forms.GroupBox();
            this.gbControleVa = new System.Windows.Forms.GroupBox();
            this.dtgControleVacina = new System.Windows.Forms.DataGridView();
            this.clData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVacina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRevacinação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtVacina = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtRevacinacao = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRevacinacao = new System.Windows.Forms.Label();
            this.gbDadosA.SuspendLayout();
            this.gbDadosP.SuspendLayout();
            this.gbControleVa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgControleVacina)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(114, 38);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(115, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(93, 70);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome:";
            // 
            // lblDataN
            // 
            this.lblDataN.AutoSize = true;
            this.lblDataN.Location = new System.Drawing.Point(27, 170);
            this.lblDataN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataN.Name = "lblDataN";
            this.lblDataN.Size = new System.Drawing.Size(104, 13);
            this.lblDataN.TabIndex = 8;
            this.lblDataN.Text = "Data de Nascimento";
            // 
            // lblProprietario
            // 
            this.lblProprietario.AutoSize = true;
            this.lblProprietario.Location = new System.Drawing.Point(273, 49);
            this.lblProprietario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProprietario.Name = "lblProprietario";
            this.lblProprietario.Size = new System.Drawing.Size(60, 13);
            this.lblProprietario.TabIndex = 9;
            this.lblProprietario.Text = "Proprietario";
            this.lblProprietario.Click += new System.EventHandler(this.lblProprietario_Click);
            // 
            // lblCoreMarcas
            // 
            this.lblCoreMarcas.AutoSize = true;
            this.lblCoreMarcas.Location = new System.Drawing.Point(58, 111);
            this.lblCoreMarcas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoreMarcas.Name = "lblCoreMarcas";
            this.lblCoreMarcas.Size = new System.Drawing.Size(73, 13);
            this.lblCoreMarcas.TabIndex = 10;
            this.lblCoreMarcas.Text = "Cor e Marcas:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(93, 149);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 11;
            this.lblSexo.Text = "Sexo";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(98, 90);
            this.lblRaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(33, 13);
            this.lblRaca.TabIndex = 12;
            this.lblRaca.Text = "Raça";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(64, 105);
            this.lblEspecie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(48, 13);
            this.lblEspecie.TabIndex = 13;
            this.lblEspecie.Text = "Especie:";
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(133, 86);
            this.txtRaca.Margin = new System.Windows.Forms.Padding(2);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(115, 20);
            this.txtRaca.TabIndex = 14;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(133, 149);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(115, 20);
            this.txtSexo.TabIndex = 15;
            // 
            // txtCorMarca
            // 
            this.txtCorMarca.Location = new System.Drawing.Point(133, 107);
            this.txtCorMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorMarca.Name = "txtCorMarca";
            this.txtCorMarca.Size = new System.Drawing.Size(115, 20);
            this.txtCorMarca.TabIndex = 16;
            // 
            // txtDatadeNascimento
            // 
            this.txtDatadeNascimento.Location = new System.Drawing.Point(133, 170);
            this.txtDatadeNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatadeNascimento.Name = "txtDatadeNascimento";
            this.txtDatadeNascimento.Size = new System.Drawing.Size(115, 20);
            this.txtDatadeNascimento.TabIndex = 17;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(133, 128);
            this.txtEspecie.Margin = new System.Windows.Forms.Padding(2);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(115, 20);
            this.txtEspecie.TabIndex = 18;
            // 
            // lblResidencia
            // 
            this.lblResidencia.AutoSize = true;
            this.lblResidencia.Location = new System.Drawing.Point(273, 70);
            this.lblResidencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResidencia.Name = "lblResidencia";
            this.lblResidencia.Size = new System.Drawing.Size(63, 13);
            this.lblResidencia.TabIndex = 20;
            this.lblResidencia.Text = "Residencia:";
            // 
            // txtProprietario
            // 
            this.txtProprietario.Location = new System.Drawing.Point(337, 47);
            this.txtProprietario.Margin = new System.Windows.Forms.Padding(2);
            this.txtProprietario.Name = "txtProprietario";
            this.txtProprietario.Size = new System.Drawing.Size(150, 20);
            this.txtProprietario.TabIndex = 21;
            // 
            // txtResidencia
            // 
            this.txtResidencia.Location = new System.Drawing.Point(337, 70);
            this.txtResidencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtResidencia.Name = "txtResidencia";
            this.txtResidencia.Size = new System.Drawing.Size(150, 20);
            this.txtResidencia.TabIndex = 22;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(12, 68);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 23;
            this.lblEndereco.Text = "Endereco:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(76, 68);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(2);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(150, 20);
            this.txtEndereco.TabIndex = 24;
            // 
            // gbDadosA
            // 
            this.gbDadosA.Controls.Add(this.txtCodigo);
            this.gbDadosA.Controls.Add(this.lblCod);
            this.gbDadosA.Controls.Add(this.txtNome);
            this.gbDadosA.Controls.Add(this.lblEspecie);
            this.gbDadosA.Location = new System.Drawing.Point(19, 26);
            this.gbDadosA.Margin = new System.Windows.Forms.Padding(2);
            this.gbDadosA.Name = "gbDadosA";
            this.gbDadosA.Padding = new System.Windows.Forms.Padding(2);
            this.gbDadosA.Size = new System.Drawing.Size(239, 172);
            this.gbDadosA.TabIndex = 25;
            this.gbDadosA.TabStop = false;
            this.gbDadosA.Text = "Dados do Animal";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(114, 17);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(53, 20);
            this.txtCodigo.TabIndex = 29;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(74, 21);
            this.lblCod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Codigo";
            // 
            // gbDadosP
            // 
            this.gbDadosP.Controls.Add(this.txtEndereco);
            this.gbDadosP.Controls.Add(this.lblEndereco);
            this.gbDadosP.Location = new System.Drawing.Point(261, 26);
            this.gbDadosP.Margin = new System.Windows.Forms.Padding(2);
            this.gbDadosP.Name = "gbDadosP";
            this.gbDadosP.Padding = new System.Windows.Forms.Padding(2);
            this.gbDadosP.Size = new System.Drawing.Size(239, 172);
            this.gbDadosP.TabIndex = 26;
            this.gbDadosP.TabStop = false;
            this.gbDadosP.Text = "Dados do Proprietario";
            // 
            // gbControleVa
            // 
            this.gbControleVa.Controls.Add(this.dtgControleVacina);
            this.gbControleVa.Location = new System.Drawing.Point(19, 279);
            this.gbControleVa.Margin = new System.Windows.Forms.Padding(2);
            this.gbControleVa.Name = "gbControleVa";
            this.gbControleVa.Padding = new System.Windows.Forms.Padding(2);
            this.gbControleVa.Size = new System.Drawing.Size(481, 167);
            this.gbControleVa.TabIndex = 27;
            this.gbControleVa.TabStop = false;
            this.gbControleVa.Text = "Controle de Vacinas";
            // 
            // dtgControleVacina
            // 
            this.dtgControleVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgControleVacina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clData,
            this.clVacina,
            this.clRevacinação});
            this.dtgControleVacina.Location = new System.Drawing.Point(4, 17);
            this.dtgControleVacina.Margin = new System.Windows.Forms.Padding(2);
            this.dtgControleVacina.Name = "dtgControleVacina";
            this.dtgControleVacina.RowTemplate.Height = 28;
            this.dtgControleVacina.Size = new System.Drawing.Size(473, 146);
            this.dtgControleVacina.TabIndex = 0;
            this.dtgControleVacina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgControleVacina_CellContentClick);
            // 
            // clData
            // 
            this.clData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clData.HeaderText = "Data";
            this.clData.Name = "clData";
            // 
            // clVacina
            // 
            this.clVacina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clVacina.HeaderText = "Vacina";
            this.clVacina.Name = "clVacina";
            // 
            // clRevacinação
            // 
            this.clRevacinação.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clRevacinação.HeaderText = "Revacinação";
            this.clRevacinação.Name = "clRevacinação";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 460);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 27);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(341, 460);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 27);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(180, 460);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 27);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(261, 460);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(77, 27);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(99, 460);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 27);
            this.btnEditar.TabIndex = 32;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtVacina
            // 
            this.txtVacina.Location = new System.Drawing.Point(204, 224);
            this.txtVacina.Name = "txtVacina";
            this.txtVacina.Size = new System.Drawing.Size(100, 20);
            this.txtVacina.TabIndex = 33;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(52, 224);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 34;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // txtRevacinacao
            // 
            this.txtRevacinacao.Location = new System.Drawing.Point(393, 225);
            this.txtRevacinacao.Name = "txtRevacinacao";
            this.txtRevacinacao.Size = new System.Drawing.Size(100, 20);
            this.txtRevacinacao.TabIndex = 35;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(16, 225);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 36;
            this.lblData.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Vacina";
            // 
            // lblRevacinacao
            // 
            this.lblRevacinacao.AutoSize = true;
            this.lblRevacinacao.Location = new System.Drawing.Point(316, 227);
            this.lblRevacinacao.Name = "lblRevacinacao";
            this.lblRevacinacao.Size = new System.Drawing.Size(71, 13);
            this.lblRevacinacao.TabIndex = 38;
            this.lblRevacinacao.Text = "Revacinação";
            // 
            // frmCartaoVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 499);
            this.Controls.Add(this.lblRevacinacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtRevacinacao);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtVacina);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbControleVa);
            this.Controls.Add(this.txtResidencia);
            this.Controls.Add(this.txtProprietario);
            this.Controls.Add(this.lblResidencia);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtDatadeNascimento);
            this.Controls.Add(this.txtCorMarca);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblCoreMarcas);
            this.Controls.Add(this.lblProprietario);
            this.Controls.Add(this.lblDataN);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.gbDadosP);
            this.Controls.Add(this.gbDadosA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCartaoVacina";
            this.Text = "Cartao de Vacina";
            this.Load += new System.EventHandler(this.frmCartaoVacina_Load);
            this.gbDadosA.ResumeLayout(false);
            this.gbDadosA.PerformLayout();
            this.gbDadosP.ResumeLayout(false);
            this.gbDadosP.PerformLayout();
            this.gbControleVa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgControleVacina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataN;
        private System.Windows.Forms.Label lblProprietario;
        private System.Windows.Forms.Label lblCoreMarcas;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtCorMarca;
        private System.Windows.Forms.TextBox txtDatadeNascimento;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label lblResidencia;
        private System.Windows.Forms.TextBox txtProprietario;
        private System.Windows.Forms.TextBox txtResidencia;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.GroupBox gbDadosA;
        private System.Windows.Forms.GroupBox gbDadosP;
        private System.Windows.Forms.GroupBox gbControleVa;
        private System.Windows.Forms.DataGridView dtgControleVacina;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVacina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRevacinação;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtVacina;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtRevacinacao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRevacinacao;
    }
}