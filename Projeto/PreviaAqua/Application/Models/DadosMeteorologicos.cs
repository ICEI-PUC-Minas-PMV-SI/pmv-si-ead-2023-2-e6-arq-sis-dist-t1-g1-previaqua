using Newtonsoft.Json;
using System.ComponentModel;
namespace Domain.ValueObjects
{
    public class DadosMeteorologicos
    {
        public DadosMeteorologicos(string dC_NOME,
            double pRE_INS, double tEM_SEN, double vL_LATITUDE, 
            double pRE_MAX, string uF, double rAD_GLO, double pTO_INS, 
            double tEM_MIN, double vL_LONGITUDE, double uMD_MIN, double pTO_MAX, 
            double vEN_DIR, DateTime dT_MEDICAO, double cHUVA, double pRE_MIN, 
            double uMD_MAX, double vEN_VEL, double pTO_MIN, double tEM_MAX, double tEN_BAT,
            double vEN_RAJ, double tEM_CPU, double tEM_INS, double uMD_INS, string cD_ESTACAO, TimeSpan hR_MEDICAO)
        {
            DC_NOME = dC_NOME ?? string.Empty;
            PRE_INS = pRE_INS;
            TEM_SEN = tEM_SEN;
            VL_LATITUDE = vL_LATITUDE;
            PRE_MAX = pRE_MAX;
            UF = uF ?? string.Empty;
            RAD_GLO = rAD_GLO;
            PTO_INS = pTO_INS;
            TEM_MIN = tEM_MIN;
            VL_LONGITUDE = vL_LONGITUDE;
            UMD_MIN = uMD_MIN;
            PTO_MAX = pTO_MAX;
            VEN_DIR = vEN_DIR;
            DT_MEDICAO = dT_MEDICAO;
            CHUVA = cHUVA;
            PRE_MIN = pRE_MIN;
            UMD_MAX = uMD_MAX;
            VEN_VEL = vEN_VEL;
            PTO_MIN = pTO_MIN;
            TEM_MAX = tEM_MAX;
            TEN_BAT = tEN_BAT;
            VEN_RAJ = vEN_RAJ;
            TEM_CPU = tEM_CPU;
            TEM_INS = tEM_INS;
            UMD_INS = uMD_INS;
            CD_ESTACAO = cD_ESTACAO ?? string.Empty;
            HR_MEDICAO = hR_MEDICAO;
        }

        [JsonProperty("DC_NOME")]
        [Description("Nome da Cidade")]
        public string DC_NOME { get; set; }

        [JsonProperty("PRE_INS")]
        [Description("Pressão atmosférica ao nível da estação, horária(mB)")]
        public double PRE_INS { get; set; }

        [JsonProperty("TEM_SEN")]
        [Description("Sensação térmica")]
        public double TEM_SEN { get; set; }

        [JsonProperty("VL_LATITUDE")]
        [Description("Latitude")]
        public double VL_LATITUDE { get; set; }

        [JsonProperty("PRE_MAX")]
        [Description("Pressão atmosférica máxima na hora anterior(mB)")]
        public double PRE_MAX { get; set; }

        [JsonProperty("UF")]
        [Description("Unidade Federativa")]
        public string UF { get; set; }

        [JsonProperty("RAD_GLO")]
        [Description("Radiação global(W/m2)")]
        public double RAD_GLO { get; set; }

        [JsonProperty("PTO_INS")]
        [Description("Temperatura do ponto de orvalho(°C)")]
        public double PTO_INS { get; set; }

        [JsonProperty("TEM_MIN")]
        [Description("Temperatura mínima na hora anterior(°C)")]
        public double TEM_MIN { get; set; }

        [JsonProperty("VL_LONGITUDE")]
        [Description("Longitude")]
        public double VL_LONGITUDE { get; set; }

        [JsonProperty("UMD_MIN")]
        [Description("Umidade relativa mínima na hora anterior(%)")]
        public double UMD_MIN { get; set; }

        [JsonProperty("PTO_MAX")]
        [Description("Temperatura orvalho máxima na hora anterior(°C)")]
        public double PTO_MAX { get; set; }

        [JsonProperty("VEN_DIR")]
        [Description("Vento, direção horária(°gr)")]
        public double VEN_DIR { get; set; }

        [JsonProperty("DT_MEDICAO")]
        [Description("Data da medição")]
        public DateTime DT_MEDICAO { get; set; }

        [JsonProperty("CHUVA")]
        [Description("Precipitação total, horário(mm)")]
        public double CHUVA { get; set; }

        [JsonProperty("PRE_MIN")]
        [Description("Pressão atmosférica mínima na hora anterior(mB)")]
        public double PRE_MIN { get; set; }

        [JsonProperty("UMD_MAX")]
        [Description("Umidade relativa máxima na hora anterior(%)")]
        public double UMD_MAX { get; set; }

        [JsonProperty("VEN_VEL")]
        [Description("Vento, velocidade horária(m/s)")]
        public double VEN_VEL { get; set; }

        [JsonProperty("PTO_MIN")]
        [Description("Temperatura orvalho mínima na hora anterior(°C)")]
        public double PTO_MIN { get; set; }

        [JsonProperty("TEM_MAX")]
        [Description("Temperatura máxima na hora anterior(°C)")]
        public double TEM_MAX { get; set; }

        [JsonProperty("TEN_BAT")]
        [Description("Tensão da bateria da estação(V)")]
        public double TEN_BAT { get; set; }

        [JsonProperty("VEN_RAJ")]
        [Description("Vento, rajada máxima")]
        public double VEN_RAJ { get; set; }

        [JsonProperty("TEM_CPU")]
        [Description("Temperatura do processador da estação(°C)")]
        public double TEM_CPU { get; set; }

        [JsonProperty("TEM_INS")]
        [Description("Temperatura do ar - bulbo seco, horária (°C)")]
        public double TEM_INS { get; set; }

        [JsonProperty("UMD_INS")]
        [Description("Umidade relativa do ar, horária(%)")]
        public double UMD_INS { get; set; }

        [JsonProperty("CD_ESTACAO")]
        [Description("Código da estação")]
        public string CD_ESTACAO { get; set; }

        [JsonProperty("HR_MEDICAO")]
        [Description("Hora da medição")]
        public TimeSpan HR_MEDICAO { get; set; }
    }
}
