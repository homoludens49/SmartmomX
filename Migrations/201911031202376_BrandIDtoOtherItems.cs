namespace Smartmom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BrandIDtoOtherItems : DbMigration
    {
        public override void Up()
        {
            Sql("Update Items SET BrandId = 1 WHERE Name = 'G6'");
            Sql("Update Items SET BrandId = 1 WHERE Name = 'G7'");
            Sql("Update Items SET BrandId = 2 WHERE Name = 'ZOE'");
            Sql("Update Items SET BrandId = 2 WHERE Name = 'SAM'");
        }
        
        public override void Down()
        {
        }
    }
}
