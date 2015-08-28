using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.modelo
{
    class RepositorioExpection : Exception
    {
        public String mensagemExpection { get; set; }
        
        public RepositorioExpection(String mensagem)
        {
            this.mensagemExpection = mensagem;
        }
    }
}
