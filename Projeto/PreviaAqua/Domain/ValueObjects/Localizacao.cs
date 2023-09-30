using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class Localizacao
    {
        public Localizacao(string nome, double latitude, double longitude)
        {
            Nome = nome;
            Latitude = latitude;
            Longitude = longitude;
          
        }
        
        public string Nome { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
