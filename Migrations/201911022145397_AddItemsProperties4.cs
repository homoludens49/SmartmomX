namespace Smartmom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItemsProperties4 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Items ON INSERT INTO Items (ItemId, Name, DateAdded, ReleaseDate, NumberInStock) VALUES (1, 'R1', 2010-04-25, 2017-05-07, 35) SET IDENTITY_INSERT Items OFF");
            Sql("SET IDENTITY_INSERT Items ON INSERT INTO Items (ItemId, Name, DateAdded, ReleaseDate, NumberInStock) VALUES (2, 'G6', 2010-04-25, 2017-05-07, 32) SET IDENTITY_INSERT Items OFF");
            Sql("SET IDENTITY_INSERT Items ON INSERT INTO Items (ItemId, Name, DateAdded, ReleaseDate, NumberInStock) VALUES (3, 'G7', 2010-04-25, 2017-05-07, 40) SET IDENTITY_INSERT Items OFF");
            Sql("SET IDENTITY_INSERT Items ON INSERT INTO Items (ItemId, Name, DateAdded, ReleaseDate, NumberInStock) VALUES (4, 'ZOE', 2010-04-25, 2017-05-07, 36) SET IDENTITY_INSERT Items OFF");
            Sql("SET IDENTITY_INSERT Items ON INSERT INTO Items (ItemId, Name, DateAdded, ReleaseDate, NumberInStock) VALUES (5, 'SAM', 2010-04-25, 2017-05-07, 16) SET IDENTITY_INSERT Items OFF");


        }

        public override void Down()
        {
        }
    }
}
