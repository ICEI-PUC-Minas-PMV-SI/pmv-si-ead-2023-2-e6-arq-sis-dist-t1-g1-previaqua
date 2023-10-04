using Infra.Configurations;
using Infra.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;


        public AuthController(IUsuarioRepository usuarioRepository)
        { 
            _usuarioRepository = usuarioRepository;
        }

        [AllowAnonymous]
        [Authorize]
        [HttpPost("criarUsuario")]
        public async Task<IActionResult> CriarUsuario(ApplicationUser applicationUser, string senha)
        {
            if (ModelState.IsValid)
            {
                var novoUsuario = applicationUser;

                var resultado = await _usuarioRepository.CriarUsuarioAsync(novoUsuario, senha); // Substitua pela senha desejada

                if (!resultado.Succeeded)
                    return BadRequest();
                return Ok();

            }
            else 
                return BadRequest();
        }
      
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var userValidado = await _usuarioRepository.AutenticarUsuarioAsync(model.Email, model.Password);

            if (userValidado != null)
            {
                var user = await _usuarioRepository.BuscarUsuarioPorEmailAsync(model.Email);
                // Usuário autenticado com sucesso, você pode gerar um token JWT aqui
                var token = _usuarioRepository.GerarToken(user);

                return Ok(new { token });
            }

            return Unauthorized("Usuário ou senha inválidos");
        }


        [HttpPost("gerarToken")]
        public async Task<IActionResult> GerarToken()
        {
            var tokenGenerator = new JwtSettings();
            var secretKey = "SuaChaveSecretaAqui";
            var issuer = "https://localhost:7196/index.html";
            var audience = "https://localhost:7196/index.html";
            var expirationMinutes = 60; // Token expira em 60 minutos

            var claims = new[]
                            {
                    new Claim(ClaimTypes.Name, "AmandaTeste"),
                    new Claim(ClaimTypes.Email, "amandaTeste@email.com"),
                    // Adicione outras reivindicações conforme necessário
                };

            var token = tokenGenerator.GenerateToken(secretKey, issuer, audience, expirationMinutes, claims);
            Console.WriteLine("Token JWT gerado:");
            Console.WriteLine(token);
            return Ok("Bearer " + token);
        }
    }
}
