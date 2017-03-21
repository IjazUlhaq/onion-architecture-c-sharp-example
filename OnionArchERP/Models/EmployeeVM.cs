using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnionArchERP.Models
{
    public class EmployeeVM
    {
        public int ID { get; set; }
        public string Code { get; set; }

        [Display(Name="First Name*")]
        [Required(ErrorMessage="Required")]
        public string FirstName { get; set; }

        [Display(Name = "Middle")]
        public string MiddleName { get; set; }

        [Display(Name = "Last")]
        public string LastName { get; set; }

        [Display(Name = "Relation*")]
        [Required(ErrorMessage="Required")]
        public Nullable<int> RelationId { get; set; }

        [Display(Name = "First Name")]
        public string GuardianFirstName { get; set; }

        [Display(Name = "Middle")]
        public string GuardianMiddleName { get; set; }

        [Display(Name = "Last")]
        public string GuardianLastName { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Date Of Birth")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }

        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }

        [Display(Name = "National Id No")]
        public string NationalIdNo { get; set; }

        [Display(Name = "Passport No")]
        public string PasportNo { get; set; }

        public byte[] Image { get; set; }

        [Display(Name = "Blood Group")]
        public Nullable<int> BloodGroupId { get; set; }

        [Display(Name = "Relation")]
        public Nullable<int> ReligionId { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

        [Display(Name = "Carear Start Date")]
        public Nullable<System.DateTime> CarearStartDate { get; set; }
    }
}