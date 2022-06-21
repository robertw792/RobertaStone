namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLexisTypeClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LexisTypes",
                c => new
                    {
                        LexisTypeId = c.Int(nullable: false, identity: true),
                        LexisTypeName = c.String(),
                    })
                .PrimaryKey(t => t.LexisTypeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LexisTypes");
        }
    }
}
