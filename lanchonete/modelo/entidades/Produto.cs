using NHibernate;
using NHibernate.Mapping.Attributes;
using projeto_escola.modelo.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.entidade
{
    [Class(NameType = typeof(Produto), Table = "produto")]
    public class Produto
    {
        [Id(0, Name = "id", Column = "id")]
        [Generator(1, Class = "native")]
        public virtual int id
        {
            get;
            set;
        }

        [Property(Unique=true)]
        public virtual String nome { get; set; }

        [Property]
        public virtual String descricao { get; set; }

        [Property(NotNull=true)]
        public virtual double preco { get; set; }

        [Property(Type= "timestamp")]
        public virtual DateTime validade { get; set; }

        [Property(NotNull = true)]
        public virtual int quantidadeEstoque { get; set; }
        
        public override string ToString()
        {
            return nome + ". Preço: "+Convert.ToString(preco);
        }

        public Produto() { }        
             
    }
}
