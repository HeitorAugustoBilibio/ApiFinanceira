using Domain.Entidades;
using Service.DTOs;

namespace Service.Interfaces;

public interface IUserService
{
     bool criarUsuario(UserDTO usuario);
     List<UserDTO> buscarUsuarios();
     UserDTO buscarUsuarioPorId(int id);
     bool editarUsuario(UserDTO usuario, int Id);
     bool removerUsuario(int id);
}
