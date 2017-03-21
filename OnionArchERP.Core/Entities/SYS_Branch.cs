using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchERP.Core.Entities
{
   public class SYS_Branch
    {
       public SYS_Branch()
       {
           this.ContactNumbers = new HashSet<SYS_ContactNo>();
           this.EmailAddresses = new HashSet<SYS_EmailAddress>();
           this.PostalAddresses = new HashSet<SYS_PostalAddress>();
           this.Designations = new HashSet<HC_Designation>();
           this.Departments = new HashSet<SYS_Department>();
           this.Employees = new HashSet<HC_Employee>();
           this.EmployeeJoinings = new HashSet<HC_EmployeeJoining>();
       }

        public int ID { get; set; }
        public string BranchCode { get; set; }
        public string ExternalBranchCode { get; set; }
        public string BranchName { get; set; }
        public string LanguageCode { get; set; }
        public Nullable<int> TimeZoneId { get; set; }
        public Nullable<int> AddressId { get; set; }
        public Nullable<int> DateFormatId { get; set; }
        public Nullable<int> TimeFormatId { get; set; }
        public Nullable<int> GroupId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDateTime { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTimeOffset> UpdatedDateTime { get; set; }
        public string Url { get; set; }

        public virtual SYS_Company Company { get; set; }
        public virtual ICollection<SYS_ContactNo> ContactNumbers { get; set; }
        public virtual ICollection<SYS_EmailAddress> EmailAddresses { get; set; }
        public virtual ICollection<SYS_PostalAddress> PostalAddresses { get; set; }
        public virtual ICollection<HC_Designation> Designations { get; set; }
        public virtual ICollection<SYS_Department> Departments { get; set; }
        public virtual ICollection<HC_Employee> Employees { get; set; }
        public virtual ICollection<HC_EmployeeJoining> EmployeeJoinings { get; set; }
    }
}
