using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchERP.Core.Entities
{
   public class SYS_FieldType
    {
       public SYS_FieldType()
        {
            this.CustomFields = new HashSet<SYS_CustomField>();
        }
    
        public int ID { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<SYS_CustomField> CustomFields { get; set; }
    }
}
