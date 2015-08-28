using NHibernate;
using NHibernate.Mapping.Attributes;
using projeto_escola.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.entidade
{
    [Class(NameType = typeof(Aluno), Table = "aluno")]
    class Aluno : Repositorio<Aluno>
    {
        public Aluno() { }
        public Aluno(ISession session)
        {
            this.Session = session;
        }


        [Id(0, Name = "Id", Column = "Id")]
        [Generator(1, Class = "sequence")]
        private virtual int Id
        {
            private get;
            set;
        }

        public override int Id()
        {
            return Id;
        }
        
        [Property]
        public virtual String Nome { get; set; }
        [Property]
        public virtual String Matricula { get; set; }

        public override Aluno thisEntidade()
        {
            return this;
        }
    }
}
