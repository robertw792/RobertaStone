namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateLanguageTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO languages (LanguageName) VALUES ('French')");
            Sql("INSERT INTO languages (LanguageName) VALUES ('Vietnamese')");
            Sql("INSERT INTO languages (LanguageName) VALUES ('Welsh')");
        }
        
        public override void Down()
        {
        }
    }
}
