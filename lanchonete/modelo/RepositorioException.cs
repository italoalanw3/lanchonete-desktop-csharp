using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.modelo
{
    class RepositorioException : Exception
    {
        
        public RepositorioException(String mensagem):base(mensagem)
        {
        }

    }
}
