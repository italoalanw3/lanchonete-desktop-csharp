using NHibernate;
using projeto_escola.entidade;
using projeto_escola.hibernate;
using projeto_escola.modelo.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.modelo.persistencia
{
    class ProdutoDao : GenericoDao<Produto>, IProdutoDao
    {
        public ProdutoDao() {
        }

        public void deletar(int id)
        {
            if (Sistema.usuarioLogado.superUsuario == false)
            {
                Sistema.loginfo("Tentativa de excluir registro com o seguinte: " + Convert.ToString(id) + ". Apenas super usuários podem apagar os registros" + Sistema.usuarioLogado.nome);
                throw new Exception("Apenas super usuários podem apagar os registros - Para mais dúvidas contate o administrador.");
            }
            using (ISession sessionBD = ConexaoBD.NovaSession())
            {
                List<VendaProduto> vendaProdutos = (List<VendaProduto>)sessionBD.CreateQuery("from VendaProduto vp where vp.produto.id = :id")
                            .SetParameter("id", id).List<VendaProduto>();
                if (vendaProdutos.Count > 0)
                {
                    throw new Exception("Este produto não pode ser removido, pois existem vendas cadastradas com ele");
                }
                using (ITransaction tx = sessionBD.BeginTransaction())
                {
                    try
                    {   
                        Produto entidade = (Produto)sessionBD.Get<Produto>(id);
                        sessionBD.Flush();
                        sessionBD.Delete(entidade);
                        tx.Commit();
                        Sistema.loginfo("Registro deletado: " + entidade.ToString() + " por " + Sistema.usuarioLogado.nome);
                    }
                    catch (Exception e)
                    {
                        if (!tx.WasCommitted)
                            tx.Rollback();

                        Sistema.logErro("Rollback ao apagar registro de código " + Convert.ToString(id) + " por " + Sistema.usuarioLogado.nome);
                        throw new Exception(e.InnerException.Message + " - Para mais dúvidas contate o administrador.");
                    }
                    finally
                    {
                        sessionBD.Dispose();
                    }

                }
            }
        }

        public void deletar(Produto entidade)
        {
            if (Sistema.usuarioLogado.superUsuario == false)
            {
                Sistema.loginfo("Tentativa de excluir registro: " + entidade.ToString() + ". Apenas super usuários podem apagar os registros. Nome de usuário logado: " + Sistema.usuarioLogado.nome + " - Login: " + Sistema.usuarioLogado.login);
                throw new Exception("Apenas super usuários podem apagar os registros - Para mais dúvidas contate o administrador.");
            }
            using (ISession sessionBD = ConexaoBD.NovaSession())
            {
                List<VendaProduto> vendaProdutos = (List<VendaProduto>)sessionBD.CreateQuery("from VendaProduto vp where vp.produto.id = :id")
                            .SetParameter("id", entidade.id).List<VendaProduto>();
                if (vendaProdutos.Count > 0)
                {
                    throw new Exception("Este produto não pode ser removido, pois existem vendas cadastradas com ele");
                }
                using (ITransaction tx = sessionBD.BeginTransaction())
                {
                    try
                    {                       
                        sessionBD.Flush();
                        sessionBD.Delete(entidade);
                        tx.Commit();
                        Sistema.loginfo("Registro deletado: " + entidade.ToString() + " por " + Sistema.usuarioLogado.nome);
                    }
                    catch (Exception e)
                    {
                        if (!tx.WasCommitted)
                            tx.Rollback();
                        Sistema.logErro("Rollback ao deletar registro: " + entidade.ToString() + " por " + Sistema.usuarioLogado.nome);
                        throw new Exception(e.InnerException.Message + " - Para mais dúvidas contate o administrador.");
                    }
                    finally
                    {
                        sessionBD.Dispose();
                    }

                }
            }
        }
    }
}
