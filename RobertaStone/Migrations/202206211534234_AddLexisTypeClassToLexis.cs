namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLexisTypeClassToLexis : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Lexis", "LexisTypeId");
            AddForeignKey("dbo.Lexis", "LexisTypeId", "dbo.LexisTypes", "LexisTypeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lexis", "LexisTypeId", "dbo.LexisTypes");
            DropIndex("dbo.Lexis", new[] { "LexisTypeId" });
        }
    }
}
