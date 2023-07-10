using System;
using System.Collections.Generic;

namespace BMOS.Models.Entities;

public partial class TblRouting
{
    public string RoutingId { get; set; } = null!;

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? Quantity { get; set; }

    public double? Price { get; set; }

    public bool? Status { get; set; }
}
