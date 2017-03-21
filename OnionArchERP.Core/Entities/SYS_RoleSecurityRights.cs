using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchERP.Core.Entities
{
    public class SYS_RoleSecurityRights
    {
        public int ID { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> FormId { get; set; }
        public bool View { get; set; }
        public bool Add { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }

        public virtual SYS_Form Forms { get; set; }
        public virtual SYS_SystemRole SYS_SystemRole { get; set; }
    }
}
