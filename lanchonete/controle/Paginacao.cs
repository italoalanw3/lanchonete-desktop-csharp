using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_escola.controle
{
    public class Paginacao
    {
        public int paginaAtual{ get; set;}
        public int quantidadeRegistrosPorPagina { get; set; }
        public int quantidadePaginas
        {
            get { 
                return (int)Math.Ceiling(Convert.ToDouble((double)quantidadeTotalRegistros / (double)quantidadeRegistrosPorPagina)); 
            }
        }
        public int quantidadeTotalRegistros { get; set; }

        /** usado na consulta: limit primeiroRegistroPagina, 10 */
        public int primeiroRegistroPagina
        {
            get
            {
                return (quantidadeRegistrosPorPagina * paginaAtual) - quantidadeRegistrosPorPagina;
            }
        }

        public Paginacao()
        {
            paginaAtual = 1;
            quantidadeRegistrosPorPagina = 5;
        }
    }
}
