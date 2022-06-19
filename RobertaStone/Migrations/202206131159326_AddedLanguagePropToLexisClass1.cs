namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLanguagePropToLexisClass1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO languages (LanguageName) VALUES ('Italian');");
        }

        public override void Down()
        {
        }
    }
}
