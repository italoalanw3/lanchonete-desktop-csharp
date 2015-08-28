using projeto_escola.modelo.persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.controle
{
    public abstract class BaseControle<T>
    {
        public IGenericoDao<T> dao { get; set; }
        public Paginacao paginacao { get; set; }
        public T entidade { get; set; }

        public BaseControle()
        {
            this.paginacao = new Paginacao();
        }

        public void salvar(T entidade)
        {
            try
            {
                dao.salvar(entidade);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public T salvarRetornandoEntidadeNova(T entidade)
        {
            try
            {
                return dao.salvarRetornandoEntidadeNova(entidade);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public T selecionar(int id)
        {
            try
            {
                return dao.selecionar(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /** Método editar que a entidade já deve ser passada com id preenchido */
        public void editar(T entidade)
        {
            try
            {
                dao.editar(entidade);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public void deletar(int id)
        {
            try
            {
                dao.deletar(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void deletar(T entidade)
        {
            try
            {
                dao.deletar(entidade);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<T> listarTodos()
        {
            try
            {
                return dao.listarTodos();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<T> listarPorPaginacao(int inicio, int fim)
        {
            try
            {
                return dao.listarTodosPaginado(inicio, fim);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int quantidadeRegistros()
        {
            try
            {
                return dao.totalRegistros();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
