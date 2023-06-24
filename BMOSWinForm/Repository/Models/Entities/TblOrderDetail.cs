using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblOrderDetail
    {
        public string OrderDetailId { get; set; }
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public DateTime? Date { get; set; }

        public virtual TblOrder Order { get; set; }
        public virtual TblProduct Product { get; set; }
    }
}
