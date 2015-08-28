using projeto_escola.entidade;
using projeto_escola.modelo.entidades;
using projeto_escola.modelo.persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.controle
{
    public class VendaProdutoControle : BaseControle<VendaProduto>
    {
        public VendaProdutoControle()
        {
            this.dao = new VendaProdutoDao();
            this.entidade = new VendaProduto();
        }

        public List<VendaProduto> todosOsProdutosVenda(int venda)
        {
            return ((VendaProdutoDao)dao).todosOsProdutosVenda(venda);
        }
    }
}
