using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class DadosDeDetecaoDeInundacao
    {
        public DateTime DataHora { get; set; }
        public string Descricao { get; set; }
        public Localizacao Localizacao { get; set; }
        public DadosClimaticos CondicoesClimaticas { get; set; }
    }
}
