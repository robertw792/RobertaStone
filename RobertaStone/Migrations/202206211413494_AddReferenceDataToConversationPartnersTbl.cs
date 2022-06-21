namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReferenceDataToConversationPartnersTbl : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ConversationPartners (PartnerFirstName, PartnerLastName) VALUES ('Ludivine', '');");
            Sql("INSERT INTO ConversationPartners (PartnerFirstName, PartnerLastName) VALUES ('Amélie', '');");
            Sql("INSERT INTO ConversationPartners (PartnerFirstName, PartnerLastName) VALUES ('Hayley', '');");
        }

        public override void Down()
        {
        }
    }
}
