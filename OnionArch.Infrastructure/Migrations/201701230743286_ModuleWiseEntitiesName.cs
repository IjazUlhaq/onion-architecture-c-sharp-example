namespace OnionArch.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModuleWiseEntitiesName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Branches", newName: "SYS_Branch");
            RenameTable(name: "dbo.Companies", newName: "SYS_Company");
            RenameTable(name: "dbo.ContactNoes", newName: "SYS_ContactNo");
            RenameTable(name: "dbo.Departments", newName: "SYS_Department");
            RenameTable(name: "dbo.Designations", newName: "HC_Designation");
            RenameTable(name: "dbo.Employees", newName: "HC_Employee");
            RenameTable(name: "dbo.PostalAddresses", newName: "SYS_PostalAddress");
            RenameTable(name: "dbo.Attendances", newName: "HC_Attendance");
            RenameTable(name: "dbo.EmployeeEmailAddresses", newName: "HC_EmployeeEmailAddress");
            RenameTable(name: "dbo.EmailAddresses", newName: "SYS_EmailAddress");
            RenameTable(name: "dbo.EmployeeJoinings", newName: "HC_EmployeeJoining");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.HC_EmployeeJoining", newName: "EmployeeJoinings");
            RenameTable(name: "dbo.SYS_EmailAddress", newName: "EmailAddresses");
            RenameTable(name: "dbo.HC_EmployeeEmailAddress", newName: "EmployeeEmailAddresses");
            RenameTable(name: "dbo.HC_Attendance", newName: "Attendances");
            RenameTable(name: "dbo.SYS_PostalAddress", newName: "PostalAddresses");
            RenameTable(name: "dbo.HC_Employee", newName: "Employees");
            RenameTable(name: "dbo.HC_Designation", newName: "Designations");
            RenameTable(name: "dbo.SYS_Department", newName: "Departments");
            RenameTable(name: "dbo.SYS_ContactNo", newName: "ContactNoes");
            RenameTable(name: "dbo.SYS_Company", newName: "Companies");
            RenameTable(name: "dbo.SYS_Branch", newName: "Branches");
        }
    }
}
