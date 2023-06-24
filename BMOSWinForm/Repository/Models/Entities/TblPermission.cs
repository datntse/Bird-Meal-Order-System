using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblPermission
    {
        public int PermissionId { get; set; }
        public int? UserRoleId { get; set; }
        public string PermissionName { get; set; }
    }
}
