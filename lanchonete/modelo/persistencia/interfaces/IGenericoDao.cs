using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.modelo.persistencia
{
    public interface IGenericoDao<T>
    {
        void salvar(T entidade);
        T salvarRetornandoEntidadeNova(T entidade);
        void editar(T entidade);
        void deletar(int id);
        void deletar(T id);
        T selecionar(int id);
        List<T> listarTodos();
        List<T> listarTodosPaginado(int inicio, int fim);
        int totalRegistros();
    }
}
