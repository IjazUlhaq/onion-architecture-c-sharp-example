using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnionArchERP.Core.Entities
{
    public class SYS_FormType
    {
        public SYS_FormType()
        {
            this.DE_Forms = new HashSet<SYS_Form>();
        }

        public int ID { get; set; }
        public string Type { get; set; }

        public virtual ICollection<SYS_Form> DE_Forms { get; set; }
    }
}
