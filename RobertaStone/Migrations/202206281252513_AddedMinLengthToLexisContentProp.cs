namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMinLengthToLexisContentProp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Lexis", "LexisContent", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lexis", "LexisContent", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
