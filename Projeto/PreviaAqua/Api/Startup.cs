using Microsoft.OpenApi.Models;
namespace Api
{
    public class Startup
    {



        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Nome do Seu API", Version = "v1" });
            });
           
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
          
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Nome do Seu API v1");
            });
            
        }
    }
}

