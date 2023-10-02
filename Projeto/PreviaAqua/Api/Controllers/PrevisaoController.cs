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
        public async Task<IActionResult> GetPrevisao(string cidade)
        {
            try
            {
                return Ok("Endpoint ok");
                // Recebe o nome da cidade e remove os hifens caso cidade com nome composto
                cidade = cidade.Replace("-", " ");

                // Obtem o caminho do arquivo JSON na pasta Dados
                string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dados", "Estacoes.json");

                // Carrega o arquivo JSON
                string jsonContent = System.IO.File.ReadAllText(jsonFilePath);

                // Analisa o conteúdo JSON para encontrar o CD_WSI correspondente à cidade
                JArray estacoesJson = JArray.Parse(jsonContent);
                string cdWsi = null;

                // Encontra a estação com DC_NOME igual ao nome inserido pelo usuário
                var estacaoEncontrada = estacoesJson.FirstOrDefault(estacao =>
                {
                    string dcNome = (string)estacao["DC_NOME"];
                    return dcNome.Contains(cidade, StringComparison.OrdinalIgnoreCase);
                });

                if (estacaoEncontrada != null)
                {
                    // Obtém o valor do atributo CD_WSI
                    string cdWsiCompleto = (string)estacaoEncontrada["CD_WSI"];

                    // Verifica se o valor tem pelo menos 14 caracteres
                    if (cdWsiCompleto.Length >= 14)
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
                        // Acessando os valores recebidos
                        string dcNome = (string)dados["DC_NOME"];
                        string preIns = (string)dados["PRE_INS"];
                        string temSen = (string)dados["TEM_SEN"];
                        string vlLatitude = (string)dados["VL_LATITUDE"];
                        string preMax = (string)dados["PRE_MAX"];
                        string uf = (string)dados["UF"];
                        string radGlo = (string)dados["RAD_GLO"];
                        string ptoIns = (string)dados["PTO_INS"];
                        string temMin = (string)dados["TEM_MIN"];
                        string vlLongitude = (string)dados["VL_LONGITUDE"];
                        string umdMin = (string)dados["UMD_MIN"];
                        string ptoMax = (string)dados["PTO_MAX"];
                        string venDir = (string)dados["VEN_DIR"];
                        string dtMedicao = (string)dados["DT_MEDICAO"];
                        string chuva = (string)dados["CHUVA"];
                        string preMin = (string)dados["PRE_MIN"];
                        string umdMax = (string)dados["UMD_MAX"];
                        string venVel = (string)dados["VEN_VEL"];
                        string ptoMin = (string)dados["PTO_MIN"];
                        string temMax = (string)dados["TEM_MAX"];
                        string tenBat = (string)dados["TEN_BAT"];
                        string venRaj = (string)dados["VEN_RAJ"];
                        string temCpu = (string)dados["TEM_CPU"];
                        string temIns = (string)dados["TEM_INS"];
                        string umdIns = (string)dados["UMD_INS"];
                        string cdEstacao = (string)dados["CD_ESTACAO"];
                        string hrMedicao = (string)dados["HR_MEDICAO"];

                        // Retorne os valores como um objeto JSON
                        var valores = new
                        {
                            DC_NOME = dcNome,
                            PRE_INS = preIns,
                            TEM_SEN = temSen,
                            VL_LATITUDE = vlLatitude,
                            PRE_MAX = preMax,
                            UF = uf,
                            RAD_GLO = radGlo,
                            PTO_INS = ptoIns,
                            TEM_MIN = temMin,
                            VL_LONGITUDE = vlLongitude,
                            UMD_MIN = umdMin,
                            PTO_MAX = ptoMax,
                            VEN_DIR = venDir,
                            DT_MEDICAO = dtMedicao,
                            CHUVA = chuva,
                            PRE_MIN = preMin,
                            UMD_MAX = umdMax,
                            VEN_VEL = venVel,
                            PTO_MIN = ptoMin,
                            TEM_MAX = temMax,
                            TEN_BAT = tenBat,
                            VEN_RAJ = venRaj,
                            TEM_CPU = temCpu,
                            TEM_INS = temIns,
                            UMD_INS = umdIns,
                            CD_ESTACAO = cdEstacao,
                            HR_MEDICAO = hrMedicao
                        };

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

