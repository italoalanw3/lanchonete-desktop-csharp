namespace projeto_escola.visao.venda
{
    partial class AdicionarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarCliente));
            this.gpbLista = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.possuiAcesso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.superUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionarCliente = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txbPesquisaCliente = new System.Windows.Forms.TextBox();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gpbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gpbFiltro.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbLista
            // 
            this.gpbLista.Controls.Add(this.label2);
            this.gpbLista.Controls.Add(this.dgvUsuarios);
            this.gpbLista.Controls.Add(this.btnAdicionarCliente);
            this.gpbLista.Controls.Add(this.pictureBox2);
            this.gpbLista.Controls.Add(this.txbPesquisaCliente);
            this.gpbLista.Controls.Add(this.gpbFiltro);
            this.gpbLista.Controls.Add(this.toolStrip);
            this.gpbLista.Controls.Add(this.button1);
            this.gpbLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbLista.Location = new System.Drawing.Point(0, 0);
            this.gpbLista.Name = "gpbLista";
            this.gpbLista.Size = new System.Drawing.Size(404, 314);
            this.gpbLista.TabIndex = 2;
            this.gpbLista.TabStop = false;
            this.gpbLista.Text = "Registros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Digite o nome do cliente para pesquisar";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.documentoIdentificador,
            this.login,
            this.possuiAcesso,
            this.superUsuario,
            this.senha,
            this.saldo});
            this.dgvUsuarios.Location = new System.Drawing.Point(5, 65);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(387, 152);
            this.dgvUsuarios.StandardTab = true;
            this.dgvUsuarios.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.id.Visible = false;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome do usuário/cliente";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // documentoIdentificador
            // 
            this.documentoIdentificador.DataPropertyName = "documentoIdentificador";
            this.documentoIdentificador.HeaderText = "Documento identificador";
            this.documentoIdentificador.Name = "documentoIdentificador";
            this.documentoIdentificador.ReadOnly = true;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Visible = false;
            // 
            // possuiAcesso
            // 
            this.possuiAcesso.DataPropertyName = "possuiAcesso";
            this.possuiAcesso.HeaderText = "Possui acesso?";
            this.possuiAcesso.Name = "possuiAcesso";
            this.possuiAcesso.ReadOnly = true;
            this.possuiAcesso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.possuiAcesso.Visible = false;
            // 
            // superUsuario
            // 
            this.superUsuario.DataPropertyName = "superUsuario";
            this.superUsuario.HeaderText = "Super usuário";
            this.superUsuario.Name = "superUsuario";
            this.superUsuario.ReadOnly = true;
            this.superUsuario.Visible = false;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Visible = false;
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            this.saldo.HeaderText = "Saldo R$";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdicionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarCliente.Image")));
            this.btnAdicionarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionarCliente.Location = new System.Drawing.Point(8, 262);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(389, 37);
            this.btnAdicionarCliente.TabIndex = 0;
            this.btnAdicionarCliente.Text = "Adicionar cliente selecionado à venda";
            this.btnAdicionarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarCliente.UseVisualStyleBackColor = false;
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 28);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // txbPesquisaCliente
            // 
            this.txbPesquisaCliente.Location = new System.Drawing.Point(49, 39);
            this.txbPesquisaCliente.Name = "txbPesquisaCliente";
            this.txbPesquisaCliente.Size = new System.Drawing.Size(290, 20);
            this.txbPesquisaCliente.TabIndex = 0;
            this.txbPesquisaCliente.TextChanged += new System.EventHandler(this.txbPesquisaCliente_TextChanged);
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.ckbOpcaoPesquias);
            this.gpbFiltro.Controls.Add(this.txbPesquisa);
            this.gpbFiltro.Location = new System.Drawing.Point(6, 426);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(632, 46);
            this.gpbFiltro.TabIndex = 23;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Pesquisar produtos";
            // 
            // ckbOpcaoPesquias
            // 
            this.ckbOpcaoPesquias.Location = new System.Drawing.Point(0, 0);
            this.ckbOpcaoPesquias.Name = "ckbOpcaoPesquias";
            this.ckbOpcaoPesquias.Size = new System.Drawing.Size(104, 24);
            this.ckbOpcaoPesquias.TabIndex = 0;
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(0, 0);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(100, 20);
            this.txbPesquisa.TabIndex = 1;
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
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
            this.toolStrip.Location = new System.Drawing.Point(3, 220);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(383, 38);
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
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(235, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.lblMensagem.Location = new System.Drawing.Point(8, 302);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(389, 35);
            this.lblMensagem.TabIndex = 17;
            this.lblMensagem.Text = "Mensagem";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagem.Visible = false;
            this.lblMensagem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblMensagem_MouseClick);
            // 
            // AdicionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(404, 346);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.gpbLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdicionarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar cliente à venda";
            this.gpbLista.ResumeLayout(false);
            this.gpbLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbLista;
        private System.Windows.Forms.Button btnAdicionarCliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txbPesquisaCliente;
        private System.Windows.Forms.GroupBox gpbFiltro;
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
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewCheckBoxColumn possuiAcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn superUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
    }
}