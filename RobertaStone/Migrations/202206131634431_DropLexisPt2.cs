namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropLexisPt2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lexis", "ConversationPartner_ConversationPartnerId", "dbo.ConversationPartners");
            DropForeignKey("dbo.Lexis", "Language_LanguageId", "dbo.Languages");
            DropIndex("dbo.Lexis", new[] { "ConversationPartner_ConversationPartnerId" });
            DropIndex("dbo.Lexis", new[] { "Language_LanguageId" });
            DropTable("dbo.Lexis");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Lexis",
                c => new
                    {
                        LexisId = c.Int(nullable: false, identity: true),
                        ConversationPartnerLanguageId = c.Int(nullable: false),
                        PartnerId = c.Int(),
                        ContentTypeId = c.Int(nullable: false),
                        LexisTypeId = c.Int(nullable: false),
                        LexisContent = c.String(nullable: false, maxLength: 255),
                        DateLearnt = c.DateTime(nullable: false),
                        TimeLearnt = c.Time(precision: 7),
                        ConversationPartner_ConversationPartnerId = c.Int(),
                        Language_LanguageId = c.Int(),
                    })
                .PrimaryKey(t => t.LexisId);
            
            CreateIndex("dbo.Lexis", "Language_LanguageId");
            CreateIndex("dbo.Lexis", "ConversationPartner_ConversationPartnerId");
            AddForeignKey("dbo.Lexis", "Language_LanguageId", "dbo.Languages", "LanguageId");
            AddForeignKey("dbo.Lexis", "ConversationPartner_ConversationPartnerId", "dbo.ConversationPartners", "ConversationPartnerId");
        }
    }
}
