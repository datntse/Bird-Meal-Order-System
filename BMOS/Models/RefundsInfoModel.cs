namespace BMOS.Models
{
    public class RefundsInfoModel
    {
        public string? RefundId { get; set; }   
        public string? OrderId { get; set;}
        public string? UserId { get; set; }
        public string? Description { get; set;}
        public DateTime?  Date { get; set; }
        public bool? IsConfirm { get; set; }
    }
}
