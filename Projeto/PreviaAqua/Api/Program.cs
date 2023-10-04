using Api;
using Infra.Configurations;
using Infra.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Configuração do serviço de banco de dados
string connectionString = "Server=myServerAddress;Port=3306;User=myUsername;Password=myPassword;";
//builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)), ServiceLifetime.Transient);
builder.Services.AddDbContext<ApplicationDbContext>();

// Configuração do ASP.NET Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Configuração da autenticação JWT
builder.Services.AddJwtConfiguration(builder);

// Outras configurações de serviços
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

// Registro de outros serviços
builder.Services.AddScoped<UserManager<ApplicationUser>>();
builder.Services.AddScoped<SignInManager<ApplicationUser>>();
builder.Services.AddScoped<RoleManager<IdentityRole>>();
builder.Services.AddScoped<ApplicationUser>();
builder.Services.AddScoped<JwtSettings>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

// Configuração do Swagger/OpenAPI
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

// Configuração do middleware de autenticação e autorização
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
});

// Criação da aplicação
var app = builder.Build();

app.UseHttpsRedirection(); // Redireciona HTTP para HTTPS
app.UseRouting(); // Configura o middleware de roteamento

// Middleware de autenticação e autorização
app.UseAuthentication();
app.UseAuthorization();

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
