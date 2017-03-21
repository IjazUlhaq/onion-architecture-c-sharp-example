using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchERP.Core.Entities
{
    public class SYS_User
    {
        public SYS_User()
        {
            this.SYS_SystemRoleUsers = new HashSet<SYS_SystemRoleUser>();
        }

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string PlanePassword { get; set; }
        public string ConfirmationToken { get; set; }
        public string UserType { get; set; }
        public Nullable<int> UserTypeId { get; set; }
        public string AccountVerified { get; set; }
        public string AccountStatus { get; set; }
        public string ForwardInfo { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDateTime { get; set; }
        public Nullable<System.DateTimeOffset> UpdatedDateTime { get; set; }

        public virtual SYS_Branch Branch { get; set; }
        public virtual SYS_Company Company { get; set; }
        public virtual HC_Employee Employee { get; set; }
        public virtual ICollection<SYS_SystemRoleUser> SYS_SystemRoleUsers { get; set; }
    }
}
