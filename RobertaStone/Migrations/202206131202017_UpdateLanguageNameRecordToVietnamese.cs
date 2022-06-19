namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLanguageNameRecordToVietnamese : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Languages SET LanguageName = 'Vietnamese' WHERE LanguageName = 'Viet';");
        }
        
        public override void Down()
        {
        }
    }
}
