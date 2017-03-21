using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchERP.Core.Entities
{
   public class SYS_CompanySubscription
    {
       public SYS_CompanySubscription()
        {
            this.CompanySubscriptionModules = new HashSet<SYS_CompanySubscriptionModule>();
        }
    
        public int ID { get; set; }
        public string SubscriptionNumber { get; set; }
        public Nullable<System.DateTimeOffset> SubscriptionDate { get; set; }
        public Nullable<bool> IsTrial { get; set; }
        public string Expires { get; set; }
        public Nullable<System.DateTimeOffset> ExpiryDate { get; set; }
        public Nullable<bool> AllowMultipleBracnhes { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDateTime { get; set; }
        public Nullable<System.DateTimeOffset> UpdatedDateTime { get; set; }
    
        public virtual SYS_Company Company { get; set; }
        public virtual ICollection<SYS_CompanySubscriptionModule> CompanySubscriptionModules { get; set; }
    }
}
