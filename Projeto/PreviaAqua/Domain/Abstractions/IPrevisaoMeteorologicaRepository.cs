using Domain.Entidades;
namespace Domain.Abstractions
{
    public interface IPrevisaoMeteorologicaRepository
    {
        public List<PrevisaoMeteorologica> ObterTodasPrevisoes();
        public PrevisaoMeteorologica? ObterPrevisaoPorId(Guid id);
        public void AtualizarPrevisao(PrevisaoMeteorologica previsao);
        public void DesativarPrevisao(Guid id);
    }
}
