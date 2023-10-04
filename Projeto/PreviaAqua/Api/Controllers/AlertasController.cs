using Application.Models;
using Domain.ValueObjects;
using Infra.Integracoes.ApiConsultaDadosClimaticos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AlertasController : Controller
    {

        //Validacao direta pelo banco de dados
        [HttpGet]
        [Authorize]
        public IActionResult ObterAlertasDeInundacoesPorArea(RequestObterAlertaDeInundacoesPorArea requestObterAlertaDeInundacoesPorArea)
        {
            try
            {
                return View(requestObterAlertaDeInundacoesPorArea);
            }
            catch (Exception ex)
            {
                return BadRequest();    
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult DispararAlertasDeChuva(RequestObterAlertaDeInundacoesPorArea requestObterAlertaDeInundacoesPorArea)
        {
            try
            {
                //buscar as areas de acordo com o filtro
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Authorize]
        public IActionResult DispararAlertasDeChuva()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
