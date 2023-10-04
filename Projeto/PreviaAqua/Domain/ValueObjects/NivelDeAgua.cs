namespace Domain.ValueObjects
{
    public class NivelDeAgua
    {
        public NivelDeAgua(DateTime dataHora, double altura, Localizacao localizacao)
        {
            DataHora = dataHora;
            Altura = altura;
            Localizacao = localizacao ?? throw new ArgumentNullException(nameof(localizacao));
           
        }

        public DateTime DataHora { get; set; }
        public double Altura { get; set; }
        public Localizacao Localizacao { get; set; }
    }
}
