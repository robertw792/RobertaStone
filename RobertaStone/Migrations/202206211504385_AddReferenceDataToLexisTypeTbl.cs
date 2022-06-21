namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReferenceDataToLexisTypeTbl : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO LexisTypes (LexisTypeName) VALUES ('Vocabulary');");
            Sql("INSERT INTO LexisTypes (LexisTypeName) VALUES ('Grammar Point');");
            Sql("INSERT INTO LexisTypes (LexisTypeName) VALUES ('Expression');");
        }
        
        public override void Down()
        {
        }
    }
}
