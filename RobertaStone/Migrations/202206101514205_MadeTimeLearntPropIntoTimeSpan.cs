namespace RobertaStone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeTimeLearntPropIntoTimeSpan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Lexis", "TimeLearnt", c => c.Time(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lexis", "TimeLearnt", c => c.DateTime(nullable: false));
        }
    }
}
