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
                        cdWsi = cdWsiCompleto.Substring(7, 7);
                    else
                        return BadRequest("Formato CD_WSI inválido.");
                }
                else
                    return NotFound("Cidade não encontrada, verifique os dados inseridos na requisição.");

                var retorno = await _consultaDadosClimaticos.ObterPrevisaoAsync(cdWsi);
                if (retorno == null)
                    return NotFound();
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + ex.InnerException);
            }
        }
    }
}

