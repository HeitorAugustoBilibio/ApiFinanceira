using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Entidades;
using Microsoft.IdentityModel.Tokens;

namespace Service.Service;

public class AuthService
{
    public Login GenarateToken(Usuario usuario)
    {
        Login login = new Login();
        var handler = new JwtSecurityTokenHandler();

        var key = Encoding.ASCII.GetBytes(Configuration.privateKey);
        var credentials = new SigningCredentials(
            new SymmetricSecurityKey(key),
            algorithm: SecurityAlgorithms.HmacSha256Signature);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = GenerateClaims(usuario),
            SigningCredentials = credentials,
            Expires = DateTime.UtcNow.AddHours(8),
        };
        
        var token = handler.CreateToken(tokenDescriptor);

        login.Token = handler.WriteToken(token);
        login.Expiration = token.ValidTo;
        login.Error = null;
        login.Usuario = usuario;

        return login; 
    }

    private static ClaimsIdentity GenerateClaims (Usuario usuario)
    {
        var ci = new ClaimsIdentity ();
        ci.AddClaim(new Claim(ClaimTypes.Name, usuario.Email));
        ci.AddClaim(new Claim("Senha", usuario.Senha));
        return ci;
    }
}
