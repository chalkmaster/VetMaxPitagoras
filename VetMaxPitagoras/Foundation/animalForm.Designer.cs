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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbRaça = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbNomeDono = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtTelefoneDoDono = new System.Windows.Forms.TextBox();
            this.txtNomeDoDono = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grupoCadAnimal = new System.Windows.Forms.GroupBox();
            this.telefoneDono = new System.Windows.Forms.Label();
            this.gridCadastroAnimal = new System.Windows.Forms.TableLayoutPanel();
            this.grupoCadAnimal.SuspendLayout();
            this.gridCadastroAnimal.SuspendLayout();
            this.SuspendLayout();
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
            // lbRaça
            // 
            this.lbRaça.AutoSize = true;
            this.lbRaça.Location = new System.Drawing.Point(18, 84);
            this.lbRaça.Name = "lbRaça";
            this.lbRaça.Size = new System.Drawing.Size(36, 13);
            this.lbRaça.TabIndex = 1;
            this.lbRaça.Text = "Raça:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(18, 192);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(31, 13);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "Tipo:";
            // 
            // lbNomeDono
            // 
            this.lbNomeDono.AutoSize = true;
            this.lbNomeDono.Location = new System.Drawing.Point(16, 121);
            this.lbNomeDono.Name = "lbNomeDono";
            this.lbNomeDono.Size = new System.Drawing.Size(82, 13);
            this.lbNomeDono.TabIndex = 4;
            this.lbNomeDono.Text = "Nome do Dono:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(129, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(174, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(129, 77);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(174, 20);
            this.txtRaca.TabIndex = 6;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(129, 185);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(174, 20);
            this.txtTipo.TabIndex = 7;
            // 
            // txtTelefoneDoDono
            // 
            this.txtTelefoneDoDono.Location = new System.Drawing.Point(129, 150);
            this.txtTelefoneDoDono.Name = "txtTelefoneDoDono";
            this.txtTelefoneDoDono.Size = new System.Drawing.Size(174, 20);
            this.txtTelefoneDoDono.TabIndex = 8;
            // 
            // txtNomeDoDono
            // 
            this.txtNomeDoDono.Location = new System.Drawing.Point(129, 114);
            this.txtNomeDoDono.Name = "txtNomeDoDono";
            this.txtNomeDoDono.Size = new System.Drawing.Size(174, 20);
            this.txtNomeDoDono.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(228, 235);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // grupoCadAnimal
            // 
            this.grupoCadAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grupoCadAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.grupoCadAnimal.Controls.Add(this.txtNome);
            this.grupoCadAnimal.Controls.Add(this.telefoneDono);
            this.grupoCadAnimal.Controls.Add(this.lbNomeDono);
            this.grupoCadAnimal.Controls.Add(this.btnCadastrar);
            this.grupoCadAnimal.Controls.Add(this.lbTipo);
            this.grupoCadAnimal.Controls.Add(this.lbNome);
            this.grupoCadAnimal.Controls.Add(this.txtNomeDoDono);
            this.grupoCadAnimal.Controls.Add(this.lbRaça);
            this.grupoCadAnimal.Controls.Add(this.txtRaca);
            this.grupoCadAnimal.Controls.Add(this.txtTelefoneDoDono);
            this.grupoCadAnimal.Controls.Add(this.txtTipo);
            this.grupoCadAnimal.Location = new System.Drawing.Point(329, 153);
            this.grupoCadAnimal.Name = "grupoCadAnimal";
            this.grupoCadAnimal.Size = new System.Drawing.Size(320, 341);
            this.grupoCadAnimal.TabIndex = 11;
            this.grupoCadAnimal.TabStop = false;
            this.grupoCadAnimal.Text = "Cadastro de animal";
            // 
            // telefoneDono
            // 
            this.telefoneDono.AutoSize = true;
            this.telefoneDono.Location = new System.Drawing.Point(16, 157);
            this.telefoneDono.Name = "telefoneDono";
            this.telefoneDono.Size = new System.Drawing.Size(99, 13);
            this.telefoneDono.TabIndex = 12;
            this.telefoneDono.Text = "Telefone do Dono :";
            // 
            // gridCadastroAnimal
            // 
            this.gridCadastroAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridCadastroAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.gridCadastroAnimal.ColumnCount = 3;
            this.gridCadastroAnimal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gridCadastroAnimal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gridCadastroAnimal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gridCadastroAnimal.Controls.Add(this.grupoCadAnimal, 1, 0);
            this.gridCadastroAnimal.Location = new System.Drawing.Point(0, 1);
            this.gridCadastroAnimal.Name = "gridCadastroAnimal";
            this.gridCadastroAnimal.RowCount = 1;
            this.gridCadastroAnimal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridCadastroAnimal.Size = new System.Drawing.Size(980, 647);
            this.gridCadastroAnimal.TabIndex = 12;
            // 
            // animalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 648);
            this.Controls.Add(this.gridCadastroAnimal);
            this.Name = "animalForm";
            this.Text = "animalForm";
            this.Load += new System.EventHandler(this.animalForm_Load);
            this.grupoCadAnimal.ResumeLayout(false);
            this.grupoCadAnimal.PerformLayout();
            this.gridCadastroAnimal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbRaça;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label telefoneDono;
        private System.Windows.Forms.Label lbNomeDono;

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtTelefoneDoDono;
        private System.Windows.Forms.TextBox txtNomeDoDono;

        private System.Windows.Forms.Button btnCadastrar;

        private System.Windows.Forms.GroupBox grupoCadAnimal;
        private System.Windows.Forms.TableLayoutPanel gridCadastroAnimal; 
    }
}