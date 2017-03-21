using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchERP.Core.Entities
{
    public class HC_Employee
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> RelationId { get; set; }
        public string GuardianFirstName { get; set; }
        public string GuardianMiddleName { get; set; }
        public string GuardianLastName { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string MaritalStatus { get; set; }
        public string NationalIdNo { get; set; }
        public string PasportNo { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> BloodGroupId { get; set; }
        public Nullable<int> ReligionId { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> CarearStartDate { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDateTime { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTimeOffset> UpdatedDateTime { get; set; }

        public String FullName
        {
            get
            {
                return(FirstName + " " + MiddleName + " " + LastName);
            }
        }

        public String GaurdianFullName
        {
            get
            {
                return (GuardianFirstName + " " + GuardianMiddleName + " " + GuardianLastName);
            }
        }

        public virtual SYS_Company Company { get; set; }
        public virtual SYS_Branch Branch { get; set; }

    }
}
