using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class AreaDeInundacaoPotencial : Entity
    {
        public AreaDeInundacaoPotencial(string nome, List<Localizacao> limites, DadosClimaticos condicoesClimaticas,
            NivelDeAgua nivelDeAgua)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Limites = limites ?? throw new ArgumentNullException(nameof(limites));
            CondicoesClimaticas = condicoesClimaticas ?? throw new ArgumentNullException(nameof(condicoesClimaticas));
            NivelDeAgua = nivelDeAgua ?? throw new ArgumentNullException(nameof(nivelDeAgua));
        }

        public string Nome { get; set; }
        public List<Localizacao> Limites { get; set; }
        public DadosClimaticos CondicoesClimaticas { get; set; }
        public NivelDeAgua NivelDeAgua { get; set; }
    }
}
