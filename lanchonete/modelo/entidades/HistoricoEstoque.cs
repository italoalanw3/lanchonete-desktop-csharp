using NHibernate.Mapping.Attributes;
using System;

namespace projeto_escola.entidade
{
    [Class(NameType = typeof(HistoricoEstoque), Table = "historico_estoque")]
    public class HistoricoEstoque : IComparable<HistoricoEstoque>
    {
        [Id(0, Name = "id", Column = "id")]
        [Generator(1, Class = "native")]
        public virtual int id
        {
            get;
            set;
        }

        [Property(Type = "timestamp")]
        public virtual DateTime dataHora { get; set; }

        [Property(Unique=false)]
        public virtual String nome { get; set; }

        [Property]
        public virtual String descricao { get; set; }

        [Property(NotNull=true)]
        public virtual double preco { get; set; }

        [Property(Type= "timestamp")]
        public virtual DateTime validade { get; set; }

        [Property(NotNull = true)]
        public virtual int quantidadeEstoque { get; set; }

        public virtual bool estoque_atual { get; set; }
        // asc/desc
        private static string coluna_ordenacao;
        // asc/desc
        private static bool ordenar_crescente;

        public static void setOrdenacao(string coluna, bool ordenar_crescent)
        {
            HistoricoEstoque.coluna_ordenacao = coluna;
            HistoricoEstoque.ordenar_crescente = ordenar_crescent;
        }

        [Property]
        public virtual int fk_produto { get; set; }

        public override string ToString()
        {
            return nome + ". Preço: "+Convert.ToString(preco);
        }

        public virtual void buildValues(Produto p)
        {
            this.dataHora = DateTime.Now;
            this.nome = p.nome;
            this.descricao = p.descricao;
            this.preco = p.preco;
            this.validade = p.validade;
            this.quantidadeEstoque = p.quantidadeEstoque;
            this.fk_produto = p.id;
        }

        public virtual int SortByNomeAscending(String value1, String value2)
        {
            return value1.CompareTo(value2);
        }

        public virtual int CompareTo(HistoricoEstoque other)
        {
            int ordenecaoCrescente = -1;
            if (HistoricoEstoque.ordenar_crescente)
                ordenecaoCrescente = 1;

            if (HistoricoEstoque.coluna_ordenacao == "id")
                return ordenecaoCrescente*this.id.CompareTo(other.id);
            if (HistoricoEstoque.coluna_ordenacao == "datahora")
                return ordenecaoCrescente * this.dataHora.CompareTo(other.dataHora);
            if (HistoricoEstoque.coluna_ordenacao == "nome")
                return ordenecaoCrescente * this.nome.CompareTo(other.nome);
            if (HistoricoEstoque.coluna_ordenacao == "descricao")
                return ordenecaoCrescente * this.descricao.CompareTo(other.descricao);
            if (HistoricoEstoque.coluna_ordenacao == "preco")
                return ordenecaoCrescente * this.preco.CompareTo(other.preco);
            if (HistoricoEstoque.coluna_ordenacao == "validade")
                return ordenecaoCrescente * this.validade.CompareTo(other.validade);
            if (HistoricoEstoque.coluna_ordenacao == "quantidadeEstoque")
                return ordenecaoCrescente * this.quantidadeEstoque.CompareTo(other.quantidadeEstoque);
            if (HistoricoEstoque.coluna_ordenacao == "fk_produto")
                return ordenecaoCrescente * this.fk_produto.CompareTo(other.fk_produto);
            if (HistoricoEstoque.coluna_ordenacao == "estoque_atual")
                return ordenecaoCrescente * this.estoque_atual.CompareTo(other.estoque_atual);
            return ordenecaoCrescente * this.nome.CompareTo(other.nome);
        }

        public HistoricoEstoque() {
            estoque_atual = true;
        }        
             
    }
}
