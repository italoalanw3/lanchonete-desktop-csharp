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
    class VendaProdutoDao : GenericoDao<VendaProduto>, IVendaProdutoDao
    {
        public VendaProdutoDao()
        {
        }

        public List<VendaProduto> todosOsProdutosVenda(int venda)
        {
            using (ISession sessionBD = ConexaoBD.NovaSession())
            {
                try
                {
                    List<VendaProduto> vendaProdutos = (List<VendaProduto>)sessionBD.CreateQuery("from VendaProduto vp where vp.venda.id = :id")
                             .SetParameter("id", venda).List<VendaProduto>();

                    return vendaProdutos;
                }
                catch (Exception e)
                {
                    throw new Exception("Exception ao listar todos os produtos da venda: " + e.Message);
                }
            }

        }
    }
}
