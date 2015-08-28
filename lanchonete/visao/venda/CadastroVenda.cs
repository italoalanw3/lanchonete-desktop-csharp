using projeto_escola.controle;
using projeto_escola.entidade;
using projeto_escola.modelo.entidades;
using projeto_escola.visao.venda;
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

namespace projeto_escola.visao.cadastros
{
    public partial class CadastroVenda : Form
    {
        public VendaControle vendaControle;
        public VendaProdutoControle vendaProdutosControle;
        private UsuarioControle usuarioControle;
        private AdicionarCliente formCliente;
        private AdicionarProdutos formProduto;

        private double troco = 0;
        private double total = 0;
        private double valorPago = 0;

        public CadastroVenda()
        {
            InitializeComponent();
            formProduto = new AdicionarProdutos(this);
            formCliente = new AdicionarCliente(this);
            vendaControle = new VendaControle();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            if (Sistema.usuarioLogado.superUsuario)
                formCliente.ShowDialog();
            else
            {
                lblMensagem.Visible = true;
                lblMensagem.BackColor = Color.LightCoral;
                lblMensagem.Text = "Apenas super usuários podem cadastrar vendas";
            }

        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if (Sistema.usuarioLogado.superUsuario)
                formProduto.ShowDialog();
            else
            {
                lblMensagem.Visible = true;
                lblMensagem.BackColor = Color.LightCoral;
                lblMensagem.Text = "Apenas super usuários podem cadastrar vendas";
            }
        }

        public void atualizarValores()
        {
            total = valorPago = troco = 0;
            foreach (VendaProduto v in vendaControle.vendaProdutos)
            {
                total += v.produto.preco;
            }
            txbTotalVenda.Text = total.ToString("C");

            valorPago = 0;
            if (txbValorPago.Value >= 0)
            {
                valorPago = Convert.ToDouble(txbValorPago.Value);
                troco = Convert.ToDouble(Convert.ToDouble(txbValorPago.Value) - Convert.ToDouble(total));
                txbTroco.Text = troco.ToString("C");

                //Se troco negativo, então o saldo vai ser somado ao troco;
                if (troco <= 0)
                {
                    txbTroco.ForeColor = Color.Red;
                    if (troco == 0)
                        txbTroco.ForeColor = Color.Black;
                    ckbTroco.Checked = false;
                    ckbTroco.Visible = false;
                }
                else
                {
                    txbTroco.ForeColor = Color.Blue;
                    ckbTroco.Visible = true;
                }                
            }
            txbTroco.Refresh();
        }

        private void listProdutos_ItemActivate(object sender, EventArgs e)
        {
            Produto p = (Produto)listProdutos.SelectedItems[0].Tag;
            MessageBox.Show("Produto: "+p.nome+"\nPreço: R$ " + p.preco+"\nQuantidade na venda: "+p.quantidadeEstoque+"\nDetalhes: "+p.descricao, p.nome);
        }

        private bool vendaValida(bool exibeMensagem)
        {
            errorProvider.Clear();
            bool vendaValida = true;
            if (vendaControle.entidade.usuario == null)
            {
                vendaValida = false;
                lblMensagem.Visible = true;
                lblMensagem.BackColor = Color.LightCoral;
                errorProvider.SetError(txbCliente, "Informe um cliente");
                if (exibeMensagem)
                    lblMensagem.Text = "Nenhum cliente informado, por favor adicione um cliente à venda";

                return false;
            }

            if (vendaControle.vendaProdutos.Count() == 0)
            {
                vendaValida = false;
                lblMensagem.Visible = true;
                lblMensagem.BackColor = Color.LightCoral;
                errorProvider.SetError(listProdutos, "Adicione pelo menos um produto à venda");
                if (exibeMensagem)
                    lblMensagem.Text = "Nenhum produto foi adicionado";
                   
                return false;
            }

            return vendaValida;
        }
        
        private void btnConfirmarVenda_Click(object sender, EventArgs e)
        {
            btnConfirmarVenda.Enabled = false;
            if (Sistema.usuarioLogado.superUsuario)
            {
                if (vendaValida(true))
                {
                    if (MessageBox.Show("Deseja confirmar a venda agora?", "Conrfirmar nova venda", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            usuarioControle = new UsuarioControle();
                            usuarioControle.entidade = vendaControle.entidade.usuario;
                            //Continuar com o procedimento da venda...
                            if (ckbTroco.Visible)
                            {
                                if (ckbTroco.Checked)
                                {
                                    //Incrementar o troco ao saldo do usuário da venda, pois ele deixou saldo positivo.                    
                                    usuarioControle.entidade.saldo += troco;
                                    usuarioControle.editar(usuarioControle.entidade);
                                } // else, despreza o saldo, ou seja, não faz nada...
                            }
                            else
                            {
                                //Incrementar o troco ao saldo do usuário, pois ele ficou devendo ou não teve troco...
                                usuarioControle.entidade.saldo += troco;
                                usuarioControle.editar(usuarioControle.entidade);
                            }

                            // 1º Passo da venda: cadastrar a venda com o usuário que realizou a compra...
                            this.vendaControle.entidade.dataVenda = DateTime.Now;
                            this.vendaControle.entidade.valorVenda = this.total;
                            this.vendaControle.entidade.valorPago = this.valorPago;
                            this.vendaControle.entidade.troco = this.troco;
                            this.vendaControle.entidade.trocoComoSaldo = ckbTroco.Checked;                            

                            //
                            vendaProdutosControle = new VendaProdutoControle();
                            foreach (VendaProduto vp in this.vendaControle.vendaProdutos)
                            {
                                vendaProdutosControle.salvar(vp);
                            }


                            this.vendaControle.entidade.cadastradaComSucesso = true;
                            this.vendaControle.editar(this.vendaControle.entidade);

                            lblMensagem.Visible = true;
                            lblMensagem.BackColor = Color.Green;
                            lblMensagem.Text = "Venda confirmada e salva com sucesso";

                            if (MessageBox.Show("Deseja limpar os campos e deixar pronto para uma nova venda?", "Confirmar limpeza de campos para nova venda", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                            {
                                limparCampos();
                            }
                        }
                        catch (Exception ex)
                        {
                            lblMensagem.Visible = true;
                            lblMensagem.BackColor = Color.LightCoral;
                            lblMensagem.Text = "Não foi possivel confirmar a venda: " + ex.Message;
                        }
                    }
                    else
                    {
                        btnConfirmarVenda.Enabled = true;
                    }
                }
                else
                {
                    btnConfirmarVenda.Enabled = true;
                }
            }
            else
            {
                lblMensagem.Visible = true;
                lblMensagem.BackColor = Color.LightCoral;
                lblMensagem.Text = "Apenas super usuários podem cadastrar vendas";
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
            habilitarCampos();
            this.vendaControle.entidade.cadastradaComSucesso = false;
            this.vendaControle.entidade.usuario = Sistema.usuarioLogado;
            this.vendaControle.entidade = this.vendaControle.salvarRetornandoEntidadeNova(this.vendaControle.entidade); 
        }

        private void habilitarCampos()
        {
            txbValorPago.Enabled = true;
            listProdutos.Enabled = true;
            btnAdicionarCliente.Enabled = true;
            btnAdicionarProduto.Enabled = true;
            btnFechar.Enabled = true;
            btnValidarVenda.Enabled = true;
        }

        private void limparCampos()
        {
            vendaControle = new VendaControle();
            vendaProdutosControle = new VendaProdutoControle();
            usuarioControle = new UsuarioControle();

            listProdutos.Clear();

            txbCliente.Text = "...nenhum cliente informado!";
            txbTotalVenda.Text = 0.ToString("C");
            txbTroco.Text = 0.ToString("C");
            txbValorPago.Value = 0;           

            btnConfirmarVenda.Enabled = true;
            Refresh();
        }

        private void lblMensagem_MouseClick(object sender, MouseEventArgs e)
        {
            lblMensagem.Visible = false;
            lblMensagem.Text = "";
        }

        private void btnValidarVenda_Click(object sender, EventArgs e)
        {
            if (vendaValida(false))
            {
                lblMensagem.Visible = true;
                lblMensagem.BackColor = Color.GreenYellow;
                lblMensagem.Text = "Venda validada com sucesso.";
            }
            else
            {
                lblMensagem.Visible = true;
                lblMensagem.BackColor = Color.LightCoral;
                lblMensagem.Text = "Venda inválida, verifique as marcações nos campos.";
            }
        }

        private void txbValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            //atualizarValores();
        }

        private void txbValorPago_ValueChanged(object sender, EventArgs e)
        {
            if (txbTotalVenda.Text == 0.ToString("C") && txbValorPago.Value == 0) 
                return;
            
            atualizarValores();
        }

        private void listProdutos_DoubleClick(object sender, EventArgs e)
        {
            /*
            ListViewItem item = new ListViewItem();
            item.Text = produto.nome;
            item.Tag = produto;
             */
            if (MessageBox.Show("Deseja realmente remover " + ((Produto)listProdutos.SelectedItems[0].Tag).nome+ " da venda?", "Confirmar remoção de produto", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                vendaControle.vendaProdutos.RemoveAt(listProdutos.SelectedItems[0].Index);
                listProdutos.Items.RemoveAt(listProdutos.SelectedItems[0].Index);
                atualizarValores();
            }
        }

        private void btnValidarVenda_Click_1(object sender, EventArgs e)
        {

        }
    }
}
