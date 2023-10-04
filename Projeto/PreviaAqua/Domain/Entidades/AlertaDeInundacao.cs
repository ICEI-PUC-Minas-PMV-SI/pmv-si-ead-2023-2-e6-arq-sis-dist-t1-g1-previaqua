using Domain.ValueObjects;

namespace Domain.Entidades
{
    public class AlertaDeInundacao : Entity
    {
        public AlertaDeInundacao(Guid id ,DateTime dataHora, string mensagem, Localizacao localizacao, 
            NivelDeAgua nivelDeAgua, bool ativo) : base(id)
        {
            DataHora = dataHora;
            Mensagem = mensagem ?? throw new ArgumentNullException(nameof(mensagem));
            Localizacao = localizacao ?? throw new ArgumentNullException(nameof(localizacao));
            NivelDeAgua = nivelDeAgua;
            Ativo = ativo;
        }

        public DateTime DataHora { get; set; }
        public string Mensagem { get; set; }
        public Localizacao Localizacao { get; set; }
        public NivelDeAgua NivelDeAgua { get; set; }
        public bool Ativo { get; set; }

        public bool AtivarAlertaDeInundacao()
        { 
            if(this.Ativo)
                return false;
            Ativo = true;
            return true;
        }

        public bool DesativarAlertaDeInundacao()
        {
            if (!this.Ativo)
                return false;
            Ativo = false;
            return true;
        }
    }
}
