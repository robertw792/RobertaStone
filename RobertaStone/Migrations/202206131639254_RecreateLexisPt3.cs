namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecreateLexisPt3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lexis",
                c => new
                    {
                        LexisId = c.Int(nullable: false, identity: true),
                        LanguageId = c.Int(nullable: false),
                        ConversationPartnerId = c.Int(),
                        ContentTypeId = c.Int(nullable: false),
                        LexisTypeId = c.Int(nullable: false),
                        LexisContent = c.String(nullable: false, maxLength: 255),
                        DateLearnt = c.DateTime(nullable: false),
                        TimeLearnt = c.Time(precision: 7),
                    })
                .PrimaryKey(t => t.LexisId)
                .ForeignKey("dbo.ContentTypes", t => t.ContentTypeId, cascadeDelete: true)
                .ForeignKey("dbo.ConversationPartners", t => t.ConversationPartnerId)
                .ForeignKey("dbo.Languages", t => t.LanguageId, cascadeDelete: true)
                .Index(t => t.LanguageId)
                .Index(t => t.ConversationPartnerId)
                .Index(t => t.ContentTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lexis", "LanguageId", "dbo.Languages");
            DropForeignKey("dbo.Lexis", "ConversationPartnerId", "dbo.ConversationPartners");
            DropForeignKey("dbo.Lexis", "ContentTypeId", "dbo.ContentTypes");
            DropIndex("dbo.Lexis", new[] { "ContentTypeId" });
            DropIndex("dbo.Lexis", new[] { "ConversationPartnerId" });
            DropIndex("dbo.Lexis", new[] { "LanguageId" });
            DropTable("dbo.Lexis");
        }
    }
}
