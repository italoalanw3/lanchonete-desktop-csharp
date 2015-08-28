using projeto_escola.controle;
using projeto_escola.entidade;
using projeto_escola.modelo.entidades;
using projeto_escola.servico;
using projeto_escola.visao.cadastros;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace projeto_escola.visao
{
    public partial class Principal : Form
    {
        private UsuarioControle usuarioControle = new UsuarioControle();
        private VendaControle vendaControle = new VendaControle();
        private HistoricoEstoqueControle historicoEstoqueControle = new HistoricoEstoqueControle();
        private ThreadLogs tlog = new ThreadLogs();
        private Thread thread;
        private List<HistoricoEstoque> historico;

        private List<System.Drawing.Color> cores = new List<Color>();        

        public Principal()
        {
            InitializeComponent();

            this.Text = "Bem-vindo " + Sistema.usuarioLogado.nome;
            statusMsg.BackColor = Color.Green;
            statusMsg.Text = "Iniciando sistema...";
            statusLogadoDesde.Text = statusLogadoDesde.Text + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            statusDataHora.Text = DateTime.Now.ToString("HH:mm:ss");
            this.Refresh();

            thread = new Thread(new ThreadStart(tlog.removerLogs));
            thread.Start();

            vendaControle = new VendaControle();

            vendaControle.paginacao.quantidadeTotalRegistros = vendaControle.quantidadeRegistros();

            cmbPaginas.Items.Clear();
            for (int i = 0; i < vendaControle.paginacao.quantidadePaginas; i++)
            {
                cmbPaginas.Items.Add(i + 1);
            }

            carregarRegistros();
            historico = historicoEstoqueControle.listarTodoEstoqueValido();
            historico.Sort((a,b) => -1* a.CompareTo(b));
            dgvEstoque.DataSource = historico;
            //chtRelatorioEstoque.DataSource = historico;


            statusMsg.Text = "Sistema iniciado!";
            timerIniciar.Enabled = false;

            if (cmbPaginas.Items.Count == 0 || cmbLinhasVisiveis.Items.Count == 0) return;

            cmbLinhasVisiveis.SelectedIndex = 0;
            cmbPaginas.SelectedIndex = 0;
            dtDe.Value = DateTime.Now.AddDays(-1);
            dtAte.Value = DateTime.Now;
            dateInicioEstoque.Value = DateTime.Now.AddDays(-1);
            dateFimEstoque.Value = DateTime.Now;
        }

        public void carregarRegistros()
        {
            dgvVenda.DataSource = vendaControle.listarPorPaginacao(vendaControle.paginacao.primeiroRegistroPagina, vendaControle.paginacao.quantidadeRegistrosPorPagina);            
            vendaControle.paginacao.quantidadeTotalRegistros = vendaControle.quantidadeRegistros();
            txbTotalRegistros.Text = "Total de registros:" + vendaControle.paginacao.quantidadeTotalRegistros;
        }

        private void txbPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbPesquisa.Text.Contains("Pesquisar vendas pelo nome do cliente"))
            {
                txbPesquisa.Text = "";
            }
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (txbPesquisa.Text.Equals(""))
            {
                txbPesquisa.Text = "Pesquisar vendas pelo nome do cliente";
            }
        }

        private void cmbLinhasVisiveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            vendaControle.paginacao.quantidadeRegistrosPorPagina = Convert.ToInt32(cmbLinhasVisiveis.Text);

            cmbPaginas.Items.Clear();
            for (int i = 1; i <= vendaControle.paginacao.quantidadePaginas; i++)
            {
                cmbPaginas.Items.Add(i);
            }

            if (cmbPaginas.Items.Count == 0) return;

            vendaControle.paginacao.paginaAtual = 1;
            cmbPaginas.SelectedIndex = 0;

            carregarRegistros();
        }

        private void cmbPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaginas.Text.Equals("")) return;
            vendaControle.paginacao.paginaAtual = Convert.ToInt32(cmbPaginas.Text);

            carregarRegistros();
        }

        private void btnPrimeiraPagina_Click(object sender, EventArgs e)
        {
            vendaControle.paginacao.paginaAtual = 1;
            if (vendaControle.quantidadeRegistros() == 0) return;
            cmbPaginas.SelectedIndex = 0;

            carregarRegistros();
        }

        private void btnPaginaAnterior_Click(object sender, EventArgs e)
        {
            if (vendaControle.paginacao.paginaAtual == 1) return;
            if (vendaControle.quantidadeRegistros() == 0) return;

            vendaControle.paginacao.paginaAtual = vendaControle.paginacao.paginaAtual - 1;
            // O index é a página atual menos um
            cmbPaginas.SelectedIndex = vendaControle.paginacao.paginaAtual - 1;

            carregarRegistros();
        }

        private void btnProximaPagina_Click(object sender, EventArgs e)
        {
            if (vendaControle.paginacao.paginaAtual == vendaControle.paginacao.quantidadePaginas) return;
            if (vendaControle.quantidadeRegistros() == 0) return;
            vendaControle.paginacao.paginaAtual = vendaControle.paginacao.paginaAtual + 1;
            // O index é a página atual menos um
            cmbPaginas.SelectedIndex = vendaControle.paginacao.paginaAtual - 1;

            carregarRegistros();
        }

        private void btnUltimaPagina_Click(object sender, EventArgs e)
        {
            vendaControle.paginacao.paginaAtual = vendaControle.paginacao.quantidadePaginas;

            if (vendaControle.quantidadeRegistros() == 0) return;
            cmbPaginas.SelectedIndex = vendaControle.paginacao.paginaAtual - 1;

            carregarRegistros();
        }


        private void produtoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (CadastroProduto frmCadastroProduto = new CadastroProduto())
            {
                frmCadastroProduto.ShowDialog();
            }
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema.usuarioLogado = null;
            Hide();
            FormLogin frmLogin = new FormLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Show();
            }
        }

        private void tmrRelogio_Tick(object sender, EventArgs e)
        {
            statusDataHora.Text = DateTime.Now.ToLocalTime().ToString("HH:mm:ss");
        }

        private void tmrEscreverLog_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(250);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CadastroUsuario frmCadastroUsuario = new CadastroUsuario())
            {
                frmCadastroUsuario.ShowDialog();
            }
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CadastroVenda frmCadastroVenda = new CadastroVenda())
            {
                frmCadastroVenda.ShowDialog();
            }
        }

        private void tmrApagarMensagem_Tick(object sender, EventArgs e)
        {
            if (statusMsg.Text != "...")
            {
                Thread.Sleep(1000);
                statusMsg.Text = "...";
            }
        }

        private void dgvVenda_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVenda.RowCount > 0)
            {
                try
                {
                    vendaControle.entidade.id = Convert.ToInt32(dgvVenda.CurrentRow.Cells[0].Value);

                    List<VendaProduto> vendaProdutos = new VendaProdutoControle().todosOsProdutosVenda(vendaControle.entidade.id);

                    lblTotalProdutosExibicao.Text = Convert.ToString(vendaProdutos.Count);
                    this.listaProdutos.Clear();
                    foreach (VendaProduto produto in vendaProdutos)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = produto.produto.nome + " \n " + produto.produto.preco.ToString("C");
                        item.Tag = produto.produto;
                        this.listaProdutos.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    statusMsg.Text = "Exceção ao selecionar dados para edição: " + ex.Message;
                }
            }
        }

        private void atualizarVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbPrincipal.SelectedIndex == 1)
            {
                statusMsg.Text = "Atualizando listagem de vendas...";
                statusMsg.BackColor = Color.Green;
                carregarRegistros();
            }
        }

        private void ckbFiltroData_Click(object sender, EventArgs e)
        {
            if (ckbFiltroData.Checked || ckbFiltroNome.Checked || ckbFIltroValorPago.Checked || ckbFiltroValorVenda.Checked)
            {
                btnAplicarFiltro.Enabled = true;
            }
            else
            {
                btnAplicarFiltro.Enabled = false;
                vendaControle.paginacao.paginaAtual = 1;
                cmbPaginas.SelectedIndex = 0;

                carregarRegistros();
            }
        }

        private void btnDesabilitarFiltros_Click(object sender, EventArgs e)
        {
            btnAplicarFiltro.Enabled = false;
            ckbFiltroData.Checked = ckbFiltroNome.Checked = ckbFiltroValorVenda.Checked = ckbFIltroValorPago.Checked = false;

            vendaControle.paginacao.paginaAtual = 1;
            cmbPaginas.SelectedIndex = 0;

            carregarRegistros();
        }

        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            listaProdutos.Clear();
            statusMsg.Text = "Atualizando listagem de vendas...";
            statusMsg.BackColor = Color.Green;
            this.Refresh();
            string filtro = "";

            string.Format("{0} like '%{1}%'", "cliente", txbPesquisa.Text);
            if (ckbFiltroData.Checked)
            {
                if (dtDe.Value > dtAte.Value)
                {
                    statusMsg.Text = "Impossivel realizar filtros com datas informadas...";
                    return;
                }
                else
                {
                    filtro = string.Format("({0} >= '{1}') AND ({2} <= '{3}')", "dataVenda", dtDe.Value, "dataVenda", dtAte.Value);
                }
            }

            if (ckbFiltroNome.Checked)
            {
                if (ckbFiltroData.Checked)
                {
                    filtro += " AND ";
                }
                if (txbPesquisa.Equals(""))
                {
                    statusMsg.Text = "Nenhum nome informado para o filtro...";
                    return;
                }
                else
                {
                    filtro += string.Format("{0} like '%{1}%'", "cliente", txbPesquisa.Text);
                }
            }

            if (ckbFiltroValorVenda.Checked)
            {
                if (numValorVenda.Value > 0)
                {
                    if (ckbFiltroData.Checked || ckbFiltroNome.Checked)
                    {
                        filtro += " AND ";
                    }
                    string operador = "=";
                    switch (cmbValorVenda.SelectedIndex)
                    {
                        //Igual
                        case 0:
                            operador = "=";
                            break;
                        //maior que
                        case 1:
                            operador = ">";
                            break;
                        // maior ou igual
                        case 2:
                            operador = ">=";
                            break;
                        //menor que
                        case 3:
                            operador = "<";
                            break;
                        //menor ou igual
                        case 4:
                            operador = "<=";
                            break;
                        //diferente
                        case 5:
                            operador = "!=";
                            break;
                    }
                    filtro += "valorVenda " + operador + " '" + Convert.ToString(numValorVenda.Value) + "'";
                }
            }

            if (ckbFIltroValorPago.Checked)
            {
                if (numValorPago.Value > 0)
                {
                    if (ckbFiltroData.Checked || ckbFiltroNome.Checked || ckbFiltroValorVenda.Checked)
                    {
                        filtro += " AND ";
                    }
                    string operador = "=";
                    switch (cmbValorPago.SelectedIndex)
                    {
                        //Igual
                        case 0:
                            operador = "=";
                            break;
                        //maior que
                        case 1:
                            operador = ">";
                            break;
                        // maior ou igual
                        case 2:
                            operador = ">=";
                            break;
                        //menor que
                        case 3:
                            operador = "<";
                            break;
                        //menor ou igual
                        case 4:
                            operador = "<=";
                            break;
                        //diferente
                        case 5:
                            operador = "!=";
                            break;
                    }
                    filtro += "valorPago " + operador + " '" + Convert.ToString(numValorPago.Value) + "'";
                }
            }

            if (filtro.Equals(""))
            {
                statusMsg.Text = "Nenhum filtro informado";
                statusMsg.BackColor = Color.Green;
                this.Refresh();
                return;
            }

            List<Venda> lista;
            if (ckbOpcaoPesquisa.Checked)
            {
                lista = vendaControle.listarPorPaginacao(vendaControle.paginacao.primeiroRegistroPagina, vendaControle.paginacao.quantidadeRegistrosPorPagina);
            }
            else
            {
                lista = vendaControle.listarTodos();
            }

            Sistema.pesquisaDataGridView<Venda>(bindingSourceVendas, dgvVenda, lista, filtro);

            statusMsg.Text = "Filtro aplicado com sucesso!";
            statusMsg.BackColor = Color.Green;
            this.Refresh();
        }

        private void visualizarVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbFiltro.Visible = true;
            gpbLista.Visible = true;
            tbPrincipal.SelectedIndex = 1;
        }

        private void atalhosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbPrincipal.SelectedIndex = 0;
        }

        private void tbAtalhos_Click(object sender, EventArgs e)
        {
            tbPrincipal.SelectedTab = tbVendas;
            gpbFiltro.Visible = false;
            gpbLista.Visible = false;
        }

        private void tbVendas_Click(object sender, EventArgs e)
        {
            tbPrincipal.SelectedTab = tbVendas;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvEstoque.Width, this.dgvEstoque.Height);
            this.dgvEstoque.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvEstoque.Width, this.dgvEstoque.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbPrincipal.SelectedTab = tbRelatorio;
        }

        private void btnFiltrarEstoque_Click(object sender, EventArgs e)
        {
            string filtro = "";
            if (dateInicioEstoque.Value > dateFimEstoque.Value)
            {
                statusMsg.Text = "Impossivel realizar filtros com datas informadas...";
                return;
            }
            else
            {
                if(cmbData.SelectedIndex <= 0)
                    filtro = string.Format("({0} >= '{1}') AND ({2} <= '{3}')", "datahora", dateInicioEstoque.Value, "datahora", dateFimEstoque.Value);
                else
                    filtro = string.Format("({0} >= '{1}') AND ({2} <= '{3}')", "validade", dateInicioEstoque.Value, "validade", dateFimEstoque.Value);
            }
            
            historico = historicoEstoqueControle.listarTodoEstoqueValido();
            historico.Sort();
            Sistema.pesquisaDataGridView<HistoricoEstoque>(bindingSourceEstoque, dgvEstoque, historico, filtro);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            statusMsg.Text = "Atualizando estoque...";
            historico = historicoEstoqueControle.listarTodoEstoqueValido();
            historico.Sort();
            dgvEstoque.DataSource = historico;
           // chtRelatorioEstoque.DataSource = historico;
            statusMsg.Text = "Estoque atualizado!";
        }

        private void dgvEstoque_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Convert.ToBoolean(dgvEstoque.Rows[e.RowIndex].Cells["estoque_atual"].Value))
            {
                if (this.dgvEstoque.Columns[e.ColumnIndex].Name == "quantidadeEstoque")
                {
                    if (e.Value != null)
                    {
                        if (Convert.ToInt32(e.Value) == 0)
                        {
                            e.CellStyle.BackColor = pnl0.BackColor;
                        }
                        else if (Convert.ToInt32(e.Value) <= 5)
                        {
                            e.CellStyle.BackColor = pnl1.BackColor;
                        }
                        else if (Convert.ToInt32(e.Value) <= 10)
                        {
                            e.CellStyle.BackColor = pnl2.BackColor;
                        }
                        else if (Convert.ToInt32(e.Value) <= 20)
                        {
                            e.CellStyle.BackColor = pnl3.BackColor;
                        }
                        else
                        {
                            e.CellStyle.BackColor = pnl4.BackColor;
                        }
                    }
                }
                else if (this.dgvEstoque.Columns[e.ColumnIndex].Name == "datavalidade")
                {
                    if (e.Value != null)
                    {
                        if (Convert.ToDateTime(e.Value).Date.CompareTo(DateTime.Now.Date) < 0)
                        {
                            e.CellStyle.BackColor = pnl0Vencido.BackColor;
                        }
                        else if (Convert.ToDateTime(e.Value).Date.CompareTo(DateTime.Now.Date) == 0)
                        {
                            e.CellStyle.BackColor = pnl1Vencendo.BackColor;
                        }
                        else
                        {
                            e.CellStyle.BackColor = pnl2Valido.BackColor;
                        }
                    }
                }
            }

            if (this.dgvEstoque.Columns[e.ColumnIndex].Name == "estoque_atual")
            {
                if (Convert.ToBoolean(e.Value))
                {
                    e.Value = "Dado atual";
                }
                else
                {
                    e.Value = "Dado histórico";
                }
            }
        }

        private void dgvEstoque_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            historico = historicoEstoqueControle.listarTodoEstoqueValido();
            dgvEstoque.Columns[e.ColumnIndex].Tag = Convert.ToInt32(!Convert.ToBoolean(dgvEstoque.Columns[e.ColumnIndex].Tag));

            HistoricoEstoque.setOrdenacao(dgvEstoque.Columns[e.ColumnIndex].Name, Convert.ToBoolean(dgvEstoque.Columns[e.ColumnIndex].Tag));
            historico.Sort();
            dgvEstoque.DataSource = historico;
           // chtRelatorioEstoque.DataSource = historico;
        }       
    }
}