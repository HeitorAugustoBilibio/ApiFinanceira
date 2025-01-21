using System.Collections.Generic;
using AutoMapper;
using Domain.Entidades;
using Infra;
using Service.DTOs;
using Service.Interfaces;

namespace Service.Service;

public class UsuarioService : IUsuarioService
{
    private readonly IMapper _mapper;
    private readonly ApiFinanceiroContext _dbContext;
    public UsuarioService(ApiFinanceiroContext dbContext, IMapper mapper)
    {
        _mapper = mapper;
        _dbContext = dbContext;
    }
    public List<UsuarioDTO> buscarUsuarios()
    {
        var usuariosDTO = _mapper.Map<List<UsuarioDTO>>(_dbContext.Usuarios.ToList());
        return usuariosDTO;
    }

    public UsuarioDTO buscarUsuarioPorId(int id)
    {
        try
        {
            var usuarioDTO = _mapper.Map<UsuarioDTO> (_dbContext.Usuarios.FirstOrDefault(x => x.Id == id));
            return usuarioDTO;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }


    public bool criarUsuario(UsuarioDTO usuarioDto)
    {
        try
        {
            var mapperToModel = _mapper.Map<Usuario>(usuarioDto);
            _dbContext.Add(mapperToModel);
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
    public bool editarUsuario(UsuarioDTO usuarioDTO)
    {
        try
        {
            var usuario = _mapper.Map<Usuario>(usuarioDTO);

            if (_dbContext.Usuarios.FirstOrDefault(x => x.Id == usuario.Id) == null)
                return false;

            _dbContext.Update(usuario);
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

            _dbContext.Remove(_dbContext.Usuarios.First(x => x.Id == id));
            _dbContext.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
            throw;
        }
        
    }

}
