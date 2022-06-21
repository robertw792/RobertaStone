namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLexisTypeIdAndLexisTypeClassAsPropsToLexis : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lexis", "LexisTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lexis", "LexisTypeId");
        }
    }
}
