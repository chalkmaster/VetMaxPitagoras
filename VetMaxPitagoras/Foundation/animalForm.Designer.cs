﻿namespace VetMaxPitagoras.Foundation
{
    partial class animalForm
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
            this.components = new System.ComponentModel.Container();
            this.lbNomeDoAnimal = new System.Windows.Forms.Label();
            this.lbRaça = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbNomeDono = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNomeDoDono = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grupoCadAnimal = new System.Windows.Forms.GroupBox();
            this.telefoneDono = new System.Windows.Forms.Label();
            this.dataCadAnimal = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validacaoAnimalCampos = new System.Windows.Forms.ErrorProvider(this.components);
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.grupoCadAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCadAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validacaoAnimalCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNomeDoAnimal
            // 
            this.lbNomeDoAnimal.AutoSize = true;
            this.lbNomeDoAnimal.Location = new System.Drawing.Point(16, 44);
            this.lbNomeDoAnimal.Name = "lbNomeDoAnimal";
            this.lbNomeDoAnimal.Size = new System.Drawing.Size(87, 13);
            this.lbNomeDoAnimal.TabIndex = 0;
            this.lbNomeDoAnimal.Text = "Nome do Animal:";
            // 
            // lbRaça
            // 
            this.lbRaça.AutoSize = true;
            this.lbRaça.Location = new System.Drawing.Point(322, 44);
            this.lbRaça.Name = "lbRaça";
            this.lbRaça.Size = new System.Drawing.Size(36, 13);
            this.lbRaça.TabIndex = 1;
            this.lbRaça.Text = "Raça:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(327, 79);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(31, 13);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "Tipo:";
            // 
            // lbNomeDono
            // 
            this.lbNomeDono.AutoSize = true;
            this.lbNomeDono.Location = new System.Drawing.Point(13, 79);
            this.lbNomeDono.Name = "lbNomeDono";
            this.lbNomeDono.Size = new System.Drawing.Size(82, 13);
            this.lbNomeDono.TabIndex = 4;
            this.lbNomeDono.Text = "Nome do Dono:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(127, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(97, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(374, 37);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(97, 20);
            this.txtRaca.TabIndex = 6;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(374, 76);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(97, 20);
            this.txtTipo.TabIndex = 7;
            this.txtTipo.Validating += new System.ComponentModel.CancelEventHandler(this.txtTipo_Validating);
            // 
            // txtNomeDoDono
            // 
            this.txtNomeDoDono.Location = new System.Drawing.Point(127, 76);
            this.txtNomeDoDono.Name = "txtNomeDoDono";
            this.txtNomeDoDono.Size = new System.Drawing.Size(174, 20);
            this.txtNomeDoDono.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(214, 168);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 26);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grupoCadAnimal
            // 
            this.grupoCadAnimal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grupoCadAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.grupoCadAnimal.Controls.Add(this.btnSair);
            this.grupoCadAnimal.Controls.Add(this.maskedTextBox1);
            this.grupoCadAnimal.Controls.Add(this.txtNome);
            this.grupoCadAnimal.Controls.Add(this.telefoneDono);
            this.grupoCadAnimal.Controls.Add(this.lbNomeDono);
            this.grupoCadAnimal.Controls.Add(this.btnCadastrar);
            this.grupoCadAnimal.Controls.Add(this.lbTipo);
            this.grupoCadAnimal.Controls.Add(this.lbNomeDoAnimal);
            this.grupoCadAnimal.Controls.Add(this.txtNomeDoDono);
            this.grupoCadAnimal.Controls.Add(this.lbRaça);
            this.grupoCadAnimal.Controls.Add(this.txtRaca);
            this.grupoCadAnimal.Controls.Add(this.txtTipo);
            this.grupoCadAnimal.Location = new System.Drawing.Point(179, 12);
            this.grupoCadAnimal.Name = "grupoCadAnimal";
            this.grupoCadAnimal.Size = new System.Drawing.Size(609, 210);
            this.grupoCadAnimal.TabIndex = 11;
            this.grupoCadAnimal.TabStop = false;
            this.grupoCadAnimal.Text = "Cadastro de animal";
            // 
            // telefoneDono
            // 
            this.telefoneDono.AutoSize = true;
            this.telefoneDono.Location = new System.Drawing.Point(14, 117);
            this.telefoneDono.Name = "telefoneDono";
            this.telefoneDono.Size = new System.Drawing.Size(52, 13);
            this.telefoneDono.TabIndex = 12;
            this.telefoneDono.Text = "Telefone:";
            // 
            // dataCadAnimal
            // 
            this.dataCadAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCadAnimal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCadAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCadAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.raca,
            this.nomeDono,
            this.telDono,
            this.tipoTel});
            this.dataCadAnimal.Location = new System.Drawing.Point(98, 228);
            this.dataCadAnimal.Name = "dataCadAnimal";
            this.dataCadAnimal.Size = new System.Drawing.Size(605, 381);
            this.dataCadAnimal.TabIndex = 12;
            this.dataCadAnimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCadAnimal_CellContentClick);
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // raca
            // 
            this.raca.HeaderText = "Raça";
            this.raca.Name = "raca";
            // 
            // nomeDono
            // 
            this.nomeDono.HeaderText = "Nome do dono";
            this.nomeDono.Name = "nomeDono";
            // 
            // telDono
            // 
            this.telDono.HeaderText = "Telefone do dono";
            this.telDono.Name = "telDono";
            // 
            // tipoTel
            // 
            this.tipoTel.HeaderText = "Tipo";
            this.tipoTel.Name = "tipoTel";
            // 
            // validacaoAnimalCampos
            // 
            this.validacaoAnimalCampos.ContainerControl = this;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(127, 117);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(87, 20);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(330, 168);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 26);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // animalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 742);
            this.Controls.Add(this.dataCadAnimal);
            this.Controls.Add(this.grupoCadAnimal);
            this.Name = "animalForm";
            this.Text = "animalForm";
            this.Load += new System.EventHandler(this.animalForm_Load);
            this.grupoCadAnimal.ResumeLayout(false);
            this.grupoCadAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCadAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validacaoAnimalCampos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNomeDoAnimal;
        private System.Windows.Forms.Label lbRaça;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label telefoneDono;
        private System.Windows.Forms.Label lbNomeDono;

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNomeDoDono;

        private System.Windows.Forms.Button btnCadastrar;

        private System.Windows.Forms.GroupBox grupoCadAnimal;
        private System.Windows.Forms.DataGridView dataCadAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn raca;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDono;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDono;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTel;
        private System.Windows.Forms.ErrorProvider validacaoAnimalCampos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}