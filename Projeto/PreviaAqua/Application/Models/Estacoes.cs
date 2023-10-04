using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class Estacoes
    {
        public Estacoes(int id, string cdEstacao, string vlLatitude, string vlLongitude)
        {
            Id = id;
            CdEstacao = cdEstacao;
            VlLatitude = vlLatitude;
            VlLongitude = vlLongitude;
        }

        public int Id { get; set; }
        public string CdEstacao { get; set; }
        public string VlLatitude { get; set; }
        public string VlLongitude { get; set; }

       
    }
}
