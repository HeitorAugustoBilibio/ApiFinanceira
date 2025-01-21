using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Entidades;
using Microsoft.IdentityModel.Tokens;
using Service.Interfaces;

namespace Service.Service;

public class AuthService : IAuthService
{
    private ClaimsIdentity GenerateClaims(Login login)
    {
        var ci = new ClaimsIdentity();
        ci.AddClaim(new Claim(ClaimTypes.Email, login.Email ?? ""));
        ci.AddClaim(new Claim("Senha", login.Senha ?? ""));
        return ci;
    }

    public string? GenarateToken(Login login)
    {
        var handler = new JwtSecurityTokenHandler();

        var credentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.privateKey)),
            algorithm: SecurityAlgorithms.HmacSha256Signature);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = GenerateClaims(login),
            SigningCredentials = credentials,
            Expires = DateTime.UtcNow.AddHours(8),
        };
        
        var token = handler.CreateToken(tokenDescriptor);

        return handler.WriteToken(token);  
    }


}
