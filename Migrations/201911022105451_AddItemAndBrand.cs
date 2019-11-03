namespace Smartmom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItemAndBrand : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Items", "BrandId", c => c.Byte(nullable: false));
            AddColumn("dbo.Items", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Items", "Brand_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Items", "NumberInStock", c => c.Byte(nullable: false));
            CreateIndex("dbo.Items", "Brand_Id");
            AddForeignKey("dbo.Items", "Brand_Id", "dbo.Brands", "Id", cascadeDelete: true);
            DropColumn("dbo.Items", "Brand");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Brand", c => c.String(nullable: false));
            DropForeignKey("dbo.Items", "Brand_Id", "dbo.Brands");
            DropIndex("dbo.Items", new[] { "Brand_Id" });
            AlterColumn("dbo.Items", "NumberInStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Items", "Brand_Id");
            DropColumn("dbo.Items", "DateAdded");
            DropColumn("dbo.Items", "BrandId");
            DropTable("dbo.Brands");
        }
    }
}
