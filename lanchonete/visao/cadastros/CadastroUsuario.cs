using projeto_escola.controle;
using projeto_escola.modelo.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_escola.visao.cadastros
{
    public partial class CadastroUsuario : Form
    {
        UsuarioControle usuarioControle;

        public CadastroUsuario()
        {
            InitializeComponent();
            usuarioControle = new UsuarioControle();

            usuarioControle.paginacao.quantidadeTotalRegistros = usuarioControle.quantidadeRegistros();
            txbTotalRegistros.Text = "Total de registros:" + usuarioControle.paginacao.quantidadeTotalRegistros;

            cmbPaginas.Items.Clear();
            for (int i = 0; i < usuarioControle.paginacao.quantidadePaginas; i++)
            {
                cmbPaginas.Items.Add(i + 1);
            }

            cmbLinhasVisiveis.SelectedIndex = 0;
            cmbPaginas.SelectedIndex = 0;

            carregarRegistros();

            this.dgvUsuarios.Columns["saldo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvUsuarios.Columns["id"].DisplayIndex = 0;
            dgvUsuarios.Columns["nome"].DisplayIndex = 1;
            dgvUsuarios.Columns["documentoIdentificador"].DisplayIndex = 2;
            dgvUsuarios.Columns["saldo"].DisplayIndex = 3;
            dgvUsuarios.Columns["debitar_saldo"].DisplayIndex = 4;
            dgvUsuarios.Columns["possuiAcesso"].DisplayIndex = 5;            
            dgvUsuarios.Columns["login"].DisplayIndex = 6;
            dgvUsuarios.Columns["senha"].Visible = false;
            dgvUsuarios.Columns["superUsuario"].DisplayIndex = 7;
            dgvUsuarios.Columns["btnEditarUsuario"].DisplayIndex = 8;
            dgvUsuarios.Columns["btnDeletarUsuario"].DisplayIndex = 9;
        }

        public void carregarRegistros()
        {
            dgvUsuarios.DataSource = usuarioControle.listarPorPaginacao(usuarioControle.paginacao.primeiroRegistroPagina, usuarioControle.paginacao.quantidadeRegistrosPorPagina);
            usuarioControle.paginacao.quantidadeTotalRegistros = usuarioControle.quantidadeRegistros();
            txbTotalRegistros.Text = "Total de registros:" + usuarioControle.paginacao.quantidadeTotalRegistros;
        }

        public void limparCampos()
        {
            usuarioControle.entidade.id = -1;
            usuarioControle.entidade.saldo = 0;
            txbNome.Text = "";
            txbDocumentoIdentificador.Text = "";
            txbSenha.Text = "";
            txbLogin.Text = "";
            ckbPossuiAcesso.Checked = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            // Salva o código para se tentar salvar e aconteça algum erro, não tentar fazer update na próxima vez.
            int codigoUsuarioBackup = usuarioControle.entidade.id; 
            if (Sistema.campoIsNull(txbNome.Text))
            {
                errorProvider.SetError(txbNome, "Informe o nome");
                return;
            }
            if (Sistema.campoIsNull(txbDocumentoIdentificador.Text))
            {
                errorProvider.SetError(txbDocumentoIdentificador, "Informe algum documento que identifique o usuário/cliente");
                return;
            }

            if (ckbPossuiAcesso.Checked)
            {
                if (Sistema.campoIsNull(txbLogin.Text))
                {
                    errorProvider.SetError(txbLogin, "Informe o login para acessar o sistema");
                    return;
                }
                if (Sistema.campoIsNull(txbSenha.Text))
                {
                    errorProvider.SetError(txbSenha, "Informe a senha para acessar o sistema");
                    return;
                }
            }

            try
            {
                usuarioControle.entidade.nome = txbNome.Text;
                usuarioControle.entidade.documentoIdentificador = txbDocumentoIdentificador.Text;
                usuarioControle.entidade.possuiAcesso = ckbPossuiAcesso.Checked;

                if (usuarioControle.entidade.possuiAcesso)
                {
                    usuarioControle.entidade.login = txbLogin.Text;

                    using(MD5 md5 = MD5.Create())
                    {
                        usuarioControle.entidade.senha = txbSenha.Text;
                        string senhaCriptografada = Sistema.GetMd5Hash(md5, usuarioControle.entidade.senha);

                        usuarioControle.entidade.senha = senhaCriptografada;
                    }

                    if(ckbSuperUsuario.Checked)
                    {
                        if (Sistema.usuarioLogado.superUsuario)
                        {
                            usuarioControle.entidade.superUsuario = ckbSuperUsuario.Checked;
                        }
                        else
                        {
                            lblMensagem.Visible = true;
                            lblMensagem.Text = "Apenas super usuários podem cadastrar super usuários! Contate o administrador do sistema.";
                            lblMensagem.BackColor = Color.LightCoral;
                            return;
                        }
                    }
                    else
                    {
                        usuarioControle.entidade.superUsuario = false;
                    }
                }
                else
                {
                    usuarioControle.entidade.login = "";
                    usuarioControle.entidade.senha = "";
                    usuarioControle.entidade.superUsuario = false;
                    usuarioControle.entidade.possuiAcesso = false;
                }


                if (usuarioControle.entidade.id <= 0)
                {
                    usuarioControle.salvar(usuarioControle.entidade);
                }
                else
                {
                    usuarioControle.editar(usuarioControle.entidade);
                }

                lblMensagem.Visible = true;
                lblMensagem.Text = "Usuário/cliente salvo com sucesso!";
                lblMensagem.BackColor = Color.GreenYellow;

                limparCampos();
                carregarRegistros();
            }
            catch (Exception ex)
            {
                usuarioControle.entidade.id = codigoUsuarioBackup; 
                lblMensagem.Visible = true;
                lblMensagem.Text = "Erro ao salvar usuário/cliente: " + ex.Message;
                lblMensagem.BackColor = Color.LightCoral;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.RowCount > 0)
                {
                    usuarioControle.entidade.id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
                    usuarioControle.entidade = usuarioControle.selecionar(usuarioControle.entidade.id);
                    if (MessageBox.Show("Deseja realmente apagar o usuário/cliente: " + usuarioControle.entidade.nome + "?", "Confirmar exclusão de usuário/cliente", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        usuarioControle.deletar(usuarioControle.entidade);

                        lblMensagem.Visible = true;
                        lblMensagem.Text = "Usuário/cliente apagado com sucesso!";
                        lblMensagem.BackColor = Color.GreenYellow;

                        carregarRegistros();
                    }
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Visible = true;
                lblMensagem.Text = "Erro ao apagar usuário/cliente: " + ex.Message;
                lblMensagem.BackColor = Color.LightCoral;
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.RowCount > 0)
            {
                try
                {
                    usuarioControle.entidade = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem; ;

                    txbNome.Text = usuarioControle.entidade.nome;
                    txbDocumentoIdentificador.Text = usuarioControle.entidade.documentoIdentificador;
                    ckbPossuiAcesso.Checked = usuarioControle.entidade.possuiAcesso;
                    ckbSuperUsuario.Checked = usuarioControle.entidade.superUsuario;

                    if (ckbPossuiAcesso.Checked)
                    {
                        txbLogin.Text = usuarioControle.entidade.login;
                        txbSenha.Text = "";
                        gpbAcesso.Visible = true;
                    }
                    else
                    {
                        txbLogin.Text = "";
                        txbSenha.Text = "";
                        gpbAcesso.Visible = false;
                    }

                    lblMensagem.Visible = true;
                    lblMensagem.Text = "Usuário pronto para edição...";
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
            usuarioControle.paginacao.quantidadeRegistrosPorPagina = Convert.ToInt32(cmbLinhasVisiveis.Text);

            cmbPaginas.Items.Clear();
            for (int i = 1; i <= usuarioControle.paginacao.quantidadePaginas; i++)
            {
                cmbPaginas.Items.Add(i);
            }

            usuarioControle.paginacao.paginaAtual = 1;
            cmbPaginas.SelectedIndex = 0;

            carregarRegistros();
        }

        private void cmbPaginas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaginas.Text.Equals("")) return;
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
            usuarioControle.paginacao.paginaAtual = usuarioControle.paginacao.quantidadePaginas;
            if (usuarioControle.quantidadeRegistros() == 0) return;
            cmbPaginas.SelectedIndex = usuarioControle.paginacao.paginaAtual - 1;

            carregarRegistros();
        }

        private void txbPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txbPesquisa.Text.Contains("Digite aqui o nome do usuário/cliente para pesquisar..."))
            {
                txbPesquisa.Text = "";
            }
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txbPesquisa.Text.Contains("Digite aqui o nome do usuário/cliente para pesquisar...") || txbPesquisa.Text.Equals("")) return;
            List<Usuario> lista = usuarioControle.listarTodos();
            if (ckbOpcaoPesquias.Checked)
            {
                lista = usuarioControle.listarPorPaginacao(usuarioControle.paginacao.primeiroRegistroPagina, usuarioControle.paginacao.quantidadeRegistrosPorPagina);
            }

            if (Sistema.pesquisaDataGridView<Usuario>(bindingSource, dgvUsuarios, lista, string.Format("{0} like '%{1}%'", "nome", txbPesquisa.Text)))
            {
                lblMensagem.Visible = false;
                lblMensagem.Text = "";
            }
            else
            {
                lblMensagem.Visible = true;
                lblMensagem.Text = "Nenhum usuário/cliente encontrado para pesquisa...";
                lblMensagem.BackColor = Color.LightGoldenrodYellow;

                bindingSource.RemoveFilter();
            }
        }

        private void txbPesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (txbPesquisa.Text.Equals(""))
            {
                txbPesquisa.Text = "Digite aqui o nome do usuário/cliente para pesquisar...";
            }
        }

        private void ckbPossuiAcesso_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPossuiAcesso.Checked)
            {
                gpbAcesso.Visible = true;
            }
            else
            {
                gpbAcesso.Visible = false;

            }
        }

        private void lblMensagem_MouseClick(object sender, MouseEventArgs e)
        {
            lblMensagem.Visible = false;
            lblMensagem.Text = "";
        }

        private void btnNovoReferencia_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.RowCount > 0)
            {
                try
                {
                    usuarioControle.entidade = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;

                    txbNome.Text = usuarioControle.entidade.nome;
                    txbDocumentoIdentificador.Text = usuarioControle.entidade.documentoIdentificador;
                    ckbPossuiAcesso.Checked = usuarioControle.entidade.possuiAcesso;
                    ckbSuperUsuario.Checked = usuarioControle.entidade.superUsuario;

                    usuarioControle.entidade.id = -1;
                    usuarioControle.entidade.saldo = 0;

                    if (ckbPossuiAcesso.Checked)
                    {
                        txbLogin.Text = usuarioControle.entidade.login;
                        txbSenha.Text = "";
                        gpbAcesso.Visible = true;
                    }
                    else
                    {
                        txbLogin.Text = "";
                        txbSenha.Text = "";
                        gpbAcesso.Visible = false;
                    }

                    lblMensagem.Visible = true;
                    lblMensagem.Text = "Um novo cliente/usuário está pronto para ser cadastrado.";
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

        private void debitoSaldo(bool init)
        {
            if (init)
            {
                gpbLista.Enabled = false;
                gpbManutencao.Enabled = false;
                pnlDebitoSaldo.Visible = true;

                mensagemDebitoSaldo.Visible = false;
                mensagemDebitoSaldo.Text = "";
                mensagemDebitoSaldo.BackColor = Color.GreenYellow;
            }
            else
            {
                numDebitoParcial.Value = 0;
                gpbLista.Enabled = true;
                gpbManutencao.Enabled = true;
                pnlDebitoSaldo.Visible = false;

                limparCampos();
                carregarRegistros();                
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsuarios.Columns["debitar_saldo"].Index)
            {
                Point p = new Point((this.Width / 2) - (pnlDebitoSaldo.Width/2), (this.Height / 2) - (pnlDebitoSaldo.Height/2));
                pnlDebitoSaldo.Location = p;

                if (dgvUsuarios.RowCount > 0)
                {
                    usuarioControle.entidade = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                    txbSaldo.Text = Convert.ToString(usuarioControle.entidade.saldo);

                    debitoSaldo(true);
                }
            }

            if (e.ColumnIndex == dgvUsuarios.Columns["btnEditarUsuario"].Index)
            {
                if (dgvUsuarios.RowCount > 0)
                {
                    try
                    {
                        usuarioControle.entidade = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;

                        txbNome.Text = usuarioControle.entidade.nome;
                        txbDocumentoIdentificador.Text = usuarioControle.entidade.documentoIdentificador;
                        ckbPossuiAcesso.Checked = usuarioControle.entidade.possuiAcesso;
                        ckbSuperUsuario.Checked = usuarioControle.entidade.superUsuario;

                        if (ckbPossuiAcesso.Checked)
                        {
                            txbLogin.Text = usuarioControle.entidade.login;
                            txbSenha.Text = "";
                            gpbAcesso.Visible = true;
                        }
                        else
                        {
                            txbLogin.Text = "";
                            txbSenha.Text = "";
                            gpbAcesso.Visible = false;
                        }

                        lblMensagem.Visible = true;
                        lblMensagem.Text = "Usuário pronto para edição...";
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

            if (e.ColumnIndex == dgvUsuarios.Columns["btnDeletarUsuario"].Index)
            {
                try
                {
                    if (dgvUsuarios.RowCount > 0)
                    {
                        usuarioControle.entidade = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                        if (MessageBox.Show("Deseja realmente apagar o usuário/cliente: " + usuarioControle.entidade.nome + "?", "Confirmar exclusão de usuário/cliente", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            usuarioControle.deletar(usuarioControle.entidade);

                            lblMensagem.Visible = true;
                            lblMensagem.Text = "Usuário/cliente apagado com sucesso!";
                            lblMensagem.BackColor = Color.GreenYellow;

                            carregarRegistros();
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Visible = true;
                    lblMensagem.Text = "Erro ao apagar usuário/cliente: " + ex.Message;
                    lblMensagem.BackColor = Color.LightCoral;
                }
            }
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            debitoSaldo(false);
        }

        private void btnDebitoParcial_Click(object sender, EventArgs e)
        {
            if (usuarioControle.entidade.saldo == 0)
            {
                mensagemDebitoSaldo.Visible = true;
                mensagemDebitoSaldo.Text = "O saldo já foi debitado";
                mensagemDebitoSaldo.BackColor = Color.LightCoral;
                return;
            }

            if (Convert.ToDouble(txbSaldo.Text) >= 0)
            {
                mensagemDebitoSaldo.Visible = true;
                mensagemDebitoSaldo.Text = "Débito é somente para saldos negativos";
                mensagemDebitoSaldo.BackColor = Color.LightCoral;
                return;
            }
            if (Sistema.numeroInvalido(Convert.ToString(numDebitoParcial.Value)))
            {
                errorProvider.SetError(numDebitoParcial, "Informe um valor válido");
                return;
            }
            double valorDebitoParcial = Convert.ToDouble(numDebitoParcial.Value);         
            
            if(valorDebitoParcial + (usuarioControle.entidade.saldo) > 0)
            {
                mensagemDebitoSaldo.Visible = true;
                mensagemDebitoSaldo.Text = "O débito não pode aumentar o saldo, somente zerar, ou diminuir parcialmente";
                mensagemDebitoSaldo.BackColor = Color.LightCoral;
                return;
            }
              
            usuarioControle.entidade.saldo = valorDebitoParcial + (usuarioControle.entidade.saldo);
            usuarioControle.editar(usuarioControle.entidade);

            txbSaldo.Text = Convert.ToString(usuarioControle.entidade.saldo);
            numDebitoParcial.Value = 0;

            mensagemDebitoSaldo.Visible = true;
            mensagemDebitoSaldo.Text = "Saldo debitado parcialmente com sucesso!";
            mensagemDebitoSaldo.BackColor = Color.GreenYellow;
        }

        private void btnDebitoTotal_Click(object sender, EventArgs e)
        {
            if (usuarioControle.entidade.saldo == 0)
            {
                mensagemDebitoSaldo.Visible = true;
                mensagemDebitoSaldo.Text = "O saldo já foi debitado";
                mensagemDebitoSaldo.BackColor = Color.LightCoral;
                return;
            }
            usuarioControle.entidade.saldo = 0;
            usuarioControle.editar(usuarioControle.entidade);
            usuarioControle.editar(usuarioControle.entidade);

            txbSaldo.Text = Convert.ToString(usuarioControle.entidade.saldo);
            numDebitoParcial.Value = 0;

            mensagemDebitoSaldo.Visible = true;
            mensagemDebitoSaldo.Text = "Saldo debitado totalmente com sucesso!";
            mensagemDebitoSaldo.BackColor = Color.GreenYellow;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            debitoSaldo(false);
        }

        private void numDebitoParcial_ValueChanged(object sender, EventArgs e)
        {
            double valorDebitoParcial = usuarioControle.entidade.saldo < 0 ? (Convert.ToDouble(numDebitoParcial.Value) * -1) : (Convert.ToDouble(numDebitoParcial.Value));
        }
    }
}
