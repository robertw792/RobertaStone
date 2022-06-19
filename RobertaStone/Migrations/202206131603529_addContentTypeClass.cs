namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addContentTypeClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.ContentType",
                    c => new
                    {
                        ContentTypeId   = c.Int(nullable: false, identity: true),
                        ContentTypeName = c.String(),
                    })
                .PrimaryKey(t => t.ContentTypeId);

        }

        public override void Down()
        {
            DropTable("dbo.ContentType");
        }
    }
}
