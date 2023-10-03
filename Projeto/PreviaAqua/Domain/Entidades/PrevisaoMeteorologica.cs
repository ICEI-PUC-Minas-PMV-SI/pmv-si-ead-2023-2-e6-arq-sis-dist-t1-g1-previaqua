using Domain.ValueObjects;

namespace Domain.Entidades
{
    public class PrevisaoMeteorologica : Entity
    {
        public PrevisaoMeteorologica(Guid id,DateTime dataHora, Localizacao localizacao,
            DadosClimaticos dadosClimaticos, PeriodoPrevisao periodoPrevisao) : base(id)
        {
            DataHora = dataHora;
            Localizacao = localizacao ?? throw new ArgumentNullException(nameof(localizacao));
            DadosClimaticos = dadosClimaticos;
            PeriodoPrevisao = periodoPrevisao;
        }

        public DateTime DataHora { get; set; }
        public DadosClimaticos DadosClimaticos { get; set; }
        public Localizacao Localizacao { get; set; }
        public PeriodoPrevisao PeriodoPrevisao { get; set; }

    }
}