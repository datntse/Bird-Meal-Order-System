using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblFeedback
    {
        public string FeedbackId { get; set; }
        public string ProductId { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public int? Star { get; set; }
        public DateTime? Date { get; set; }
    }
}
