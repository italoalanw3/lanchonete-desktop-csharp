﻿using NHibernate;
using projeto_escola.entidade;
using projeto_escola.modelo.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.modelo.persistencia
{
    class ClienteDao : GenericoDao<Cliente>, IClienteDao
    {
        public ClienteDao() {
        }
    }
}
