namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewReferenceDataInContentTypeTbl : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ContentTypes (ContentTypeName) VALUES ('Red Dead Redemption 2');");
            Sql("INSERT INTO ContentTypes (ContentTypeName) VALUES ('Tandem');");
            Sql("INSERT INTO ContentTypes (ContentTypeName) VALUES ('Netflix');");
            Sql("INSERT INTO ContentTypes (ContentTypeName) VALUES ('LingoDeer');");
            Sql("INSERT INTO ContentTypes (ContentTypeName) VALUES ('Youtube');");
            Sql("INSERT INTO ContentTypes (ContentTypeName) VALUES ('Pimsleur');");
            Sql("INSERT INTO ContentTypes (ContentTypeName) VALUES ('WordReference');");
            Sql("INSERT INTO ContentTypes (ContentTypeName) VALUES ('French Course from Cardiff Uni');");
            Sql("INSERT INTO ContentTypes (ContentTypeName) VALUES ('Assimil');");
            Sql("INSERT INTO ContentTypes (ContentTypeName) VALUES ('Italki');");
            Sql("INSERT INTO ContentTypes (ContentTypeName) VALUES ('Unknown');");
        }

        public override void Down()
        {
        }
    }
}
