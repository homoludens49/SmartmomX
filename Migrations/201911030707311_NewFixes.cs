namespace Smartmom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewFixes : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Items", name: "BrandName_Id", newName: "Brand_Id");
            RenameIndex(table: "dbo.Items", name: "IX_BrandName_Id", newName: "IX_Brand_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Items", name: "IX_Brand_Id", newName: "IX_BrandName_Id");
            RenameColumn(table: "dbo.Items", name: "Brand_Id", newName: "BrandName_Id");
        }
    }
}
