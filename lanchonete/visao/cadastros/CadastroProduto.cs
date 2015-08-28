using NHibernate.Mapping;
using projeto_escola.controle;
using projeto_escola.entidade;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_escola.visao.cadastros
{   

    public partial class CadastroProduto : Form
    {
        public class QuantidadeAlterada
        {
            public static int quantidadeAntiga { get; set; }
            public static int quantidadeNova { get; set; }

            public static bool isAlterado()
            {
                return quantidadeAntiga != quantidadeNova;
            }
        }

        ProdutoControle produtoControle;
        HistoricoEstoqueControle historicoControle;

        public CadastroProduto()
        {
            InitializeComponent();
            produtoControle = new ProdutoControle();
            historicoControle = new HistoricoEstoqueControle();

            produtoControle.paginacao.quantidadeTotalRegistros = produtoControle.quantidadeRegistros();
            txbTotalRegistros.Text = "Total de registros:" + produtoControle.paginacao.quantidadeTotalRegistros;

            cmbPaginas.Items.Clear();
            for (int i = 0; i < produtoControle.paginacao.quantidadePaginas; i++)
            {
                cmbPaginas.Items.Add(i + 1);
            }

            if (cmbPaginas.Items.Count == 0 || cmbLinhasVisiveis.Items.Count == 0) return;

            cmbLinhasVisiveis.SelectedIndex = 0;
            cmbPaginas.SelectedIndex = 0;

            carregarRegistros();

            this.dgvProdutos.Columns["colPreco"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        public void carregarRegistros()
        {
            dgvProdutos.DataSource = produtoControle.listarPorPaginacao(produtoControle.paginacao.primeiroRegistroPagina, produtoControle.paginacao.quantidadeRegistrosPorPagina);
            produtoControle.paginacao.quantidadeTotalRegistros = produtoControle.quantidadeRegistros();
            txbTotalRegistros.Text = "Total de registros:" + produtoControle.paginacao.quantidadeTotalRegistros;
        }

        public void limparCampos()
        {
            produtoControle.entidade.id = -1;
            txbNome.Text = "";
            txbDescricao.Text = "";
            numPreco.Value = 0;
            numQuantidade.Value = 0;
            validade.Value = DateTime.Now;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int codigoProdutoBackup = produtoControle.entidade.id;
            if (Sistema.campoIsNull(txbNome.Text))
            {
                errorProvider.SetError(txbNome, "Informe o nome do produto");
                return;
            }
            if (Sistema.campoIsNull(txbDescricao.Text))
            {
                errorProvider.SetError(txbDescricao, "Informe algum detalhe do produto");
                return;
            }
            if (Sistema.numeroInvalido(Convert.ToString(numPreco.Value)))
            {
                errorProvider.SetError(numPreco, "Informe o preço do produto");
                return;
            }

            try
            {
                produtoControle.entidade.nome = txbNome.Text;
                produtoControle.entidade.descricao = txbDescricao.Text;
                produtoControle.entidade.preco = Convert.ToDouble(numPreco.Value);
                produtoControle.entidade.validade = validade.Value;
                produtoControle.entidade.quantidadeEstoque = Convert.ToInt32(numQuantidade.Value);

                if (produtoControle.entidade.id <= 0)
                {
                    historicoControle.entidade.buildValues(produtoControle.salvarRetornandoEntidadeNova(produtoControle.entidade));
                    historicoControle.salvar(historicoControle.entidade);
                }
                else
                {
                    produtoControle.editar(produtoControle.entidade);
                    QuantidadeAlterada.quantidadeAntiga = produtoControle.entidade.quantidadeEstoque;

                    if(QuantidadeAlterada.isAlterado())
                    {
                        historicoControle.entidade.buildValues(produtoControle.entidade);
                        historicoControle.salvar(historicoControle.entidade);
                    }
                }

                lblMensagem.Visible = true;
                lblMensagem.Text = "Produto salvo com sucesso!";
                lblMensagem.BackColor = Color.GreenYellow;

                limparCampos();
                carregarRegistros();
            }
            catch (Exception ex)
            {
                produtoControle.entidade.id = codigoProdutoBackup;
                lblMensagem.Visible = true;
                lblMensagem.Text = "Erro ao salvar produto: " + ex.Message;
                lblMensagem.BackColor = Color.LightCoral;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.RowCount > 0)
                {
                    produtoControle.entidade.id = Convert.ToInt32(dgvProdutos.CurrentRow.Cells[0].Value);
                    produtoControle.entidade = produtoControle.selecionar(produtoControle.entidade.id);
                    if (MessageBox.Show("Deseja realmente apagar o produto: " + produtoControle.entidade.nome + "?", "Confirmar exclusão de produto", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        produtoControle.deletar(produtoControle.entidade);

                        lblMensagem.Visible = true;
                        lblMensagem.Text = "Produto apagado com sucesso!";
                        lblMensagem.BackColor = Color.GreenYellow;

                        carregarRegistros();
                    }
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Visible = true;
                lblMensagem.Text = "Erro ao apagar produto: " + ex.Message;
                lblMensagem.BackColor = Color.LightCoral;
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                try
                {
                    produtoControle.entidade.id = Convert.ToInt32(dgvProdutos.CurrentRow.Cells[0].Value);
                    produtoControle.entidade = produtoControle.selecionar(produtoControle.entidade.id);

                    txbNome.Text = produtoControle.entidade.nome;
                    txbDescricao.Text = produtoControle.entidade.descricao;

                    numPreco.Value = Convert.ToDecimal(produtoControle.entidade.preco);
                    numQuantidade.Value = Convert.ToInt32(produtoControle.entidade.quantidadeEstoque);

                    lblMensagem.Visible = true;
                    lblMensagem.Text = "Produto pronto para edição...";
                    lblMensagem.BackColor = Color.GreenYellow;
                }
                catch (Exception ex)
                {
                    lblMensagem.Visible = true;
                    lblMensagem.Text = "Exceção ao selecionar dados para edição: " + ex.Message;
                    lblMensagem.BackColor = Color.LightCoral;
                }
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
            if (cmbPaginas.Items.Count == 0 || cmbLinhasVisiveis.Items.Count == 0) return;

            produtoControle.paginacao.paginaAtual = 1;
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
            if (cmbPaginas.Items.Count == 0) return;
            if (produtoControle.quantidadeRegistros() == 0) return;
            produtoControle.paginacao.paginaAtual = 1;
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
            if (txbPesquisa.Text.Contains("Digite aqui o nome do produto para pesquisar..."))
            {
                txbPesquisa.Text = "";
            }
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txbPesquisa.Text.Contains("Digite aqui o nome do produto para pesquisar...") || txbPesquisa.Text.Equals("")) return;
            List<Produto> lista = produtoControle.listarTodos();
            if (ckbOpcaoPesquias.Checked)
            {
                lista = produtoControle.listarPorPaginacao(produtoControle.paginacao.primeiroRegistroPagina, produtoControle.paginacao.quantidadeRegistrosPorPagina);
            }

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
            if (txbPesquisa.Text.Equals(""))
            {
                txbPesquisa.Text = "Digite aqui o nome do produto para pesquisar...";
            }
        }

        private void lblMensagem_MouseDown(object sender, MouseEventArgs e)
        {
            lblMensagem.Visible = false;
            lblMensagem.Text = "";
        }

        private void btnNovoReferencia_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                try
                {
                    produtoControle.entidade = (Produto)dgvProdutos.CurrentRow.DataBoundItem; ; ;

                    txbNome.Text = produtoControle.entidade.nome;
                    txbDescricao.Text = produtoControle.entidade.descricao;

                    numPreco.Value = Convert.ToDecimal(produtoControle.entidade.preco);
                    produtoControle.entidade.id = -1;

                    lblMensagem.Visible = true;
                    lblMensagem.Text = "Um novo produto está pronto para ser cadastrado.";
                    lblMensagem.BackColor = Color.GreenYellow;
                }
                catch (Exception ex)
                {
                    lblMensagem.Visible = true;
                    lblMensagem.Text = "Exceção ao selecionar dados para cadastrar como referência: " + ex.Message;
                    lblMensagem.BackColor = Color.LightCoral;
                }
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProdutos.Columns["btnEditarProduto"].Index)
            {
                if (dgvProdutos.RowCount > 0)
                {
                    try
                    {
                        produtoControle.entidade = (Produto)dgvProdutos.CurrentRow.DataBoundItem;

                        txbNome.Text = produtoControle.entidade.nome;
                        txbDescricao.Text = produtoControle.entidade.descricao;

                        numPreco.Value = Convert.ToDecimal(produtoControle.entidade.preco);
                        validade.Value = produtoControle.entidade.validade;
                        numQuantidade.Value = Convert.ToInt32(produtoControle.entidade.quantidadeEstoque);

                        QuantidadeAlterada.quantidadeAntiga = produtoControle.entidade.quantidadeEstoque;

                        lblMensagem.Visible = true;
                        lblMensagem.Text = "Produto pronto para edição...";
                        lblMensagem.BackColor = Color.GreenYellow;
                    }
                    catch (Exception ex)
                    {
                        lblMensagem.Visible = true;
                        lblMensagem.Text = "Exceção ao selecionar dados para edição: " + ex.Message;
                        lblMensagem.BackColor = Color.LightCoral;
                    }
                }
            }
            if (e.ColumnIndex == dgvProdutos.Columns["btnDeletarProduto"].Index)
            {
                try
                {
                    if (dgvProdutos.RowCount > 0)
                    {
                        produtoControle.entidade = (Produto)dgvProdutos.CurrentRow.DataBoundItem;
                        if (MessageBox.Show("Deseja realmente apagar o produto: " + produtoControle.entidade.nome + "?", "Confirmar exclusão de produto", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            produtoControle.deletar(produtoControle.entidade);

                            lblMensagem.Visible = true;
                            lblMensagem.Text = "Produto apagado com sucesso!";
                            lblMensagem.BackColor = Color.GreenYellow;

                            carregarRegistros();
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Visible = true;
                    lblMensagem.Text = "Erro ao apagar produto: " + ex.Message;
                    lblMensagem.BackColor = Color.LightCoral;
                }
            }
        }
    }
}
