using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchERP.Core.Entities
{
    public class SYS_CompanySubscriptionModule
    {
        public int ID { get; set; }
        public Nullable<int> SubscriptionId { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTimeOffset> RegistrationDate { get; set; }
        public string Status { get; set; }

        public virtual SYS_CompanySubscription CompanySubscription { get; set; }
        public virtual SYS_Module Modules { get; set; }
    }
}
