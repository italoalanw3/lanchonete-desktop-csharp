using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projeto_escola.servico
{
    class ThreadLogs
    {
        public ThreadLogs()
        {

        }
        public void removerLogs()
        {
            while (true)
            {
                Sistema.escreverLogs();
                Thread.Sleep(2000);
            }
        }
    }
}
