using Infra.Configurations;
using Infra.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    [Authorize]
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuariosController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [Authorize]
        [HttpPost("criarUsuario")]
        public async Task<IActionResult> CriarUsuario(ApplicationUser applicationUser, string senha)
        {
            var novoUsuario = applicationUser;

            var resultado = await _usuarioRepository.CriarUsuarioAsync(novoUsuario, senha); // Substitua pela senha desejada

            if (!resultado.Succeeded)
                return BadRequest();
            return Ok();
        }
    }
}
