using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblRouting
    {
        public string RoutingId { get; set; }
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public bool? Status { get; set; }

        public virtual TblProduct Product { get; set; }
    }
}
