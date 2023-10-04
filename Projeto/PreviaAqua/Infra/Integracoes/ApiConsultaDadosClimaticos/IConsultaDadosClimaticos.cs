using Domain.ValueObjects;

namespace Infra.Integracoes.ApiConsultaDadosClimaticos
{
    public interface IConsultaDadosClimaticos
    {
        public Task<DadosMeteorologicos?> ObterPrevisaoAsync(string cdWsi);
    }
}