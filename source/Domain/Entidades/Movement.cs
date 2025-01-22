using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades;

public class Movement : EntityBase
{
    public DateTimeOffset Launch { get; set; }
    public DateTimeOffset Payment { get; set; }
    public int ParcelQuantity { get; set; }
    public int ParcelNumber { get; set; }
    public decimal Value { get; set; }
    public decimal ValueInterest { get; set; }
    public MovementType? MovementType { get; set; }
}
