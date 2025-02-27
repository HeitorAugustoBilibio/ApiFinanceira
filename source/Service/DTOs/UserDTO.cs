﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Service.DTOs;

public class UserDTO
{
    public string? Name { get; set; }
    public string? Picture { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public int Cargo { get; set; }
}
