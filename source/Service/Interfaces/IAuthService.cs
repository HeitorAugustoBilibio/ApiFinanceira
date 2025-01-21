using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace Service.Interfaces;

public interface IAuthService
{
    string? GenarateToken(Login login);
}
