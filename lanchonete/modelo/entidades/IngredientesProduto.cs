using NHibernate.Mapping.Attributes;
using projeto_escola.entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.modelo.entidades
{
    [Class(NameType = typeof(IngredienteProduto), Table = "ingrediente_produto")]
    public class IngredienteProduto
    {
        [Id(0, Name = "id", Column = "id")]
        [Generator(1, Class = "sequence")]
        public virtual int id
        {
            get;
            set;
        }

        [NHibernate.Mapping.Attributes.ManyToOne(2, ClassType = typeof(Produto), OuterJoin = OuterJoinStrategy.True)]
        public virtual Produto produto { get; set; }

        [NHibernate.Mapping.Attributes.ManyToOne(2, ClassType = typeof(Ingrediente), OuterJoin = OuterJoinStrategy.True)]
        public virtual Ingrediente ingrediente { get; set; }

        public IngredienteProduto()
        {

        }
    }
}

