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

  
        private readonly IConfiguration _configuration;

        public AuthController(IUsuarioRepository usuarioRepository, IConfiguration configuration)
        {
            _usuarioRepository = usuarioRepository;
            _configuration = configuration;
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
                var token = GenerateJwtToken(resultado);
                return Ok();

            }
            else 
                return BadRequest();
        }
      
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                // Usuário autenticado com sucesso, você pode gerar um token JWT aqui
                var token = GenerateJwtToken(user);

                return Ok(new { token });
            }

            return Unauthorized("Usuário ou senha inválidos");
        }

        private string GenerateJwtToken(ApplicationUser user)
        {
            var claims = new[]
            {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Name, user.UserName)
            // Adicione outras claims personalizadas, se necessário
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtIssuer"],
                audience: _configuration["JwtIssuer"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30), // Defina o tempo de expiração do token
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    

        [HttpPost("GerarToken")]
        public async Task<IActionResult> GerarToken()
        {
            var tokenGenerator = new JwtSettings();
            var secretKey = "SuaChaveSecretaAqui";
            var issuer = "https://localhost:7196/index.html";
            var audience = "https://localhost:7196/index.html";
            var expirationMinutes = 60; // Token expira em 60 minutos

            var claims = new[]
                            {
                    new Claim(ClaimTypes.Name, "SeuNome"),
                    new Claim(ClaimTypes.Email, "seu@email.com"),
                    // Adicione outras reivindicações conforme necessário
                };

            var token = tokenGenerator.GenerateToken(secretKey, issuer, audience, expirationMinutes, claims);
            Console.WriteLine("Token JWT gerado:");
            Console.WriteLine(token);
            return Ok(token);
        }
    }
}
