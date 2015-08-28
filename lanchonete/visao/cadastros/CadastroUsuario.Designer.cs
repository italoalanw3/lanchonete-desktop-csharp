namespace projeto_escola.visao.cadastros
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblDocumentoIdentificador = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.gpbManutencao = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbAcesso = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbSuperUsuario = new System.Windows.Forms.CheckBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbPossuiAcesso = new System.Windows.Forms.CheckBox();
            this.txbDocumentoIdentificador = new System.Windows.Forms.TextBox();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ckbOpcaoPesquias = new System.Windows.Forms.CheckBox();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.gpbLista = new System.Windows.Forms.GroupBox();
            this.btnNovoReferencia = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitar_saldo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.possuiAcesso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superUsuario = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEditarUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDeletarUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlDebitoSaldo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txbSaldo = new System.Windows.Forms.TextBox();
            this.numDebitoParcial = new System.Windows.Forms.NumericUpDown();
            this.btnDebitoTotal = new System.Windows.Forms.Button();
            this.btnDebitoParcial = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.mensagemDebitoSaldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.gpbManutencao.SuspendLayout();
            this.gpbAcesso.SuspendLayout();
            this.gpbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.pnlDebitoSaldo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDebitoParcial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(13, 122);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 37);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.lblMensagem.Location = new System.Drawing.Point(10, 176);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(823, 35);
            this.lblMensagem.TabIndex = 16;
            this.lblMensagem.Text = "Mensagem";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagem.Visible = false;
            this.lblMensagem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblMensagem_MouseClick);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(138, 26);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(285, 20);
            this.txbNome.TabIndex = 5;
            // 
            // lblDocumentoIdentificador
            // 
            this.lblDocumentoIdentificador.AutoSize = true;
            this.lblDocumentoIdentificador.Location = new System.Drawing.Point(10, 60);
            this.lblDocumentoIdentificador.Name = "lblDocumentoIdentificador";
            this.lblDocumentoIdentificador.Size = new System.Drawing.Size(122, 13);
            this.lblDocumentoIdentificador.TabIndex = 4;
            this.lblDocumentoIdentificador.Text = "Documento identificador";
            // 
            // btnFechar
            // 
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(35, 122);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(74, 35);
            this.btnFechar.TabIndex = 15;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do usuário/cliente";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
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
            this.toolStrip.Location = new System.Drawing.Point(3, 439);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(836, 38);
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
            this.btnPrimeiraPagina.Click += new System.EventHandler(this.btnUltimaPagina_Click);
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
            // gpbManutencao
            // 
            this.gpbManutencao.Controls.Add(this.label4);
            this.gpbManutencao.Controls.Add(this.gpbAcesso);
            this.gpbManutencao.Controls.Add(this.ckbPossuiAcesso);
            this.gpbManutencao.Controls.Add(this.txbDocumentoIdentificador);
            this.gpbManutencao.Controls.Add(this.btnSalvar);
            this.gpbManutencao.Controls.Add(this.txbNome);
            this.gpbManutencao.Controls.Add(this.lblDocumentoIdentificador);
            this.gpbManutencao.Controls.Add(this.label1);
            this.gpbManutencao.Controls.Add(this.btnFechar);
            this.gpbManutencao.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbManutencao.Location = new System.Drawing.Point(0, 0);
            this.gpbManutencao.Name = "gpbManutencao";
            this.gpbManutencao.Size = new System.Drawing.Size(842, 170);
            this.gpbManutencao.TabIndex = 13;
            this.gpbManutencao.TabStop = false;
            this.gpbManutencao.Text = "Manutenção";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(172, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Deixe desmarcado se for um cliente";
            // 
            // gpbAcesso
            // 
            this.gpbAcesso.Controls.Add(this.label5);
            this.gpbAcesso.Controls.Add(this.ckbSuperUsuario);
            this.gpbAcesso.Controls.Add(this.txbSenha);
            this.gpbAcesso.Controls.Add(this.txbLogin);
            this.gpbAcesso.Controls.Add(this.label3);
            this.gpbAcesso.Controls.Add(this.label2);
            this.gpbAcesso.Location = new System.Drawing.Point(455, 19);
            this.gpbAcesso.Name = "gpbAcesso";
            this.gpbAcesso.Size = new System.Drawing.Size(336, 115);
            this.gpbAcesso.TabIndex = 12;
            this.gpbAcesso.TabStop = false;
            this.gpbAcesso.Text = "Acesso ao sistema";
            this.gpbAcesso.Visible = false;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(124, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Super usuários podem cadastrar vendas e outros super usuários.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckbSuperUsuario
            // 
            this.ckbSuperUsuario.AutoSize = true;
            this.ckbSuperUsuario.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbSuperUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ckbSuperUsuario.Location = new System.Drawing.Point(15, 92);
            this.ckbSuperUsuario.Name = "ckbSuperUsuario";
            this.ckbSuperUsuario.Size = new System.Drawing.Size(103, 18);
            this.ckbSuperUsuario.TabIndex = 16;
            this.ckbSuperUsuario.Text = "Super usuário?";
            this.ckbSuperUsuario.UseVisualStyleBackColor = true;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(51, 58);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(254, 20);
            this.txbSenha.TabIndex = 13;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(51, 27);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(254, 20);
            this.txbLogin.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Senha";
            // 
            // ckbPossuiAcesso
            // 
            this.ckbPossuiAcesso.AutoSize = true;
            this.ckbPossuiAcesso.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbPossuiAcesso.Location = new System.Drawing.Point(10, 90);
            this.ckbPossuiAcesso.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ckbPossuiAcesso.Name = "ckbPossuiAcesso";
            this.ckbPossuiAcesso.Size = new System.Drawing.Size(153, 17);
            this.ckbPossuiAcesso.TabIndex = 7;
            this.ckbPossuiAcesso.Text = "Possui acesso ao sistema?";
            this.ckbPossuiAcesso.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ckbPossuiAcesso.UseVisualStyleBackColor = true;
            this.ckbPossuiAcesso.CheckedChanged += new System.EventHandler(this.ckbPossuiAcesso_CheckedChanged);
            // 
            // txbDocumentoIdentificador
            // 
            this.txbDocumentoIdentificador.Location = new System.Drawing.Point(138, 57);
            this.txbDocumentoIdentificador.Name = "txbDocumentoIdentificador";
            this.txbDocumentoIdentificador.Size = new System.Drawing.Size(131, 20);
            this.txbDocumentoIdentificador.TabIndex = 6;
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.Controls.Add(this.pictureBox1);
            this.gpbFiltro.Controls.Add(this.ckbOpcaoPesquias);
            this.gpbFiltro.Controls.Add(this.txbPesquisa);
            this.gpbFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbFiltro.Location = new System.Drawing.Point(3, 16);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(836, 46);
            this.gpbFiltro.TabIndex = 23;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Pesquisar usuários/clientes";
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
            this.ckbOpcaoPesquias.Size = new System.Drawing.Size(252, 17);
            this.ckbOpcaoPesquias.TabIndex = 1;
            this.ckbOpcaoPesquias.Text = "Pesquisar apenas nos usuários/clientes visíveis";
            this.ckbOpcaoPesquias.UseVisualStyleBackColor = true;
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Location = new System.Drawing.Point(12, 20);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(305, 20);
            this.txbPesquisa.TabIndex = 0;
            this.txbPesquisa.Text = "Digite aqui o nome do usuário/cliente para pesquisar...";
            this.txbPesquisa.TextChanged += new System.EventHandler(this.txbPesquisa_TextChanged);
            this.txbPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPesquisa_KeyPress);
            this.txbPesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbPesquisa_KeyUp);
            // 
            // gpbLista
            // 
            this.gpbLista.Controls.Add(this.btnNovoReferencia);
            this.gpbLista.Controls.Add(this.gpbFiltro);
            this.gpbLista.Controls.Add(this.toolStrip);
            this.gpbLista.Controls.Add(this.dgvUsuarios);
            this.gpbLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpbLista.Location = new System.Drawing.Point(0, 214);
            this.gpbLista.Name = "gpbLista";
            this.gpbLista.Size = new System.Drawing.Size(842, 480);
            this.gpbLista.TabIndex = 12;
            this.gpbLista.TabStop = false;
            this.gpbLista.Text = "Registros";
            // 
            // btnNovoReferencia
            // 
            this.btnNovoReferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoReferencia.Location = new System.Drawing.Point(439, 405);
            this.btnNovoReferencia.Name = "btnNovoReferencia";
            this.btnNovoReferencia.Size = new System.Drawing.Size(396, 31);
            this.btnNovoReferencia.TabIndex = 25;
            this.btnNovoReferencia.Text = "Usar usuário selecionado como referência, para cadastrar um novo";
            this.btnNovoReferencia.UseVisualStyleBackColor = true;
            this.btnNovoReferencia.Click += new System.EventHandler(this.btnNovoReferencia_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.documentoIdentificador,
            this.saldo,
            this.debitar_saldo,
            this.possuiAcesso,
            this.login,
            this.senha,
            this.superUsuario,
            this.btnEditarUsuario,
            this.btnDeletarUsuario});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsuarios.Location = new System.Drawing.Point(6, 68);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(829, 331);
            this.dgvUsuarios.StandardTab = true;
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 65;
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
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.saldo.DefaultCellStyle = dataGridViewCellStyle3;
            this.saldo.HeaderText = "Saldo R$";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            // 
            // debitar_saldo
            // 
            this.debitar_saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.debitar_saldo.HeaderText = "Debitar saldo";
            this.debitar_saldo.Name = "debitar_saldo";
            this.debitar_saldo.ReadOnly = true;
            this.debitar_saldo.Text = "debitar saldo total ou parcial";
            this.debitar_saldo.UseColumnTextForButtonValue = true;
            this.debitar_saldo.Width = 75;
            // 
            // possuiAcesso
            // 
            this.possuiAcesso.DataPropertyName = "possuiAcesso";
            this.possuiAcesso.FalseValue = "Não";
            this.possuiAcesso.HeaderText = "Possui acesso?";
            this.possuiAcesso.IndeterminateValue = "Indeterminado";
            this.possuiAcesso.Name = "possuiAcesso";
            this.possuiAcesso.ReadOnly = true;
            this.possuiAcesso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.possuiAcesso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.possuiAcesso.TrueValue = "Sim";
            this.possuiAcesso.Visible = false;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Visible = false;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Visible = false;
            // 
            // superUsuario
            // 
            this.superUsuario.DataPropertyName = "superUsuario";
            this.superUsuario.FalseValue = "Sim";
            this.superUsuario.HeaderText = "É super usuário?";
            this.superUsuario.IndeterminateValue = "Indeterminado";
            this.superUsuario.Name = "superUsuario";
            this.superUsuario.ReadOnly = true;
            this.superUsuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.superUsuario.TrueValue = "Não";
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.btnEditarUsuario.HeaderText = "Editar";
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.ReadOnly = true;
            this.btnEditarUsuario.Text = "Clique para editar";
            this.btnEditarUsuario.UseColumnTextForButtonValue = true;
            this.btnEditarUsuario.Width = 40;
            // 
            // btnDeletarUsuario
            // 
            this.btnDeletarUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.btnDeletarUsuario.HeaderText = "Deletar";
            this.btnDeletarUsuario.Name = "btnDeletarUsuario";
            this.btnDeletarUsuario.ReadOnly = true;
            this.btnDeletarUsuario.Text = "Clique para deletar";
            this.btnDeletarUsuario.UseColumnTextForButtonValue = true;
            this.btnDeletarUsuario.Width = 47;
            // 
            // pnlDebitoSaldo
            // 
            this.pnlDebitoSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDebitoSaldo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDebitoSaldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlDebitoSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDebitoSaldo.Controls.Add(this.mensagemDebitoSaldo);
            this.pnlDebitoSaldo.Controls.Add(this.btnVoltar);
            this.pnlDebitoSaldo.Controls.Add(this.label7);
            this.pnlDebitoSaldo.Controls.Add(this.txbSaldo);
            this.pnlDebitoSaldo.Controls.Add(this.numDebitoParcial);
            this.pnlDebitoSaldo.Controls.Add(this.btnDebitoTotal);
            this.pnlDebitoSaldo.Controls.Add(this.btnDebitoParcial);
            this.pnlDebitoSaldo.Controls.Add(this.label6);
            this.pnlDebitoSaldo.Location = new System.Drawing.Point(335, 282);
            this.pnlDebitoSaldo.Name = "pnlDebitoSaldo";
            this.pnlDebitoSaldo.Size = new System.Drawing.Size(218, 152);
            this.pnlDebitoSaldo.TabIndex = 31;
            this.pnlDebitoSaldo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(2, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Valor para debito parcial";
            // 
            // txbSaldo
            // 
            this.txbSaldo.Enabled = false;
            this.txbSaldo.ForeColor = System.Drawing.Color.Black;
            this.txbSaldo.Location = new System.Drawing.Point(128, 33);
            this.txbSaldo.Name = "txbSaldo";
            this.txbSaldo.Size = new System.Drawing.Size(66, 20);
            this.txbSaldo.TabIndex = 4;
            this.txbSaldo.Text = "0";
            this.txbSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numDebitoParcial
            // 
            this.numDebitoParcial.BackColor = System.Drawing.SystemColors.Window;
            this.numDebitoParcial.DecimalPlaces = 2;
            this.numDebitoParcial.ForeColor = System.Drawing.Color.Black;
            this.numDebitoParcial.Location = new System.Drawing.Point(128, 5);
            this.numDebitoParcial.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDebitoParcial.Name = "numDebitoParcial";
            this.numDebitoParcial.Size = new System.Drawing.Size(66, 20);
            this.numDebitoParcial.TabIndex = 0;
            this.numDebitoParcial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDebitoParcial.ValueChanged += new System.EventHandler(this.numDebitoParcial_ValueChanged);
            // 
            // btnDebitoTotal
            // 
            this.btnDebitoTotal.Location = new System.Drawing.Point(120, 58);
            this.btnDebitoTotal.Name = "btnDebitoTotal";
            this.btnDebitoTotal.Size = new System.Drawing.Size(75, 23);
            this.btnDebitoTotal.TabIndex = 2;
            this.btnDebitoTotal.Text = "Débito total";
            this.btnDebitoTotal.UseVisualStyleBackColor = true;
            this.btnDebitoTotal.Click += new System.EventHandler(this.btnDebitoTotal_Click);
            // 
            // btnDebitoParcial
            // 
            this.btnDebitoParcial.Location = new System.Drawing.Point(25, 58);
            this.btnDebitoParcial.Name = "btnDebitoParcial";
            this.btnDebitoParcial.Size = new System.Drawing.Size(89, 23);
            this.btnDebitoParcial.TabIndex = 1;
            this.btnDebitoParcial.Text = "Débito parcial";
            this.btnDebitoParcial.UseVisualStyleBackColor = true;
            this.btnDebitoParcial.Click += new System.EventHandler(this.btnDebitoParcial_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(89, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Saldo";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(25, 87);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(170, 23);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Fechar e voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // mensagemDebitoSaldo
            // 
            this.mensagemDebitoSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mensagemDebitoSaldo.BackColor = System.Drawing.Color.LightCoral;
            this.mensagemDebitoSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mensagemDebitoSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensagemDebitoSaldo.ForeColor = System.Drawing.Color.Black;
            this.mensagemDebitoSaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mensagemDebitoSaldo.Location = new System.Drawing.Point(3, 113);
            this.mensagemDebitoSaldo.Name = "mensagemDebitoSaldo";
            this.mensagemDebitoSaldo.Size = new System.Drawing.Size(208, 35);
            this.mensagemDebitoSaldo.TabIndex = 18;
            this.mensagemDebitoSaldo.Text = "Mensagem";
            this.mensagemDebitoSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mensagemDebitoSaldo.Visible = false;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(842, 694);
            this.Controls.Add(this.pnlDebitoSaldo);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.gpbManutencao);
            this.Controls.Add(this.gpbLista);
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuários/clientes";
            this.Load += new System.EventHandler(this.CadastroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.gpbManutencao.ResumeLayout(false);
            this.gpbManutencao.PerformLayout();
            this.gpbAcesso.ResumeLayout(false);
            this.gpbAcesso.PerformLayout();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.pnlDebitoSaldo.ResumeLayout(false);
            this.pnlDebitoSaldo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDebitoParcial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblDocumentoIdentificador;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox gpbManutencao;
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
        private System.Windows.Forms.ToolStripButton txbTotalRegistros;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.CheckBox ckbPossuiAcesso;
        private System.Windows.Forms.TextBox txbDocumentoIdentificador;
        private System.Windows.Forms.GroupBox gpbAcesso;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbSuperUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNovoReferencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewButtonColumn debitar_saldo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn possuiAcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn superUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditarUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn btnDeletarUsuario;
        private System.Windows.Forms.Panel pnlDebitoSaldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbSaldo;
        private System.Windows.Forms.NumericUpDown numDebitoParcial;
        private System.Windows.Forms.Button btnDebitoTotal;
        private System.Windows.Forms.Button btnDebitoParcial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label mensagemDebitoSaldo;
    }
}