using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades;

public class MovementType : EntityBase
{
    public bool Enter { get; set; }
    public bool Leave { get; set; }
}
