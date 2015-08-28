using projeto_escola.controle;
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
    public partial class AdicionarCliente : Form
    {
        UsuarioControle usuarioControle;
        CadastroVenda formVenda;

        public AdicionarCliente(CadastroVenda venda)
        {
            this.formVenda = venda;

            InitializeComponent();
            usuarioControle = new UsuarioControle();

            usuarioControle.paginacao.quantidadeTotalRegistros = usuarioControle.quantidadeRegistros();

            cmbPaginas.Items.Clear();
            for (int i = 0; i < usuarioControle.paginacao.quantidadePaginas; i++)
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
            dgvUsuarios.DataSource = usuarioControle.listarPorPaginacao(usuarioControle.paginacao.primeiroRegistroPagina, usuarioControle.paginacao.quantidadeRegistrosPorPagina);
            usuarioControle.paginacao.quantidadeTotalRegistros = usuarioControle.quantidadeRegistros();
        }

        public void limparCampos()
        {
            usuarioControle.entidade.id = -1;
        }
        private void adicionarCliente()
        {
            try
            {
                if (dgvUsuarios.RowCount > 0)
                {
                    usuarioControle.entidade.id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
                    usuarioControle.entidade = usuarioControle.selecionar(usuarioControle.entidade.id);
                    formVenda.vendaControle.entidade.usuario = usuarioControle.entidade;

                    formVenda.txbCliente.Text = usuarioControle.entidade.nome;
                    formVenda.txbCliente.Refresh();
                    lblMensagem.BackColor = Color.GreenYellow;
                    lblMensagem.Visible = false;
                    lblMensagem.Text = "";
                    Close();
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Visible = true;
                lblMensagem.BackColor = Color.LightCoral;
                lblMensagem.Text = "Erro ao adicionar cliente: " + ex.Message;
            }
        }
        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            adicionarCliente();   
        }

        private void cmbLinhasVisiveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            usuarioControle.paginacao.quantidadeRegistrosPorPagina = Convert.ToInt32(cmbLinhasVisiveis.Text);

            cmbPaginas.Items.Clear();
            for (int i = 1; i <= usuarioControle.paginacao.quantidadePaginas; i++)
            {
                cmbPaginas.Items.Add(i);
            }

            if (cmbPaginas.Items.Count == 0 || cmbLinhasVisiveis.Items.Count == 0) return;
            usuarioControle.paginacao.paginaAtual = 1;
            cmbPaginas.SelectedIndex = 0;

            carregarRegistros();
        }

        private void cmbPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaginas.Text.Equals("")) return;
            if (usuarioControle.quantidadeRegistros() == 0) return;
            usuarioControle.paginacao.paginaAtual = Convert.ToInt32(cmbPaginas.Text);

            carregarRegistros();
        }

        private void btnPrimeiraPagina_Click(object sender, EventArgs e)
        {
            usuarioControle.paginacao.paginaAtual = 1;
            cmbPaginas.SelectedIndex = 0;

            carregarRegistros();
        }

        private void btnPaginaAnterior_Click(object sender, EventArgs e)
        {
            if (usuarioControle.paginacao.paginaAtual == 1) return;
            if (usuarioControle.quantidadeRegistros() == 0) return;

            usuarioControle.paginacao.paginaAtual = usuarioControle.paginacao.paginaAtual - 1;
            // O index é a página atual menos um
            cmbPaginas.SelectedIndex = usuarioControle.paginacao.paginaAtual - 1;

            carregarRegistros();
        }

        private void btnProximaPagina_Click(object sender, EventArgs e)
        {
            if (usuarioControle.paginacao.paginaAtual == usuarioControle.paginacao.quantidadePaginas) return;
            if (usuarioControle.quantidadeRegistros() == 0) return;

            usuarioControle.paginacao.paginaAtual = usuarioControle.paginacao.paginaAtual + 1;
            // O index é a página atual menos um
            cmbPaginas.SelectedIndex = usuarioControle.paginacao.paginaAtual - 1;

            carregarRegistros();
        }

        private void btnUltimaPagina_Click(object sender, EventArgs e)
        {
            if (usuarioControle.quantidadeRegistros() == 0) return;
            usuarioControle.paginacao.paginaAtual = usuarioControle.paginacao.quantidadePaginas;
            cmbPaginas.SelectedIndex = usuarioControle.paginacao.paginaAtual - 1;

            carregarRegistros();
        }

        private void txbPesquisaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txbPesquisaCliente_TextChanged(object sender, EventArgs e)
        {
            if (txbPesquisaCliente.Text.Equals("")) return;
            List<Usuario> lista = usuarioControle.listarTodos();

            if (Sistema.pesquisaDataGridView<Usuario>(bindingSource, dgvUsuarios, lista, string.Format("{0} like '%{1}%'", "nome", txbPesquisaCliente.Text)))
            {
                lblMensagem.Visible = false;
                lblMensagem.Text = "";
            }
            else
            {
                lblMensagem.Visible = true;
                lblMensagem.Text = "Nenhum cliente encontrado para pesquisa...";
                lblMensagem.BackColor = Color.LightGoldenrodYellow;

                bindingSource.RemoveFilter();
            }
        }

        private void txbPesquisaCliente_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void lblMensagem_MouseClick(object sender, MouseEventArgs e)
        {
            lblMensagem.Visible = false;
            lblMensagem.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMensagem.Visible = false;
            lblMensagem.Text = "";
            Close();
        }
    }
}
