namespace projeto_escola.visao.venda
{
    partial class AdicionarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarProdutos));
            this.gpbLista = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ckbOpcaoPesquias = new System.Windows.Forms.CheckBox();
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbQuantidade = new System.Windows.Forms.NumericUpDown();
            this.gpbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gpbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbLista
            // 
            this.gpbLista.Controls.Add(this.label1);
            this.gpbLista.Controls.Add(this.pictureBox2);
            this.gpbLista.Controls.Add(this.textBox1);
            this.gpbLista.Controls.Add(this.gpbFiltro);
            this.gpbLista.Controls.Add(this.toolStrip);
            this.gpbLista.Controls.Add(this.dgvProdutos);
            this.gpbLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbLista.Location = new System.Drawing.Point(0, 0);
            this.gpbLista.Name = "gpbLista";
            this.gpbLista.Size = new System.Drawing.Size(404, 252);
            this.gpbLista.TabIndex = 0;
            this.gpbLista.TabStop = false;
            this.gpbLista.Text = "Registros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Digite o nome do produto para pesquisar";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 28);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPesquisa_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbPesquisa_KeyUp);
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.pictureBox1);
            this.gpbFiltro.Controls.Add(this.ckbOpcaoPesquias);
            this.gpbFiltro.Controls.Add(this.txbPesquisa);
            this.gpbFiltro.Location = new System.Drawing.Point(6, 426);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(632, 46);
            this.gpbFiltro.TabIndex = 23;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Pesquisar produtos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ckbOpcaoPesquias
            // 
            this.ckbOpcaoPesquias.AutoSize = true;
            this.ckbOpcaoPesquias.Checked = true;
            this.ckbOpcaoPesquias.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbOpcaoPesquias.Location = new System.Drawing.Point(369, 23);
            this.ckbOpcaoPesquias.Name = "ckbOpcaoPesquias";
            this.ckbOpcaoPesquias.Size = new System.Drawing.Size(213, 17);
            this.ckbOpcaoPesquias.TabIndex = 1;
            this.ckbOpcaoPesquias.Text = "Pesquisar apenas nos produtos visíveis";
            this.ckbOpcaoPesquias.UseVisualStyleBackColor = true;
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(12, 20);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(305, 20);
            this.txbPesquisa.TabIndex = 0;
            this.txbPesquisa.Text = "Digite aqui o nome do produto para pesquisar...";
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
            this.toolStripSeparator1});
            this.toolStrip.Location = new System.Drawing.Point(3, 211);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(398, 38);
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
            this.btnPrimeiraPagina.Size = new System.Drawing.Size(23, 35);
            this.btnPrimeiraPagina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrimeiraPagina.Click += new System.EventHandler(this.btnPrimeiraPagina_Click);
            // 
            // btnPaginaAnterior
            // 
            this.btnPaginaAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnPaginaAnterior.Image")));
            this.btnPaginaAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaginaAnterior.Name = "btnPaginaAnterior";
            this.btnPaginaAnterior.Size = new System.Drawing.Size(23, 35);
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
            this.btnProximaPagina.Size = new System.Drawing.Size(23, 35);
            this.btnProximaPagina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProximaPagina.Click += new System.EventHandler(this.btnProximaPagina_Click);
            // 
            // btnUltimaPagina
            // 
            this.btnUltimaPagina.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimaPagina.Image")));
            this.btnUltimaPagina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimaPagina.Name = "btnUltimaPagina";
            this.btnUltimaPagina.Size = new System.Drawing.Size(23, 35);
            this.btnUltimaPagina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUltimaPagina.Click += new System.EventHandler(this.btnUltimaPagina_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colPreco,
            this.quantidadeEstoque,
            this.validade,
            this.descricao});
            this.dgvProdutos.Location = new System.Drawing.Point(8, 67);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(382, 141);
            this.dgvProdutos.TabIndex = 1;
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
            this.colId.Visible = false;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.DataPropertyName = "nome";
            this.colNome.HeaderText = "Nome do produto";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colPreco
            // 
            this.colPreco.DataPropertyName = "preco";
            this.colPreco.HeaderText = "Preço em R$";
            this.colPreco.Name = "colPreco";
            this.colPreco.ReadOnly = true;
            // 
            // quantidadeEstoque
            // 
            this.quantidadeEstoque.DataPropertyName = "quantidadeEstoque";
            this.quantidadeEstoque.HeaderText = "Quantidade";
            this.quantidadeEstoque.Name = "quantidadeEstoque";
            this.quantidadeEstoque.ReadOnly = true;
            // 
            // validade
            // 
            this.validade.DataPropertyName = "validade";
            this.validade.HeaderText = "Validade";
            this.validade.Name = "validade";
            this.validade.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Detalhes";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Visible = false;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarProduto.Image")));
            this.btnAdicionarProduto.Location = new System.Drawing.Point(164, 258);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(228, 50);
            this.btnAdicionarProduto.TabIndex = 1;
            this.btnAdicionarProduto.Text = "Adicionar produto selecionado à venda";
            this.btnAdicionarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarProduto.UseVisualStyleBackColor = false;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagem.BackColor = System.Drawing.Color.LightCoral;
            this.lblMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Black;
            this.lblMensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensagem.Location = new System.Drawing.Point(9, 311);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(384, 35);
            this.lblMensagem.TabIndex = 18;
            this.lblMensagem.Text = "Mensagem";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagem.Visible = false;
            this.lblMensagem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblMensagem_MouseClick);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(248, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Quantidade";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(103, 271);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(55, 20);
            this.txbQuantidade.TabIndex = 33;
            // 
            // AdicionarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(404, 346);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.gpbLista);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdicionarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar produtos à venda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdicionarProdutos_FormClosing);
            this.Load += new System.EventHandler(this.AdicionarProdutos_Load);
            this.gpbLista.ResumeLayout(false);
            this.gpbLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbLista;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ckbOpcaoPesquias;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbLinhasVisiveis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnPrimeiraPagina;
        private System.Windows.Forms.ToolStripButton btnPaginaAnterior;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbPaginas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnProximaPagina;
        private System.Windows.Forms.ToolStripButton btnUltimaPagina;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.NumericUpDown txbQuantidade;
    }
}