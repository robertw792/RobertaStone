namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droppedLexisTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lexis", "ContentTypeId", "dbo.ContentTypes");
            DropForeignKey("dbo.Lexis", "ConversationPartnerId", "dbo.ConversationPartners");
            DropForeignKey("dbo.Lexis", "LanguageId", "dbo.Languages");
            DropIndex("dbo.Lexis", new[] { "LanguageId" });
            DropIndex("dbo.Lexis", new[] { "ConversationPartnerId" });
            DropIndex("dbo.Lexis", new[] { "ContentTypeId" });
            DropTable("dbo.Lexis");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Lexis",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        LanguageId = c.Int(nullable: false),
                        ConversationPartnerId = c.Int(),
                        ContentTypeId = c.Int(nullable: false),
                        LexisContent = c.String(nullable: false, maxLength: 255),
                        DateLearnt = c.DateTime(nullable: false),
                        TimeLearnt = c.Time(precision: 7),
                    })
                .PrimaryKey(t => t.id);
            
            CreateIndex("dbo.Lexis", "ContentTypeId");
            CreateIndex("dbo.Lexis", "ConversationPartnerId");
            CreateIndex("dbo.Lexis", "LanguageId");
            AddForeignKey("dbo.Lexis", "LanguageId", "dbo.Languages", "LanguageId", cascadeDelete: true);
            AddForeignKey("dbo.Lexis", "ConversationPartnerId", "dbo.ConversationPartners", "ConversationPartnerId");
            AddForeignKey("dbo.Lexis", "ContentTypeId", "dbo.ContentTypes", "ContentTypeId", cascadeDelete: true);
        }
    }
}
