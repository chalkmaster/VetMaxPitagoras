namespace VetMaxPitagoras.Foundation
{
    partial class EstoqueForm
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
            this.tabControlPesquisaProdutos = new System.Windows.Forms.TabControl();
            this.tabPagePesquisaEstoque = new System.Windows.Forms.TabPage();
            this.btnSairPesquisaEstoque = new System.Windows.Forms.Button();
            this.groupBoxDgvDadosProdutos = new System.Windows.Forms.GroupBox();
            this.DgvListaEstoque = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPesquisaNomeProd = new System.Windows.Forms.GroupBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.txtNomeprodutopesquisar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageCadastroProdutos = new System.Windows.Forms.TabPage();
            this.btnSairCadastroProdutos = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtEstoqueMaxProd = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtEstoqueMinProd = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtQtdProdCadastrar = new System.Windows.Forms.TextBox();
            this.txtValorPagoProd = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtFornecProd = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtModeloProd = new System.Windows.Forms.TextBox();
            this.txtMarcaProduto = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBoxCategProd = new System.Windows.Forms.ComboBox();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlPesquisaProdutos.SuspendLayout();
            this.tabPagePesquisaEstoque.SuspendLayout();
            this.groupBoxDgvDadosProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaEstoque)).BeginInit();
            this.groupPesquisaNomeProd.SuspendLayout();
            this.tabPageCadastroProdutos.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPesquisaProdutos
            // 
            this.tabControlPesquisaProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlPesquisaProdutos.Controls.Add(this.tabPagePesquisaEstoque);
            this.tabControlPesquisaProdutos.Controls.Add(this.tabPageCadastroProdutos);
            this.tabControlPesquisaProdutos.Location = new System.Drawing.Point(19, 23);
            this.tabControlPesquisaProdutos.Name = "tabControlPesquisaProdutos";
            this.tabControlPesquisaProdutos.SelectedIndex = 0;
            this.tabControlPesquisaProdutos.Size = new System.Drawing.Size(671, 461);
            this.tabControlPesquisaProdutos.TabIndex = 0;
            // 
            // tabPagePesquisaEstoque
            // 
            this.tabPagePesquisaEstoque.Controls.Add(this.btnSairPesquisaEstoque);
            this.tabPagePesquisaEstoque.Controls.Add(this.groupBoxDgvDadosProdutos);
            this.tabPagePesquisaEstoque.Controls.Add(this.groupPesquisaNomeProd);
            this.tabPagePesquisaEstoque.Location = new System.Drawing.Point(4, 22);
            this.tabPagePesquisaEstoque.Name = "tabPagePesquisaEstoque";
            this.tabPagePesquisaEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePesquisaEstoque.Size = new System.Drawing.Size(663, 435);
            this.tabPagePesquisaEstoque.TabIndex = 1;
            this.tabPagePesquisaEstoque.Text = "Pesquisa Estoque";
            this.tabPagePesquisaEstoque.UseVisualStyleBackColor = true;
            // 
            // btnSairPesquisaEstoque
            // 
            this.btnSairPesquisaEstoque.Location = new System.Drawing.Point(498, 406);
            this.btnSairPesquisaEstoque.Name = "btnSairPesquisaEstoque";
            this.btnSairPesquisaEstoque.Size = new System.Drawing.Size(146, 23);
            this.btnSairPesquisaEstoque.TabIndex = 3;
            this.btnSairPesquisaEstoque.Text = "SAIR";
            this.btnSairPesquisaEstoque.UseVisualStyleBackColor = true;
            this.btnSairPesquisaEstoque.Click += new System.EventHandler(this.btnSairPesquisaEstoque_Click);
            // 
            // groupBoxDgvDadosProdutos
            // 
            this.groupBoxDgvDadosProdutos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDgvDadosProdutos.Controls.Add(this.DgvListaEstoque);
            this.groupBoxDgvDadosProdutos.Location = new System.Drawing.Point(6, 80);
            this.groupBoxDgvDadosProdutos.Name = "groupBoxDgvDadosProdutos";
            this.groupBoxDgvDadosProdutos.Size = new System.Drawing.Size(651, 326);
            this.groupBoxDgvDadosProdutos.TabIndex = 2;
            this.groupBoxDgvDadosProdutos.TabStop = false;
            this.groupBoxDgvDadosProdutos.Text = "Dados Produtos";
            // 
            // DgvListaEstoque
            // 
            this.DgvListaEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvListaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Categoria,
            this.Valor,
            this.Quantidade});
            this.DgvListaEstoque.Location = new System.Drawing.Point(7, 20);
            this.DgvListaEstoque.Name = "DgvListaEstoque";
            this.DgvListaEstoque.Size = new System.Drawing.Size(638, 300);
            this.DgvListaEstoque.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 80;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 200;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 150;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Width = 85;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 80;
            // 
            // groupPesquisaNomeProd
            // 
            this.groupPesquisaNomeProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupPesquisaNomeProd.Controls.Add(this.btnPesquisarProduto);
            this.groupPesquisaNomeProd.Controls.Add(this.txtNomeprodutopesquisar);
            this.groupPesquisaNomeProd.Controls.Add(this.label11);
            this.groupPesquisaNomeProd.Location = new System.Drawing.Point(6, 8);
            this.groupPesquisaNomeProd.Name = "groupPesquisaNomeProd";
            this.groupPesquisaNomeProd.Size = new System.Drawing.Size(651, 63);
            this.groupPesquisaNomeProd.TabIndex = 1;
            this.groupPesquisaNomeProd.TabStop = false;
            this.groupPesquisaNomeProd.Text = "Pesquisa Produtos";
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(499, 23);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(146, 23);
            this.btnPesquisarProduto.TabIndex = 3;
            this.btnPesquisarProduto.Text = "PESQUISAR";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            // 
            // txtNomeprodutopesquisar
            // 
            this.txtNomeprodutopesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeprodutopesquisar.Location = new System.Drawing.Point(77, 23);
            this.txtNomeprodutopesquisar.Multiline = true;
            this.txtNomeprodutopesquisar.Name = "txtNomeprodutopesquisar";
            this.txtNomeprodutopesquisar.Size = new System.Drawing.Size(418, 23);
            this.txtNomeprodutopesquisar.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "PRODUTO";
            // 
            // tabPageCadastroProdutos
            // 
            this.tabPageCadastroProdutos.Controls.Add(this.button1);
            this.tabPageCadastroProdutos.Controls.Add(this.btnSairCadastroProdutos);
            this.tabPageCadastroProdutos.Controls.Add(this.btnCadastrarProduto);
            this.tabPageCadastroProdutos.Controls.Add(this.groupBox7);
            this.tabPageCadastroProdutos.Controls.Add(this.groupBox);
            this.tabPageCadastroProdutos.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastroProdutos.Name = "tabPageCadastroProdutos";
            this.tabPageCadastroProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastroProdutos.Size = new System.Drawing.Size(663, 435);
            this.tabPageCadastroProdutos.TabIndex = 2;
            this.tabPageCadastroProdutos.Text = "Cadastro Produtos";
            this.tabPageCadastroProdutos.UseVisualStyleBackColor = true;
            // 
            // btnSairCadastroProdutos
            // 
            this.btnSairCadastroProdutos.Location = new System.Drawing.Point(530, 299);
            this.btnSairCadastroProdutos.Name = "btnSairCadastroProdutos";
            this.btnSairCadastroProdutos.Size = new System.Drawing.Size(95, 25);
            this.btnSairCadastroProdutos.TabIndex = 21;
            this.btnSairCadastroProdutos.Text = "SAIR";
            this.btnSairCadastroProdutos.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(322, 299);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(102, 25);
            this.btnCadastrarProduto.TabIndex = 20;
            this.btnCadastrarProduto.Text = "CADASTRAR";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox7.Controls.Add(this.txtEstoqueMaxProd);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.txtEstoqueMinProd);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.txtQtdProdCadastrar);
            this.groupBox7.Controls.Add(this.txtValorPagoProd);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(6, 155);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(651, 138);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Valores do produto";
            // 
            // txtEstoqueMaxProd
            // 
            this.txtEstoqueMaxProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstoqueMaxProd.Location = new System.Drawing.Point(385, 75);
            this.txtEstoqueMaxProd.Name = "txtEstoqueMaxProd";
            this.txtEstoqueMaxProd.Size = new System.Drawing.Size(260, 22);
            this.txtEstoqueMaxProd.TabIndex = 35;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(250, 72);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(129, 16);
            this.label28.TabIndex = 34;
            this.label28.Text = "ESTOQUE MÁXIMO";
            // 
            // txtEstoqueMinProd
            // 
            this.txtEstoqueMinProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstoqueMinProd.Location = new System.Drawing.Point(128, 72);
            this.txtEstoqueMinProd.Name = "txtEstoqueMinProd";
            this.txtEstoqueMinProd.Size = new System.Drawing.Size(102, 22);
            this.txtEstoqueMinProd.TabIndex = 33;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 75);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(125, 16);
            this.label29.TabIndex = 32;
            this.label29.Text = "ESTOQUE MÍNIMO";
            // 
            // txtQtdProdCadastrar
            // 
            this.txtQtdProdCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQtdProdCadastrar.Location = new System.Drawing.Point(384, 41);
            this.txtQtdProdCadastrar.Name = "txtQtdProdCadastrar";
            this.txtQtdProdCadastrar.Size = new System.Drawing.Size(261, 22);
            this.txtQtdProdCadastrar.TabIndex = 31;
            // 
            // txtValorPagoProd
            // 
            this.txtValorPagoProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValorPagoProd.Location = new System.Drawing.Point(128, 41);
            this.txtValorPagoProd.Name = "txtValorPagoProd";
            this.txtValorPagoProd.Size = new System.Drawing.Size(102, 22);
            this.txtValorPagoProd.TabIndex = 29;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(282, 44);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(97, 16);
            this.label30.TabIndex = 30;
            this.label30.Text = "QUANTIDADE";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(32, 44);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(94, 16);
            this.label31.TabIndex = 28;
            this.label31.Text = "VALOR PAGO";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox.Controls.Add(this.txtCodProduto);
            this.groupBox.Controls.Add(this.label22);
            this.groupBox.Controls.Add(this.txtFornecProd);
            this.groupBox.Controls.Add(this.label23);
            this.groupBox.Controls.Add(this.txtModeloProd);
            this.groupBox.Controls.Add(this.txtMarcaProduto);
            this.groupBox.Controls.Add(this.label24);
            this.groupBox.Controls.Add(this.label25);
            this.groupBox.Controls.Add(this.comboBoxCategProd);
            this.groupBox.Controls.Add(this.txtNomeProd);
            this.groupBox.Controls.Add(this.label26);
            this.groupBox.Controls.Add(this.label27);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(6, 16);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(651, 133);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Informações do Estoque";
            this.groupBox.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodProduto.Location = new System.Drawing.Point(128, 28);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(102, 22);
            this.txtCodProduto.TabIndex = 31;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(62, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 16);
            this.label22.TabIndex = 30;
            this.label22.Text = "CÓDIGO";
            // 
            // txtFornecProd
            // 
            this.txtFornecProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFornecProd.Location = new System.Drawing.Point(385, 89);
            this.txtFornecProd.Name = "txtFornecProd";
            this.txtFornecProd.Size = new System.Drawing.Size(260, 22);
            this.txtFornecProd.TabIndex = 29;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(276, 92);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 16);
            this.label23.TabIndex = 28;
            this.label23.Text = "FORNECEDOR";
            // 
            // txtModeloProd
            // 
            this.txtModeloProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModeloProd.Location = new System.Drawing.Point(384, 56);
            this.txtModeloProd.Name = "txtModeloProd";
            this.txtModeloProd.Size = new System.Drawing.Size(261, 22);
            this.txtModeloProd.TabIndex = 27;
            // 
            // txtMarcaProduto
            // 
            this.txtMarcaProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarcaProduto.Location = new System.Drawing.Point(128, 92);
            this.txtMarcaProduto.Name = "txtMarcaProduto";
            this.txtMarcaProduto.Size = new System.Drawing.Size(102, 22);
            this.txtMarcaProduto.TabIndex = 26;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(313, 59);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 16);
            this.label24.TabIndex = 25;
            this.label24.Text = "MODELO";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(66, 95);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 16);
            this.label25.TabIndex = 24;
            this.label25.Text = "MARCA";
            // 
            // comboBoxCategProd
            // 
            this.comboBoxCategProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCategProd.FormattingEnabled = true;
            this.comboBoxCategProd.Items.AddRange(new object[] {
            "Alimentos",
            "Brinquedos",
            "Coleiras/Guias",
            "Medicamentos",
            "Produtos de Higiene"});
            this.comboBoxCategProd.Location = new System.Drawing.Point(128, 56);
            this.comboBoxCategProd.Name = "comboBoxCategProd";
            this.comboBoxCategProd.Size = new System.Drawing.Size(102, 24);
            this.comboBoxCategProd.TabIndex = 23;
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeProd.Location = new System.Drawing.Point(384, 28);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(261, 22);
            this.txtNomeProd.TabIndex = 22;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(36, 62);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 16);
            this.label26.TabIndex = 21;
            this.label26.Text = "CATEGORIA";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(236, 31);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(142, 16);
            this.label27.TabIndex = 20;
            this.label27.Text = "NOME DO PRODUTO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(226, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 13);
            this.label17.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 9;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(325, 35);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(182, 20);
            this.textBox15.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Alimentos",
            "Medicamentos",
            "Brinquedos",
            "Produtos de Higiene",
            "Coleiras/Guias"});
            this.comboBox2.Location = new System.Drawing.Point(76, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(274, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 13;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(64, 88);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(153, 20);
            this.textBox14.TabIndex = 14;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(325, 64);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(182, 20);
            this.textBox13.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(255, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 16;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(325, 91);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(182, 20);
            this.textBox12.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 18;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(64, 31);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(153, 20);
            this.textBox11.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(38, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 20;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(292, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 22;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(105, 22);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(112, 20);
            this.textBox19.TabIndex = 21;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(363, 22);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(120, 20);
            this.textBox18.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 13);
            this.label19.TabIndex = 24;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(105, 53);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(112, 20);
            this.textBox17.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(280, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 13);
            this.label18.TabIndex = 26;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(371, 56);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(112, 20);
            this.textBox16.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EstoqueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 496);
            this.Controls.Add(this.tabControlPesquisaProdutos);
            this.Name = "EstoqueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstoqueForm";
            this.tabControlPesquisaProdutos.ResumeLayout(false);
            this.tabPagePesquisaEstoque.ResumeLayout(false);
            this.groupBoxDgvDadosProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaEstoque)).EndInit();
            this.groupPesquisaNomeProd.ResumeLayout(false);
            this.groupPesquisaNomeProd.PerformLayout();
            this.tabPageCadastroProdutos.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPesquisaProdutos;
        private System.Windows.Forms.TabPage tabPagePesquisaEstoque;
        private System.Windows.Forms.GroupBox groupPesquisaNomeProd;
        private System.Windows.Forms.GroupBox groupBoxDgvDadosProdutos;
        private System.Windows.Forms.TextBox txtNomeprodutopesquisar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DgvListaEstoque;
        private System.Windows.Forms.TabPage tabPageCadastroProdutos;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox txtEstoqueMaxProd;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtEstoqueMinProd;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtQtdProdCadastrar;
        private System.Windows.Forms.TextBox txtValorPagoProd;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtFornecProd;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtModeloProd;
        private System.Windows.Forms.TextBox txtMarcaProduto;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBoxCategProd;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnSairCadastroProdutos;
        private System.Windows.Forms.Button btnSairPesquisaEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Button button1;
    }
}