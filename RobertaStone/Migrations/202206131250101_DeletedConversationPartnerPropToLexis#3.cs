namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedConversationPartnerPropToLexis3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Lexis", "ConversationPartner_ConversationPartnerId", "dbo.ConversationPartners");
            DropIndex("dbo.Lexis", new[] { "ConversationPartner_ConversationPartnerId" });
            DropColumn("dbo.Lexis", "ConversationPartner_ConversationPartnerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lexis", "ConversationPartner_ConversationPartnerId", c => c.Int());
            CreateIndex("dbo.Lexis", "ConversationPartner_ConversationPartnerId");
            AddForeignKey("dbo.Lexis", "ConversationPartner_ConversationPartnerId", "dbo.ConversationPartners", "ConversationPartnerId");
        }
    }
}
