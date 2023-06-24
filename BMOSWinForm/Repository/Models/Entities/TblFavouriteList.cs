using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblFavouriteList
    {
        public string FavouriteListId { get; set; }
        public string UserId { get; set; }
        public string ProductId { get; set; }
    }
}
