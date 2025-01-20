using Domain.Entidades;

namespace Service.Interfaces;

public interface IUsuario
{
    public bool criarUsuario(Usuario usuario);
    public List<Usuario> buscarUsuarios();
    public Usuario buscarUsuarioPorId(int id);
    public bool editarUsuario(Usuario usuario, int id);
    public bool removerUsuario(int id);
}
