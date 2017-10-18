namespace VetMaxPitagoras
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioDaClínicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.pesquisaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1250, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.animaisToolStripMenuItem,
            this.funcionárioDaClínicaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(268, 30);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // animaisToolStripMenuItem
            // 
            this.animaisToolStripMenuItem.Name = "animaisToolStripMenuItem";
            this.animaisToolStripMenuItem.Size = new System.Drawing.Size(268, 30);
            this.animaisToolStripMenuItem.Text = "Animais";
            this.animaisToolStripMenuItem.Click += new System.EventHandler(this.animaisToolStripMenuItem_Click);
            // 
            // funcionárioDaClínicaToolStripMenuItem
            // 
            this.funcionárioDaClínicaToolStripMenuItem.Name = "funcionárioDaClínicaToolStripMenuItem";
            this.funcionárioDaClínicaToolStripMenuItem.Size = new System.Drawing.Size(268, 30);
            this.funcionárioDaClínicaToolStripMenuItem.Text = "Funcionário da Clínica";
            this.funcionárioDaClínicaToolStripMenuItem.Click += new System.EventHandler(this.funcionárioDaClínicaToolStripMenuItem_Click);
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.pesquisaToolStripMenuItem.Text = "Pesquisa";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(255, 30);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(967, 685);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 35);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 829);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animaisToolStripMenuItem;
        private System.Windows.Forms.Button btnSair;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionárioDaClínicaToolStripMenuItem;
    }
}

