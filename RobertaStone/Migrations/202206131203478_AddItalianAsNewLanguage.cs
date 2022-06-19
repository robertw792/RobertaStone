namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddItalianAsNewLanguage : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Languages (LanguageName) VALUES ('Italian');");
        }
        
        public override void Down()
        {
        }
    }
}
