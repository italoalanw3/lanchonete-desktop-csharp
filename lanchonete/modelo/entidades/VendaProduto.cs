using NHibernate.Mapping.Attributes;
using projeto_escola.entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.modelo.entidades
{
    [Class(NameType = typeof(VendaProduto), Table = "venda_produto")]
    public class VendaProduto
    {
        [Id(0, Name = "id", Column = "id")]
        [Generator(1, Class = "sequence")]
        public virtual int id
        {
            get;
            set;
        }

        [NHibernate.Mapping.Attributes.ManyToOne(2, ClassType = typeof(Venda), OuterJoin = OuterJoinStrategy.True)]
        public virtual Venda venda { get; set; }

        [NHibernate.Mapping.Attributes.ManyToOne(2, ClassType = typeof(Produto), OuterJoin = OuterJoinStrategy.True, Lazy = Laziness.False)]
        public virtual Produto produto { get; set; }

        [Property(NotNull = true)]
        public virtual int quantidadeProdutosVenda { get; set; }


        public VendaProduto()
        {

        }
    }
}

