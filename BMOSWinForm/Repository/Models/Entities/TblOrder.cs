using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblOrder
    {
        public string OrderId { get; set; }
        public string UserId { get; set; }
        public double? TotalPrice { get; set; }
        public DateTime? Date { get; set; }
        public bool? IsConfirm { get; set; }
    }
}
