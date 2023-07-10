using System;
using System.Collections.Generic;

namespace BMOS.Models.Entities;

public partial class TblProductInRouting
{
    public int Id { get; set; }

    public string? ProductId { get; set; }

    public string? RoutingId { get; set; }
}
