using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using projeto_escola.entidade;
using projeto_escola.modelo;
using projeto_escola.modelo.entidade;
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
                cfg.Configure();
                /** Classes Mapeadas */
                cfg.AddInputStream(NHibernate.Mapping.Attributes.HbmSerializer.Default.Serialize(typeof(Aluno)));
                cfg.AddInputStream(NHibernate.Mapping.Attributes.HbmSerializer.Default.Serialize(typeof(Usuario)));
             
            }
            catch (RepositorioException e)
            {
                Console.Write("Código: "+e.Source+" | Mensagem"+e.Message);
                throw new RepositorioException("Hibernate não conseguiu carregar configurações do banco de dados");
            }
            catch (Exception e)
            {
                Console.Write("Código: " + e.Source + " | Mensagem" + e.Message);
                throw new RepositorioException("Erro geral: "+e.Message);
            }
            return cfg;
            
        }

        public static ISession NovaSession {get{ return sessionFactory.OpenSession();}}
        public static ISession SessionAtual { get { return sessionFactory.GetCurrentSession(); }}
    }
}
