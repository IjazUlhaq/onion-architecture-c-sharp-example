using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchERP.Core.Entities
{
   public class SYS_Module
    {
       public SYS_Module()
        {
            this.CompanySubscriptionModules = new HashSet<SYS_CompanySubscriptionModule>();
            this.DE_Forms = new HashSet<SYS_Form>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Status { get; set; }
        public Nullable<int> OrderIndex { get; set; }

        public virtual ICollection<SYS_CompanySubscriptionModule> CompanySubscriptionModules { get; set; }
        public virtual ICollection<SYS_Form> DE_Forms { get; set; }
    }
}
