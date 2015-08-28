using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using projeto_escola.entidade;
using projeto_escola.modelo.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.hibernate
{
    public class ConexaoBD
    {
        private static ISessionFactory sessionFactory = GetConfiguracao().BuildSessionFactory();
        private static Configuration GetConfiguracao()
        {
            Configuration cfg = new Configuration();
            try
            {
                cfg.Configure().SetProperty("connection.connection_string", Sistema._conexaoBanco);
                /** Classes Mapeadas */

                cfg.AddInputStream(NHibernate.Mapping.Attributes.HbmSerializer.Default.Serialize(typeof(Produto)));
                cfg.AddInputStream(NHibernate.Mapping.Attributes.HbmSerializer.Default.Serialize(typeof(Cliente)));
                cfg.AddInputStream(NHibernate.Mapping.Attributes.HbmSerializer.Default.Serialize(typeof(HistoricoEstoque)));
                cfg.AddInputStream(NHibernate.Mapping.Attributes.HbmSerializer.Default.Serialize(typeof(Ingrediente)));
                cfg.AddInputStream(NHibernate.Mapping.Attributes.HbmSerializer.Default.Serialize(typeof(IngredienteProduto)));
                cfg.AddInputStream(NHibernate.Mapping.Attributes.HbmSerializer.Default.Serialize(typeof(Usuario)));
                cfg.AddInputStream(NHibernate.Mapping.Attributes.HbmSerializer.Default.Serialize(typeof(Venda)));
                cfg.AddInputStream(NHibernate.Mapping.Attributes.HbmSerializer.Default.Serialize(typeof(VendaProduto)));
             
            }
            catch (Exception e)
            {
                Console.Write("Código: " + e.Source + " | Mensagem" + e.Message);
                Sistema.logErro("Código: " + e.Source + " | Mensagem" + e.InnerException.Message);
                throw new Exception("Erro geral: " + e.InnerException.Message);
            }
            return cfg;
            
        }

        private static ISession persistentSession = null;
        public static ISession NovaSession()
        {
            if (persistentSession == null || persistentSession.IsOpen == false)
            {
                persistentSession = sessionFactory.OpenSession();
            }

            return persistentSession;
        }
    }
}
