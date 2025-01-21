using AutoMapper;
using Infra;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.DTOs;
using Service.Interfaces;
using Service.Service;

namespace APIFinanceira.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioControllers : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioControllers(IUsuarioService usuarioService, IMapper mapper, ApiFinanceiroContext apiFinanceiroContext )
        {
            _usuarioService = new UsuarioService(apiFinanceiroContext, mapper);
        }

        [HttpGet]
        public IActionResult ListarUsuario()
        {
            var usuarios = _usuarioService.buscarUsuarios();
            return Ok(usuarios);
        }
        [HttpGet("{id}")]
        public IActionResult ListaUsuarioId(int id)
        {
            var usuario = _usuarioService.buscarUsuarioPorId(id);
            return Ok(usuario);
        }
        [HttpPost]
        public IActionResult CriarUsuario([FromBody] UsuarioDTO usuarioDTO)
        {
           var retorno = _usuarioService.criarUsuario(usuarioDTO);
            return Ok(retorno); 
        }
        [HttpPut()]
        public IActionResult EditarUsuario([FromBody] UsuarioDTO usuarioDTO)
        {
            var retorno = _usuarioService.editarUsuario(usuarioDTO);
            return Ok(retorno);
        }


        [HttpDelete]
        public IActionResult DeletaUsuario(int id)
        {
            var retorno = _usuarioService.removerUsuario(id);
            return Ok(retorno);
        }

    }
}
