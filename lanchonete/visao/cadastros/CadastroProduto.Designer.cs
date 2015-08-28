namespace projeto_escola.visao.cadastros
{
    partial class CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbLista = new System.Windows.Forms.GroupBox();
            this.btnNovoReferencia = new System.Windows.Forms.Button();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.ckbOpcaoPesquias = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbLinhasVisiveis = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrimeiraPagina = new System.Windows.Forms.ToolStripButton();
            this.btnPaginaAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbPaginas = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProximaPagina = new System.Windows.Forms.ToolStripButton();
            this.btnUltimaPagina = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txbTotalRegistros = new System.Windows.Forms.ToolStripButton();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.gpbManutencao = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.validade = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.numPreco = new System.Windows.Forms.NumericUpDown();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMensagem = new System.Windows.Forms.Label();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditarProduto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDeletarProduto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gpbLista.SuspendLayout();
            this.gpbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.gpbManutencao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbLista
            // 
            this.gpbLista.Controls.Add(this.btnNovoReferencia);
            this.gpbLista.Controls.Add(this.gpbFiltro);
            this.gpbLista.Controls.Add(this.toolStrip);
            this.gpbLista.Controls.Add(this.dgvProdutos);
            this.gpbLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpbLista.Location = new System.Drawing.Point(0, 279);
            this.gpbLista.Name = "gpbLista";
            this.gpbLista.Size = new System.Drawing.Size(807, 420);
            this.gpbLista.TabIndex = 0;
            this.gpbLista.TabStop = false;
            this.gpbLista.Text = "Registros";
            // 
            // btnNovoReferencia
            // 
            this.btnNovoReferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoReferencia.Location = new System.Drawing.Point(455, 342);
            this.btnNovoReferencia.Name = "btnNovoReferencia";
            this.btnNovoReferencia.Size = new System.Drawing.Size(345, 31);
            this.btnNovoReferencia.TabIndex = 24;
            this.btnNovoReferencia.Text = "Usar produto selecionado como referência, para cadastrar um novo";
            this.btnNovoReferencia.UseVisualStyleBackColor = true;
            this.btnNovoReferencia.Click += new System.EventHandler(this.btnNovoReferencia_Click);
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.ckbOpcaoPesquias);
            this.gpbFiltro.Controls.Add(this.pictureBox1);
            this.gpbFiltro.Controls.Add(this.txbPesquisa);
            this.gpbFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbFiltro.Location = new System.Drawing.Point(3, 16);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(801, 46);
            this.gpbFiltro.TabIndex = 23;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Pesquisar produtos";
            // 
            // ckbOpcaoPesquias
            // 
            this.ckbOpcaoPesquias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbOpcaoPesquias.AutoSize = true;
            this.ckbOpcaoPesquias.Checked = true;
            this.ckbOpcaoPesquias.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbOpcaoPesquias.Location = new System.Drawing.Point(579, 19);
            this.ckbOpcaoPesquias.Name = "ckbOpcaoPesquias";
            this.ckbOpcaoPesquias.Size = new System.Drawing.Size(213, 17);
            this.ckbOpcaoPesquias.TabIndex = 5;
            this.ckbOpcaoPesquias.Text = "Pesquisar apenas nos produtos visíveis";
            this.ckbOpcaoPesquias.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(539, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPesquisa.Location = new System.Drawing.Point(12, 20);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(525, 20);
            this.txbPesquisa.TabIndex = 4;
            this.txbPesquisa.Text = "Digite aqui o nome do produto para pesquisar...";
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            this.txbPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPesquisa_KeyPress);
            this.txbPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbPesquisa_KeyUp);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.cmbLinhasVisiveis,
            this.toolStripSeparator2,
            this.btnPrimeiraPagina,
            this.btnPaginaAnterior,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.cmbPaginas,
            this.toolStripSeparator4,
            this.btnProximaPagina,
            this.btnUltimaPagina,
            this.toolStripSeparator1,
            this.txbTotalRegistros});
            this.toolStrip.Location = new System.Drawing.Point(3, 379);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(801, 38);
            this.toolStrip.TabIndex = 22;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(81, 35);
            this.toolStripLabel2.Text = "Linhas visíveis";
            // 
            // cmbLinhasVisiveis
            // 
            this.cmbLinhasVisiveis.AutoSize = false;
            this.cmbLinhasVisiveis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLinhasVisiveis.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbLinhasVisiveis.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100",
            "500",
            "1000"});
            this.cmbLinhasVisiveis.Name = "cmbLinhasVisiveis";
            this.cmbLinhasVisiveis.Size = new System.Drawing.Size(45, 23);
            this.cmbLinhasVisiveis.SelectedIndexChanged += new System.EventHandler(this.cmbLinhasVisiveis_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnPrimeiraPagina
            // 
            this.btnPrimeiraPagina.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimeiraPagina.Image")));
            this.btnPrimeiraPagina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrimeiraPagina.Name = "btnPrimeiraPagina";
            this.btnPrimeiraPagina.Size = new System.Drawing.Size(94, 35);
            this.btnPrimeiraPagina.Text = "Primeira página";
            this.btnPrimeiraPagina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrimeiraPagina.Click += new System.EventHandler(this.btnPrimeiraPagina_Click);
            // 
            // btnPaginaAnterior
            // 
            this.btnPaginaAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnPaginaAnterior.Image")));
            this.btnPaginaAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaginaAnterior.Name = "btnPaginaAnterior";
            this.btnPaginaAnterior.Size = new System.Drawing.Size(91, 35);
            this.btnPaginaAnterior.Text = "Página anterior";
            this.btnPaginaAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPaginaAnterior.Click += new System.EventHandler(this.btnPaginaAnterior_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(62, 35);
            this.toolStripLabel1.Text = "Pág. atual:";
            // 
            // cmbPaginas
            // 
            this.cmbPaginas.AutoSize = false;
            this.cmbPaginas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaginas.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbPaginas.Name = "cmbPaginas";
            this.cmbPaginas.Size = new System.Drawing.Size(53, 23);
            this.cmbPaginas.SelectedIndexChanged += new System.EventHandler(this.cmbPaginas_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // btnProximaPagina
            // 
            this.btnProximaPagina.Image = ((System.Drawing.Image)(resources.GetObject("btnProximaPagina.Image")));
            this.btnProximaPagina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximaPagina.Name = "btnProximaPagina";
            this.btnProximaPagina.Size = new System.Drawing.Size(93, 35);
            this.btnProximaPagina.Text = "Próxima página";
            this.btnProximaPagina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProximaPagina.Click += new System.EventHandler(this.btnProximaPagina_Click);
            // 
            // btnUltimaPagina
            // 
            this.btnUltimaPagina.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimaPagina.Image")));
            this.btnUltimaPagina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimaPagina.Name = "btnUltimaPagina";
            this.btnUltimaPagina.Size = new System.Drawing.Size(85, 35);
            this.btnUltimaPagina.Text = "Última página";
            this.btnUltimaPagina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUltimaPagina.Click += new System.EventHandler(this.btnUltimaPagina_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // txbTotalRegistros
            // 
            this.txbTotalRegistros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.txbTotalRegistros.Image = ((System.Drawing.Image)(resources.GetObject("txbTotalRegistros.Image")));
            this.txbTotalRegistros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txbTotalRegistros.Name = "txbTotalRegistros";
            this.txbTotalRegistros.Size = new System.Drawing.Size(123, 35);
            this.txbTotalRegistros.Text = "Total  de registros: 10";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.descricao,
            this.colPreco,
            this.quantidadeEstoque,
            this.dataValidade,
            this.btnEditarProduto,
            this.btnDeletarProduto});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutos.Location = new System.Drawing.Point(6, 68);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(794, 270);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // gpbManutencao
            // 
            this.gpbManutencao.Controls.Add(this.label9);
            this.gpbManutencao.Controls.Add(this.numQuantidade);
            this.gpbManutencao.Controls.Add(this.label10);
            this.gpbManutencao.Controls.Add(this.label8);
            this.gpbManutencao.Controls.Add(this.label7);
            this.gpbManutencao.Controls.Add(this.validade);
            this.gpbManutencao.Controls.Add(this.label6);
            this.gpbManutencao.Controls.Add(this.label5);
            this.gpbManutencao.Controls.Add(this.label4);
            this.gpbManutencao.Controls.Add(this.txbDescricao);
            this.gpbManutencao.Controls.Add(this.label3);
            this.gpbManutencao.Controls.Add(this.btnSalvar);
            this.gpbManutencao.Controls.Add(this.numPreco);
            this.gpbManutencao.Controls.Add(this.txbNome);
            this.gpbManutencao.Controls.Add(this.label2);
            this.gpbManutencao.Controls.Add(this.label1);
            this.gpbManutencao.Controls.Add(this.btnFechar);
            this.gpbManutencao.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbManutencao.Location = new System.Drawing.Point(0, 0);
            this.gpbManutencao.Name = "gpbManutencao";
            this.gpbManutencao.Size = new System.Drawing.Size(807, 230);
            this.gpbManutencao.TabIndex = 1;
            this.gpbManutencao.TabStop = false;
            this.gpbManutencao.Text = "Manutenção";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(200, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Quantidade  de produtos em estoque";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(74, 154);
            this.numQuantidade.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(120, 20);
            this.numQuantidade.TabIndex = 4;
            this.numQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(290, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Data de vencimento do produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Validade";
            // 
            // validade
            // 
            this.validade.Location = new System.Drawing.Point(74, 125);
            this.validade.Name = "validade";
            this.validade.Size = new System.Drawing.Size(210, 20);
            this.validade.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(200, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Preço unitário do produto em R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(452, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome principal do produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(452, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingredientes, descrição ou qualquer detalhe descritivo do produto";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(74, 60);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(364, 20);
            this.txbDescricao.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Detalhes";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(12, 185);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 39);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "&Salvar produto";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // numPreco
            // 
            this.numPreco.DecimalPlaces = 2;
            this.numPreco.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPreco.Location = new System.Drawing.Point(74, 91);
            this.numPreco.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPreco.Name = "numPreco";
            this.numPreco.Size = new System.Drawing.Size(120, 20);
            this.numPreco.TabIndex = 2;
            this.numPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(74, 26);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(364, 20);
            this.txbNome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(51, 185);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(74, 35);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagem.BackColor = System.Drawing.Color.LightCoral;
            this.lblMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensagem.Location = new System.Drawing.Point(6, 237);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(794, 35);
            this.lblMensagem.TabIndex = 11;
            this.lblMensagem.Text = "Mensagem";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagem.Visible = false;
            this.lblMensagem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMensagem_MouseDown);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colId.DataPropertyName = "id";
            this.colId.HeaderText = "Código";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colId.Width = 65;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.DataPropertyName = "nome";
            this.colNome.HeaderText = "Nome do produto";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Detalhes do produto";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // colPreco
            // 
            this.colPreco.DataPropertyName = "preco";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.colPreco.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPreco.HeaderText = "Preço em R$";
            this.colPreco.Name = "colPreco";
            this.colPreco.ReadOnly = true;
            // 
            // quantidadeEstoque
            // 
            this.quantidadeEstoque.DataPropertyName = "quantidadeEstoque";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.quantidadeEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            this.quantidadeEstoque.HeaderText = "Quantidade";
            this.quantidadeEstoque.Name = "quantidadeEstoque";
            this.quantidadeEstoque.ReadOnly = true;
            // 
            // dataValidade
            // 
            this.dataValidade.DataPropertyName = "validade";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataValidade.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataValidade.HeaderText = "Validade";
            this.dataValidade.Name = "dataValidade";
            this.dataValidade.ReadOnly = true;
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.HeaderText = "Editar produto";
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.ReadOnly = true;
            this.btnEditarProduto.Text = "Clique para editar";
            this.btnEditarProduto.ToolTipText = "Editar produto";
            this.btnEditarProduto.UseColumnTextForButtonValue = true;
            // 
            // btnDeletarProduto
            // 
            this.btnDeletarProduto.HeaderText = "Deletar produto";
            this.btnDeletarProduto.Name = "btnDeletarProduto";
            this.btnDeletarProduto.ReadOnly = true;
            this.btnDeletarProduto.Text = "Clique para deletar";
            this.btnDeletarProduto.ToolTipText = "Deletar produto";
            this.btnDeletarProduto.UseColumnTextForButtonValue = true;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(807, 699);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.gpbManutencao);
            this.Controls.Add(this.gpbLista);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.gpbLista.ResumeLayout(false);
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.gpbManutencao.ResumeLayout(false);
            this.gpbManutencao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbLista;
        private System.Windows.Forms.GroupBox gpbManutencao;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPreco;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnPrimeiraPagina;
        private System.Windows.Forms.ToolStripButton btnPaginaAnterior;
        private System.Windows.Forms.ToolStripButton btnProximaPagina;
        private System.Windows.Forms.ToolStripButton btnUltimaPagina;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox cmbLinhasVisiveis;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbPaginas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton txbTotalRegistros;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNovoReferencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbOpcaoPesquias;
        private System.Windows.Forms.DateTimePicker validade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValidade;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarProduto;
        private System.Windows.Forms.DataGridViewButtonColumn btnDeletarProduto;
    }
}