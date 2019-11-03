namespace Smartmom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalFixes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "DateAdded", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Items", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "ReleaseDate", c => c.DateTime());
            AlterColumn("dbo.Items", "DateAdded", c => c.DateTime());
        }
    }
}
