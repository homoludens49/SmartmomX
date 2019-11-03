namespace Smartmom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBrandInItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "BrandId", c => c.Byte(nullable: false));
            AddColumn("dbo.Items", "Brand_Id", c => c.Int());
            CreateIndex("dbo.Items", "Brand_Id");
            AddForeignKey("dbo.Items", "Brand_Id", "dbo.Brands", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Brand_Id", "dbo.Brands");
            DropIndex("dbo.Items", new[] { "Brand_Id" });
            DropColumn("dbo.Items", "Brand_Id");
            DropColumn("dbo.Items", "BrandId");
        }
    }
}
