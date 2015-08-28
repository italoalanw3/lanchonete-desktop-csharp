using NHibernate.Mapping.Attributes;
using projeto_escola.entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.modelo.entidades
{
    [Class(NameType = typeof(Venda), Table = "venda")]
    public class Venda
    {
        [Id(0, Name = "id", Column = "id")]
        [Generator(1, Class = "sequence")]
        public virtual int id
        {
            get;
            set;
        }

        [Property(Type = "timestamp")]
        public virtual DateTime dataVenda { get; set; }

        public virtual String cliente
        {
            get
            {
                return usuario.nome;
            }
        }

        [Property]
        public virtual bool deletada { get; set; }

        [Property(Precision = 2)]
        public virtual double valorVenda { get; set; }

        [Property(Precision = 2)]
        public virtual double valorPago { get; set; }

        [Property(Precision = 2)]
        public virtual double troco
        {
            get;
            set;
        }

        [Property]
        public virtual bool trocoComoSaldo { get; set; }

        [Property]
        public virtual bool cadastradaComSucesso { get; set; }

        [ManyToOne(2, ClassType = typeof(Usuario), Lazy = Laziness.False)]
        public virtual Usuario usuario { get; set; }
        
        public Venda()
        {
            cadastradaComSucesso = false;
        }
    }
}

