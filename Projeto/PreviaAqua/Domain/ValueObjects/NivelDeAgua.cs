namespace Domain.ValueObjects
{
    public class NivelDeAgua
    {
        public NivelDeAgua(DateTime dataHora, double altura, double pressao,Localizacao localizacao)
        {
            DataHora = dataHora;
            Altura = altura;
            Localizacao = localizacao ?? throw new ArgumentNullException(nameof(localizacao));
            Pressao = pressao;
            TipoChuva = DefinicaoDoTipoDaChuva();
        }

        public DateTime DataHora { get; set; }
        public double Altura { get; set; }
        public double Pressao { get; set; }
        public Localizacao Localizacao { get; set; }
        public TipoChuva TipoChuva { get; set; }

        public TipoChuva DefinicaoDoTipoDaChuva()
        {
            if (Pressao > 700 && Altura > 0.3)
                return TipoChuva.ChuvaForte;
            else if (Altura < 0.50)
                return TipoChuva.SemChuva;
            else
                return TipoChuva.ChuvaIsolada;
        }
    }

    public enum TipoChuva
    { 
        ChuvaForte,
        SemChuva,
        ChuvaIsolada
    }
}
