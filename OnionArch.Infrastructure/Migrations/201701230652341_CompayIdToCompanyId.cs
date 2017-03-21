namespace OnionArch.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompayIdToCompanyId : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employees", name: "Company_ID", newName: "CompanyId");
            RenameIndex(table: "dbo.Employees", name: "IX_Company_ID", newName: "IX_CompanyId");
            DropColumn("dbo.Employees", "CompayId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "CompayId", c => c.Int());
            RenameIndex(table: "dbo.Employees", name: "IX_CompanyId", newName: "IX_Company_ID");
            RenameColumn(table: "dbo.Employees", name: "CompanyId", newName: "Company_ID");
        }
    }
}
