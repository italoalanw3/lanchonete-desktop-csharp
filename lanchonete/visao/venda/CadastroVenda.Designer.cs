using projeto_escola.controle;
namespace projeto_escola.visao.cadastros
{
    partial class CadastroVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVenda));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbDetalheVenda = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnValidarVenda = new System.Windows.Forms.Button();
            this.btnConfirmarVenda = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTroco = new System.Windows.Forms.Label();
            this.ckbTroco = new System.Windows.Forms.CheckBox();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnAdicionarCliente = new System.Windows.Forms.Button();
            this.txbValorPago = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTotalVenda = new System.Windows.Forms.TextBox();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listProdutos = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnFechar = new System.Windows.Forms.Button();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gpbDetalheVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbValorPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // gpbDetalheVenda
            // 
            this.gpbDetalheVenda.Controls.Add(this.btnNovo);
            this.gpbDetalheVenda.Controls.Add(this.lblMensagem);
            this.gpbDetalheVenda.Controls.Add(this.btnValidarVenda);
            this.gpbDetalheVenda.Controls.Add(this.btnConfirmarVenda);
            this.gpbDetalheVenda.Controls.Add(this.label6);
            this.gpbDetalheVenda.Controls.Add(this.panel4);
            this.gpbDetalheVenda.Controls.Add(this.panel3);
            this.gpbDetalheVenda.Controls.Add(this.panel2);
            this.gpbDetalheVenda.Controls.Add(this.panel1);
            this.gpbDetalheVenda.Controls.Add(this.txbTroco);
            this.gpbDetalheVenda.Controls.Add(this.ckbTroco);
            this.gpbDetalheVenda.Controls.Add(this.btnAdicionarProduto);
            this.gpbDetalheVenda.Controls.Add(this.btnAdicionarCliente);
            this.gpbDetalheVenda.Controls.Add(this.txbValorPago);
            this.gpbDetalheVenda.Controls.Add(this.label4);
            this.gpbDetalheVenda.Controls.Add(this.label2);
            this.gpbDetalheVenda.Controls.Add(this.txbTotalVenda);
            this.gpbDetalheVenda.Controls.Add(this.txbCliente);
            this.gpbDetalheVenda.Controls.Add(this.label9);
            this.gpbDetalheVenda.Controls.Add(this.label5);
            this.gpbDetalheVenda.Controls.Add(this.listProdutos);
            this.gpbDetalheVenda.Controls.Add(this.label3);
            this.gpbDetalheVenda.Controls.Add(this.label1);
            this.gpbDetalheVenda.Controls.Add(this.dateTimePicker1);
            this.gpbDetalheVenda.Controls.Add(this.btnFechar);
            this.gpbDetalheVenda.Location = new System.Drawing.Point(12, 12);
            this.gpbDetalheVenda.Name = "gpbDetalheVenda";
            this.gpbDetalheVenda.Size = new System.Drawing.Size(643, 491);
            this.gpbDetalheVenda.TabIndex = 20;
            this.gpbDetalheVenda.TabStop = false;
            this.gpbDetalheVenda.Text = "Detalhes da venda";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(506, 453);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(120, 35);
            this.btnNovo.TabIndex = 44;
            this.btnNovo.Text = "&Iniciar venda";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensagem.BackColor = System.Drawing.Color.LightCoral;
            this.lblMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensagem.Location = new System.Drawing.Point(3, 453);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(492, 35);
            this.lblMensagem.TabIndex = 45;
            this.lblMensagem.Text = "Mensagem";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensagem.Visible = false;
            // 
            // btnValidarVenda
            // 
            this.btnValidarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidarVenda.Enabled = false;
            this.btnValidarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnValidarVenda.Image")));
            this.btnValidarVenda.Location = new System.Drawing.Point(389, 412);
            this.btnValidarVenda.Name = "btnValidarVenda";
            this.btnValidarVenda.Size = new System.Drawing.Size(106, 32);
            this.btnValidarVenda.TabIndex = 4;
            this.btnValidarVenda.Text = "&Validar venda";
            this.btnValidarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValidarVenda.UseVisualStyleBackColor = true;
            this.btnValidarVenda.Click += new System.EventHandler(this.btnValidarVenda_Click);
            // 
            // btnConfirmarVenda
            // 
            this.btnConfirmarVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarVenda.Enabled = false;
            this.btnConfirmarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmarVenda.Image")));
            this.btnConfirmarVenda.Location = new System.Drawing.Point(506, 412);
            this.btnConfirmarVenda.Name = "btnConfirmarVenda";
            this.btnConfirmarVenda.Size = new System.Drawing.Size(120, 32);
            this.btnConfirmarVenda.TabIndex = 5;
            this.btnConfirmarVenda.Text = "&Confirmar venda";
            this.btnConfirmarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmarVenda.UseVisualStyleBackColor = true;
            this.btnConfirmarVenda.Click += new System.EventHandler(this.btnConfirmarVenda_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Beige;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(10, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 80);
            this.label6.TabIndex = 43;
            this.label6.Text = "Clique duas vezes no produto com o botão esquerdo do mouse para ver detalhes e du" +
    "as vezes com o botão direito para exclui-lo da venda.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Location = new System.Drawing.Point(7, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(613, 10);
            this.panel4.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(575, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(51, 36);
            this.panel3.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(575, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 36);
            this.panel2.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(575, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 36);
            this.panel1.TabIndex = 40;
            // 
            // txbTroco
            // 
            this.txbTroco.AccessibleDescription = "Teste";
            this.txbTroco.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.txbTroco.BackColor = System.Drawing.Color.Silver;
            this.txbTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTroco.Enabled = false;
            this.txbTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTroco.Location = new System.Drawing.Point(475, 349);
            this.txbTroco.Name = "txbTroco";
            this.txbTroco.Size = new System.Drawing.Size(100, 20);
            this.txbTroco.TabIndex = 39;
            this.txbTroco.Text = "0,00";
            this.txbTroco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ckbTroco
            // 
            this.ckbTroco.AutoSize = true;
            this.ckbTroco.Enabled = false;
            this.ckbTroco.Location = new System.Drawing.Point(459, 380);
            this.ckbTroco.Name = "ckbTroco";
            this.ckbTroco.Size = new System.Drawing.Size(158, 17);
            this.ckbTroco.TabIndex = 3;
            this.ckbTroco.Text = "Deixou o troco como saldo?";
            this.ckbTroco.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Enabled = false;
            this.btnAdicionarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarProduto.Image")));
            this.btnAdicionarProduto.Location = new System.Drawing.Point(482, 127);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(134, 95);
            this.btnAdicionarProduto.TabIndex = 1;
            this.btnAdicionarProduto.Text = "Adicionar produto na venda";
            this.btnAdicionarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.Enabled = false;
            this.btnAdicionarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarCliente.Image")));
            this.btnAdicionarCliente.Location = new System.Drawing.Point(482, 56);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(134, 49);
            this.btnAdicionarCliente.TabIndex = 0;
            this.btnAdicionarCliente.Text = "Adicionar cliente da venda";
            this.btnAdicionarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarCliente.UseVisualStyleBackColor = true;
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);
            // 
            // txbValorPago
            // 
            this.txbValorPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbValorPago.DecimalPlaces = 2;
            this.txbValorPago.Enabled = false;
            this.txbValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorPago.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txbValorPago.Location = new System.Drawing.Point(475, 301);
            this.txbValorPago.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txbValorPago.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.txbValorPago.Name = "txbValorPago";
            this.txbValorPago.Size = new System.Drawing.Size(100, 31);
            this.txbValorPago.TabIndex = 2;
            this.txbValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbValorPago.ThousandsSeparator = true;
            this.txbValorPago.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.txbValorPago.ValueChanged += new System.EventHandler(this.txbValorPago_ValueChanged);
            this.txbValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbValorPago_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Valor pago (R$)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Total da venda (R$)";
            // 
            // txbTotalVenda
            // 
            this.txbTotalVenda.BackColor = System.Drawing.SystemColors.Info;
            this.txbTotalVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTotalVenda.Enabled = false;
            this.txbTotalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalVenda.Location = new System.Drawing.Point(475, 260);
            this.txbTotalVenda.Name = "txbTotalVenda";
            this.txbTotalVenda.Size = new System.Drawing.Size(100, 22);
            this.txbTotalVenda.TabIndex = 31;
            this.txbTotalVenda.Text = "0,00";
            this.txbTotalVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbCliente
            // 
            this.txbCliente.BackColor = System.Drawing.SystemColors.Info;
            this.txbCliente.Enabled = false;
            this.txbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliente.Location = new System.Drawing.Point(154, 69);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(315, 26);
            this.txbCliente.TabIndex = 0;
            this.txbCliente.Text = "...nenhum cliente informado!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Cliente da venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Produtos da venda";
            // 
            // listProdutos
            // 
            this.listProdutos.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listProdutos.AutoArrange = false;
            this.listProdutos.BackColor = System.Drawing.SystemColors.Info;
            this.listProdutos.Enabled = false;
            this.listProdutos.HideSelection = false;
            this.listProdutos.HoverSelection = true;
            this.listProdutos.Location = new System.Drawing.Point(154, 127);
            this.listProdutos.MultiSelect = false;
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(315, 95);
            this.listProdutos.TabIndex = 23;
            this.listProdutos.UseCompatibleStateImageBehavior = false;
            this.listProdutos.ItemActivate += new System.EventHandler(this.listProdutos_ItemActivate);
            this.listProdutos.DoubleClick += new System.EventHandler(this.listProdutos_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Troco (R$)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data da venda";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(321, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(520, 453);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(106, 35);
            this.btnFechar.TabIndex = 46;
            this.btnFechar.Text = "Fechar janela";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // CadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(664, 506);
            this.Controls.Add(this.gpbDetalheVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastroVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de nova venda";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gpbDetalheVenda.ResumeLayout(false);
            this.gpbDetalheVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbValorPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.BindingSource bindingSource;
        public System.Windows.Forms.GroupBox gpbDetalheVenda;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListView listProdutos;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbTotalVenda;
        public System.Windows.Forms.TextBox txbCliente;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown txbValorPago;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnAdicionarProduto;
        public System.Windows.Forms.Button btnAdicionarCliente;
        private System.Windows.Forms.CheckBox ckbTroco;
        public System.Windows.Forms.Label txbTroco;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.Label lblMensagem;
        public System.Windows.Forms.Button btnValidarVenda;
        public System.Windows.Forms.Button btnConfirmarVenda;
        public System.Windows.Forms.Button btnFechar;
    }
}