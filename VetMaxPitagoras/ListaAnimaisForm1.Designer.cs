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
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 237);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColunaAnimal
            // 
            this.ColunaAnimal.HeaderText = "Nome do Animal";
            this.ColunaAnimal.Name = "ColunaAnimal";
            this.ColunaAnimal.Width = 72;
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
            // ListaAnimaisForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 261);
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
    }
}