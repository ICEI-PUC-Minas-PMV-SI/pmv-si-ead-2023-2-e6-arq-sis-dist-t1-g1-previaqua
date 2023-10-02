using Api;
using Infra.Configurations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var configuration = builder.Configuration
                .SetBasePath(builder.Environment.ContentRootPath)
                .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, reloadOnChange: true)
.AddEnvironmentVariables();

builder.Services.AddTransient<IConfiguration>(provider => configuration.Build());
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("JwtAuthorization", policy =>
    {
        policy.AuthenticationSchemes.Add(JwtBearerDefaults.AuthenticationScheme);
        policy.RequireAuthenticatedUser();
    });
});

var configurationRoot = new ConfigurationBuilder()
                                                        .SetBasePath(Environment.CurrentDirectory)
                                                        .AddConfiguration(configuration.Build());

builder.Services.AddTransient<IConfigurationRoot>(provider => configurationRoot.Build());

var connectionString = DatabaseConfig.GetConnectionString(configuration.Build());


builder.Services.AddScoped<Microsoft.AspNet.Identity.UserManager<ApplicationUser>>();
builder.Services.AddScoped<SignInManager<ApplicationUser>>();

builder.Services.AddJwtConfiguration(builder);

// Configure o Swagger/OpenAPI
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Nome do Seu API", Version = "v1" });

    // Configuração para suportar autenticação com Bearer (apiKey)
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                new string[] { }
            }
        });
});
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
});



builder.Services.AddScoped<ApplicationUser>();
builder.Services.AddScoped<JwtSettings>();


var app = builder.Build();

app.UseHttpsRedirection(); // Redireciona HTTP para HTTPS
app.UseRouting(); // Configura o middleware de roteamento
app.UseAuthentication(); // Configura o middleware de autenticação
app.UseAuthorization(); // Configura o middleware de autorização

app.UseSwagger(); // Configura o Swagger para geração de documentação
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Previa Aqua v1");
    c.DefaultModelsExpandDepth(-1); // Impede que os modelos sejam expandidos por padrão
    c.DocExpansion(DocExpansion.List);
    c.RoutePrefix = string.Empty; // Para acessar a página Swagger na raiz da URL
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Define o mapeamento dos endpoints dos controladores
});

app.Run(); // Encerra o pipeline e manipula solicitações não tratadas

