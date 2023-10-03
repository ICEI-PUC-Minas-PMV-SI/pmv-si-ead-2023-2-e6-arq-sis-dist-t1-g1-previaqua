using Infra.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Infra.Repositories
{
    public class UsuarioRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UsuarioRepository(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> CriarUsuarioAsync(ApplicationUser usuario, string senha)
        {
            return await _userManager.CreateAsync(usuario, senha);
        }

        public async Task<ApplicationUser?> BuscarUsuarioPorIdAsync(string userId)
        {
            return await _userManager.FindByIdAsync(userId);
        }

        public async Task<ApplicationUser?> BuscarUsuarioPorEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<List<ApplicationUser>> ListarUsuariosAsync()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<SignInResult> AutenticarUsuarioAsync(string email, string senha)
        {
            return await _signInManager.PasswordSignInAsync(email, senha, isPersistent: false, lockoutOnFailure: false);
        }

        // Você pode adicionar mais métodos conforme necessário para seu caso de uso
    }
}
