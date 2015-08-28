using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.controle
{
    abstract class SuperControle<T>
    {
        SuperControle() {

        }

        public abstract bool salvar();

        public abstract T selecionar(int id);

        public abstract bool editar();

        public abstract bool deletar();

        public abstract List<T> listarTodos();

        public abstract List<T> listarPaginacao(int inicio, int fim);
    }
}
