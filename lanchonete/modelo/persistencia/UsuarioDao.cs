using NHibernate;
using projeto_escola.hibernate;
using projeto_escola.modelo.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.modelo.persistencia
{
    class UsuarioDao : GenericoDao<Usuario>, IUsuarioDao
    {
        public UsuarioDao()
        {
        }

        public bool autenticarUsuario(Usuario usuario)
        {
            bool autenticado = false;

            try
            {
                using (ISession sessionBD = ConexaoBD.NovaSession())
                {

                    IList<Usuario> usuarios = sessionBD.CreateQuery("from Usuario usuario where login = :login and senha = :senha")
                             .SetParameter("login", usuario.login)
                             .SetParameter("senha", usuario.senha).List<Usuario>();
                    usuario = null;
                    if (usuarios.Count == 1){
                        usuario = usuarios.ElementAt(0);
                        autenticado = true;
                    }
                    else
                    {
                        usuarios = sessionBD.CreateQuery("from Usuario usuario").List<Usuario>();
                        usuario = null;
                        if (usuarios.Count == 0)
                        {
                            Usuario primeiroUsuario = new Usuario();
                            primeiroUsuario.nome = "Administrador";
                            primeiroUsuario.login = "admin";
                            primeiroUsuario.saldo = 0;
                            primeiroUsuario.superUsuario = true;
                            primeiroUsuario.possuiAcesso = true;
                            primeiroUsuario.documentoIdentificador = "???";
                            using (MD5 md5Hash = MD5.Create())
                            {
                                string senhaCriptografada = Sistema.GetMd5Hash(md5Hash, "admin");
                                primeiroUsuario.senha = senhaCriptografada;
                            }
                            salvar(primeiroUsuario);
                            autenticado = true;
                        }
                        else
                        {
                            autenticado = false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                autenticado = true;
                throw new Exception("Exception ao autenticar usuário: " + e.InnerException.Message);
            }
            if (usuario == null)
            {
                autenticado = false;
            }
            else
            {
                autenticado = true;
                Sistema.usuarioLogado = usuario;
            }

            return autenticado;
        }
    }
}
