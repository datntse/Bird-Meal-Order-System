using System;
using System.Collections.Generic;

namespace BMOS.Models.Entities;

public partial class TblVoucherUsed
{
    public string Id { get; set; } = null!;

    public string? VoucherId { get; set; }

    public int? UserId { get; set; }
}
