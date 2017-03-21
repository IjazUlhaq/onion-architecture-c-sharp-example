using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchERP.Core.Entities
{
    public class SYS_CustomFieldValue
    {
        public int ID { get; set; }
        public Nullable<int> CustomFieldId { get; set; }
        public string Value { get; set; }
        public Nullable<int> RecordId { get; set; }
        public Nullable<int> FormId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDateTime { get; set; }

        public virtual SYS_CustomField CustomField { get; set; }
        public virtual SYS_Form Form { get; set; }
    }
}
