using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Service.DTOs;

public class UsuarioDTO
{
    public int Id { get; set; }

    public string Nome { get; set; }
    public string Foto { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public int Cargo { get; set; }
}
