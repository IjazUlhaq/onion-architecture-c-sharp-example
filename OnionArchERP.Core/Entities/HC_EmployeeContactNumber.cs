using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchERP.Core.Entities
{
   public class HC_EmployeeContactNumber
    {
        public int ID { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<int> ContactNumberId { get; set; }
        public string Status { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> BranchId { get; set; }

        public virtual SYS_Company Company { get; set; }
        public virtual SYS_Branch Branch { get; set; }
        public virtual HC_Employee Employee { get; set; }
        public virtual SYS_ContactNo ContactNumber { get; set; }
    }
}
