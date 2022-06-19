namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropColumnConversationPartner_ConversationPartnerIdFromLexisTable : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Lexis DROP COLUMN ConversationPartner_ConversationPartnerId;");
        }
        
        public override void Down()
        {
        }
    }
}
