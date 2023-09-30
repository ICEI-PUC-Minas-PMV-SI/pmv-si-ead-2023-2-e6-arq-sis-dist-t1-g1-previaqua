using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class DadosClimaticos
    {
        public DadosClimaticos(double temperatura, double umidade, double velocidadeVento, double pressaoAtmosferica)
        {
            Temperatura = temperatura;
            Umidade = umidade;
            VelocidadeVento = velocidadeVento;
            PressaoAtmosferica = pressaoAtmosferica;
        }

        public double Temperatura { get; set; }
        public double Umidade { get; set; }
        public double VelocidadeVento { get; set; }
        public double PressaoAtmosferica { get; set; }
    }
}
