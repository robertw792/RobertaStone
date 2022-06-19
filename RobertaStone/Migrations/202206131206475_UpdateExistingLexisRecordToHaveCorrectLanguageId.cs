namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateExistingLexisRecordToHaveCorrectLanguageId : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE lexis SET LanguageId = 4 WHERE LexisId = '1122';");
        }
        
        public override void Down()
        {
        }
    }
}
