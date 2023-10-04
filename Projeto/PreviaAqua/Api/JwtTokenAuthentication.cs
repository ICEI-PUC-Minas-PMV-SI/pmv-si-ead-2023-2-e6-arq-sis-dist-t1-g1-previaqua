using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Api
{
	public static class JwtTokenAuthentication
	{

		public static void AddJwtConfiguration(this IServiceCollection services, WebApplicationBuilder builder)
		{

            JwtSettings JwtAppSettings = new JwtSettings
            {
                ValidIssuer = "https://localhost:7196/index.html", // URL da sua aplicação
                ValidAudience = "https://localhost:7196/index.html", // URL da sua aplicação
                SecretKey = "SuaChaveSecretaAqui"
            };

            services.AddAuthentication("Bearer")
                .AddJwtBearer("Bearer", options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidIssuer = JwtAppSettings.ValidIssuer,
                        ValidAudience = JwtAppSettings.ValidAudience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtAppSettings.SecretKey)),
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = false,
                        ValidateIssuerSigningKey = true
                    };
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("PreviaAqua",
					authBuilder =>
                    {
                        authBuilder.AddAuthenticationSchemes("App");
                        authBuilder.RequireAuthenticatedUser();
                    });
               
            });
        }
	}
}
