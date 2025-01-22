using Domain.Entidades;
using Service.DTOs;

namespace Service.Interfaces;

public interface IUsuarioService
{
     bool criarUsuario(UsuarioDTO usuario);
     List<UsuarioDTO> buscarUsuarios();
     UsuarioDTO buscarUsuarioPorId(int id);
     bool editarUsuario(UsuarioDTO usuario, int Id);
     bool removerUsuario(int id);
}
