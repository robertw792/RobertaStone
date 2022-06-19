namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReAddedConversationPartnerPropToLexisAttemptNo3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lexis", "ConversationPartnerId", c => c.Int());
            CreateIndex("dbo.Lexis", "ConversationPartnerId");
            AddForeignKey("dbo.Lexis", "ConversationPartnerId", "dbo.ConversationPartners", "ConversationPartnerId");
            DropColumn("dbo.Lexis", "PartnerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lexis", "PartnerId", c => c.Int());
            DropForeignKey("dbo.Lexis", "ConversationPartnerId", "dbo.ConversationPartners");
            DropIndex("dbo.Lexis", new[] { "ConversationPartnerId" });
            DropColumn("dbo.Lexis", "ConversationPartnerId");
        }
    }
}
