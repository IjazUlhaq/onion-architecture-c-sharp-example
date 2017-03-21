using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchERP.Core.Entities
{
    public class SYS_BranchEmailAddress
    {
        public int ID { get; set; }
        public Nullable<int> EmailAddressId { get; set; }
        public string Status { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> CompanyId { get; set; }

        public virtual SYS_Branch Branch { get; set; }
        public virtual SYS_Company Company { get; set; }
        public virtual SYS_EmailAddress EmailAddress { get; set; }
    }
}
