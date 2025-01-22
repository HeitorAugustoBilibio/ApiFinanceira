using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades;

public class CategoryMovement : EntityBase
{
    public string? Description { get; set; }
    public MovementType MovementType { get; set; }
}
