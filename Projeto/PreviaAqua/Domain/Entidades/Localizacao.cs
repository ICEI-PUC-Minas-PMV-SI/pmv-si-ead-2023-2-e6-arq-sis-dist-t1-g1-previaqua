using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class Localizacao
    {
        public Localizacao(int id, string nome, double latitude, double longitude)
        {
            Id = id;
            Nome = nome;
            Latitude = latitude;
            Longitude = longitude;
          
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        // Outras propriedades relevantes para a localização

    }
}
