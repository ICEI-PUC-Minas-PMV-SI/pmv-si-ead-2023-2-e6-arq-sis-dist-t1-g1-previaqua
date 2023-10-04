using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class RequestObterAlertaDeInundacoesPorArea
    {
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
        public string? Municipio { get; set; }
        public string? Bairro { get; set; }
        public double? PeriodoInicialLatitude { get; set; }
        public double? PeriodoFinalLatitude { get; set; }
        public double? PeriodoInicialLongitude { get; set; }
        public double? PeriodoFinalLongitude { get; set; }

    }
}
