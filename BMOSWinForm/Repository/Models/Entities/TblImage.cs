using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblImage
    {
        public string ImageId { get; set; }
        public string Name { get; set; }
        public string RelationId { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
    }
}
