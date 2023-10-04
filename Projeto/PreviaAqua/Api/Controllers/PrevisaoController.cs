using Domain.ValueObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] 
    public class PrevisaoController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public PrevisaoController()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://apiprevmet3.inmet.gov.br/proxima")
            };
        }

        /// <summary>
        /// Insira o nome da cidade na requisição seguindo o formato: /nome-da-cidade (Ex: Rio de Janeiro: rio-de-janeiro)
        /// </summary>
        /// <param name="cidade">Nome da cidade</param>
        /// <returns>A API retorna os seguintes valores</returns>
        [HttpGet("{cidade}")]
        [Authorize]
        public async Task<IActionResult> ObterPrevisao(string cidade)
        {
            try
            {
                cidade = cidade.Replace("-", " ");

                string jsonFilePath = "Estacoes.json";
                string jsonContent = System.IO.File.ReadAllText(jsonFilePath);

                JArray estacoesJson = JArray.Parse(jsonContent);
                string? cdWsi = null;
            
                // Encontra a estação com DC_NOME igual ao nome inserido pelo usuário
                var estacaoEncontrada = estacoesJson.FirstOrDefault(estacao =>
                {
                    if (estacao == null)
                        return false;
                    string? dcNome = estacao["DC_NOME"]?.ToString();
                    if (dcNome == null)
                        return false;
                    return dcNome.Contains(cidade, StringComparison.OrdinalIgnoreCase);
                });

                if (estacaoEncontrada != null)
                {
                    string? cdWsiCompleto = estacaoEncontrada["CD_WSI"]?.ToString();

                    if (cdWsiCompleto != null && cdWsiCompleto.Length >= 14)
                    {
                        // Extrai os caracteres do 8º ao 14º
                        cdWsi = cdWsiCompleto.Substring(7, 7);
                    }
                    else
                    {
                        return BadRequest("Formato CD_WSI inválido.");
                    }
                }
                else
                {
                    return NotFound("Cidade não encontrada, verifique os dados inseridos na requisição.");
                }

                // Monta a URL completa com o CD_WSI
                string apiUrl = $"estacao/proxima/{cdWsi}";

                Console.WriteLine(apiUrl);

                // Faz a chamada à API externa
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

                // Verifica se a chamada foi bem-sucedida
                if (response.IsSuccessStatusCode)
                {
                    // Se a chamada for bem-sucedida, faz a leitura da resposta como string
                    string responseContent = await response.Content.ReadAsStringAsync();
                    JObject jsonObject = JObject.Parse(responseContent);

                    // Extrai os dados do objeto "dados" da resposta
                    JObject dados = (JObject)jsonObject["dados"];

                    if (dados != null)
                    {
                        var dcNome = dados["DC_NOME"]?.ToString();
                        double preIns = 0;
                        double.TryParse(dados["PRE_INS"]?.ToString(), out preIns);

                        double temSen = 0;
                        double.TryParse(dados["TEM_SEN"]?.ToString(), out temSen);

                        double vlLatitude = 0;
                        double.TryParse(dados["VL_LATITUDE"]?.ToString(), out vlLatitude);

                        double preMax = 0;
                        double.TryParse(dados["PRE_MAX"]?.ToString(), out preMax);

                        string uf = dados["UF"]?.ToString() ?? string.Empty;

                        double radGlo = 0;
                        double.TryParse(dados["RAD_GLO"]?.ToString(), out radGlo);

                        double ptoIns = 0;
                        double.TryParse(dados["PTO_INS"]?.ToString(), out ptoIns);

                        double temMin = 0;
                        double.TryParse(dados["TEM_MIN"]?.ToString(), out temMin);

                        double vlLongitude = 0;
                        double.TryParse(dados["VL_LONGITUDE"]?.ToString(), out vlLongitude);

                        double umdMin = 0;
                        double.TryParse(dados["UMD_MIN"]?.ToString(), out umdMin);

                        double ptoMax = 0;
                        double.TryParse(dados["PTO_MAX"]?.ToString(), out ptoMax);

                        double venDir = 0;
                        double.TryParse(dados["VEN_DIR"]?.ToString(), out venDir);

                        DateTime dtMedicao = DateTime.MinValue;
                        DateTime.TryParse(dados["DT_MEDICAO"]?.ToString(), out dtMedicao);

                        double chuva = 0;
                        double.TryParse(dados["CHUVA"]?.ToString(), out chuva);

                        double preMin = 0;
                        double.TryParse(dados["PRE_MIN"]?.ToString(), out preMin);

                        double umdMax = 0;
                        double.TryParse(dados["UMD_MAX"]?.ToString(), out umdMax);

                        double venVel = 0;
                        double.TryParse(dados["VEN_VEL"]?.ToString(), out venVel);

                        double ptoMin = 0;
                        double.TryParse(dados["PTO_MIN"]?.ToString(), out ptoMin);

                        double temMax = 0;
                        double.TryParse(dados["TEM_MAX"]?.ToString(), out temMax);

                        double tenBat = 0;
                        double.TryParse(dados["TEN_BAT"]?.ToString(), out tenBat);

                        double venRaj = 0;
                        double.TryParse(dados["VEN_RAJ"]?.ToString(), out venRaj);

                        double temCpu = 0;
                        double.TryParse(dados["TEM_CPU"]?.ToString(), out temCpu);

                        double temIns = 0;
                        double.TryParse(dados["TEM_INS"]?.ToString(), out temIns);

                        double umdIns = 0;
                        double.TryParse(dados["UMD_INS"]?.ToString(), out umdIns);

                        string cdEstacao = dados["CD_ESTACAO"]?.ToString() ?? string.Empty;

                        TimeSpan hrMedicao = TimeSpan.Zero;
                        TimeSpan.TryParse(dados["HR_MEDICAO"]?.ToString(), out hrMedicao);

                        var valores = new DadosMeteorologicos(dcNome ?? string.Empty, preIns, temSen, vlLatitude, preMax,
                            uf, radGlo, ptoIns, temMin, vlLongitude, umdMin, ptoMax, venDir, dtMedicao, chuva, preMin, 
                            umdMax, venVel, ptoMin, temMax, tenBat, venRaj, temCpu, temIns, umdIns, cdEstacao, hrMedicao);

                        return Ok(valores);
                    }
                }
                else
                {
                    // Se a chamada não for bem-sucedida, retorna um erro
                    return StatusCode((int)response.StatusCode, $"Erro ao chamar a API externa: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                // Em caso de exceção, retorna um erro interno do servidor
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }

            return StatusCode(500, "Erro interno do servidor: Nenhum resultado encontrado.");
        }
    }
}

