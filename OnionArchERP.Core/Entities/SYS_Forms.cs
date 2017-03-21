using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchERP.Core.Entities
{
   public class SYS_Form
    {
       public SYS_Form()
        {
            this.CustomFields = new HashSet<SYS_CustomField>();
            this.CustomFieldValue = new HashSet<SYS_CustomFieldValue>();
            this.ChildForms = new HashSet<SYS_Form>();
            this.SYS_RoleSecurityRights = new HashSet<SYS_RoleSecurityRights>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public string Status { get; set; }
        public Nullable<int> FormTypeId { get; set; }
        public Nullable<int> DisplayIndex { get; set; }
        public string ImagePath { get; set; }
        public string PagePath { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<bool> IsMain { get; set; }

        public virtual ICollection<SYS_CustomField> CustomFields { get; set; }
        public virtual ICollection<SYS_CustomFieldValue> CustomFieldValue { get; set; }
        public virtual ICollection<SYS_Form> ChildForms { get; set; }
        public virtual SYS_Form ParentForm { get; set; }
        public virtual SYS_FormType FormType { get; set; }
        public virtual SYS_Module Modules { get; set; }
        public virtual ICollection<SYS_RoleSecurityRights> SYS_RoleSecurityRights { get; set; }
    }
}
