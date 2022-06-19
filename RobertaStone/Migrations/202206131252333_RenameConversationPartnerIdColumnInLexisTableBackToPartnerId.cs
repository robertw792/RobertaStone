namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameConversationPartnerIdColumnInLexisTableBackToPartnerId : DbMigration
    {
        public override void Up()
        {
            Sql("EXECUTE SP_RENAME @objname = 'Lexis.ConversationPartnerId', @newname = 'PartnerId', @objtype = 'COLUMN';");
        }

        public override void Down()
        {
        }
    }
}
