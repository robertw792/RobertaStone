namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedTestBool : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Lexis", "testBool");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lexis", "testBool", c => c.Boolean(nullable: false));
        }
    }
}
