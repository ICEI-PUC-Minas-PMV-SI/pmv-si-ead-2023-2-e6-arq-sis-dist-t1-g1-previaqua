using Infra.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace Api.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly SignInManager<ApplicationUser> _signInManager;

        //public AuthController(
        //    UserManager<ApplicationUser> userManager,
        //    SignInManager<ApplicationUser> signInManager)
        //{
        //    _userManager = userManager;
        //    _signInManager = signInManager;
        //}

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            // Implemente o registro de usuários aqui usando _userManager
            // Gere e retorne um token JWT após o registro
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            // Implemente a lógica de login aqui usando _signInManager
            // Gere e retorne um token JWT após o login bem-sucedido
            return Ok();
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
