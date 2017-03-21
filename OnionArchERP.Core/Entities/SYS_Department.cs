using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchERP.Core.Entities
{
   public class SYS_Department
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> DepLevel { get; set; }
        public Nullable<int> ParentDepId { get; set; }
        public string Status { get; set; }
        public Nullable<int> TypeId { get; set; }
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
