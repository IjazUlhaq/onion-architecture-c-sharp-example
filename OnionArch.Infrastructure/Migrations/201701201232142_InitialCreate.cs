namespace OnionArch.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BranchCode = c.String(),
                        ExternalBranchCode = c.String(),
                        BranchName = c.String(),
                        LanguageCode = c.String(),
                        TimeZoneId = c.Int(),
                        AddressId = c.Int(),
                        DateFormatId = c.Int(),
                        TimeFormatId = c.Int(),
                        GroupId = c.Int(),
                        CompanyId = c.Int(),
                        CreatedBy = c.Int(),
                        CreatedDateTime = c.DateTimeOffset(precision: 7),
                        UpdatedBy = c.Int(),
                        UpdatedDateTime = c.DateTimeOffset(precision: 7),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyCode = c.String(),
                        CompanyName = c.String(),
                        CompanyTypeId = c.Int(),
                        CompanyLogo = c.Binary(),
                        CreatdBy = c.Int(),
                        CreatedDateTime = c.DateTimeOffset(precision: 7),
                        UpdatedBy = c.Int(),
                        UpdatedDateTime = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        DepLevel = c.Int(),
                        ParentDepId = c.Int(),
                        Status = c.String(),
                        TypeId = c.Int(),
                        CompanyId = c.Int(),
                        BranchId = c.Int(),
                        CreatedBy = c.Int(),
                        CreatedDateTime = c.DateTimeOffset(precision: 7),
                        UpdatedBy = c.Int(),
                        UpdatedDateTime = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ShortName = c.String(),
                        Description = c.String(),
                        ReportsTo = c.String(),
                        AttendanceEnabled = c.Boolean(nullable: false),
                        DutyTimeId = c.Int(),
                        AttendanceRuleId = c.Int(),
                        OverTimeAllowed = c.Boolean(nullable: false),
                        OverTimeRate = c.Decimal(precision: 18, scale: 2),
                        DailyWagesStatus = c.Boolean(nullable: false),
                        DailyRate = c.Decimal(precision: 18, scale: 2),
                        BasicSalary = c.Decimal(precision: 18, scale: 2),
                        AllowncesTotal = c.Decimal(precision: 18, scale: 2),
                        Gross = c.Decimal(precision: 18, scale: 2),
                        DeductionsTotal = c.Decimal(precision: 18, scale: 2),
                        NetSalary = c.Decimal(precision: 18, scale: 2),
                        Status = c.Boolean(),
                        CompanyId = c.Int(),
                        BranchId = c.Int(),
                        CreatedBy = c.Int(),
                        CreatedDateTime = c.DateTimeOffset(precision: 7),
                        UpdatedBy = c.Int(),
                        UpdatedDateTime = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DN = c.Int(),
                        DIN = c.Int(),
                        Clock = c.DateTime(),
                        VeryfiMode = c.Int(),
                        AttTypeId = c.String(),
                        CollectionDate = c.DateTime(),
                        LastUpdatedUID = c.Int(),
                        LastupdatedDate = c.DateTime(),
                        Remarks = c.String(),
                        Name = c.String(),
                        SyncOnlineStatus = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EmployeeJoinings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        DepLevel = c.Int(),
                        ParentDepId = c.Int(),
                        Status = c.String(),
                        TypeId = c.Int(),
                        CompanyId = c.Int(),
                        BranchId = c.Int(),
                        CreatedBy = c.Int(),
                        CreatedDateTime = c.DateTimeOffset(precision: 7),
                        UpdatedBy = c.Int(),
                        UpdatedDateTime = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        RelationId = c.Int(),
                        GuardianFirstName = c.String(),
                        GuardianMiddleName = c.String(),
                        GuardianLastName = c.String(),
                        Gender = c.String(),
                        DateOfBirth = c.DateTime(),
                        MaritalStatus = c.String(),
                        NationalIdNo = c.String(),
                        PasportNo = c.String(),
                        Image = c.Binary(),
                        BloodGroupId = c.Int(),
                        ReligionId = c.Int(),
                        Status = c.String(),
                        CarearStartDate = c.DateTime(),
                        CompayId = c.Int(),
                        BranchId = c.Int(),
                        CreatedBy = c.Int(),
                        CreatedDateTime = c.DateTimeOffset(precision: 7),
                        UpdatedBy = c.Int(),
                        UpdatedDateTime = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
            DropTable("dbo.EmployeeJoinings");
            DropTable("dbo.Attendances");
            DropTable("dbo.Designations");
            DropTable("dbo.Departments");
            DropTable("dbo.Companies");
            DropTable("dbo.Branches");
        }
    }
}
