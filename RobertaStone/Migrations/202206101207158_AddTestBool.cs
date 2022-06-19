namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestBool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lexis", "testBool", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lexis", "testBool");
        }
    }
}
