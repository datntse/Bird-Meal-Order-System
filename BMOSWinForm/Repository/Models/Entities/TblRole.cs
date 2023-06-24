using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblRole
    {
        public int UserRoleId { get; set; }
        public string RoleName { get; set; }

        public virtual TblPermission UserRole { get; set; }
        public virtual TblUser UserRoleNavigation { get; set; }
    }
}
