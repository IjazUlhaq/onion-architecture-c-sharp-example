using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchERP.Core.Entities
{
   public class HC_Attendance
    {
        public int ID { get; set; }
        public Nullable<int> DN { get; set; }
        public Nullable<int> DIN { get; set; }
        public Nullable<System.DateTime> Clock { get; set; }
        public Nullable<int> VeryfiMode { get; set; }
        public string AttTypeId { get; set; }
        public Nullable<System.DateTime> CollectionDate { get; set; }
        public Nullable<int> LastUpdatedUID { get; set; }
        public Nullable<System.DateTime> LastupdatedDate { get; set; }
        public string Remarks { get; set; }
        public string Name { get; set; }
        public Nullable<bool> SyncOnlineStatus { get; set; }
    }
}
