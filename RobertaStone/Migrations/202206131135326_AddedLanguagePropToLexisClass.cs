namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLanguagePropToLexisClass : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Lexis", "LanguageId");
            AddForeignKey("dbo.Lexis", "LanguageId", "dbo.Languages", "LanguageId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lexis", "LanguageId", "dbo.Languages");
            DropIndex("dbo.Lexis", new[] { "LanguageId" });
        }
    }
}
