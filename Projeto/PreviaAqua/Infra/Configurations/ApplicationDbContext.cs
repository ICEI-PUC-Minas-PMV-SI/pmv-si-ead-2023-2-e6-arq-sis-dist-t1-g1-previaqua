using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Domain.Entidades;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Infra.Configurations
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext()
        {
        }

        public DbSet<PrevisaoMeteorologica> PrevisaoMeteorologica { get; set; }

        private static JsonSerializerSettings GetJsonSerializerSettings()
        {
            return new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
        }

        // Outros DbSet e configurações, se necessário
    }

}
