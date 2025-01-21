using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace Service.DTOs;

public class MovimentacaoDTO
{
    public DateTimeOffset LançamentoDTO { get; set; }
    public DateTimeOffset PagamentoDTO { get; set; }
    public int QuantidadeParcelaDTO { get; set; }
    public int NumeroParcelaDTO { get; set; }
    public decimal ValorDTO { get; set; }
    public decimal ValorJurosDTO { get; set; }
    public int TipoMovimentacaoDTO { get; set; }
}
