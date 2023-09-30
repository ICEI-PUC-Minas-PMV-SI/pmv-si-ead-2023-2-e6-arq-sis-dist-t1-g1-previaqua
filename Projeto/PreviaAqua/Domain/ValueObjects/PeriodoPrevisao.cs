using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class PeriodoPrevisao
    {

        public DateTime Inicio { get; private set; }
        public DateTime Fim { get; private set; }

        private PeriodoPrevisao(DateTime inicio, DateTime fim)
        {
            Inicio = inicio;
            Fim = fim;
        }

        public static PeriodoPrevisao Criar(DateTime inicio, DateTime fim)
        {
            if (inicio >= fim)
            {
                throw new ArgumentException("A data de início deve ser anterior à data de fim.");
            }

            return new PeriodoPrevisao(inicio, fim);
        }
    }
}
