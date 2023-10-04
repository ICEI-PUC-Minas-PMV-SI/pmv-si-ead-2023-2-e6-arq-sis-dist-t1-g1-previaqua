using AlertaEventosClimaticos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace AlertaEventosClimaticos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertasController : ControllerBase
    {
        HttpClient client;
        public AlertasController()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7184")
            };

        }

        [HttpGet("{cidade}")]
        public async Task<IActionResult> BuscarPorCidade(string cidade)
        {
            try
            {
                string url = $"api/Previsao/{cidade}";
                // Faz a chamada à API externa
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    // Se a chamada for bem-sucedida, faz a leitura da resposta como string
                    string content = await response.Content.ReadAsStringAsync();

                    //Usa o metodo helper do pacote NewtonSoft.Json para deserializar o json em um objeto alerta de chuva.
                    //O objeto alerta (tipo AlertaDeChuva) possui os campos com as anotacoes relativas aos campos do json
                    AlertaDeChuva alerta =  JsonConvert.DeserializeObject<AlertaDeChuva>(content);

                    return Ok(alerta);
                }
                else
                {
                    // Se a chamada não for bem-sucedida, retorna um erro
                    return StatusCode((int)response.StatusCode, $"Erro ao chamar a API externa: {response.ReasonPhrase}");
                }
            }
            catch(Exception ex) 
            {
                // Em caso de exceção, retorna um erro interno do servidor
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }
    }
}

