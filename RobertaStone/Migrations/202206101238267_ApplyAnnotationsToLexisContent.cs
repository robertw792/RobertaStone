namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToLexisContent : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Lexis", "LexisContent", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lexis", "LexisContent", c => c.String());
        }
    }
}
