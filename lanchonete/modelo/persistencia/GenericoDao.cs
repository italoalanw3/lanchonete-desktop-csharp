using NHibernate;
using projeto_escola.hibernate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.modelo.persistencia
{
    class GenericoDao<T> : IGenericoDao<T>
    {

        public GenericoDao()
        {
        }

        public void salvar(T entidade)
        {
            using (ISession sessionBD = ConexaoBD.NovaSession())
            {
                using (ITransaction tx = sessionBD.BeginTransaction())
                {
                    try
                    {
                        sessionBD.Save(entidade);
                        tx.Commit();
                        Sistema.loginfo("Registro inserido: " + entidade.ToString() + " por " + Sistema.usuarioLogado.nome);
                    }
                    catch (Exception e)
                    {
                        if (!tx.WasCommitted)
                            tx.Rollback();
                        Sistema.logErro("Rollback ao inserir registro: " + entidade.ToString() + " por " + Sistema.usuarioLogado.nome);
                        throw new Exception(e.InnerException.Message + " - Para mais dúvidas contate o administrador.");
                    }
                    finally
                    {
                        sessionBD.Dispose();
                    }
                }
            }
        }

        public T salvarRetornandoEntidadeNova(T entidade)
        {
            using (ISession sessionBD = ConexaoBD.NovaSession())
            {
                using (ITransaction tx = sessionBD.BeginTransaction())
                {
                    try
                    {
                        sessionBD.Save(entidade);
                        tx.Commit();
                        Sistema.loginfo("Registro inserido: " + entidade.ToString() + " por " + Sistema.usuarioLogado.nome);
                        return entidade;
                    }
                    catch (Exception e)
                    {
                        if (!tx.WasCommitted)
                            tx.Rollback();
                        Sistema.logErro("Rollback ao inserir registro: " + entidade.ToString() + " por " + Sistema.usuarioLogado.nome);
                        throw new Exception(e.InnerException.Message + " - Para mais dúvidas contate o administrador.");
                    }
                    finally
                    {
                        sessionBD.Dispose();
                    }
                }
            }

        }

        public void editar(T entidade)
        {
            using (ISession sessionBD = ConexaoBD.NovaSession())
            {
                using (ITransaction tx = sessionBD.BeginTransaction())
                {
                    try
                    {
                        sessionBD.Flush();
                        sessionBD.SaveOrUpdate(entidade);
                        tx.Commit();
                        Sistema.loginfo("Registro editado: " + entidade.ToString() + " por " + Sistema.usuarioLogado.nome);
                    }
                    catch (Exception e)
                    {
                        if (!tx.WasCommitted)
                            tx.Rollback();
                        Sistema.logErro("Rollback ao editar registro: " + entidade.ToString() + " por " + Sistema.usuarioLogado.nome);
                        throw new Exception(e.InnerException.Message + " - Para mais dúvidas contate o administrador.");
                    }
                    finally
                    {
                        sessionBD.Dispose();
                    }
                }
            }
        }

        public T selecionar(int id)
        {

            using (ISession sessionBD = ConexaoBD.NovaSession())
            {
                try
                {
                    T entidade = (T)sessionBD.Get<T>(id);
                    sessionBD.Flush();
                    return entidade;
                }
                catch (Exception e)
                {
                    throw new Exception(e.InnerException.Message + " - Para mais dúvidas contate o administrador.");
                }
                finally
                {
                    sessionBD.Dispose();
                }
            }

        }

        public void deletar(int id)
        {
            if (Sistema.usuarioLogado.superUsuario == false)
            {
                Sistema.loginfo("Tentativa de excluir registro com o seguinte: " + Convert.ToString(id) +". Apenas super usuários podem apagar os registros" + Sistema.usuarioLogado.nome);
                throw new Exception("Apenas super usuários podem apagar os registros - Para mais dúvidas contate o administrador.");
            }
            using (ISession sessionBD = ConexaoBD.NovaSession())
            {
                using (ITransaction tx = sessionBD.BeginTransaction())
                {
                    try
                    {
                        T entidade = (T)sessionBD.Get<T>(id);
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

        public void deletar(T entidade)
        {
            if (Sistema.usuarioLogado.superUsuario == false)
            {
                Sistema.loginfo("Tentativa de excluir registro: " + entidade.ToString() + ". Apenas super usuários podem apagar os registros. Nome de usuário logado: " + Sistema.usuarioLogado.nome+" - Login: "+Sistema.usuarioLogado.login);
                throw new Exception("Apenas super usuários podem apagar os registros - Para mais dúvidas contate o administrador.");
            }
            using (ISession sessionBD = ConexaoBD.NovaSession())
            {
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
                        throw new Exception(e.InnerException.Message+" - Para mais dúvidas contate o administrador.");
                    }
                    finally
                    {
                        sessionBD.Dispose();
                    }

                }
            }
        }

        public List<T> listarTodos()
        {
            List<T> lista = null;

            using (ISession sessionBD = ConexaoBD.NovaSession())
            {
                try
                {
                    lista = (List<T>)sessionBD.CreateCriteria(typeof(T)).AddOrder(NHibernate.Criterion.Order.Desc("id")).List<T>();
                    return lista;
                }
                catch (Exception e)
                {
                    Sistema.logErro("Erro ao listar registros. Usuário logado: " + Sistema.usuarioLogado.nome);
                    throw new Exception(e.InnerException.Message + " - Para mais dúvidas contate o administrador.");
                }
                finally
                {
                    sessionBD.Dispose();
                }
            }

        }

        public List<T> listarTodosPaginado(int inicio, int fim)
        {
            List<T> lista = null;

            using (ISession sessionBD = ConexaoBD.NovaSession())
            {
                try
                {
                    lista = (List<T>)sessionBD.CreateCriteria(typeof(T)).SetFirstResult(inicio).SetMaxResults(fim).AddOrder(NHibernate.Criterion.Order.Desc("id")).List<T>();
                }
                catch (Exception e)
                {
                    Sistema.logErro("Erro ao listar registros paginado. Usuário logado: " + Sistema.usuarioLogado.nome);
                    throw new Exception(e.InnerException.Message + " - Para mais dúvidas contate o administrador.");
                }
                finally
                {
                    sessionBD.Dispose();
                }

                return lista;
            }
        }

        public int totalRegistros()
        {
            using (ISession sessionBD = ConexaoBD.NovaSession())
            {
                try
                {
                    var total = sessionBD.CreateSQLQuery("select count(id) as total from " + typeof(T).Name.ToLower());
                    total.AddScalar("total", NHibernateUtil.Int32);
                    var recordCount = total.List<int>().Single();
                    return recordCount;
                }
                catch (Exception e)
                {
                    Sistema.logErro("Erro ao retornar quantidade total de registros. Usuário logado: " + Sistema.usuarioLogado.nome);
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
