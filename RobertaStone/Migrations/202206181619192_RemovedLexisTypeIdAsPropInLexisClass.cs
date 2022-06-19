namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedLexisTypeIdAsPropInLexisClass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Lexis", "LexisTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lexis", "LexisTypeId", c => c.Int(nullable: false));
        }
    }
}
