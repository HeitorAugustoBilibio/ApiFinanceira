using Domain.Entidades;

namespace Service.Interfaces;

public interface IAuthService
{
    string? GenarateToken(Login login);
}
