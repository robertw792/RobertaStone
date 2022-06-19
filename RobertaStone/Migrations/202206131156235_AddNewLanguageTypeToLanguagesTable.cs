namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewLanguageTypeToLanguagesTable : DbMigration
    {
        public override void Up()
        {

            Sql("UPDATE languages SET LanguageName = 'Viet' WHERE language_name = 'Vietnamese';");

        }
        
        public override void Down()
        {
        }
    }
}
