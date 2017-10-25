namespace VetMaxPitagoras.Foundation
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
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNomeDoDono = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grupoCadAnimal = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.dataCadAnimal = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validacaoAnimalCampos = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxRaca = new System.Windows.Forms.ComboBox();
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
            this.txtNome.Size = new System.Drawing.Size(174, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(374, 76);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(139, 20);
            this.txtTipo.TabIndex = 7;
            this.txtTipo.Enter += new System.EventHandler(this.txtTipo_Enter);
            this.txtTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipo_KeyPress);
            this.txtTipo.Leave += new System.EventHandler(this.txtTipo_Leave);
            // 
            // txtNomeDoDono
            // 
            this.txtNomeDoDono.Location = new System.Drawing.Point(127, 76);
            this.txtNomeDoDono.Name = "txtNomeDoDono";
            this.txtNomeDoDono.Size = new System.Drawing.Size(174, 20);
            this.txtNomeDoDono.TabIndex = 9;
            this.txtNomeDoDono.Enter += new System.EventHandler(this.txtNomeDoDono_Enter);
            this.txtNomeDoDono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeDoDono_KeyPress);
            this.txtNomeDoDono.Leave += new System.EventHandler(this.txtNomeDoDono_Leave);
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
            this.grupoCadAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grupoCadAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.grupoCadAnimal.Controls.Add(this.cbxRaca);
            this.grupoCadAnimal.Controls.Add(this.btnSair);
            this.grupoCadAnimal.Controls.Add(this.txtNome);
            this.grupoCadAnimal.Controls.Add(this.lbNomeDono);
            this.grupoCadAnimal.Controls.Add(this.btnCadastrar);
            this.grupoCadAnimal.Controls.Add(this.lbTipo);
            this.grupoCadAnimal.Controls.Add(this.lbNomeDoAnimal);
            this.grupoCadAnimal.Controls.Add(this.txtNomeDoDono);
            this.grupoCadAnimal.Controls.Add(this.lbRaça);
            this.grupoCadAnimal.Controls.Add(this.txtTipo);
            this.grupoCadAnimal.Location = new System.Drawing.Point(26, 12);
            this.grupoCadAnimal.Name = "grupoCadAnimal";
            this.grupoCadAnimal.Size = new System.Drawing.Size(664, 210);
            this.grupoCadAnimal.TabIndex = 11;
            this.grupoCadAnimal.TabStop = false;
            this.grupoCadAnimal.Text = "Cadastro de animal";
            this.grupoCadAnimal.Enter += new System.EventHandler(this.grupoCadAnimal_Enter);
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
            // dataCadAnimal
            // 
            this.dataCadAnimal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataCadAnimal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCadAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCadAnimal.Location = new System.Drawing.Point(26, 228);
            this.dataCadAnimal.Name = "dataCadAnimal";
            this.dataCadAnimal.Size = new System.Drawing.Size(664, 381);
            this.dataCadAnimal.TabIndex = 12;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 124;
            // 
            // raca
            // 
            this.raca.HeaderText = "Raça";
            this.raca.Name = "raca";
            this.raca.Width = 124;
            // 
            // nomeDono
            // 
            this.nomeDono.HeaderText = "Nome do dono";
            this.nomeDono.Name = "nomeDono";
            this.nomeDono.Width = 125;
            // 
            // telDono
            // 
            this.telDono.HeaderText = "Telefone do dono";
            this.telDono.Name = "telDono";
            this.telDono.Width = 124;
            // 
            // tipoTel
            // 
            this.tipoTel.HeaderText = "Tipo";
            this.tipoTel.Name = "tipoTel";
            this.tipoTel.Width = 124;
            // 
            // validacaoAnimalCampos
            // 
            this.validacaoAnimalCampos.ContainerControl = this;
            // 
            // cbxRaca
            // 
            this.cbxRaca.FormattingEnabled = true;
            this.cbxRaca.Location = new System.Drawing.Point(374, 36);
            this.cbxRaca.Name = "cbxRaca";
            this.cbxRaca.Size = new System.Drawing.Size(203, 21);
            this.cbxRaca.TabIndex = 15;
            // 
            // animalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 665);
            this.Controls.Add(this.dataCadAnimal);
            this.Controls.Add(this.grupoCadAnimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "animalForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lbNomeDono;

        private System.Windows.Forms.TextBox txtNome;
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
        private System.Windows.Forms.ComboBox cbxRaca;
    }
}