namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePartnerIdColumnInLexisToBeConversationPartnerId : DbMigration
    {
        public override void Up()
        {
            Sql("EXECUTE SP_RENAME @objname = 'Lexis.PartnerId', @newname = 'ConversationPartnerId', @objtype = 'COLUMN';");
        }
        
        public override void Down()
        {
        }
    }
}
