using Domain.ValueObjects;

namespace Domain.Entidades
{
    public class AlertaDeInundacao : Entity
    {
        public AlertaDeInundacao(DateTime dataHora, string mensagem, Localizacao localizacao, NivelDeAgua nivelDeAgua = null)
        {
            DataHora = dataHora;
            Mensagem = mensagem ?? throw new ArgumentNullException(nameof(mensagem));
            Localizacao = localizacao ?? throw new ArgumentNullException(nameof(localizacao));
            NivelDeAgua = nivelDeAgua;
        }

        public DateTime DataHora { get; set; }
        public string Mensagem { get; set; }
        public Localizacao Localizacao { get; set; }
        public NivelDeAgua NivelDeAgua { get; set; }
    }
}
