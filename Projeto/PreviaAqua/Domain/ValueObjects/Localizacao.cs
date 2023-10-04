using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Localizacao
    {
        public Localizacao(string nome, double latitude, double longitude,
            string cidade, string estado, string municipio, string bairro)
        {
            Nome = nome;
            Latitude = latitude;
            Longitude = longitude;
            Cidade = cidade;
            Estado = estado;
            Municipio = municipio;
            Bairro = bairro;
        }

        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
