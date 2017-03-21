using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchERP.Core.Entities
{
   public class HC_EmployeeEmailAddress
    {
        public int ID { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> EmailId { get; set; }
        public string Status { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> BranchId { get; set; }

        public virtual SYS_Company Company { get; set; }
        public virtual SYS_Branch Branch { get; set; }
        public virtual HC_Employee Employee { get; set; }
        public virtual SYS_EmailAddress EmailAddress { get; set; }
    }
}
