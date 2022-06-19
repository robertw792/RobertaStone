namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadePartnerIdNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Lexis", "PartnerId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lexis", "PartnerId", c => c.Int(nullable: false));
        }
    }
}
