using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchERP.Core.Entities
{
   public class HC_Designation
    {
        public int ID { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string ReportsTo { get; set; }
        public bool AttendanceEnabled { get; set; }
        public Nullable<int> DutyTimeId { get; set; }
        public Nullable<int> AttendanceRuleId { get; set; }
        public bool OverTimeAllowed { get; set; }
        public Nullable<decimal> OverTimeRate { get; set; }
        public bool DailyWagesStatus { get; set; }
        public Nullable<decimal> DailyRate { get; set; }
        public Nullable<decimal> BasicSalary { get; set; }
        public Nullable<decimal> AllowncesTotal { get; set; }
        public Nullable<decimal> Gross { get; set; }
        public Nullable<decimal> DeductionsTotal { get; set; }
        public Nullable<decimal> NetSalary { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDateTime { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTimeOffset> UpdatedDateTime { get; set; }

        public virtual SYS_Company Company { get; set; }
        public virtual SYS_Branch Branch { get; set; }

    }
}
