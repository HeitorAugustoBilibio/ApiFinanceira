using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.DTOs;
using Service.Interfaces;

namespace APIFinanceira.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult EditarUsuario([FromBody] LoginDTO loginDTO)
        {
            var retorno = _loginService.ObterAutenticacao(loginDTO);
            return Ok(retorno);
        }
    }
}
