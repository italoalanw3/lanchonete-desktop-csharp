using NHibernate;
using NHibernate.Mapping.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.modelo
{
    abstract class Repositorio<T>
    {
        public Repositorio() {
        }

        public virtual int Id();

        public virtual ISession Session { get; set; }

        public abstract T thisEntidade();

        public virtual void Salvar()
        {
            try { 
                Session.Save(thisEntidade());
            }
            catch (RepositorioException e)
            {
                throw new RepositorioException("Não foi possivel salvar registro: " + e.Message);
            }
        }

        public virtual void Editar()
        {
            try
            {
                if (Id() == 0)
                    throw new RepositorioException("Para editar, o Id precisa ser preenchido");                                
                T entidade = (T)Session.Get<T>(Id());                
                Session.Flush();
                Session.Update(entidade);
            }
            catch (RepositorioException e)
            {
                throw new RepositorioException("Não foi possivel editar registro: " + e.Message);
            }
        }

        public virtual void Deletar()
        {
            try
            {
                if (Id == 0)
                    throw new RepositorioException("Para deletar, o Id precisa ser preenchido");                
                T entidade = (T)Session.Get<T>(Id);
                Session.Flush();
                Session.Delete(entidade);                
            }
            catch (RepositorioException e)
            {
                throw new RepositorioException("Não foi possivel deletar registro: " + e.Message);
            }
        }

        public virtual IList ListarTodos()
        {
            try { 
                return Session.CreateCriteria(typeof(T)).List();
            }
            catch (RepositorioException e)
            {
                throw new RepositorioException("Não foi possivel listar registros: " + e.Message);
            }
        }
    }
}
