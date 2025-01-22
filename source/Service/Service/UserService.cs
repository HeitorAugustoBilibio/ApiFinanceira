using System.Collections.Generic;
using AutoMapper;
using Domain.Entidades;
using Infra;
using Service.DTOs;
using Service.Interfaces;

namespace Service.Service;

public class UserService : IUserService
{
    private readonly IMapper _mapper;
    private readonly ApiFinanceiroContext _dbContext;
    public UserService(ApiFinanceiroContext dbContext, IMapper mapper)
    {
        _mapper = mapper;
        _dbContext = dbContext;
    }
    public List<UserDTO> buscarUsuarios()
    {
        var usuariosDTO = _mapper.Map<List<UserDTO>>(_dbContext.User.ToList());
        return usuariosDTO;
    }

    public UserDTO buscarUsuarioPorId(int id)
    {
        try
        {
            var usuarioDTO = _mapper.Map<UserDTO> (_dbContext.User.FirstOrDefault(x => x.Id == id));
            return usuarioDTO;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }


    public bool criarUsuario(UserDTO usuarioDto)
    {
        try
        {
            var mapperToModel = _mapper.Map<User>(usuarioDto);
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
    public bool editarUsuario(UserDTO usuarioDTO, int Id)
    {
        try
        {
            var usuario = _mapper.Map<User>(usuarioDTO);
            User? usuarioExistente = _dbContext.User.FirstOrDefault(x => x.Id == Id);
            if (usuarioExistente == null)
                return false;

            usuarioExistente.Name = usuario.Name;
            usuarioExistente.Cpf = usuario.Cpf;
            usuarioExistente.Picture = usuario.Picture;
            usuarioExistente.Email = usuario.Email;
            usuarioExistente.Password = usuario.Password;
            usuarioExistente.Position = usuario.Position;
                
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

            _dbContext.Remove(_dbContext.User.First(x => x.Id == id));
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
