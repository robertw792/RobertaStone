namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeTimeLearntOptional : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Lexis", "TimeLearnt", c => c.Time(precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lexis", "TimeLearnt", c => c.Time(nullable: false, precision: 7));
        }
    }
}
