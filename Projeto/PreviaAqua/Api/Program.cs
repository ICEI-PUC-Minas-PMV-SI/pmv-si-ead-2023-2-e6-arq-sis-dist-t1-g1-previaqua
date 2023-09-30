using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Configure o Swagger/OpenAPI
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Previa Aqua", Version = "v1" });
});

var app = builder.Build();

// Configure o HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Habilitar o Swagger e a interface do Swagger UI
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Previa Aqua v1"); // O título aqui deve ser igual ao definido em SwaggerDoc
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
