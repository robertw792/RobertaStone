namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDummyDataToContentTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ContentTypes (ContentTypeName) VALUES ('Instagram')");
        }
        
        public override void Down()
        {
        }
    }
}
