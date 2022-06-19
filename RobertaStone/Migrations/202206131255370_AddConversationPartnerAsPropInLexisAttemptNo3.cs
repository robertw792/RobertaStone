namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConversationPartnerAsPropInLexisAttemptNo3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lexis", "LanguageId", "dbo.Languages");
            DropIndex("dbo.Lexis", new[] { "LanguageId" });
            RenameColumn(table: "dbo.Lexis", name: "LanguageId", newName: "Language_LanguageId");
            AddColumn("dbo.Lexis", "ConversationPartnerLanguageId", c => c.Int(nullable: false));
            AddColumn("dbo.Lexis", "ConversationPartner_ConversationPartnerId", c => c.Int());
            AlterColumn("dbo.Lexis", "Language_LanguageId", c => c.Int());
            CreateIndex("dbo.Lexis", "ConversationPartner_ConversationPartnerId");
            CreateIndex("dbo.Lexis", "Language_LanguageId");
            AddForeignKey("dbo.Lexis", "ConversationPartner_ConversationPartnerId", "dbo.ConversationPartners", "ConversationPartnerId");
            AddForeignKey("dbo.Lexis", "Language_LanguageId", "dbo.Languages", "LanguageId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lexis", "Language_LanguageId", "dbo.Languages");
            DropForeignKey("dbo.Lexis", "ConversationPartner_ConversationPartnerId", "dbo.ConversationPartners");
            DropIndex("dbo.Lexis", new[] { "Language_LanguageId" });
            DropIndex("dbo.Lexis", new[] { "ConversationPartner_ConversationPartnerId" });
            AlterColumn("dbo.Lexis", "Language_LanguageId", c => c.Int(nullable: false));
            DropColumn("dbo.Lexis", "ConversationPartner_ConversationPartnerId");
            DropColumn("dbo.Lexis", "ConversationPartnerLanguageId");
            RenameColumn(table: "dbo.Lexis", name: "Language_LanguageId", newName: "LanguageId");
            CreateIndex("dbo.Lexis", "LanguageId");
            AddForeignKey("dbo.Lexis", "LanguageId", "dbo.Languages", "LanguageId", cascadeDelete: true);
        }
    }
}
