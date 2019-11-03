namespace Smartmom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBrandsThirdAttempt : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Brands (BrandName) VALUES('Alilo')");
            Sql("INSERT INTO Brands (BrandName) VALUES('ZAZU')");
        }
        
        public override void Down()
        {
        }
    }
}
