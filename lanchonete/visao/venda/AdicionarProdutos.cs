using projeto_escola.controle;
using projeto_escola.entidade;
using projeto_escola.modelo.entidades;
using projeto_escola.visao.cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_escola.visao.venda
{
    public partial class AdicionarProdutos : Form
    {
        ProdutoControle produtoControle;
        HistoricoEstoqueControle historicoEstoque;
        CadastroVenda formVenda;

        public AdicionarProdutos(CadastroVenda venda)
        {
            this.formVenda = venda;

            InitializeComponent();
            produtoControle = new ProdutoControle();
            historicoEstoque = new HistoricoEstoqueControle();

            produtoControle.paginacao.quantidadeTotalRegistros = produtoControle.quantidadeRegistros();

            cmbPaginas.Items.Clear();
            for (int i = 0; i < produtoControle.paginacao.quantidadePaginas; i++)
            {
                cmbPaginas.Items.Add(i + 1);
            }

            if (cmbPaginas.Items.Count == 0 || cmbLinhasVisiveis.Items.Count == 0) return;

            cmbLinhasVisiveis.SelectedIndex = 0;
            cmbPaginas.SelectedIndex = 0;

            carregarRegistros();
        }

        public void carregarRegistros()
        {
            dgvProdutos.DataSource = produtoControle.listarPorPaginacao(produtoControle.paginacao.primeiroRegistroPagina, produtoControle.paginacao.quantidadeRegistrosPorPagina);
            produtoControle.paginacao.quantidadeTotalRegistros = produtoControle.quantidadeRegistros();
        }

        public void limparCampos()
        {
            produtoControle.entidade.id = -1;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.RowCount > 0)
                {
                    int quantidade = 0;
                    try
                    {
                        quantidade = Convert.ToInt32(txbQuantidade.Text);
                        if (quantidade <= 0)
                        {
                            lblMensagem.Visible = true;
                            lblMensagem.BackColor = Color.LightCoral;
                            lblMensagem.Text = "A quantidade deve ser maior que 0 (zero).";
                            return;
                        }
                        Produto produtoTemp = new Produto();
                        produtoControle.entidade.id = Convert.ToInt32(dgvProdutos.CurrentRow.Cells[0].Value);
                        produtoTemp = produtoControle.selecionar(produtoControle.entidade.id);
                        if (quantidade > produtoTemp.quantidadeEstoque)
                        {
                            lblMensagem.Visible = true;
                            lblMensagem.BackColor = Color.LightCoral;
                            lblMensagem.Text = "A quantidade deve ser menor ou igual que o estoque.";
                            return;
                        }
                        if (produtoTemp.quantidadeEstoque == 0)
                        {
                            lblMensagem.Visible = true;
                            lblMensagem.BackColor = Color.LightCoral;
                            lblMensagem.Text = "Não existe esse produto em estoque";
                            return;
                        }
                    }
                    catch(Exception){
                        lblMensagem.Visible = true;
                        lblMensagem.BackColor = Color.LightCoral;
                        lblMensagem.Text = "Informe uma quantidade válida (Um valor inteiro e maior que 0).";
                    }
                                        
                    Produto produto = new Produto();
                    produtoControle.entidade.id = Convert.ToInt32(dgvProdutos.CurrentRow.Cells[0].Value);
                    produto = produtoControle.selecionar(produtoControle.entidade.id);
                    // Atualizar estoque do produto
                    produto.quantidadeEstoque = produto.quantidadeEstoque - quantidade;
                    // Atualizar estoque do produto no BANCO
                    produtoControle.editar(produto);

                    //Inserir histórico
                    historicoEstoque.entidade.buildValues(produto);
                    historicoEstoque.salvar(historicoEstoque.entidade);

                    VendaProduto vendaProduto = new VendaProduto();
                    vendaProduto.produto = produto;
                    vendaProduto.quantidadeProdutosVenda = quantidade;
                    vendaProduto.venda = formVenda.vendaControle.entidade;

                    formVenda.vendaControle.vendaProdutos.Add(vendaProduto);
                    ListViewItem item = new ListViewItem();
                    item.Text = produto.nome;
                    produto.quantidadeEstoque = quantidade;
                    item.Tag = produto;
                    formVenda.listProdutos.Items.Add(item);
                        
                    lblMensagem.Text = "Adicionado: " + Convert.ToString(quantidade) + " " + produto.nome + " na venda. Pressione ESC para fechar";

                    carregarRegistros();
                    lblMensagem.BackColor = Color.GreenYellow;
                    lblMensagem.Visible = true;                   
                    
                    formVenda.listProdutos.Refresh();
                    formVenda.txbCliente.Refresh();

                    formVenda.atualizarValores();

                    txbQuantidade.Text = "1";
                    txbPesquisa.Text = "";
                    txbPesquisa.Focus();
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Visible = true;
                lblMensagem.BackColor = Color.LightCoral;
                lblMensagem.Text = "Erro ao adicionar produto: "+ex.Message;
            }
        }

        private void cmbLinhasVisiveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            produtoControle.paginacao.quantidadeRegistrosPorPagina = Convert.ToInt32(cmbLinhasVisiveis.Text);

            cmbPaginas.Items.Clear();
            for (int i = 1; i <= produtoControle.paginacao.quantidadePaginas; i++)
            {
                cmbPaginas.Items.Add(i);
            }

            produtoControle.paginacao.paginaAtual = 1;

            if (cmbPaginas.Items.Count == 0 || cmbLinhasVisiveis.Items.Count == 0) return;
            cmbPaginas.SelectedIndex = 0;

            carregarRegistros();
        }

        private void cmbPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaginas.Text.Equals("")) return;
            produtoControle.paginacao.paginaAtual = Convert.ToInt32(cmbPaginas.Text);

            carregarRegistros();
        }

        private void btnPrimeiraPagina_Click(object sender, EventArgs e)
        {
            produtoControle.paginacao.paginaAtual = 1;
            if (produtoControle.quantidadeRegistros() == 0) return;

            if (cmbPaginas.Items.Count == 0 || cmbLinhasVisiveis.Items.Count == 0) return;
            cmbPaginas.SelectedIndex = 0;

            carregarRegistros();
        }

        private void btnPaginaAnterior_Click(object sender, EventArgs e)
        {
            if (produtoControle.paginacao.paginaAtual == 1) return;
            if (produtoControle.quantidadeRegistros() == 0) return;

            produtoControle.paginacao.paginaAtual = produtoControle.paginacao.paginaAtual - 1;
            // O index é a página atual menos um
            cmbPaginas.SelectedIndex = produtoControle.paginacao.paginaAtual - 1;

            carregarRegistros();
        }

        private void btnProximaPagina_Click(object sender, EventArgs e)
        {
            if (produtoControle.paginacao.paginaAtual == produtoControle.paginacao.quantidadePaginas) return;
            if (produtoControle.quantidadeRegistros() == 0) return;

            produtoControle.paginacao.paginaAtual = produtoControle.paginacao.paginaAtual + 1;
            // O index é a página atual menos um
            cmbPaginas.SelectedIndex = produtoControle.paginacao.paginaAtual - 1;

            carregarRegistros();
        }

        private void btnUltimaPagina_Click(object sender, EventArgs e)
        {
            produtoControle.paginacao.paginaAtual = produtoControle.paginacao.quantidadePaginas;
            if (produtoControle.quantidadeRegistros() == 0) return;
            cmbPaginas.SelectedIndex = produtoControle.paginacao.paginaAtual - 1;

            carregarRegistros();
        }

        private void txbPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txbPesquisa.Text.Equals("")) return;
            List<Produto> lista = produtoControle.listarTodos();

            if (Sistema.pesquisaDataGridView<Produto>(bindingSource, dgvProdutos, lista, string.Format("{0} like '%{1}%'", "nome", txbPesquisa.Text)))
            {
                lblMensagem.Visible = false;
                lblMensagem.Text = "";
            }
            else
            {
                lblMensagem.Visible = true;
                lblMensagem.Text = "Nenhum produto encontrado para pesquisa...";
                lblMensagem.BackColor = Color.LightGoldenrodYellow;

                bindingSource.RemoveFilter();
            }
        }

        private void txbPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void AdicionarProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void lblMensagem_MouseClick(object sender, MouseEventArgs e)
        {
            lblMensagem.Visible = false;
            lblMensagem.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdicionarProdutos_Load(object sender, EventArgs e)
        {
            txbQuantidade.Text = "1";
            carregarRegistros();
        }
    }
}
