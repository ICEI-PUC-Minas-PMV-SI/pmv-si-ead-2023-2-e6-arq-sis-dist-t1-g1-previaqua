using Domain.ValueObjects;
using Infra.Integracoes.ApiConsultaDadosClimaticos;
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
        public IConsultaDadosClimaticos _consultaDadosClimaticos;

        public PrevisaoController(IConsultaDadosClimaticos consultaDadosClimaticos)
        {
            _consultaDadosClimaticos = consultaDadosClimaticos;
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

                var retorno = await _consultaDadosClimaticos.ObterPrevisaoAsync(cdWsi);
                if (retorno == null)
                    return NotFound();

                return Ok(retorno);

            }
            catch (Exception ex)
            {
                // Em caso de exceção, retorna um erro interno do servidor
                return BadRequest(ex.Message + ex.InnerException);
            }
        }
    }
}

