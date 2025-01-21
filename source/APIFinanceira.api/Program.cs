using Domain.Entidades;
using Infra;
using Microsoft.EntityFrameworkCore;
using Service.AutoMapper;
using Service.Interfaces;
using Service.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAuthentication().AddBearerToken();  

// Configurar o DbContext
builder.Services.AddDbContext<ApiFinanceiroContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("ControleFinanceiroDatabase"),
        b => b.MigrationsAssembly("Infra")));

// Configurar os serviços da API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMapperSetup));
builder.Services.AddTransient<ILoginService, LoginService>();
builder.Services.AddTransient<IUsuarioService, UsuarioService>();



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
