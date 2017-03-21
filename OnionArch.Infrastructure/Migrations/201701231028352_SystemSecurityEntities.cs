namespace OnionArch.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SystemSecurityEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SYS_BranchContactNumber",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BranchId = c.Int(),
                        ContactNoId = c.Int(),
                        Status = c.String(),
                        CompanyId = c.Int(),
                        ContactNumber_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_Branch", t => t.BranchId)
                .ForeignKey("dbo.SYS_Company", t => t.CompanyId)
                .ForeignKey("dbo.SYS_ContactNo", t => t.ContactNumber_ID)
                .Index(t => t.BranchId)
                .Index(t => t.CompanyId)
                .Index(t => t.ContactNumber_ID);
            
            CreateTable(
                "dbo.SYS_BranchEmailAddress",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmailAddressId = c.Int(),
                        Status = c.String(),
                        BranchId = c.Int(),
                        CompanyId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_Branch", t => t.BranchId)
                .ForeignKey("dbo.SYS_Company", t => t.CompanyId)
                .ForeignKey("dbo.SYS_EmailAddress", t => t.EmailAddressId)
                .Index(t => t.EmailAddressId)
                .Index(t => t.BranchId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.SYS_CompanySubscriptionModule",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubscriptionId = c.Int(),
                        ModuleId = c.Int(),
                        Price = c.Decimal(precision: 18, scale: 2),
                        RegistrationDate = c.DateTimeOffset(precision: 7),
                        Status = c.String(),
                        CompanySubscription_ID = c.Int(),
                        Modules_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_CompanySubscription", t => t.CompanySubscription_ID)
                .ForeignKey("dbo.SYS_Module", t => t.Modules_ID)
                .Index(t => t.CompanySubscription_ID)
                .Index(t => t.Modules_ID);
            
            CreateTable(
                "dbo.SYS_CompanySubscription",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubscriptionNumber = c.String(),
                        SubscriptionDate = c.DateTimeOffset(precision: 7),
                        IsTrial = c.Boolean(),
                        Expires = c.String(),
                        ExpiryDate = c.DateTimeOffset(precision: 7),
                        AllowMultipleBracnhes = c.Boolean(),
                        CompanyId = c.Int(),
                        CreatedDateTime = c.DateTimeOffset(precision: 7),
                        UpdatedDateTime = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_Company", t => t.CompanyId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.SYS_Module",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        ImagePath = c.String(),
                        Price = c.Decimal(precision: 18, scale: 2),
                        Status = c.String(),
                        OrderIndex = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SYS_Form",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        ModuleId = c.Int(),
                        Status = c.String(),
                        FormTypeId = c.Int(),
                        DisplayIndex = c.Int(),
                        ImagePath = c.String(),
                        PagePath = c.String(),
                        ParentId = c.Int(),
                        IsMain = c.Boolean(),
                        ParentForm_ID = c.Int(),
                        Modules_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_Form", t => t.ParentForm_ID)
                .ForeignKey("dbo.SYS_FormType", t => t.FormTypeId)
                .ForeignKey("dbo.SYS_Module", t => t.Modules_ID)
                .Index(t => t.FormTypeId)
                .Index(t => t.ParentForm_ID)
                .Index(t => t.Modules_ID);
            
            CreateTable(
                "dbo.SYS_CustomField",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeId = c.Int(),
                        Lable = c.String(),
                        FormId = c.Int(),
                        IsCompulsory = c.Boolean(nullable: false),
                        SortOrder = c.Int(),
                        CompanyId = c.Int(),
                        BranchId = c.Int(),
                        CreatedBy = c.Int(),
                        CreatedDateTime = c.DateTime(),
                        UpdatedBy = c.Int(),
                        UpdatedDateTime = c.DateTime(),
                        FieldType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_FieldType", t => t.FieldType_ID)
                .ForeignKey("dbo.SYS_Form", t => t.FormId)
                .Index(t => t.FormId)
                .Index(t => t.FieldType_ID);
            
            CreateTable(
                "dbo.SYS_CustomFieldValue",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomFieldId = c.Int(),
                        Value = c.String(),
                        RecordId = c.Int(),
                        FormId = c.Int(),
                        CompanyId = c.Int(),
                        BranchId = c.Int(),
                        CreatedBy = c.Int(),
                        CreatedDateTime = c.DateTime(),
                        UpdatedBy = c.Int(),
                        UpdatedDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_CustomField", t => t.CustomFieldId)
                .ForeignKey("dbo.SYS_Form", t => t.FormId)
                .Index(t => t.CustomFieldId)
                .Index(t => t.FormId);
            
            CreateTable(
                "dbo.SYS_FieldType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SYS_FormType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SYS_RoleSecurityRights",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(),
                        FormId = c.Int(),
                        View = c.Boolean(nullable: false),
                        Add = c.Boolean(nullable: false),
                        Edit = c.Boolean(nullable: false),
                        Delete = c.Boolean(nullable: false),
                        Forms_ID = c.Int(),
                        SYS_SystemRole_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_Form", t => t.Forms_ID)
                .ForeignKey("dbo.SYS_SystemRole", t => t.SYS_SystemRole_ID)
                .Index(t => t.Forms_ID)
                .Index(t => t.SYS_SystemRole_ID);
            
            CreateTable(
                "dbo.SYS_SystemRole",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SystemGroup = c.Boolean(),
                        CompanyId = c.Int(),
                        BranchId = c.Int(),
                        CreatedBy = c.Int(),
                        CreatedDatetime = c.DateTimeOffset(precision: 7),
                        UpdatedBy = c.Int(),
                        UpdatedDateTime = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_Branch", t => t.BranchId)
                .ForeignKey("dbo.SYS_Company", t => t.CompanyId)
                .Index(t => t.CompanyId)
                .Index(t => t.BranchId);
            
            CreateTable(
                "dbo.SYS_SystemRoleUser",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(),
                        UserId = c.Int(),
                        CompanyId = c.Int(),
                        BranchId = c.Int(),
                        SYS_SystemRole_ID = c.Int(),
                        SYS_User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_Branch", t => t.BranchId)
                .ForeignKey("dbo.SYS_Company", t => t.CompanyId)
                .ForeignKey("dbo.SYS_SystemRole", t => t.SYS_SystemRole_ID)
                .ForeignKey("dbo.SYS_User", t => t.SYS_User_ID)
                .Index(t => t.CompanyId)
                .Index(t => t.BranchId)
                .Index(t => t.SYS_SystemRole_ID)
                .Index(t => t.SYS_User_ID);
            
            CreateTable(
                "dbo.SYS_User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        PasswordSalt = c.String(),
                        PlanePassword = c.String(),
                        ConfirmationToken = c.String(),
                        UserType = c.String(),
                        UserTypeId = c.Int(),
                        AccountVerified = c.String(),
                        AccountStatus = c.String(),
                        ForwardInfo = c.String(),
                        CompanyId = c.Int(),
                        BranchId = c.Int(),
                        CreatedDateTime = c.DateTimeOffset(precision: 7),
                        UpdatedDateTime = c.DateTimeOffset(precision: 7),
                        Employee_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SYS_Branch", t => t.BranchId)
                .ForeignKey("dbo.SYS_Company", t => t.CompanyId)
                .ForeignKey("dbo.HC_Employee", t => t.Employee_ID)
                .Index(t => t.CompanyId)
                .Index(t => t.BranchId)
                .Index(t => t.Employee_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SYS_SystemRoleUser", "SYS_User_ID", "dbo.SYS_User");
            DropForeignKey("dbo.SYS_User", "Employee_ID", "dbo.HC_Employee");
            DropForeignKey("dbo.SYS_User", "CompanyId", "dbo.SYS_Company");
            DropForeignKey("dbo.SYS_User", "BranchId", "dbo.SYS_Branch");
            DropForeignKey("dbo.SYS_SystemRoleUser", "SYS_SystemRole_ID", "dbo.SYS_SystemRole");
            DropForeignKey("dbo.SYS_SystemRoleUser", "CompanyId", "dbo.SYS_Company");
            DropForeignKey("dbo.SYS_SystemRoleUser", "BranchId", "dbo.SYS_Branch");
            DropForeignKey("dbo.SYS_RoleSecurityRights", "SYS_SystemRole_ID", "dbo.SYS_SystemRole");
            DropForeignKey("dbo.SYS_SystemRole", "CompanyId", "dbo.SYS_Company");
            DropForeignKey("dbo.SYS_SystemRole", "BranchId", "dbo.SYS_Branch");
            DropForeignKey("dbo.SYS_RoleSecurityRights", "Forms_ID", "dbo.SYS_Form");
            DropForeignKey("dbo.SYS_Form", "Modules_ID", "dbo.SYS_Module");
            DropForeignKey("dbo.SYS_Form", "FormTypeId", "dbo.SYS_FormType");
            DropForeignKey("dbo.SYS_CustomField", "FormId", "dbo.SYS_Form");
            DropForeignKey("dbo.SYS_CustomField", "FieldType_ID", "dbo.SYS_FieldType");
            DropForeignKey("dbo.SYS_CustomFieldValue", "FormId", "dbo.SYS_Form");
            DropForeignKey("dbo.SYS_CustomFieldValue", "CustomFieldId", "dbo.SYS_CustomField");
            DropForeignKey("dbo.SYS_Form", "ParentForm_ID", "dbo.SYS_Form");
            DropForeignKey("dbo.SYS_CompanySubscriptionModule", "Modules_ID", "dbo.SYS_Module");
            DropForeignKey("dbo.SYS_CompanySubscriptionModule", "CompanySubscription_ID", "dbo.SYS_CompanySubscription");
            DropForeignKey("dbo.SYS_CompanySubscription", "CompanyId", "dbo.SYS_Company");
            DropForeignKey("dbo.SYS_BranchEmailAddress", "EmailAddressId", "dbo.SYS_EmailAddress");
            DropForeignKey("dbo.SYS_BranchEmailAddress", "CompanyId", "dbo.SYS_Company");
            DropForeignKey("dbo.SYS_BranchEmailAddress", "BranchId", "dbo.SYS_Branch");
            DropForeignKey("dbo.SYS_BranchContactNumber", "ContactNumber_ID", "dbo.SYS_ContactNo");
            DropForeignKey("dbo.SYS_BranchContactNumber", "CompanyId", "dbo.SYS_Company");
            DropForeignKey("dbo.SYS_BranchContactNumber", "BranchId", "dbo.SYS_Branch");
            DropIndex("dbo.SYS_User", new[] { "Employee_ID" });
            DropIndex("dbo.SYS_User", new[] { "BranchId" });
            DropIndex("dbo.SYS_User", new[] { "CompanyId" });
            DropIndex("dbo.SYS_SystemRoleUser", new[] { "SYS_User_ID" });
            DropIndex("dbo.SYS_SystemRoleUser", new[] { "SYS_SystemRole_ID" });
            DropIndex("dbo.SYS_SystemRoleUser", new[] { "BranchId" });
            DropIndex("dbo.SYS_SystemRoleUser", new[] { "CompanyId" });
            DropIndex("dbo.SYS_SystemRole", new[] { "BranchId" });
            DropIndex("dbo.SYS_SystemRole", new[] { "CompanyId" });
            DropIndex("dbo.SYS_RoleSecurityRights", new[] { "SYS_SystemRole_ID" });
            DropIndex("dbo.SYS_RoleSecurityRights", new[] { "Forms_ID" });
            DropIndex("dbo.SYS_CustomFieldValue", new[] { "FormId" });
            DropIndex("dbo.SYS_CustomFieldValue", new[] { "CustomFieldId" });
            DropIndex("dbo.SYS_CustomField", new[] { "FieldType_ID" });
            DropIndex("dbo.SYS_CustomField", new[] { "FormId" });
            DropIndex("dbo.SYS_Form", new[] { "Modules_ID" });
            DropIndex("dbo.SYS_Form", new[] { "ParentForm_ID" });
            DropIndex("dbo.SYS_Form", new[] { "FormTypeId" });
            DropIndex("dbo.SYS_CompanySubscription", new[] { "CompanyId" });
            DropIndex("dbo.SYS_CompanySubscriptionModule", new[] { "Modules_ID" });
            DropIndex("dbo.SYS_CompanySubscriptionModule", new[] { "CompanySubscription_ID" });
            DropIndex("dbo.SYS_BranchEmailAddress", new[] { "CompanyId" });
            DropIndex("dbo.SYS_BranchEmailAddress", new[] { "BranchId" });
            DropIndex("dbo.SYS_BranchEmailAddress", new[] { "EmailAddressId" });
            DropIndex("dbo.SYS_BranchContactNumber", new[] { "ContactNumber_ID" });
            DropIndex("dbo.SYS_BranchContactNumber", new[] { "CompanyId" });
            DropIndex("dbo.SYS_BranchContactNumber", new[] { "BranchId" });
            DropTable("dbo.SYS_User");
            DropTable("dbo.SYS_SystemRoleUser");
            DropTable("dbo.SYS_SystemRole");
            DropTable("dbo.SYS_RoleSecurityRights");
            DropTable("dbo.SYS_FormType");
            DropTable("dbo.SYS_FieldType");
            DropTable("dbo.SYS_CustomFieldValue");
            DropTable("dbo.SYS_CustomField");
            DropTable("dbo.SYS_Form");
            DropTable("dbo.SYS_Module");
            DropTable("dbo.SYS_CompanySubscription");
            DropTable("dbo.SYS_CompanySubscriptionModule");
            DropTable("dbo.SYS_BranchEmailAddress");
            DropTable("dbo.SYS_BranchContactNumber");
        }
    }
}
