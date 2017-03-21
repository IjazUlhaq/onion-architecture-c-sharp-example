using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchERP.Core.Entities
{
    public class SYS_EmailAddress
    {
        public int ID { get; set; }
        public Nullable<int> ContactTypeId { get; set; }
        public string Description { get; set; }
        public bool RegisteredStatus { get; set; }
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
