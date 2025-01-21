using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;
using Infra;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Service.Interfaces;

namespace Service.Service;

public class LoginService : ILoginService

{
    private readonly ApiFinanceiroContext _dbContext;
    private readonly AuthService _authService;
    
    public LoginService(ApiFinanceiroContext dbContext, AuthService authService)
    {
        _authService = authService;
        _dbContext = dbContext;
    }
    public string ObterAutenticacao(string email, string senha)
    {
        var usuarioExistente = ObterUsuarioExistente(email, senha);

        if (usuarioExistente == null)
            return "";

         return _authService.GenarateToken(usuarioExistente);        
    }

    public Login? ObterUsuarioExistente(string emailExistente, string senhaExistente)
    {
        Login login = new Login();
        try
        {
            var usuario = _dbContext.Usuarios
                          .FromSql($"SELECT Email, Senha FROM Usuarios WHERE Email = {emailExistente} AND Senha = {senhaExistente}")
                          .Select(x => new
                          {
                              email = x.Email,
                              senha = x.Senha
                          })
                          .First();
            login.Email = usuario.email;
            login.Senha = usuario.senha;
            return login;
        }
        catch (Exception)
        {
            throw;
        }
        
    }
}
