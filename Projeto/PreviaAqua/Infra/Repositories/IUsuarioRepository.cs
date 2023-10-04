using Infra.Configurations;
using Microsoft.AspNetCore.Identity;

namespace Infra.Repositories
{
    public interface IUsuarioRepository
    {
        Task<SignInResult> AutenticarUsuarioAsync(string email, string senha);
        Task<ApplicationUser> BuscarUsuarioPorEmailAsync(string email);
        Task<ApplicationUser> BuscarUsuarioPorIdAsync(string userId);
        Task<IdentityResult> CriarUsuarioAsync(ApplicationUser usuario, string senha);
        Task<List<ApplicationUser>> ListarUsuariosAsync();
        public Task<string> GerarToken(ApplicationUser user);
    }
}