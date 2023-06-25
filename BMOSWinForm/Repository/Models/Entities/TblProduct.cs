using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblFavouriteLists = new HashSet<TblFavouriteList>();
            TblFeedbacks = new HashSet<TblFeedback>();
            TblOrderDetails = new HashSet<TblOrderDetail>();
            TblRoutings = new HashSet<TblRouting>();
        }

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
        public byte[] Photo { get; set; }

        public virtual ICollection<TblFavouriteList> TblFavouriteLists { get; set; }
        public virtual ICollection<TblFeedback> TblFeedbacks { get; set; }
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
        public virtual ICollection<TblRouting> TblRoutings { get; set; }
    }
}
