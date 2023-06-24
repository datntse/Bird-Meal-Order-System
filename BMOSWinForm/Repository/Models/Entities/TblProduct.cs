using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblProduct
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
        public double? Weight { get; set; }
        public bool? IsAvailable { get; set; }
        public bool? IsLoved { get; set; }
        public bool? Status { get; set; }
        public double? Price { get; set; }
        public string ImagelInk { get; set; }
        public string Type { get; set; }
    }
}
