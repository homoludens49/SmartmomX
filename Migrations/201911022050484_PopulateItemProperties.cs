namespace Smartmom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateItemProperties : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Items", "Brand", c => c.String(nullable: false));


        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "Brand", c => c.String());
            AlterColumn("dbo.Items", "Name", c => c.String());
        }
    }
}
