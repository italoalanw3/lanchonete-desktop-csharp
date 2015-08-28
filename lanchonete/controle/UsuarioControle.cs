using projeto_escola.modelo.entidades;
using projeto_escola.modelo.persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.controle
{
    public class UsuarioControle : BaseControle<Usuario>
    {

        public UsuarioControle()
        {
            this.dao = new UsuarioDao();
            this.entidade = new Usuario();
        }

        public bool autenticarUsuario()
        {
            try
            {
                return ((IUsuarioDao)this.dao).autenticarUsuario(this.entidade);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
