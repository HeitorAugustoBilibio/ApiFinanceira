using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entidades;

namespace Service.DTOs;

public class MovementDTO
{
    public DateTimeOffset Launch { get; set; }
    public DateTimeOffset Payment { get; set; }
    public int ParcelQuantity { get; set; }
    public int ParcelNumber { get; set; }
    public decimal Value { get; set; }
    public decimal ValueInterest { get; set; }
    public int MovementType { get; set; }
}
