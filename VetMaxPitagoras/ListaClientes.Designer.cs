using System;

namespace VetMaxPitagoras
{
    partial class ListaClientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_dadosCadastroCliente = new System.Windows.Forms.DataGridView();
            this.Column_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dadosCadastroCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(17, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1004, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgv_dadosCadastroCliente
            // 
            this.dgv_dadosCadastroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_dadosCadastroCliente.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_dadosCadastroCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dadosCadastroCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Nome,
            this.Column_Sexo,
            this.Column_Cpf,
            this.Column_Fone,
            this.Column_Celular,
            this.Column_Endereco,
            this.Column_Numero,
            this.Column_Complemento,
            this.Column_Cidade});
            this.dgv_dadosCadastroCliente.Location = new System.Drawing.Point(19, 59);
            this.dgv_dadosCadastroCliente.Name = "dgv_dadosCadastroCliente";
            this.dgv_dadosCadastroCliente.Size = new System.Drawing.Size(1000, 155);
            this.dgv_dadosCadastroCliente.TabIndex = 7;
            // 
            // Column_Nome
            // 
            this.Column_Nome.HeaderText = "Nome";
            this.Column_Nome.Name = "Column_Nome";
            this.Column_Nome.Width = 210;
            // 
            // Column_Sexo
            // 
            this.Column_Sexo.HeaderText = "Sexo";
            this.Column_Sexo.Name = "Column_Sexo";
            this.Column_Sexo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Sexo.Width = 40;
            // 
            // Column_Cpf
            // 
            this.Column_Cpf.HeaderText = "Cpf";
            this.Column_Cpf.Name = "Column_Cpf";
            this.Column_Cpf.Width = 120;
            // 
            // Column_Fone
            // 
            this.Column_Fone.HeaderText = "Fone";
            this.Column_Fone.Name = "Column_Fone";
            this.Column_Fone.Width = 90;
            // 
            // Column_Celular
            // 
            this.Column_Celular.HeaderText = "Celular";
            this.Column_Celular.Name = "Column_Celular";
            this.Column_Celular.Width = 90;
            // 
            // Column_Endereco
            // 
            this.Column_Endereco.HeaderText = "Endereço";
            this.Column_Endereco.Name = "Column_Endereco";
            this.Column_Endereco.Width = 125;
            // 
            // Column_Numero
            // 
            this.Column_Numero.HeaderText = "Numero";
            this.Column_Numero.Name = "Column_Numero";
            this.Column_Numero.Width = 45;
            // 
            // Column_Complemento
            // 
            this.Column_Complemento.HeaderText = "Compl.";
            this.Column_Complemento.Name = "Column_Complemento";
            this.Column_Complemento.Width = 80;
            // 
            // Column_Cidade
            // 
            this.Column_Cidade.HeaderText = "Cidade";
            this.Column_Cidade.Name = "Column_Cidade";
            this.Column_Cidade.Width = 160;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "ALTERAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(519, 27);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(600, 27);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "SAIR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 293);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_dadosCadastroCliente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaClientes";
            this.Text = "ListaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dadosCadastroCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgv_dadosCadastroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCancelar;

        public EventHandler button4_Click { get; private set; }
    }
}