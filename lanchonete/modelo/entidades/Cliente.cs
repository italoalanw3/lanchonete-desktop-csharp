using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.modelo.entidades
{
    [Class(NameType = typeof(Cliente), Table = "cliente")]
    public class Cliente
    {
        public Cliente() { }

        [Id(0, Name = "id", Column = "id")]
        [Generator(1, Class = "sequence")]
        public virtual int id
        {
            get;
            set;
        }

        [Property]
        public virtual String nome { get; set; }

        [Property(NotNull = false)]
        public virtual String cpf { get; set; }

        [Property(NotNull = false)]
        public virtual String rg { get; set; }

        [Property(Type = "timestamp")]
        public virtual DateTime dataNascimento { get; set; }
    }
}
