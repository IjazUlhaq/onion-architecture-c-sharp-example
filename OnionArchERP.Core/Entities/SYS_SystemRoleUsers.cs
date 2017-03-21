using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchERP.Core.Entities
{
    public class SYS_SystemRoleUser
    {
        public int ID { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> BranchId { get; set; }

        public virtual SYS_Branch Branch { get; set; }
        public virtual SYS_Company Company { get; set; }
        public virtual SYS_SystemRole SYS_SystemRole { get; set; }
        public virtual SYS_User SYS_User { get; set; }
    }
}
