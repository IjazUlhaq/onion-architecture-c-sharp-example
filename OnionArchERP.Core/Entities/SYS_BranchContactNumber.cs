using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchERP.Core.Entities
{
    public class SYS_BranchContactNumber
    {
        public int ID { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> ContactNoId { get; set; }
        public string Status { get; set; }
        public Nullable<int> CompanyId { get; set; }

        public virtual SYS_Branch Branch { get; set; }
        public virtual SYS_Company Company { get; set; }
        public virtual SYS_ContactNo ContactNumber { get; set; }
    }
}
