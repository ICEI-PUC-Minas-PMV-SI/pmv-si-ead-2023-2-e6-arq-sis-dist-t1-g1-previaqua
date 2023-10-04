

using Newtonsoft.Json;

namespace AlertaEventosClimaticos.Models
{
    public class AlertaDeChuva
    {
        [JsonProperty("chuva")]
        public double Chuva { get; set; }

        [JsonProperty("umD_MAX")]
        public double UmidadeMaxima { get; set; }

        [JsonProperty("prE_MIN")]
        public double Pressao { get; set; }

        public string Resultado
        {
            get
            {
                if(Pressao > 700 && Chuva > 0.3)
                {
                    return "Chuva forte";
                }else if (Chuva < 0.50)
                {
                    return "Sem chuva";
                }
                else
                {
                    return "Chuva isolada";
                }
            }
        }
    }
}
