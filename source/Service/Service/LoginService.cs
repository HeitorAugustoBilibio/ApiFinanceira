using AutoMapper;
using Domain.Entidades;
using Infra;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Service.DTOs;
using Service.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Service.Service;

public class LoginService : ILoginService

{
    private readonly IMapper _mapper;
    private readonly ApiFinanceiroContext _dbContext;
    
    public LoginService(ApiFinanceiroContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }
    public string ObterAutenticacao(LoginDTO loginDTO)
    {
        var mapperToModel = _mapper.Map<Login>(loginDTO);
        var usuarioExistente = ObterUsuarioExistente(mapperToModel.Email, mapperToModel.Password);

        if (usuarioExistente == null)
            return "";

         return new AuthService().GenarateToken(usuarioExistente)??"";        
    }
    public Login? ObterUsuarioExistente(string emailExistente, string senhaExistente)
    {
        Login login = new Login();
        string query = $"SELECT \"Email\", \"Password\" FROM public.\"User\" where \"Email\" ILIKE @Email AND \"Password\" ILIKE @Senha";
        using (var command = new SqlCommand(query))

            try
            {
            var usuario = _dbContext.User
                          .FromSqlRaw(query,
                            new Npgsql.NpgsqlParameter("@Email", emailExistente),
                            new Npgsql.NpgsqlParameter("@Senha", senhaExistente))
                          .Select(x => new
                          {
                              email = x.Email,
                              senha = x.Password
                          })
                          .First();
            login.Email = usuario.email;
            login.Password = usuario.senha;
            return login;
        }
        catch (Exception)
        {
            throw;
        }
        
    }
}
