namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReAddedConversationPartnerPropToLexis : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lexis", "ConversationPartner_ConversationPartnerId", c => c.Int());
            CreateIndex("dbo.Lexis", "ConversationPartner_ConversationPartnerId");
            AddForeignKey("dbo.Lexis", "ConversationPartner_ConversationPartnerId", "dbo.ConversationPartners", "ConversationPartnerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lexis", "ConversationPartner_ConversationPartnerId", "dbo.ConversationPartners");
            DropIndex("dbo.Lexis", new[] { "ConversationPartner_ConversationPartnerId" });
            DropColumn("dbo.Lexis", "ConversationPartner_ConversationPartnerId");
        }
    }
}
