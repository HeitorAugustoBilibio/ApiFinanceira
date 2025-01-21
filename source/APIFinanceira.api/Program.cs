using Domain.Entidades;
using Infra;
using Microsoft.EntityFrameworkCore;
using Service.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<AuthService>();


// Configurar o DbContext
builder.Services.AddDbContext<ApiFinanceiroContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("ControleFinanceiroDatabase"),
        b => b.MigrationsAssembly("Infra")));

// Configurar os serviços da API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Middlewares
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

app.Run();
