using NHibernate;
using projeto_escola.controle;
using projeto_escola.entidade;
using projeto_escola.hibernate;
using projeto_escola.modelo.persistencia;
using projeto_escola.visao.cadastros;
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

namespace projeto_escola
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            if (Sistema._ambiente == Sistema.AMBIENTE_DESENVOLVIMENTO)
            {
                txbUsuario.Text = "admin";
                txbSenha.Text = "admin";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Sistema.campoIsNull(txbUsuario.Text))
            {
                lblMensagem.ForeColor = Color.Red;
                lblMensagem.Text = "Informe o nome do usuário";
                return;
            }
            if (Sistema.campoIsNull(txbSenha.Text))
            {
                lblMensagem.ForeColor = Color.Red;
                lblMensagem.Text = "Informe a senha do usuário";
                return;
            }
            try
            {
                lblMensagem.ForeColor = Color.White;
                lblMensagem.Text = "Tentando autenticar...";
                this.Refresh();

                UsuarioControle usuarioControle = new UsuarioControle();

                usuarioControle.entidade.login = txbUsuario.Text;
                usuarioControle.entidade.senha = txbSenha.Text;


                using (MD5 md5Hash = MD5.Create())
                {
                    string senhaCriptografada = Sistema.GetMd5Hash(md5Hash, usuarioControle.entidade.senha);

                    usuarioControle.entidade.senha = senhaCriptografada;
                    if (Sistema.VerifyMd5Hash(md5Hash, usuarioControle.entidade.senha, senhaCriptografada))
                    {
                        Console.WriteLine("The hashes are the same.");
                    }
                    else
                    {
                        Console.WriteLine("The hashes are not same.");
                    }
                }

                if (usuarioControle.autenticarUsuario())
                {
                    lblMensagem.ForeColor = Color.White;
                    lblMensagem.Text = "Usuário autenticado!";
                    this.Refresh();

                    Thread.Sleep(200);
                    this.DialogResult = DialogResult.OK; 
                    this.Close();
                }
                else
                {
                    lblMensagem.ForeColor = Color.Red;
                    lblMensagem.Text = "Usuário não autenticado";
                }
            }
            catch (Exception ex)
            {
                Sistema.logErro(ex.Message);
                MessageBox.Show("Erro FATAL: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
