using Domain.Entidades;
using Infra;
using Service.Interfaces;

namespace Service.Service;

public class UsuarioService : IUsuario
{
    private readonly ApiFinanceiroContext _dbContext;
    public UsuarioService(ApiFinanceiroContext dbContext)
    {
        _dbContext = dbContext;
    }
    public List<Usuario> buscarUsuarios()
    {
        return _dbContext.Usuarios.ToList();
    }

    public Usuario buscarUsuarioPorId(int id)
    {
        try
        {
            var usuario = _dbContext.Usuarios.FirstOrDefault(x => x.Id == id);
            return usuario;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }
    public bool criarUsuario(Usuario usuario)
    {
        try
        {
            _dbContext.Add(usuario);
            _dbContext.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return false;
            throw;
        }
        
    }
    public bool editarUsuario(Usuario usuario, int id)
    {
        try
        {
            var usuarioEditado = buscarUsuarioPorId(id);
            if (usuarioEditado == null)
            {
                return false;
            }

            usuarioEditado.Nome = usuario.Nome;
            usuarioEditado.Cpf = usuario.Cpf;
            usuarioEditado.Foto = usuario.Foto;
            usuarioEditado.Cargo = usuario.Cargo;
            usuarioEditado.Email = usuario.Email;
            usuarioEditado.Senha = usuario.Senha;

            _dbContext.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return false;
            throw;
        }

    }

    public bool removerUsuario(int id)
    {
        try
        {
            var usuarioRemovido = buscarUsuarioPorId(id);
            if(usuarioRemovido == null)
                return false;

            _dbContext.Remove(id);
            return true;
        }
        catch (Exception)
        {
            return false;
            throw;
        }
        
    }

}
