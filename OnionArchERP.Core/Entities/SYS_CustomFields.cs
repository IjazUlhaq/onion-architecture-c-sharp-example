using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchERP.Core.Entities
{
    public class SYS_CustomField
    {
        public SYS_CustomField()
        {
            this.CustomFieldValues = new HashSet<SYS_CustomFieldValue>();
        }

        public int ID { get; set; }
        public Nullable<int> TypeId { get; set; }
        public string Lable { get; set; }
        public Nullable<int> FormId { get; set; }
        public bool IsCompulsory { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDateTime { get; set; }

        public virtual SYS_FieldType FieldType { get; set; }
        public virtual SYS_Form Form { get; set; }
        public virtual ICollection<SYS_CustomFieldValue> CustomFieldValues { get; set; }
    }
}
