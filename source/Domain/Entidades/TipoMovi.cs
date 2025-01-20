using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades;

public class TipoMovi : EntityBase
{
    public bool Entrada { get; set; }
    public bool Saida { get; set; }
}
