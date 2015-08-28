using projeto_escola.entidade;
using projeto_escola.modelo.persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.controle
{
    class HistoricoEstoqueControle : BaseControle<HistoricoEstoque>
    {
        public HistoricoEstoqueControle()
        {
            this.dao = new HistoricoEstoqueDao();
            this.entidade = new HistoricoEstoque();
        }

        public List<HistoricoEstoque> listarTodoEstoqueValido()
        {
            return ((HistoricoEstoqueDao)dao).listarTodoEstoqueValido();
        }
    }
}
