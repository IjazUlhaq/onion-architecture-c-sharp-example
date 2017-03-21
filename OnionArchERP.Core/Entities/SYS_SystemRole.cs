using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchERP.Core.Entities
{
   public class SYS_SystemRole
    {
       public SYS_SystemRole()
        {
            this.SYS_RoleSecurityRights = new HashSet<SYS_RoleSecurityRights>();
            this.SYS_SystemRoleUsers = new HashSet<SYS_SystemRoleUser>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<bool> SystemGroup { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDatetime { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTimeOffset> UpdatedDateTime { get; set; }
    
        public virtual SYS_Branch Branch { get; set; }
        public virtual SYS_Company Company { get; set; }
        public virtual ICollection<SYS_RoleSecurityRights> SYS_RoleSecurityRights { get; set; }
        public virtual ICollection<SYS_SystemRoleUser> SYS_SystemRoleUsers { get; set; }
    }
}
