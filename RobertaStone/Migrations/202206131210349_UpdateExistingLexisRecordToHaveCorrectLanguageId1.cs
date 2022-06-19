namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateExistingLexisRecordToHaveCorrectLanguageId1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE lexis SET LanguageId = 4 WHERE LexisContent = 'ciao';");
        }

        public override void Down()
        {
        }
    }
}
