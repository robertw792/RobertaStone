namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecreateLexis : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.LexisId)
                .ForeignKey("dbo.ConversationPartners", t => t.ConversationPartner_ConversationPartnerId)
                .ForeignKey("dbo.Languages", t => t.Language_LanguageId)
                .Index(t => t.ConversationPartner_ConversationPartnerId)
                .Index(t => t.Language_LanguageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lexis", "Language_LanguageId", "dbo.Languages");
            DropForeignKey("dbo.Lexis", "ConversationPartner_ConversationPartnerId", "dbo.ConversationPartners");
            DropIndex("dbo.Lexis", new[] { "Language_LanguageId" });
            DropIndex("dbo.Lexis", new[] { "ConversationPartner_ConversationPartnerId" });
            DropTable("dbo.Lexis");
        }
    }
}
