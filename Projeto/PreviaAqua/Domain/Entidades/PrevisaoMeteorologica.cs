using Domain.ValueObjects;

namespace Domain.Entidades
{
    public class PrevisaoMeteorologica : Entity
    {
        public PrevisaoMeteorologica(DateTime dataHora, double temperatura,
            double umidade, double velocidadeVento, Localizacao localizacao)
        {
            DataHora = dataHora;
            Temperatura = temperatura;
            Umidade = umidade;
            VelocidadeVento = velocidadeVento;
            Localizacao = localizacao ?? throw new ArgumentNullException(nameof(localizacao));
            Ativa = true;
        }

        public DateTime DataHora { get; set; }
        public double Temperatura { get; set; }
        public double Umidade { get; set; }
        public double VelocidadeVento { get; set; }
        public Localizacao Localizacao { get; set; }
        public bool Ativa { get; set; }
    }
}