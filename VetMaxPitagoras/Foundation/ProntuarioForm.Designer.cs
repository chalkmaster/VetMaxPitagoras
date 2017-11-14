namespace VetMaxPitagoras.Foundation
{
    partial class ProntuarioForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPesquisaNumeroPront = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskeddataPesquisaProntuario = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeClientePesquisaPront = new System.Windows.Forms.TextBox();
            this.txtNomePesquisaAnimalPront = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtNomeAnimalCadastroProntuario = new System.Windows.Forms.TextBox();
            this.txtNomeClienteCadastroProtuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedBoxDataEntradaCadastroAnimal = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarProntuario = new System.Windows.Forms.Button();
            this.txtAnamneseProntuarioAnimal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvarCadastroProntuario = new System.Windows.Forms.Button();
            this.btnCancelarCadastroProntuari = new System.Windows.Forms.Button();
            this.lstBoxProntuarioPesquisa = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 365);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnPesquisarProntuario);
            this.tabPage1.Controls.Add(this.txtPesquisaNumeroPront);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.maskeddataPesquisaProntuario);
            this.tabPage1.Controls.Add(this.txtNomeClientePesquisaPront);
            this.tabPage1.Controls.Add(this.txtNomePesquisaAnimalPront);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(677, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar Prontuário";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaNumeroPront
            // 
            this.txtPesquisaNumeroPront.Location = new System.Drawing.Point(338, 30);
            this.txtPesquisaNumeroPront.Name = "txtPesquisaNumeroPront";
            this.txtPesquisaNumeroPront.Size = new System.Drawing.Size(321, 22);
            this.txtPesquisaNumeroPront.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(234, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "PRONTUÁRIO";
            // 
            // maskeddataPesquisaProntuario
            // 
            this.maskeddataPesquisaProntuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskeddataPesquisaProntuario.Location = new System.Drawing.Point(152, 30);
            this.maskeddataPesquisaProntuario.Mask = "00/00/0000";
            this.maskeddataPesquisaProntuario.Name = "maskeddataPesquisaProntuario";
            this.maskeddataPesquisaProntuario.Size = new System.Drawing.Size(76, 22);
            this.maskeddataPesquisaProntuario.TabIndex = 5;
            this.maskeddataPesquisaProntuario.ValidatingType = typeof(System.DateTime);
            // 
            // txtNomeClientePesquisaPront
            // 
            this.txtNomeClientePesquisaPront.Location = new System.Drawing.Point(152, 101);
            this.txtNomeClientePesquisaPront.Name = "txtNomeClientePesquisaPront";
            this.txtNomeClientePesquisaPront.Size = new System.Drawing.Size(507, 22);
            this.txtNomeClientePesquisaPront.TabIndex = 4;
            // 
            // txtNomePesquisaAnimalPront
            // 
            this.txtNomePesquisaAnimalPront.Location = new System.Drawing.Point(152, 65);
            this.txtNomePesquisaAnimalPront.Name = "txtNomePesquisaAnimalPront";
            this.txtNomePesquisaAnimalPront.Size = new System.Drawing.Size(507, 22);
            this.txtNomePesquisaAnimalPront.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOME DO CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME DO ANIMAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancelarCadastroProntuari);
            this.tabPage2.Controls.Add(this.btnSalvarCadastroProntuario);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtAnamneseProntuarioAnimal);
            this.tabPage2.Controls.Add(this.maskedBoxDataEntradaCadastroAnimal);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtNomeClienteCadastroProtuario);
            this.tabPage2.Controls.Add(this.txtNomeAnimalCadastroProntuario);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(677, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar Prontuário";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtNomeAnimalCadastroProntuario
            // 
            this.txtNomeAnimalCadastroProntuario.Location = new System.Drawing.Point(142, 26);
            this.txtNomeAnimalCadastroProntuario.Name = "txtNomeAnimalCadastroProntuario";
            this.txtNomeAnimalCadastroProntuario.Size = new System.Drawing.Size(315, 22);
            this.txtNomeAnimalCadastroProntuario.TabIndex = 0;
            // 
            // txtNomeClienteCadastroProtuario
            // 
            this.txtNomeClienteCadastroProtuario.Location = new System.Drawing.Point(142, 57);
            this.txtNomeClienteCadastroProtuario.Name = "txtNomeClienteCadastroProtuario";
            this.txtNomeClienteCadastroProtuario.Size = new System.Drawing.Size(315, 22);
            this.txtNomeClienteCadastroProtuario.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "NOME DO ANIMAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "NOME DO CLIENTE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "DATA DE ENTRADA";
            // 
            // maskedBoxDataEntradaCadastroAnimal
            // 
            this.maskedBoxDataEntradaCadastroAnimal.Location = new System.Drawing.Point(142, 85);
            this.maskedBoxDataEntradaCadastroAnimal.Mask = "00/00/0000 90:00";
            this.maskedBoxDataEntradaCadastroAnimal.Name = "maskedBoxDataEntradaCadastroAnimal";
            this.maskedBoxDataEntradaCadastroAnimal.Size = new System.Drawing.Size(109, 22);
            this.maskedBoxDataEntradaCadastroAnimal.TabIndex = 5;
            this.maskedBoxDataEntradaCadastroAnimal.ValidatingType = typeof(System.DateTime);
            // 
            // btnPesquisarProntuario
            // 
            this.btnPesquisarProntuario.Location = new System.Drawing.Point(529, 309);
            this.btnPesquisarProntuario.Name = "btnPesquisarProntuario";
            this.btnPesquisarProntuario.Size = new System.Drawing.Size(130, 25);
            this.btnPesquisarProntuario.TabIndex = 8;
            this.btnPesquisarProntuario.Text = "PESQUISAR";
            this.btnPesquisarProntuario.UseVisualStyleBackColor = true;
            // 
            // txtAnamneseProntuarioAnimal
            // 
            this.txtAnamneseProntuarioAnimal.Location = new System.Drawing.Point(6, 152);
            this.txtAnamneseProntuarioAnimal.Multiline = true;
            this.txtAnamneseProntuarioAnimal.Name = "txtAnamneseProntuarioAnimal";
            this.txtAnamneseProntuarioAnimal.Size = new System.Drawing.Size(665, 153);
            this.txtAnamneseProntuarioAnimal.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "ANAMNESE";
            // 
            // btnSalvarCadastroProntuario
            // 
            this.btnSalvarCadastroProntuario.Location = new System.Drawing.Point(582, 311);
            this.btnSalvarCadastroProntuario.Name = "btnSalvarCadastroProntuario";
            this.btnSalvarCadastroProntuario.Size = new System.Drawing.Size(89, 23);
            this.btnSalvarCadastroProntuario.TabIndex = 8;
            this.btnSalvarCadastroProntuario.Text = "SALVAR";
            this.btnSalvarCadastroProntuario.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCadastroProntuari
            // 
            this.btnCancelarCadastroProntuari.Location = new System.Drawing.Point(487, 311);
            this.btnCancelarCadastroProntuari.Name = "btnCancelarCadastroProntuari";
            this.btnCancelarCadastroProntuari.Size = new System.Drawing.Size(89, 23);
            this.btnCancelarCadastroProntuari.TabIndex = 9;
            this.btnCancelarCadastroProntuari.Text = "CANCELAR";
            this.btnCancelarCadastroProntuari.UseVisualStyleBackColor = true;
            // 
            // lstBoxProntuarioPesquisa
            // 
            this.lstBoxProntuarioPesquisa.FormattingEnabled = true;
            this.lstBoxProntuarioPesquisa.ItemHeight = 16;
            this.lstBoxProntuarioPesquisa.Location = new System.Drawing.Point(7, 22);
            this.lstBoxProntuarioPesquisa.Name = "lstBoxProntuarioPesquisa";
            this.lstBoxProntuarioPesquisa.Size = new System.Drawing.Size(627, 132);
            this.lstBoxProntuarioPesquisa.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBoxProntuarioPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(19, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 163);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Histórico de Prontuário";
            // 
            // ProntuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 495);
            this.Controls.Add(this.tabControl1);
            this.Name = "ProntuarioForm";
            this.Text = "ProntuarioForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox maskeddataPesquisaProntuario;
        private System.Windows.Forms.TextBox txtNomeClientePesquisaPront;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisaNumeroPront;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomePesquisaAnimalPront;
        private System.Windows.Forms.Button btnPesquisarProntuario;
        private System.Windows.Forms.MaskedTextBox maskedBoxDataEntradaCadastroAnimal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeClienteCadastroProtuario;
        private System.Windows.Forms.TextBox txtNomeAnimalCadastroProntuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAnamneseProntuarioAnimal;
        private System.Windows.Forms.Button btnCancelarCadastroProntuari;
        private System.Windows.Forms.Button btnSalvarCadastroProntuario;
        private System.Windows.Forms.ListBox lstBoxProntuarioPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}