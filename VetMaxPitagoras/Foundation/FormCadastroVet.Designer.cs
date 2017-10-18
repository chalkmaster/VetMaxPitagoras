namespace frmCadastroVeterinario
{
    partial class FrmCadastroVeterinario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbIdentificação = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCRMV = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbCEP = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.cbEspecialidades = new System.Windows.Forms.ComboBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbLogradouro = new System.Windows.Forms.TextBox();
            this.tbNumEndereco = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbEnderecoUF = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbCel = new System.Windows.Forms.MaskedTextBox();
            this.mtbCasa = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbOrgaoEmissor = new System.Windows.Forms.TextBox();
            this.tbRG = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.gbIdentificação.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIdentificação
            // 
            this.gbIdentificação.Controls.Add(this.maskedTextBox1);
            this.gbIdentificação.Controls.Add(this.tbRG);
            this.gbIdentificação.Controls.Add(this.tbOrgaoEmissor);
            this.gbIdentificação.Controls.Add(this.label17);
            this.gbIdentificação.Controls.Add(this.label16);
            this.gbIdentificação.Controls.Add(this.label15);
            this.gbIdentificação.Controls.Add(this.cbEspecialidades);
            this.gbIdentificação.Controls.Add(this.tbEmail);
            this.gbIdentificação.Controls.Add(this.cbUF);
            this.gbIdentificação.Controls.Add(this.tbMatricula);
            this.gbIdentificação.Controls.Add(this.label6);
            this.gbIdentificação.Controls.Add(this.label2);
            this.gbIdentificação.Controls.Add(this.tbNome);
            this.gbIdentificação.Controls.Add(this.label5);
            this.gbIdentificação.Controls.Add(this.label1);
            this.gbIdentificação.Controls.Add(this.label3);
            this.gbIdentificação.Controls.Add(this.label4);
            this.gbIdentificação.Controls.Add(this.tbCRMV);
            this.gbIdentificação.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIdentificação.Location = new System.Drawing.Point(34, 23);
            this.gbIdentificação.Name = "gbIdentificação";
            this.gbIdentificação.Size = new System.Drawing.Size(732, 172);
            this.gbIdentificação.TabIndex = 0;
            this.gbIdentificação.TabStop = false;
            this.gbIdentificação.Text = "Identificação";
            this.gbIdentificação.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEnderecoUF);
            this.groupBox2.Controls.Add(this.tbCEP);
            this.groupBox2.Controls.Add(this.tbCidade);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbBairro);
            this.groupBox2.Controls.Add(this.tbNumEndereco);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbLogradouro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CRMV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "UF:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Matrícula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Especialidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Logradouro:";
            // 
            // tbCRMV
            // 
            this.tbCRMV.Location = new System.Drawing.Point(75, 68);
            this.tbCRMV.Name = "tbCRMV";
            this.tbCRMV.Size = new System.Drawing.Size(112, 23);
            this.tbCRMV.TabIndex = 9;
            this.tbCRMV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(75, 129);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(379, 23);
            this.tbEmail.TabIndex = 10;
            // 
            // tbCEP
            // 
            this.tbCEP.Location = new System.Drawing.Point(298, 77);
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(116, 22);
            this.tbCEP.TabIndex = 11;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(75, 37);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(380, 23);
            this.tbNome.TabIndex = 12;
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(540, 38);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(100, 23);
            this.tbMatricula.TabIndex = 13;
            // 
            // cbUF
            // 
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Location = new System.Drawing.Point(230, 66);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(29, 24);
            this.cbUF.TabIndex = 14;
            // 
            // cbEspecialidades
            // 
            this.cbEspecialidades.FormattingEnabled = true;
            this.cbEspecialidades.Location = new System.Drawing.Point(373, 67);
            this.cbEspecialidades.Name = "cbEspecialidades";
            this.cbEspecialidades.Size = new System.Drawing.Size(152, 24);
            this.cbEspecialidades.TabIndex = 15;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(94, 49);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(164, 22);
            this.tbBairro.TabIndex = 9;
            this.tbBairro.TextChanged += new System.EventHandler(this.tbBairro_TextChanged);
            // 
            // tbLogradouro
            // 
            this.tbLogradouro.Location = new System.Drawing.Point(94, 21);
            this.tbLogradouro.Name = "tbLogradouro";
            this.tbLogradouro.Size = new System.Drawing.Size(305, 22);
            this.tbLogradouro.TabIndex = 12;
            // 
            // tbNumEndereco
            // 
            this.tbNumEndereco.Location = new System.Drawing.Point(450, 21);
            this.tbNumEndereco.Name = "tbNumEndereco";
            this.tbNumEndereco.Size = new System.Drawing.Size(52, 22);
            this.tbNumEndereco.TabIndex = 13;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(94, 77);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(100, 22);
            this.tbCidade.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bairro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "UF:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "CEP:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(418, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Nº:";
            // 
            // cbEnderecoUF
            // 
            this.cbEnderecoUF.FormattingEnabled = true;
            this.cbEnderecoUF.Location = new System.Drawing.Point(229, 77);
            this.cbEnderecoUF.Name = "cbEnderecoUF";
            this.cbEnderecoUF.Size = new System.Drawing.Size(29, 24);
            this.cbEnderecoUF.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.mtbCasa);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.mtbCel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(584, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telefone";
            // 
            // mtbCel
            // 
            this.mtbCel.Location = new System.Drawing.Point(55, 40);
            this.mtbCel.Mask = "(99)99999-9999";
            this.mtbCel.Name = "mtbCel";
            this.mtbCel.Size = new System.Drawing.Size(100, 22);
            this.mtbCel.TabIndex = 0;
            // 
            // mtbCasa
            // 
            this.mtbCasa.Location = new System.Drawing.Point(55, 68);
            this.mtbCasa.Mask = "(99)9999-9999";
            this.mtbCasa.Name = "mtbCasa";
            this.mtbCasa.Size = new System.Drawing.Size(100, 22);
            this.mtbCasa.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Cel:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Casa:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(617, 367);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(698, 367);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(536, 367);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(455, 367);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "RG:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(370, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "CPF:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(193, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "Òrgão Emissor:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // tbOrgaoEmissor
            // 
            this.tbOrgaoEmissor.Location = new System.Drawing.Point(306, 100);
            this.tbOrgaoEmissor.Name = "tbOrgaoEmissor";
            this.tbOrgaoEmissor.Size = new System.Drawing.Size(58, 23);
            this.tbOrgaoEmissor.TabIndex = 19;
            // 
            // tbRG
            // 
            this.tbRG.Location = new System.Drawing.Point(75, 100);
            this.tbRG.Name = "tbRG";
            this.tbRG.Size = new System.Drawing.Size(112, 23);
            this.tbRG.TabIndex = 20;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(414, 100);
            this.maskedTextBox1.Mask = "999.999.999-99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(111, 23);
            this.maskedTextBox1.TabIndex = 21;
            // 
            // frmCadastroVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(789, 400);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbIdentificação);
            this.Name = "frmCadastroVeterinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veterináros";
            this.Load += new System.EventHandler(this.cadastroVeterinario_Load);
            this.gbIdentificação.ResumeLayout(false);
            this.gbIdentificação.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIdentificação;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCRMV;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbCEP;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbMatricula;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.ComboBox cbEspecialidades;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbNumEndereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLogradouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEnderecoUF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbCasa;
        private System.Windows.Forms.MaskedTextBox mtbCel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbRG;
        private System.Windows.Forms.TextBox tbOrgaoEmissor;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

