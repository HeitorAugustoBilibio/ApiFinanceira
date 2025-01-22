using Domain.Entidades;
using Service.DTOs;

namespace Service.Interfaces;

public interface ILoginService
{
    string ObterAutenticacao(LoginDTO loginDTO);
    Login? ObterUsuarioExistente(string emailExistente, string senhaExistente);
}
