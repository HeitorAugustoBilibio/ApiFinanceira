using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades;

public class CategoriaMovi : EntityBase
{
    public string? Descricao { get; set; }
    public TipoMovi TipoMovimentacao { get; set; }
}
