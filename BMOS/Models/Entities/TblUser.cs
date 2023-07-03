using System;
using System.Collections.Generic;

namespace BMOS.Models.Entities;

public partial class TblUser
{
    public string UserId { get; set; } = null!;

    public string? Username { get; set; }

    public string? Password { get; set; }

    public bool? IsConfirm { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Numberphone { get; set; }

    public string? Address { get; set; }

    public DateTime? DateCreate { get; set; }

    public DateTime? LastActivitty { get; set; }

    public double? Point { get; set; }

    public bool? Status { get; set; }

    public int? UserRoleId { get; set; }

    public virtual ICollection<TblAddress> TblAddresses { get; set; } = new List<TblAddress>();

    public virtual ICollection<TblFavouriteList> TblFavouriteLists { get; set; } = new List<TblFavouriteList>();

    public virtual ICollection<TblFeedback> TblFeedbacks { get; set; } = new List<TblFeedback>();

    public virtual ICollection<TblNotify> TblNotifies { get; set; } = new List<TblNotify>();

    public virtual ICollection<TblOrder> TblOrders { get; set; } = new List<TblOrder>();

    public virtual ICollection<TblRefund> TblRefunds { get; set; } = new List<TblRefund>();
}
