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
        private readonly IUserService _usuarioService;

        public UsuarioControllers(IUserService usuarioService, IMapper mapper, ApiFinanceiroContext apiFinanceiroContext)
        {
            _usuarioService = new UserService(apiFinanceiroContext, mapper);
        }

        [HttpGet("ListUser")]
        public IActionResult ListarUsuario()
        {
            var usuarios = _usuarioService.buscarUsuarios();
            return Ok(usuarios);
        }
        [HttpGet("ListUser/{id}")]
        public IActionResult ListaUsuarioId(int id)
        {
            var usuario = _usuarioService.buscarUsuarioPorId(id);
            return Ok(usuario);
        }
        [HttpPost("CreateUser")]
        public IActionResult CriarUsuario([FromBody] UserDTO usuarioDTO)
        {
            var retorno = _usuarioService.criarUsuario(usuarioDTO);
            return Ok(retorno);
        }
        [HttpPut("EditUser/{Id}")]
        public IActionResult EditarUsuario([FromBody] UserDTO usuarioDTO, int Id)
        {
            var retorno = _usuarioService.editarUsuario(usuarioDTO, Id);
            return Ok(retorno);
        }


        [HttpDelete("DeleteUser")]
        public IActionResult DeletaUsuario(int id)
        {
            var retorno = _usuarioService.removerUsuario(id);
            return Ok(retorno);
        }

    }
}
