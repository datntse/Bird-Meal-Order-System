using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsConfirm { get; set; } = true;
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Numberphone { get; set; }
        public string Address { get; set; }
        public DateTime? DateCreate { get; set; } = DateTime.Now;
        public DateTime? LastActivitty { get; set; }
        public double? Point { get; set; } = 0;
        public bool? Status { get; set; }
        public int? UserRoleId { get; set; } = 2;
    }
}
