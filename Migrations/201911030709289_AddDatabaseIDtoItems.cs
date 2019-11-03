namespace Smartmom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatabaseIDtoItems : DbMigration
    {
        public override void Up()
        {

            
            Sql("Update Items SET BrandId = 1 WHERE Name = 'R1'");
           
        }
        
        public override void Down()
        {
        }
    }
}
