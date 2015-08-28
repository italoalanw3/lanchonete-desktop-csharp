using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.modelo.entidades
{
    [Class(NameType = typeof(Ingrediente), Table = "ingrediente")]
    public class Ingrediente
    {
        [Id(0, Name = "id", Column = "id")]
        [Generator(1, Class = "sequence")]
        public virtual int id
        {
            get;
            set;
        }

        [Property]
        public virtual String nome { get; set; }

        [Timestamp]
        public virtual DateTime validade { get; set; }

        public Ingrediente()
        {

        }
    }
}
