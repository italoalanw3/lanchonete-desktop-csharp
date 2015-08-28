using projeto_escola.entidade;
using projeto_escola.modelo.persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.controle
{
    class ProdutoControle : BaseControle<Produto>
    {
        public ProdutoControle()
        {
            this.dao = new ProdutoDao();
            this.entidade = new Produto();
        }
    }
}
