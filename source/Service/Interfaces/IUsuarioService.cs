using Domain.Entidades;
using Service.DTOs;

namespace Service.Interfaces;

public interface IUsuarioService
{
     bool criarUsuario(UsuarioDTO usuario);
     List<UsuarioDTO> buscarUsuarios();
     UsuarioDTO buscarUsuarioPorId(int id);
     bool editarUsuario(UsuarioDTO usuario);
     bool removerUsuario(int id);
}
