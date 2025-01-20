using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades;

public class Movimentacao : EntityBase
{
    public DateTimeOffset Lançamento { get; set; }
    public DateTimeOffset Pagamento { get; set; }
    public int QuantidadeParcela { get; set; }
    public int NumeroParcela { get; set; }
    public decimal Valor { get; set; }
    public decimal ValorJuros { get; set; }
    public TipoMovi? TipoMovimentacao { get; set; }
}
