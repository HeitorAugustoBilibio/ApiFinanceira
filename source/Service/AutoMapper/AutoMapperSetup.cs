using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entidades;
using Service.DTOs;

namespace Service.AutoMapper;

public class AutoMapperSetup : Profile
{
    public AutoMapperSetup()
    {
        CreateMap<UsuarioDTO, Usuario>().ReverseMap();
        CreateMap<MovimentacaoDTO, Movimentacao>().ReverseMap();
        CreateMap<LoginDTO, Login>().ReverseMap();
    }
}

