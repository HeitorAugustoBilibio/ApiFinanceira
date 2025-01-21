using Domain.Entidades;

namespace Service.Interfaces;

public interface IUsuario
{
     bool criarUsuario(Usuario usuario);
     List<Usuario> buscarUsuarios();
     Usuario buscarUsuarioPorId(int id);
     bool editarUsuario(Usuario usuario, int id);
     bool removerUsuario(int id);
}
