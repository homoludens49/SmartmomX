namespace Smartmom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateItemID : DbMigration
    {
        public override void Up()
        {
            
            DropPrimaryKey("dbo.Items");
            DropColumn("dbo.Items", "Id");
            
            AddColumn("dbo.Items", "ItemId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Items", "ItemId");
            

        }
        
        public override void Down()
        {
            
            AddColumn("dbo.Items", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Items", "Id");
            
            DropPrimaryKey("dbo.Items");
            DropColumn("dbo.Items", "ItemId");
            
        }
    }
}
