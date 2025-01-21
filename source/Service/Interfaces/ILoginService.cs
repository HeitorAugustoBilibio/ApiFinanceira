using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace Service.Interfaces;

public interface ILoginService
{
    string ObterAutenticacao(string username, string password);

    Login? ObterUsuarioExistente(string emailExistente, string senhaExistente);
}
