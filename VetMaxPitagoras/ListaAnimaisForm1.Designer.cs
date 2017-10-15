namespace VetMaxPitagoras
{
    partial class ListaAnimaisForm1
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
            this.ColunaAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaRaça = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaVacinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaSintomas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaAnimal,
            this.ColunaEspecie,
            this.ColunaCor,
            this.ColunaRaça,
            this.ColunaSexo,
            this.ColunaPeso,
            this.ColunaVacinas,
            this.ColunaSintomas});
            this.dataGridView1.Location = new System.Drawing.Point(2, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 215);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColunaAnimal
            // 
            this.ColunaAnimal.HeaderText = "Nome do Animal";
            this.ColunaAnimal.Name = "ColunaAnimal";
            // 
            // ColunaEspecie
            // 
            this.ColunaEspecie.HeaderText = "Especie";
            this.ColunaEspecie.Name = "ColunaEspecie";
            this.ColunaEspecie.Width = 70;
            // 
            // ColunaCor
            // 
            this.ColunaCor.HeaderText = "Cor";
            this.ColunaCor.Name = "ColunaCor";
            this.ColunaCor.Width = 48;
            // 
            // ColunaRaça
            // 
            this.ColunaRaça.HeaderText = "Raça";
            this.ColunaRaça.Name = "ColunaRaça";
            this.ColunaRaça.Width = 58;
            // 
            // ColunaSexo
            // 
            this.ColunaSexo.HeaderText = "Sexo";
            this.ColunaSexo.Name = "ColunaSexo";
            this.ColunaSexo.Width = 56;
            // 
            // ColunaPeso
            // 
            this.ColunaPeso.HeaderText = "Peso";
            this.ColunaPeso.Name = "ColunaPeso";
            this.ColunaPeso.Width = 56;
            // 
            // ColunaVacinas
            // 
            this.ColunaVacinas.HeaderText = "Vacinas";
            this.ColunaVacinas.Name = "ColunaVacinas";
            this.ColunaVacinas.Width = 70;
            // 
            // ColunaSintomas
            // 
            this.ColunaSintomas.HeaderText = "Sintomas";
            this.ColunaSintomas.Name = "ColunaSintomas";
            this.ColunaSintomas.Width = 75;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ListaAnimaisForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaAnimaisForm1";
            this.Text = "ListaAnimaisForm1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaRaça;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaVacinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaSintomas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}