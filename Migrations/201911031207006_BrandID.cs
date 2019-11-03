namespace Smartmom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BrandID : DbMigration
    {
        public override void Up()
        {
            Sql("Update Items SET Brand_Id = 1 WHERE Name = 'R1'");
            Sql("Update Items SET Brand_Id = 1 WHERE Name = 'G6'");
            Sql("Update Items SET Brand_Id = 1 WHERE Name = 'G7'");
            Sql("Update Items SET Brand_Id = 2 WHERE Name = 'ZOE'");
            Sql("Update Items SET Brand_Id = 2 WHERE Name = 'SAM'");
        }
        
        public override void Down()
        {
        }
    }
}
