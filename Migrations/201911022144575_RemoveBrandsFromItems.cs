namespace Smartmom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveBrandsFromItems : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "Brand_Id", "dbo.Brands");
            DropIndex("dbo.Items", new[] { "Brand_Id" });
            DropColumn("dbo.Items", "BrandId");
            DropColumn("dbo.Items", "Brand_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Brand_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "BrandId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Items", "Brand_Id");
            AddForeignKey("dbo.Items", "Brand_Id", "dbo.Brands", "Id", cascadeDelete: true);
        }
    }
}
