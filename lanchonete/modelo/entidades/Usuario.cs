using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.modelo.entidades
{
    [Class(NameType = typeof(Usuario), Table = "usuario")]
    public class Usuario
    {
        public Usuario() { }

        [Id(0, Name = "id", Column = "id")]
        [Generator(1, Class = "sequence")]
        public virtual int id
        {
            get;
            set;
        }

        [Property(NotNull=true)]
        public virtual String nome { get; set; }

        [Property(Unique=true)]
        public virtual String documentoIdentificador { get; set; }

        [Property(Unique=false)]
        public virtual String login { get; set; }

        [Property]
        public virtual String senha { get; set; }

        [Property]
        public virtual bool possuiAcesso { get; set; }

        [Property]
        public virtual bool superUsuario { get; set; }

        [Property]
        public virtual double saldo { get; set; }

        public override string ToString()
        {
            return nome;
        }
    }
}
