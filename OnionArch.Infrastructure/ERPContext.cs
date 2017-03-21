using OnionArchERP.Core.Entities;
using System.Data.Entity;

namespace OnionArch.Infrastructure
{
    public class ERPContext : DbContext
    {
        public ERPContext()
            : base("name=ERPContextConnectionString")
        {
            var a = Database.Connection.ConnectionString;
        }

        public DbSet<HC_Employee> Employees { get; set; }

        public DbSet<SYS_EmailAddress> EmailAddresses { get; set; }

        public DbSet<HC_EmployeeEmailAddress> EmployeeEmailAddresses { get; set; }

        public DbSet<SYS_ContactNo> ContactNumbers { get; set; }

        public DbSet<SYS_PostalAddress> PostalAddresses { get; set; }

        public DbSet<SYS_Department> Departments { get; set; }

        public DbSet<HC_Designation> Designations { get; set; }

        public DbSet<HC_EmployeeJoining> EmployeeJoinings { get; set; }

        public DbSet<HC_Attendance> EmployeeAttendances { get; set; }

        public DbSet<SYS_Company> Companies { get; set; }

        public DbSet<SYS_CompanySubscription> CompanuSubscriptions { get; set; }

        public DbSet<SYS_CompanySubscriptionModule> CompanuSubscriptionModules { get; set; }

        public DbSet<SYS_Branch> Branches { get; set; }

        public DbSet<SYS_BranchContactNumber> BrancheContactNos { get; set; }

        public DbSet<SYS_BranchEmailAddress> BrancheEmailAddresses { get; set; }

        public DbSet<SYS_CustomField> CustomFields { get; set; }

        public DbSet<SYS_CustomFieldValue> CustomFieldValues { get; set; }

        public DbSet<SYS_FieldType> FieldTypes { get; set; }

        public DbSet<SYS_Form> Forms { get; set; }

        public DbSet<SYS_FormType> FormTypes { get; set; }

        public DbSet<SYS_Module> Modules { get; set; }

        public DbSet<SYS_SystemRole> SystemRoles { get; set; }

        public DbSet<SYS_SystemRoleUser> SystemRoleUser { get; set; }

        public DbSet<SYS_User> Users { get; set; }

        public DbSet<SYS_RoleSecurityRights> RoleSecurityRights { get; set; }
    }
}
