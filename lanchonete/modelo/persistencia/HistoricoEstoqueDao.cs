using NHibernate;
using projeto_escola.entidade;
using projeto_escola.hibernate;
using System;
using System.Collections.Generic;

namespace projeto_escola.modelo.persistencia
{
    class HistoricoEstoqueDao : GenericoDao<HistoricoEstoque>, IHistoricoEstoqueDao
    {
        public HistoricoEstoqueDao() {
        }

        public List<HistoricoEstoque> listarTodoEstoqueValido()
        {
            using (ISession sessionBD = ConexaoBD.NovaSession())
            {
                try
                {
                    /*  string sql = "select id as {historico_estoque.id}, estoque.datahora as {historico_estoque.dataHora}, nome as {historico_estoque.nome}, " +
                                   "descricao as {historico_estoque.descricao}, preco as {historico_estoque.preco}, validade as {historico_estoque.validade}, " +
                                   "estoque.quantidadeestoque as {historico_estoque.quantidadeEstoque}, estoque.fk_produto as {historico_estoque.fk_produto} " +
                                   "from produto as p join " +
                                   "(select fk_produto, sum(quantidadeestoque) as quantidadeestoque, min(datahora) as datahora " +
                                   "from historico_estoque " +
                                   "group by fk_produto) as estoque " +
                                   "on p.id = estoque.fk_produto;";
                      */
                    var sql = "select {historico_estoque.*} from historico_estoque historico_estoque inner join produto p on historico_estoque.fk_produto = p.id order by historico_estoque.datahora";
                    var result = sessionBD.CreateSQLQuery(sql).AddEntity("historico_estoque",typeof(HistoricoEstoque)).List<HistoricoEstoque>();

                    List <HistoricoEstoque> historicoEstoque = (List<HistoricoEstoque>) result;

                    // Marcar cada histórico como sendo o último histórico

                    /*
                    Algoritmo
                    iterar um produto por vez e correr todo o histórico, só verifica se forem o mesmo produto,
                    se for o mesmo produto, verificar qual é o mais atual, o que for, recebe true no atributo estoque_atual, o outro recebe false
                    */
                    foreach (HistoricoEstoque historicoDaVez in historicoEstoque){
                        foreach (HistoricoEstoque historico in historicoEstoque)
                        {
                            if (historicoDaVez.fk_produto == historico.fk_produto &&
                                historicoDaVez.id != historico.id) // O mesmo produto não precisa ser verificado com ele mesmo
                            {
                                if (historicoDaVez.dataHora >= historico.dataHora)
                                {
                                    historicoDaVez.estoque_atual = true;
                                    historico.estoque_atual = false;
                                }
                                else
                                {
                                    historico.estoque_atual = true;
                                    historicoDaVez.estoque_atual = false;
                                    break;
                                }
                            }
                        }
                    }

                    return historicoEstoque;
                }
                catch (Exception e)
                {
                    throw new Exception("Exception ao listar histórico de produtos: " + e.Message);
                }
            }

        }
    }
}
