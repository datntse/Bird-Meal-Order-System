using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMOS.Models.Entities;

public partial class TblRouting
{
    [NotMapped]
    public List<SelectListItem> productList { get; set; }
    [NotMapped]
    public string[] listProductId { get; set; }
    public string RoutingId { get; set; } = null!;

    public string? ProductId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? Quantity { get; set; }

    public double? Price { get; set; }

    public bool? Status { get; set; }


}
