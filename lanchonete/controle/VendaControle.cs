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
    public class VendaControle : BaseControle<Venda>
    {
        public List<VendaProduto> vendaProdutos { get; set; }
        public VendaControle()
        {
            this.dao = new VendaDao();
            this.entidade = new Venda();
            vendaProdutos = new List<VendaProduto>();
        }
    }
}
