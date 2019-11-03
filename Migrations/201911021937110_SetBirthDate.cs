namespace Smartmom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1980-01-01' AS DATETIME) WHERE Id = 1");
            Sql("UPDATE Customers SET Birthdate = CAST('1990-11-21' AS DATETIME) WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
