namespace Smartmom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalPopulateBrands : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brands", "BrandName", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Brands", "Name");

        }
        
        public override void Down()
        {
            AddColumn("dbo.Brands", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Brands", "BrandName");
        }
    }
}
