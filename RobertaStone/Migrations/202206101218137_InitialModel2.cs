namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConversationPartners",
                c => new
                    {
                        ConversationPartnerId = c.Int(nullable: false, identity: true),
                        PartnerFirstName = c.String(),
                        PartnerLastName = c.String(),
                    })
                .PrimaryKey(t => t.ConversationPartnerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ConversationPartners");
        }
    }
}
