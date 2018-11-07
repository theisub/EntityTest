namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "EventStartTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Events", "EventEndTiem", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "EventEndTiem", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Events", "EventStartTime", c => c.DateTime(nullable: false));
        }
    }
}
