using NHibernate;
using projeto_escola.controle;
using projeto_escola.entidade;
using projeto_escola.hibernate;
using projeto_escola.modelo;
using projeto_escola.modelo.entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_escola
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbUsuario.Text.Equals(""))
            {
                lblMensagem.ForeColor = Color.Red;
                lblMensagem.Text = "Informe o nome do usuário";
                return;
            }
            if (txbSenha.Text.Equals(""))
            {
                lblMensagem.ForeColor = Color.Red;
                lblMensagem.Text = "Informe a senha do usuário";
                return;
            }
            try
            {
                lblMensagem.ForeColor = Color.White;
                lblMensagem.Text = "Tentando autenticar";
                LoginControle login = new LoginControle(new Usuario(ConexaoBD.NovaSession));

                if (login.autenticarUsuario())
                {
                    lblMensagem.ForeColor = Color.White;
                    MessageBox.Show("Parabéns você está logado;");
                }
                else
                {
                    lblMensagem.ForeColor = Color.Red;
                    lblMensagem.Text = "Usuário não autenticado";
                }
            }
            catch (RepositorioException ex)
            {
                MessageBox.Show("Exceção no repositorio: "+ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceção geral: " + ex.Message);
            }
        }
    }
}
