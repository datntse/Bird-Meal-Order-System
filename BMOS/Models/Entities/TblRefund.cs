using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMOS.Models.Entities;

public partial class TblRefund
{
    public string RefundId { get; set; }

    public int? UserId { get; set; }

    public string OrderId { get; set; }

    public string Description { get; set; }

    public DateTime? Date { get; set; }

    public bool? IsConfirm { get; set; }

    [NotMapped]
    public virtual TblOrder? Order { get; set; }
	[NotMapped]

	public virtual TblUser? User { get; set; }
}
